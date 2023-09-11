using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public interface IBrinquedoRepository
    {
        public void ListAll();
        public void Register(Brinquedo toy);
        public void Update(Brinquedo toy);
        public void Delete(int id);
    }
}
