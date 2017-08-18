using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    public class Program
    {
        //declaração de uma lista
        public static List<Carro> listaCarro;

        //método principal
        static void Main(string[] args)
        {
            //criando uma lista vazia de carros
            listaCarro = new List<Carro>();

            //criando objetos do tipo carro
            Carro carro1 = new Carro("Ford");
            Carro carro2 = new Carro("GM");
            Carro carro3 = new Carro("Fiat");

            //adicionando na lista
            listaCarro.Add(carro1);
            listaCarro.Add(carro2);
            listaCarro.Add(carro3);

            //listando
            foreach (var carro in listaCarro)
            {
                Console.WriteLine("A marca do carro é:" + carro.Marca);
            }

        }


        /*  foreach (var argumento in args)
          {
              Console.WriteLine("O argumento é:"+argumento);
          }*/


        //var meuPrograma = new Program();
        //int x = 20;
        //int y = 30;
        //Console.WriteLine("Antes - Valor de x é {0} e y é {1}", x, y);

        //meuPrograma.Soma(x, y);

        //Console.WriteLine("Depois - Valor de x é {0} e y é {1}", x, y);


        /*  var meuPrograma = new Program();

          int total=0 ;

          int x = 40;
          int y = 30;
          Console.WriteLine("Antes - total é:"+total);

          meuPrograma.Soma2(x,y, out total);

          Console.WriteLine("Depois - total é:" + total);*/

        // }


        public static void ImprimeMsg()
        {
            Console.WriteLine("Hello World1!!!!!!!");
            Console.WriteLine("Hello World2!!!!!!!");
            Console.WriteLine("Hello World3!!!!!!!");
            Console.WriteLine("Hello World4!!!!!!!");
        }

        //passagem de parametros por valor
        public int Soma(int x, int y)
        {
            return x + y;
        }

        //passagem de parametros por referência
        public void Soma2(int x, int y, out int total)
        {
            total = x + y;
        }


    }


}

