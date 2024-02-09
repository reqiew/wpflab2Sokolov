using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public interface Iviewier
    {

        public int Visits { get; set; }

   

        public void Visit() 
        {
            Visits++;
        }
        public abstract double Cost(double price);
   

    }
}
