using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
        }
     
       
        static void Main(string[] args)
        {
            List<SecretSanta> christmasGifts = new List<SecretSanta>();
            string[] giftsFromFile = GetDataFromFile();

            foreach(string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newGifts = new SecretSanta(tempArray[0], tempArray[1]);
                christmasGifts.Add(newGifts);
            }

            foreach(SecretSanta giftsFromList in christmasGifts)
            {
                Console.WriteLine($"{giftsFromList.Name} wants {giftsFromList.Gift}.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Carmel\source\repos\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
