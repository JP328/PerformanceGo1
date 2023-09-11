using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public abstract class Brinquedo
    {
        private int id, type;
        private string name, brand, description;
        private decimal price;

        public Brinquedo(int id, int type, string name, string brand, string description, decimal price)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.brand = brand;
            this.description = description;
            this.price = price;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetTypeOfToy()
        {
            return type;
        }

        public void SetTypeOfToy(int type)
        {
            this.type = type;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }


        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
        }

        public virtual void View()
        {
            string? writingType = string.Empty;

            if (type == 1)
                writingType = "Boneco(a)";
            else
                writingType = "Jogo de Mesa";


            Console.WriteLine("****************************************************");
            Console.WriteLine("                 Informações do Brinquedo:");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"Número do Id: {id}");
            Console.WriteLine($"Nome do Brinquedo: {name}");
            Console.WriteLine($"Preço do Brinquedo: {price:C}");
            Console.WriteLine($"Tipo do Brinquedo: {writingType}");
        }


    }
}
