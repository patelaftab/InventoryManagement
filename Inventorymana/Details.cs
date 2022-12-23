using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventorymana
{
  public class Details
    {
        public List<TypesOfRice> typesOfRice;
    }
    public class TypesOfRice 
    {
        public string name;
        public int weight;
        public int price;
    }
}
