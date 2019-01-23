using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    class AppsAbstractFabric
    {
    }

    //Интерфейс абстрактной фабрики
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    //Интерфейс продукта семейства А
    public interface IProductA
    {
        void WriteNameAndType();
    }

    //Интерфейс продукта семейства В    
    public interface IProductB
    {
        void WriteNumber();
    }

    public class ProductA1 : IProductA
    {
        public void WriteNameAndType()
        {
            Console.WriteLine("Name: ProductA. Type: 1");
        }
    }

    public class ProductA2 : IProductA
    {
        public void WriteNameAndType()
        {
            Console.WriteLine("Name: ProductA. Type: 2");
        }
    }

    public class ProductB1 : IProductB
    {
        public void WriteNumber()
        {
            Console.WriteLine(1);
        }
    }

    public class ProductB2 : IProductB
    {
        public void WriteNumber()
        {
            Console.WriteLine(2);
        }
    }

    public class Factory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class Factory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public class ClientCode
    {
        private IProductA productA;
        private IProductB productB;

        public ClientCode(IAbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void WriteNamaAndType()
        {
            productA.WriteNameAndType();
        }

        public void WriteNumber()
        {
            productB.WriteNumber();
        }
    }

}
