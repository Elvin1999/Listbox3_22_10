using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listbox3_22_10
{
    public class Car
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Vendor} {Model} {Year}";
        }
    }
}
