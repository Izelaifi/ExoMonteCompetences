using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        //Constructeur
        public Client(AbstractFactory factory) {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
    }
        public void run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
