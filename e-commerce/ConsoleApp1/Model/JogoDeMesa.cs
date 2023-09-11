using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class JogoDeMesa : Brinquedo
    {
        private string typeOfGame, rules;

        public JogoDeMesa(int id, int type, string name, string brand, string description, decimal price, string typeOfGame, string rules) 
            : base(id, type, name, brand, description, price)
        {
            this.typeOfGame = typeOfGame;
            this.rules = rules;
        }

        public string GetTypeOfGame()
        {
            return typeOfGame;
        }

        public void SetTypeOfGame(string typeOfGame)
        {
            this.typeOfGame = typeOfGame;
        }
        public string GetRules()
        {
            return rules;
        }

        public void SetRules(string rules)
        {
            this.rules = rules;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Tipo do jogo: {typeOfGame}");
            Console.WriteLine($"As regras do jogo são: {rules}");
            Console.WriteLine("****************************************************");
        }
    }
}
