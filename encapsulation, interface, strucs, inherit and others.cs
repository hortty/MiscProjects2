using System;

namespace Proj
{
    interface Inter {
          void func1(string c);
          int func2(int a, int b);  
    }

    interface Inter2 {
          string func3(string c);
    }

    public class Classe:Inter, Inter2 { //interface handling
        public void func1(string c) {
            Console.WriteLine(c);
        }
        public int func2(int a, int b) {
            return a+b;
        }
        public string func3(string c) {
            return c;
        }
    }

    struct Casa {                       //struct handling
        private int janela;
        private int flag;
        public void Janela() {
            flag=0;
            perguntar();
            if(flag!=1) {
                Console.WriteLine("Voce escolheu "+janela+" janelas!");
            }
        }
        public void Parede() {
            int i=1;
            for(i=1;i<=10;i++) {
            Console.WriteLine("Parede "+i);
            }
        }
        private void perguntar() {
            Console.WriteLine("Quantas janelas você quer? Inteiro e maior que zero");
            try {                       //exception handling
                janela = Convert.ToInt32(Console.ReadLine());
                if(janela<=0) {
                    throw new Exception("Janela nao pode ser menor que zero");
                }
            }
            catch(Exception error) {
                Console.WriteLine("Ocorreu um erro: " + error);
                flag=1;
            }
        }
    }

    class Base {                        
        protected string color;
        protected int height;           //encapsulation
        public Base() {                 //constructor
            height = 5;
            color = "Red";
            Console.WriteLine("Base class constructor test");
            Console.WriteLine("Color: "+color+", Height: "+height);
        }
           public class NestClass:Base {
            public void Show() {
                color="Blue";           //nested classes
                height=10;
                Console.WriteLine("Color: "+color+", Height: "+height);
            }
        }
            public void Show1() {
                color="Yellow";
                height=20;
                Console.WriteLine("Color: "+color+", Height: "+height);
            }
    }

    class Program
    {
        enum Enumeros {One,Two,Three};

        static void Generic <T> (T A, T B) {
            Console.WriteLine("Valores: "+A+" e "+B);
        }

        static void Main(string[] args)
        {
            //teste1
            Classe c = new Classe();
            c.func1("Nome1");
            Console.WriteLine(c.func2(5,3));
            Console.WriteLine(c.func3("Nome2"));
            Console.WriteLine("Teste0");
            Console.WriteLine("\n");
            //teste2
            Casa ss = new Casa();
            ss.Parede();
            ss.Janela();
            Console.WriteLine("Teste1");
            Console.WriteLine("\n");

            //teste3
            Base.NestClass teste = new Base.NestClass();
            teste.Show();
            teste.Show1();
            Console.WriteLine("Teste2");
            Console.WriteLine("\n");

            Enumeros x = Enumeros.Two;  //enum test
            if(x==Enumeros.Two) {
                Console.WriteLine(Enumeros.Two);
            }
            Console.WriteLine("Teste3");
            Console.WriteLine("\n");

            Generic("AA", "BB");        //generic test
            Generic(321, 123);
            Console.WriteLine("Teste4");
            Console.WriteLine("\n");
        }
    }
}

