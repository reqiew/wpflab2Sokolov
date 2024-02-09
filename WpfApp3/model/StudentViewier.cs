using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace WpfApp3
{
    internal class StudentViewier: Iviewier
    {
        public int Visits { get; set; }

        public StudentViewier(int visits)
        {
            Visits = visits;
        }

        public double Cost(double price)
        {
            int discont = 0;
            if (Visits % 3 == 0)
            {
                discont = 50;
            }
            return price - (price * discont) / 100;
        }
    }
}
