﻿using System;

namespace _7_S187_Zutatenstruktur_Array
{
    class Program
    {
        struct Zutaten
        {
            //einfache Zutatenstruktur
            public string Name { get; set; }
            public string Unit { get; set; }
            public string Amount { get; set; }

        }
        //Array von einer Zutatenstruktur
        
        static void Main(string[] args)
        {
            Ingredient[] ingredients = new Ingredient[2];
            ingredients[0] = new Ingredient();
            ingredients[0].Name = "Mehl";
            ingredients[0].Amount = 30;
            ingredients[0].Unit = "g";
            ingredients[1] = new Ingredient();
            ingredients[1].Name = "Wasser";
            ingredients[1].Amount = 0.25f;
            ingredients[1].Unit = "1";
        }
    }
}
