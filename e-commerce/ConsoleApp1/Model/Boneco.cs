using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Boneco : Brinquedo
    {
        private string gender, acessories;

        public Boneco(int id, int type, string name, string brand, string description, decimal price, string gender, string acessories) 
            : base(id, type, name, brand, description, price)
        {
            this.gender = gender;
            this.acessories = acessories;
        }

        public string GetGender()
        {
            return gender;
        }

        public void SetGender(string gender)
        {
            this.gender = gender;
        }
        public string GetAcessories()
        {
            return acessories;
        }

        public void SetAcessories(string acessories)
        {
            this.acessories = acessories;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"O público alvo do boneco(a) é {gender}");
            Console.WriteLine($"O boneco(a) tem os seguintes acessórios: {gender}");
            Console.WriteLine("****************************************************");
        }
    }
}
