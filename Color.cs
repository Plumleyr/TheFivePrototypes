using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFivePrototypes
{
    class Color(int r = 0, int g = 0, int b = 0)
    {
        public int RedValue { get; init; } = r;
        public int GreenValue { get; init; } = g;
        public int BlueValue { get; init; } = b;

        public void PrintColorValues()
        {
            Console.WriteLine($"Your colors rgb values are ({this.RedValue}, {this.GreenValue}, {this.BlueValue}).");
        }

        static public Color Red()
        {
            return new Color
            {
                RedValue = 255,
                GreenValue = 0,
                BlueValue = 0
            };
        }

        static public Color Blue()
        {
            return new Color
            {
                RedValue = 0,
                GreenValue = 0,
                BlueValue = 255
            };
        }

        static public Color Green()
        {
            return new Color
            {
                RedValue = 0,
                GreenValue = 128,
                BlueValue = 0
            };
        }
        static public Color Purple()
        {
            return new Color
            {
                RedValue = 128,
                GreenValue = 0,
                BlueValue = 128
            };
        }

        static public Color Yellow()
        {
            return new Color
            {
                RedValue = 255,
                GreenValue = 255,
                BlueValue = 0
            };
        }

        static public Color Orange()
        {
            return new Color
            {
                RedValue = 255,
                GreenValue = 165,
                BlueValue = 0
            };
        }

        static public Color White()
        {
            return new Color
            {
                RedValue = 255,
                GreenValue = 255,
                BlueValue = 255
            };
        }

        static public Color Black()
        {
            return new Color
            {
                RedValue = 0,
                GreenValue = 0,
                BlueValue = 0
            };
        }

    }
}
