using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.App
{
    public class MenuItem
    {
        public string Description { get; set; }
        public ConsoleKey KeyToActivate { get; set; }
        public string KeyDescription { get; set; }
        public Action Operation { get; set; }
    }
}
