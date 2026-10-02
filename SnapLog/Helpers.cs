using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace SnapLog
{
    public static class Helpers
    {
        // check if valid IP address format
        public static bool IsValidIP(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            string regExpression = @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            return Regex.IsMatch(s, regExpression);
        }

        private static bool IsValidIP2(string ip)
        {
            if (string.IsNullOrEmpty(ip)) return false;
            Match match = Regex.Match(ip, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            return match.Success;
        }

        public static bool IsValidURL(string url)
        {
            if (string.IsNullOrEmpty(url)) return false;
            Match match = Regex.Match(url, @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$");
            return match.Success;
        }

        public static bool IsValidURL2(string url)
        {
            if (string.IsNullOrEmpty(url)) return false;
            if (!url.StartsWith("http"))
            {
                url = "http://" + url;
            }

            Uri validateUri;
            if (Uri.TryCreate(url, UriKind.Absolute, out validateUri))
            {
                return (validateUri.Scheme == Uri.UriSchemeHttp || validateUri.Scheme == Uri.UriSchemeHttps);
            }

            return false;
        }

        // returns URL's IP address
        public static IPAddress GetRemoteIP(string url)
        {
            if (string.IsNullOrEmpty(url)) return IPAddress.Parse("0.0.0.0");

            if (IsValidIP(url))
            {
                return IPAddress.Parse(url);
            }
            else if (IsValidURL(url))
            {
                try
                {
                    url = url.Replace("http://", "").Replace("https://", "").Trim().Split('/')[0];
                    IPHostEntry ipEntry = Dns.GetHostEntry(url);
                    IPAddress ip = ipEntry.AddressList[0];
                    return ip;
                }
                catch
                {
                    return IPAddress.Parse("0.0.0.0");
                }
            }

            return IPAddress.Parse("0.0.0.0");
        }

        // Run trace route via shell
        public static string RunConsole(string app, string args, bool hidden = false)
        {
            Process oProcess = new Process();
            ProcessStartInfo oStartInfo = new ProcessStartInfo(app, args);
            string sOutput = "";

            foreach (Process p in Process.GetProcessesByName(app))
            {
                try
                {
                    p.Kill();
                    p.WaitForExit();
                }
                catch
                {
                }
            }

            oStartInfo.UseShellExecute = false;
            oStartInfo.RedirectStandardOutput = true;
            if (hidden) oStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            oStartInfo.CreateNoWindow = true;

            oProcess.StartInfo = oStartInfo;
            oProcess.Start();

            using (StreamReader oStreamReader = oProcess.StandardOutput)
            {
                sOutput = oStreamReader.ReadToEnd();
            }

            return sOutput;
        }

        public static void RunCommand(string cmd, string workingDirectory, string args = "", bool hidden = false)
        {
            Process oProcess = new Process();
            ProcessStartInfo oStartInfo = new ProcessStartInfo(cmd, args);

            foreach (Process p in Process.GetProcessesByName(cmd))
            {
                try
                {
                    p.Kill();
                }
                catch
                {
                }
            }

            oStartInfo.WorkingDirectory = workingDirectory;
            if (hidden)
            {
                oStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                oStartInfo.CreateNoWindow = true;
            }

            oProcess.StartInfo = oStartInfo;
            oProcess.Start();
        }

        public static List<string> ImportTextFile(string filename)
        {
            if (File.Exists(filename))
            {
                List<string> list = new List<string>();

                using (StreamReader reader = new StreamReader(filename))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        // skip comments or blank lines
                        if (line.Trim().Length > 0 && !line.Trim().StartsWith("#"))
                        {
                            list.Add(line.Trim());
                        }

                        line = reader.ReadLine();
                    }

                    reader.Close();
                }

                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
