using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Car
    {
        public ServiceRequirements Requirements { get; set; }
        public bool IsServiceComplete { get; }
    }
}
