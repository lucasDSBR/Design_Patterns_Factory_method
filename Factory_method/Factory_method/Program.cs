using System;


namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Criador: O mesmo código de criadores acabou de trabalhar com " + product.Operation();

            return result;
        }

    }

    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

    public interface IProduct
    {
        string Operation();
    }

    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Resultado do ConcreteProduct1}";
        }
    }


    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Resultado do ConcreteProduct2}";
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Lançado com o ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Lançado com o ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Cliente: Não tenho conhecimento da classe do criador, " +
                "mas ainda funciona.\n" + creator.SomeOperation());
        }

        class Program
        {
            static void Main(string[] args)
            {
                new Client().Main();
            }
        }
    }
}