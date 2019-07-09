using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

            // makes list
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // adds Jupiter & Saturn
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // creates new list
            List<string> NewPlanetList = new List<string>() { "Uranus", "Neptune" };
            //runs NewPlanetList
            NewPlanetList.ForEach(npl => Console.WriteLine(npl));

            // add Uranus & Neptune with AddRange method
            planetList.AddRange(NewPlanetList);


            // insert Venus & Earth with .Insert
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // adds Pluto
            planetList.Add("Pluto");



            var rockyPlanets = planetList.GetRange(3, 0);
            Console.WriteLine("These are the Rocky Planets");


            planetList.ForEach(pl => Console.WriteLine(pl));










        }
    }
}
