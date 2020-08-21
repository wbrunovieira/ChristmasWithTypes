﻿using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int ? TreeHeight { get; set; } //Done Make the Height property nullable

        //Done Make the property, "Day", type enum
        public enum Day {Sunday, Monday, Tusday, Wednesday, Thursday, Friday, Saturday};

    }
}
