using System;
using System.Collections.Generic;


namespace listExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Exercises");
            List<string> planetList = new List<string>(){"Mercury", "Mars","Uranus","Venus"};
// Add() Jupiter and Saturn at the end of the list.
planetList.Add("Jupiter");
planetList.Add("Saturn");
// Create another List that contains that last two planet of our solar system.
List<string> newPlanetList = new List <string>(){"Last","Two","Planets"};
// Combine the two lists by using AddRange().
planetList.AddRange(newPlanetList);

// Use Insert() to add Earth, and Venus in the correct order.
planetList.Insert(3,"Earth");
planetList.Insert(2,"Venus");
// Use Add() again to add Pluto to the end of the list.
planetList.Add("Pluto");
// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.


List <string> rockyPlanetList = planetList.GetRange(1,4);
// Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
planetList.Remove("Pluto");
Console.WriteLine(planetList);
Console.WriteLine(rockyPlanetList);
// ***************************

Random random = new Random();
List<int> numbers = new List<int> {
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
};
for (int i=0; i<numbers.Count; i++) {
Console.WriteLine(numbers);
}









        }
    }
}
