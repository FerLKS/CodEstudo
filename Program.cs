using System;
using System.Globalization;
using System.Collections.Generic;
using Primeiro.Entities;
using Primeiro.Entities.Enums;

namespace Primeiro
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
            Triangulo X, Y;

            X = new Triangulo();
            Y = new Triangulo();

            double p=0;
            double a=0;
            double py = 0;
            double ay = 0;
            
            Console.WriteLine( "Entre com as medidas do triângulo X");

            X.A = double.Parse(Console.ReadLine());
            X.B = double.Parse(Console.ReadLine());
            X.C = double.Parse(Console.ReadLine());


            double AreaX = X.Area();

 //          p = (X.A + X.B + X.C)/2.0;
 //          a = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));


            Console.WriteLine( "Entre com as medidas do triângulo Y");

            Y.A = double.Parse(Console.ReadLine());
            Y.B = double.Parse(Console.ReadLine());
            Y.C = double.Parse(Console.ReadLine());


            double AreaY = Y.Area();

 //          py = (Y.A + Y.B + Y.C)/2.0;
 //          ay = Math.Sqrt(py * (py - Y.A) * (py - Y.B) * (py - Y.C));


            Console.WriteLine("Área de X = {0:F4}", AreaX);

            Console.WriteLine("Área de Y = {0:F4}", AreaY);


            if (a>ay)
            {

                Console.WriteLine("Triângulo  X é maior");
            }
            else
            {


                Console.WriteLine("Triângulo Y é maior");
            } 
            */



            /*
            DADOS x, y;

            x = new DADOS();

            y = new DADOS();

            Console.WriteLine("Dados da primeira pessoa:");


            Console.Write("Nome:");
            x.A = Console.ReadLine();


            Console.Write("Idade:");
              x.B = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome:");
             y.A = Console.ReadLine();


            Console.Write("Idade:");
             y.B = int.Parse(Console.ReadLine());


            if (x.B>y.B)
            {
                Console.WriteLine("Pessoa mais velha: {0}",x.A);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", y.A);

            }

            */




            /*

            produtos n;

            n = new produtos();


            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");  n.Nome = Console.ReadLine();
            Console.Write("Preço: "); n.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: "); n.Qnt = int.Parse(Console.ReadLine());

            double total = n.Qnt * n.Preco;

            Console.WriteLine("Dados do produto: {0}, $ {1}, {2} unidades, Total: $ {3}",n.Nome,n.Preco,n.Qnt,total) ;

            Console.Write("Digite o número  de produtos  a ser adicionado ao estoque: "); int qntadicionar = int.Parse(Console.ReadLine());

            n.Qnt = n.Qnt + qntadicionar;
            // total = n.Qnt * n.Preco;

            Console.WriteLine("Dados atualizados: {0}, $ {1}, {2} unidades, Total: $ {3}", n.Nome, n.Preco, n.Qnt, total;


            Console.Write("Digite o número  de produtos  a ser removido do estoque: "); int qntretirar = int.Parse(Console.ReadLine());

            n.Qnt = n.Qnt - qntretirar;
          //  total = n.Qnt * n.Preco;

            Console.WriteLine("Dados atualizados: {0}, $ {1}, {2} unidades, Total: $ {3}", n.Nome, n.Preco, n.Qnt, total;


            */






            /*
                        Retangulo x;

                        x = new Retangulo();

                        Console.WriteLine("Entre a largura e altura do retângulo:");

                        x.Largura = double.Parse(Console.ReadLine());
                        x.Altura  = double.Parse(Console.ReadLine());


            Console.WriteLine("AREA = "      +   x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " +   x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = "  +   x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            */





            /*

            ConversorDeMoeda x;

            x = new ConversorDeMoeda();

            Console.Write("Qual é a cotação do dólar? ");   x.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares vc vai comprar? ");  x.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais? = "+ x.Total().ToString("F2",CultureInfo.InvariantCulture));



            

            */




            /*

            
              // Produto p = new Produto();
                Console.WriteLine("Entre os dados do produto:");

              //  Produto p = new Produto("TV", 500.00, 10);

               // Console.WriteLine(p.Nome);

               // Console.WriteLine(p.Preco);

                
                Console.Write("Nome: ");       string nome = Console.ReadLine();


                Console.Write("Preço: ");      double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Console.Write("Quantidade no estoque: ");  int  quantidade = int.Parse(Console.ReadLine());


                Produto p = new Produto(nome, preco, quantidade);


                Console.WriteLine("Dados do produto: " + p);

 
                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + p);
                Console.WriteLine();
                Console.Write("Digite o número de produtos a ser removido do estoque: ");

               
                
                qte = int.Parse(Console.ReadLine());

                if (qte>quantidade)
                {
                Console.WriteLine("Essa quantidade não pode ser retirada");
                }


                else
                 {


                p.RemoverProdutos(qte);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + p);


                 }

            */





            /*
            

            Console.WriteLine("Entre o número da conta: "); int NumConta =int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: "); string Nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)"); char LetraDep = char.Parse(Console.ReadLine());
            Banco x = new Banco(NumConta, Nome, LetraDep);
            if (LetraDep == 's' || LetraDep == 'S')
            {
                Console.WriteLine("Entre o valor do depósito inicial:"); double vlr = double.Parse(Console.ReadLine());
                x.Vi(vlr);
            }



            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine("Conta: " + x);
            Console.WriteLine("Entre um valor para depósito: "); double adc= double.Parse(Console.ReadLine());
            x.AdicionarDin(adc);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Conta: " + x);
            Console.WriteLine("Entre um valor para saque: "); double ret = double.Parse(Console.ReadLine());
            x.RetirarDin(ret);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Conta: " + x);


            */

            /*
       
            
                double? x = null;
                double? y = 10.0;
                Console.WriteLine(x.GetValueOrDefault());
                Console.WriteLine(y.GetValueOrDefault());
                Console.WriteLine(x.HasValue);
                Console.WriteLine(y.HasValue);
                if (x.HasValue)
                {

                Console.WriteLine(x.Value);
                }
                else
                {
                Console.WriteLine("X is null");
                }
                
                if (y.HasValue)
                {
                Console.WriteLine(y.Value);
                }
                   
                else
                {
                Console.WriteLine("Y is null");
                }   
                    
            */




            /*
            int n = int.Parse(Console.ReadLine());
            double med=0;
            double[] x = new double [n];

            for (int i= 0; i < n; i++)
            {
                double alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                 med = med + alt;

            }
            med = med / n;
            Console.WriteLine("AVERAGE HEIGHT = " + med.ToString("F2", CultureInfo.InvariantCulture));



            */

            /*
            int n = int.Parse(Console.ReadLine());
            double med = 0;
            string nome;
            double[] x = new double[n];

            for (int i = 0; i < n; i++)
            {
                nome = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                med = med + price;

            }
            med = med / n;
            Console.WriteLine("AVERAGE PRICE  = " + med.ToString("F2", CultureInfo.InvariantCulture));


            */

            /*
           Estudante[] n = new Estudante[10];

            Console.WriteLine("Qunatos quartos serão alugados?"); int x = int.Parse(Console.ReadLine());

            

            Console.WriteLine();

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome:"); string nome = Console.ReadLine();
                Console.Write("E-mail:"); string email = Console.ReadLine();
                Console.Write("Quarto:"); int quarto = int.Parse(Console.ReadLine());
                n[quarto] = new Estudante(nome, email);               
                
               
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for(int i = 1; i<=10;i++)
            {
                if (n[i] != null)
                {
                    Console.WriteLine(i + ": " + n[i]);
                }
            }


            */



            /*


          Console.Write("Quantos funcionários você quer registrar? ");
          int x = int.Parse(Console.ReadLine());


          List<funcionarios> registros = new List<funcionarios>();


          for (int i = 1; i<=x;i++)
          {
              Console.WriteLine("Funcionário #" + i +":" );
              Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
              Console.Write("Nome: "); string nome = Console.ReadLine();
              Console.Write("Salário:  "); double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
              registros.Add(new funcionarios(id,nome,salario));
              Console.WriteLine();

          }

          Console.Write("Digite o ID do funcionário que deseja aumentar o salário: "); int aumentoid = int.Parse(Console.ReadLine());


          funcionarios y = registros.Find(x => x.ID == aumentoid);

          if (y!=null)
          {
              Console.WriteLine("Digite a porcentagem:");double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
              y.aumento(porcentagem);
          }
          else
          {
              Console.WriteLine("Este ID não existe!");
          }

          Console.WriteLine();
          Console.WriteLine("Lista de funcionários atualizada:");
          foreach (funcionarios obj in registros)
          {
              Console.WriteLine(obj);

          }

          */





            /*

                int n = int.Parse(Console.ReadLine());

                int[,] mat = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string[] values = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        mat[i, j] = int.Parse(values[j]);
                    }
                }

                Console.WriteLine("Main diagonal:");
                for (int i = 0; i < n; i++)
                {
                Console.Write(mat[i, i] + " ");
                }
                Console.WriteLine();

                int count = 0;
                for (int i = 0; i < n; i++)
                 {
                     for (int j = 0; j < n; j++)
                    {
                        if (mat[i, j] < 0)
                        {
                        count++;
                        }
                    }
                }
                Console.WriteLine("Negative numbers: " + count);



            */




            /*
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());


            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }

            }

            */


            /*
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            */





            /*
            

            DateTime h = new DateTime(2000, 8, 15, 13, 5, 58, 275); //275 é milisegundo


            DateTime y = new DateTime(2000, 8, 15, 13, 5, 58);

            DateTime x = DateTime.Now;

            DateTime z = new DateTime(2020, 10, 15);
            DateTime w = new DateTime(2020, 10, 20);

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58,275);


            TimeSpan t1 =  new TimeSpan();
            TimeSpan t2 =  new TimeSpan(2,11,21);
            
            string t3 = d.ToString("yyyy-MM-dd      HH:mm:ss.fff");

            TimeSpan t = w.Subtract(z);


            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(h);

            Console.WriteLine(t1);
            Console.WriteLine(t2);

            Console.WriteLine(t3);


            Console.WriteLine(t + " Dias");




            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());



            */



            /*

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderProcess.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderProcess.PendingPayment.ToString();

            OrderProcess os = (OrderProcess)Enum.Parse(typeof(OrderProcess), "Delivered");


            Console.WriteLine(os);
            Console.WriteLine(txt);

         


            */












        }
    }
  }

