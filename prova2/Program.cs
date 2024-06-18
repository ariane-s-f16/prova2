using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor = 0;
            double saldo = 0;
            double totalsaldo = 0;


            string op = "S";

            while (op == "S")
            {

                
                Console.WriteLine("Escolha entre as opções:");
                Console.WriteLine("1-) Efetuar depósito");
                Console.WriteLine("2-) Efetuar saque");
                Console.WriteLine("3-) Efetuar pagamento");
                Console.WriteLine("4-) Consultar saldo");
                Console.Write("Escolha:");
                int es = int.Parse(Console.ReadLine());

                switch (es)
                {
                    case 1:
                        Console.Write("Quanto deseja depositar? R$");
                        valor = double.Parse(Console.ReadLine());
                        saldo = dep(valor, totalsaldo);
                        
                        break;
                    case 2:
                        Console.Write("Quanto deseja sacar? R$");
                        valor = double.Parse(Console.ReadLine());
                        if (valor > totalsaldo)
                        {
                            Console.WriteLine("saldo insuficiente");
                        }
                        else if (valor < totalsaldo)
                        {

                            saldo = saq(valor, totalsaldo);
                        }
                        break;
                    case 3:
                        Console.Write("Quanto deseja pagar? R$");
                        valor = double.Parse(Console.ReadLine());
                        if (valor > totalsaldo)
                        {
                            Console.WriteLine("saldo insuficiente");
                        }
                        else if (valor < totalsaldo)
                        {
                            Console.WriteLine("Pagamento efetuado");
                            saldo = pag(valor, totalsaldo);
                        }
                        break;
                    case 4:
                        saldo = totalsaldo;
                        break;
                        
                       

                } 
                

                Console.WriteLine("O saldo é: " + saldo.ToString("C"));

                Console.WriteLine("deseja fazer mais alguma coisa(S/N)?");
                 op = Console.ReadLine().ToUpper();

                Console.Clear();    
               
                totalsaldo = saldo;


                
            }


        }
        static double saq(double valor, double saldo)
        {

            double saq = saldo - valor;
            return saq;
        }

        static double dep(double valordep, double saldo)
        {

           double dep = saldo +  valordep;
            return dep;
        }

        static double pag(double valor, double saldo)
        {

            double pag = saldo - valor;
            return pag;
        }
    }
}
