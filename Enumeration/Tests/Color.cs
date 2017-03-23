﻿namespace Tests
{
    using Headspring;

    public class Color : Enumeration<Color>
    {
        public static readonly Color Red = new Color(1, "Red");
        public static readonly Color Blue = new Color(2, "Blue");

        private Color(int value, string displayName) : base(value, displayName)
        {
        }
    }
}