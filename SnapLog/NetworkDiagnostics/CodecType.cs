using System;

namespace SnapLog.NetworkDiagnostics
{
    public class CodecType
    {
        public static CodecType G711 = new CodecType("G711", 10, 0, 30, 15);
        public static CodecType iLBC = new CodecType("iLBC", 30, 10, 35, 10);
        public static CodecType G729 = new CodecType("G.729", 20, 11, 40, 10);
        public static CodecType MAIN = G729;

        public string Name { get; private set; }
        public int PacketInterval { get; private set; }
        public int Y1 { get; private set; }
        public int Y2 { get; private set; }
        public int Y3 { get; private set; }

        public CodecType(string name, int packetInterval, int y1, int y2, int y3)
        {
            Name = name;
            PacketInterval = packetInterval;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;
        }

        public static CodecType ToCodecType(string name)
        {
            CodecType g729 = CodecType.G729;

            if (name == CodecType.G711.Name)
            {
                g729 = CodecType.G711;
            }
            else if (name == CodecType.iLBC.Name)
            {
                g729 = CodecType.iLBC;
            }

            return g729;
        }
    }
}
