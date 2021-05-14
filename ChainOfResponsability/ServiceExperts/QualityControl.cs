using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.ServiceExperts
{
    class QualityControl : ServiceHandler
    {
        public QualityControl() : base(ServiceRequirements.TestDrive) { }

    }
}
