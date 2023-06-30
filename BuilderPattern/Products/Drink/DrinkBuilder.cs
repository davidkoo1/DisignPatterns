using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products.Drink
{
    public class DrinkBuilder : IDrinkBuilder
    {

        private Drink _drink;

        public DrinkBuilder()
        {
            _drink = new();
        }

        public void Cola()
        {
            _drink.Name = "Coca-Cola";
            _drink.Description = "Sweet water";
            VolumeType[] volumeCola = new VolumeType[]
            {
                new VolumeType{Name = "0,2", Price = 3m },
                new VolumeType{Name = "0,5", Price = 5m },
                new VolumeType{Name = "1", Price = 10m }
            };

            Console.WriteLine("Select volume : ");
            Console.WriteLine("1 - 0,2 |  3$");
            Console.WriteLine("2 - 0,5 |  5$");
            Console.WriteLine("3 - 1   | 10$");
            int optionColaVolume = int.Parse(Console.ReadLine());
            _drink.Description += "\t\t| " + volumeCola[optionColaVolume - 1].Name;
            _drink.Description += "\n----------------------------------------------------------------\n";
            _drink._price = volumeCola[optionColaVolume - 1].Price;
        }

        public void Sprite()
        {
            _drink.Name = "Sprite";
            _drink.Description = "Sweet water";
            VolumeType[] volumeCola = new VolumeType[]
            {
                new VolumeType{Name = "0,2", Price = 2.79m },
                new VolumeType{Name = "0,5", Price = 3.87m },
                new VolumeType{Name = "1", Price = 5.18m }
            };

            Console.WriteLine("Select volume : ");
            Console.WriteLine("1 - 0,2 |  2.79$");
            Console.WriteLine("2 - 0,5 |  3.87$");
            Console.WriteLine("3 - 1   |  5.18$");
            int optionColaVolume = int.Parse(Console.ReadLine());

            _drink.Description +="\t\t| " + volumeCola[optionColaVolume - 1].Name;
            _drink.Description += "\n----------------------------------------------------------------\n";
            _drink._price = volumeCola[optionColaVolume - 1].Price;
        }

        public void Fanta()
        {
            _drink.Name = "Fanta";
            _drink.Description = "Sweet water";
            VolumeType[] volumeCola = new VolumeType[]
            {
                new VolumeType{Name = "0,2", Price = 3m },
                new VolumeType{Name = "0,5", Price = 4.5m },
                new VolumeType{Name = "1", Price = 7.22m }
            };

            Console.WriteLine("Select volume : ");
            Console.WriteLine("1 - 0,2 |  3$");
            Console.WriteLine("2 - 0,5 |  4.5$");
            Console.WriteLine("3 - 1   |  7.22$");
            int optionColaVolume = int.Parse(Console.ReadLine());

            _drink.Description += "\t\t| " + volumeCola[optionColaVolume - 1].Name;
            _drink.Description += "\n----------------------------------------------------------------\n";
            _drink._price = volumeCola[optionColaVolume - 1].Price;
        }

        public void SimpleWater()
        {
            _drink.Name = "Gura-Cainarului";
            _drink.Description = "Simple water";
            VolumeType[] volumeCola = new VolumeType[]
            {
                new VolumeType{Name = "0,2", Price = 1m },
                new VolumeType{Name = "0,5", Price = 1.5m },
                new VolumeType{Name = "1", Price = 3m }
            };

            Console.WriteLine("Select volume : ");
            Console.WriteLine("1 - 0,2 |  1$");
            Console.WriteLine("2 - 0,5 |  1.5$");
            Console.WriteLine("3 - 1   |    3$");
            int optionColaVolume = int.Parse(Console.ReadLine());

            _drink.Description += "\t\t| " + volumeCola[optionColaVolume - 1].Name;
            _drink.Description += "\n----------------------------------------------------------------\n";
            _drink._price = volumeCola[optionColaVolume - 1].Price;
        }

        public void Baban()
        {
            _drink.Name = "Baban";
            _drink.Description = "Water for GUD";

            _drink.Description += "\t\t| Baban With Orange";
            _drink.Description += "\n----------------------------------------------------------------\n";
            _drink._price = 7;
        }
        public Drink GetDrink()
        {
            Drink drink = _drink;

            _drink = new();

            return drink;
        }
    }
}
