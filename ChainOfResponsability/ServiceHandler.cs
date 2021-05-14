using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    abstract class ServiceHandler
    {
        protected ServiceHandler _nextServiceHandler;
        protected ServiceRequirements _serviceProvided;

        public ServiceHandler(ServiceRequirements serviceProvided)
        {
            _serviceProvided = serviceProvided;
        }

        public void Service(Car car) 
        {
            if (_serviceProvided == (car.Requirements & _serviceProvided))
            {
                Console.WriteLine($"{this.GetType().Name} providing {this._serviceProvided} services.");
                car.Requirements &= ~_serviceProvided;
            }
            if (car.IsServiceComplete || _nextServiceHandler == null)
            {
                return;
            }
            else
            {
                _nextServiceHandler.Service(car);
            }
        }

        public void SetNextServiceHandler(ServiceHandler handler)
        {
            _nextServiceHandler = handler;
        }
    }
}
