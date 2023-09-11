using ConsoleApp1.Model;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class BrinquedoController : IBrinquedoRepository
    {
        private readonly List<Brinquedo> toysList = new();
        private int num = 0;

        public void Delete(int id)
        {
            var toy = SearchInCollection(id);

            if (toy == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O brinquedo com Id {id} não foi encontrada");
                Console.ResetColor();
            }
            else
            {
                if (toysList.Remove(toy) == true)
                    Console.WriteLine($"Brinquedo do Id {id} foi removido com sucesso!");
            }
        }

        public void ListAll()
        {
            if (toysList.Count() > 0)
            {
                foreach (var toy in toysList)
                    toy.View();
            }
            else
            {
                Console.WriteLine("Estamos sem brinquedos no momento, volte mais tarde!");
            }
        }

        public void Register(Brinquedo toy)
        {
            toysList.Add(toy);
            Console.WriteLine($"O Brinquedo {toy.GetName()} foi cadastrado com sucesso");
        }

        public void Update(Brinquedo toy)
        {
            var Toy = SearchInCollection(toy.GetId());

            if (Toy == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Este brinquedo não foi encontrada");
                Console.ResetColor();
            }
            else
            {
                var index = toysList.IndexOf(Toy);
                toysList[index] = toy;

                Console.WriteLine($"O brinquedo de ID {toy.GetId()} foi atualizada com sucesso");
            }
        }

        public int GenerateNumber()
        {
            return ++num;
        }

        public Brinquedo? SearchInCollection(int id)
        {
            foreach (var toy in toysList)
            {
                if (toy.GetId() == id)
                    return toy;
            }

            return null;
        }
    }
}
