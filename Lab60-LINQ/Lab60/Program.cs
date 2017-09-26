using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab60
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
            new Car() { Make = "BMW", Model="550i", Color=CarColor.blue, StickerPrice= 55000, Year= 2009 },
            new Car() { Make = "Toyota", Model = "4Runner", Color = CarColor.white, StickerPrice = 35000, Year = 2010 },
            new Car() { Make = "BMW", Model = "745li", Color = CarColor.black, StickerPrice = 75000, Year = 2008 },
            new Car() { Make = "Ford", Model = "Escape", Color = CarColor.white, StickerPrice = 28000, Year = 2008 },
            new Car() { Make = "BMW", Model = "550i", Color = CarColor.black, StickerPrice = 57000, Year = 2010 }
        };


            var BMW2010 = from car in myCars
                          where car.Year == 2010 
                          && car.Make == "BMW"
                          select car;

            Console.WriteLine("2010 BMWS \n");
            foreach (var car in BMW2010)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}");
            }

            var Post2009 = from car in myCars
                           where car.Year > 2009
                           select new { car.Make, car.Model, car.Year };

            Console.WriteLine("\nCar Year > 2009 \n");
            foreach (var car in Post2009)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}");
            }

            var CarDesc = from car in myCars
                          orderby car.Year descending
                          select car;

            Console.WriteLine("\nCars Ordered By Descending \n");
            foreach (var car in CarDesc)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}");
            }


        }
    }
}
