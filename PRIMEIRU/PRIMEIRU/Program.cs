using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEIRU
{
    class Program
    {
        static void Main(string[] args)
        {
            List<figura> L = new List<figura>();
            quadrado Q = null;
            triangulo T = null;
            Circulo C = null;
            int op;

            do
            {
                Console.Clear();

                Console.WriteLine("1.Adicionar Quadrado.");
                Console.WriteLine("2.Adicionar Triangulo.");
                Console.WriteLine("3.Adicionar Circulo.");
                Console.WriteLine("4.Consultar objeto.");
                Console.Write("Selecione a opção:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Q = new quadrado();
                        Console.Write("Digite o nome:");
                        Q.Nome = Console.ReadLine();
                        Console.Write("Digite a cor:");
                        Q.Cor = Console.ReadLine();
                        Console.Write("Digite o valor do lado:");
                        Q.Lado = double.Parse(Console.ReadLine());
                        L.Add(Q);
                        break;
                    case 2:
                        T = new triangulo();
                        Console.Write("Digite o nome:");
                        T.Nome = Console.ReadLine();
                        Console.Write("Digite a cor:");
                        T.Cor = Console.ReadLine();
                        Console.Write("Digite o valor da altura:");
                        T.Altura = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor da base:");
                        T.Baset = double.Parse(Console.ReadLine());
                        L.Add(T);
                        break;
                    case 3:
                        C = new Circulo();
                        Console.Write("Digite o nome:");
                        C.Nome = Console.ReadLine();
                        Console.Write("Digite a cor:");
                        C.Cor = Console.ReadLine();
                        Console.Write("Digite o valor do Raio:");
                        C.Raio = double.Parse(Console.ReadLine());
                        L.Add(C);
                        break;
                    case 4:
                        Console.Write("Digite o nome da figura:");
                        string s = Console.ReadLine();
                        foreach (figura i in L)
                        {
                            if (s==i.Nome)
                            {
                                mostra(i);
                            }
                        }
                        
                        break;
                    case 5:
                        break;
                    default:
                        break;

                }
            } while (op != 5);

        }
        static void mostra(figura L)
        {
            Console.WriteLine("Nome da figura:"+L.Nome+" cor:"+L.Cor+"Area"+L.area());
        }
    }
    }
