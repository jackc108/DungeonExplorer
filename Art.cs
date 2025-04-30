using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public static class Art
    {
        public static void DrawSword()
        {
            Console.WriteLine("         |");
            Console.WriteLine("        |||");
            Console.WriteLine("        |||");
            Console.WriteLine("        |||");
            Console.WriteLine("     ___|||___");
            Console.WriteLine("     ___   ___");
            Console.WriteLine("        | |   ");
            Console.WriteLine("        ---");
            Console.WriteLine();
        }

        public static void DrawShield()
        {
            Console.WriteLine("   -----------------");
            Console.WriteLine("   |               |");
            Console.WriteLine("   |   ___||___    |");
            Console.WriteLine("   |      ||       |");
            Console.WriteLine("   |      ||       |");
            Console.WriteLine("    YYY         YYY");
            Console.WriteLine("      YYY     YYY");
            Console.WriteLine("       YYY  YYY");
            Console.WriteLine("         YYY");
            Console.WriteLine();
        }

        public static void DrawHealthPot()
        {
            Console.WriteLine("    ____");
            Console.WriteLine("   <    >");
            Console.WriteLine("    |  |");
            Console.WriteLine("    *  *");
            Console.WriteLine("  *      *");
            Console.WriteLine("*          *");
            Console.WriteLine(" *        *");
            Console.WriteLine("  *______*");
        }
        public static void DrawSkull()
        {
            Console.WriteLine(" _______");
            Console.WriteLine("o       o");
            Console.WriteLine("o x   x o");
            Console.WriteLine("o   .   o");
            Console.WriteLine(" o     o");
            Console.WriteLine("  |||||");
        }
    }
}
