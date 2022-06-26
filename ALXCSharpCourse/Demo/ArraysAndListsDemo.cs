using ALXCSharpCourse.Models;
using System;
using System.Collections.Generic;

namespace ALXCSharpCourse.Demo
{
    public class ArraysAndListsDemo
    {
        public static void Run()
        {
            int x = 4;
            //typ[] nazwa = new typ[numberOfElements];
            int[] array1 = new int[7];
            array1[0] = 4;
            array1[1] = 2;
            array1[2] = 1;
            array1[3] = 0;
            array1[4] = 3;
            array1[5] = 4;
            array1[6] = 1;
            //typ[] nazwa = { elements };
            int[] array2 = { 4, 2, 1, 0, 3, 4, 1 };

            //foreach(typ elementName in arrayName)
            Console.WriteLine("Array 1");
            foreach(int number in array1)
            {
                
                Console.Write($"{number}, ");
            }
            Console.WriteLine("Array 2");
            foreach (int number in array2)
            {
                Console.Write($"{number}, ");
            }

            Dog[] dogArray = new Dog[3];
            dogArray[0] = new Dog("Mickey", "Golden Retriver");
            dogArray[1] = new Dog("Azor", "Doberman");
            dogArray[2] = new Dog("Boorek", "Jack Russel Terrier");

            Dog westieDog = new Dog("Skipper","WHNT");
            Dog dobermanDog = new Dog("Misio", "Doberman");
            Dog[] dogArray2 = { westieDog, dobermanDog, new Dog("Jack", "Huskey")};

            int[,] twoDArray = new int[2, 7];
            int[,,] threeDArraey = new int[4, 4, 5];


                Console.WriteLine("Dog Array");

            foreach(Dog dog in dogArray)
            {
                dog.Present();
                dog.Bark();
            }

        }
        public static void RunLists()
        {
            // dog czy var - nie ma znaczenia
            var dog1 = new Dog("Mickey", "Golden Retriver");
            var dog2 = new Dog("Azor", "Doberman");
            var dog3 = new Dog("Boorek", "Jack Russel Terrier");
            var dog4 = new Dog("Jack", "Huskey");

            //List<ListElementClass> listName = new List<ListElementClass>()
            //List<Dog> dogs = List<Dog>();
            var dogs = new List<Dog>();

            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog2);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog3);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog1);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog4);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Remove(dog2);
            Console.WriteLine($"List Size: {dogs.Count}");

            foreach (var dog in dogs)
            {
                dog.Present();
            }

            List<int> numbers = new List<int>();
            numbers.Add(1); 
            numbers.Add(35);
            numbers.Add(121);
            numbers.Add(1200);
            Console.WriteLine(numbers[1]);
             
        }
        
    }
}
