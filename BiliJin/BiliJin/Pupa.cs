using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliJin
{
    public class Pupa
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public Pupa(int idProduct, string name, decimal cost)
        {
            IdProduct = idProduct;
            Name = name;
            Cost = cost;
        }
    }

    public class Lupa : Pupa
    {
        public int Amount { get; set; }

        public Lupa(int idProduct, string name, decimal cost, int amount) : base(idProduct, name, cost)
        {
            Amount = amount;
        }   
    }
}
