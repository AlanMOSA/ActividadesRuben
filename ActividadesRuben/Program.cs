using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesRuben
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            //Console.Write("Dame tu nombre completo por favor ");
            //string nombreCompleto = Console.ReadLine();
            //Console.WriteLine("Hola " + nombreCompleto);

            //Console.Write("Tecla un numero entero: ");
            //string n1 = Console.ReadLine();
            //Console.Write("Tecla un numero entero: ");
            //string n2 = Console.ReadLine();
            //int suma = int.Parse(n1) + int.Parse(n2);
            //int resta = int.Parse(n1) - int.Parse(n2);
            //int multiplicacion = int.Parse(n1) * int.Parse(n2);
            //double divicion = int.Parse(n1) / double.Parse(n2);
            //Console.WriteLine("Suma: " + suma);
            //Console.WriteLine("resta: " + resta);
            //Console.WriteLine("multiplicacion: " + multiplicacion);
            //Console.WriteLine("divicion: " + divicion);



            //int n1, n2, s, r, m;
            //double d;

            //Console.Write("Tecla un numero entero: ");
            //n1= int.Parse(Console.ReadLine());
            //Console.Write("Tecla un numero entero: ");
            //n2 = int.Parse(Console.ReadLine());
            //s = n1 + n2;
            //r = n1 - n2;
            //m = n1 * n2;
            ////d =(double) n1 / n2;
            //d = n1 / (n2 * 1.0);

            //Console.WriteLine("Suma "+s);
            //Console.WriteLine("Resta " + r);
            //Console.WriteLine("Multiplicacion " + m);
            //Console.WriteLine("Divicion " + d);


            Console.WriteLine("Inicio");
            int a = 5;
            int b = 100;
            int c = 1;
            // ==   !=   >  <  >=  <=   !  --------- &&  ||
            // Tablas de Verdad 
            // A  B   X  AND (&&) Para que el resultado sea V todas la entradas deben de ser V
            // F  F   F
            // F  V   F
            // V  F   F
            // V  V   V

            // A  B   X  OR (||) Para que el resultado sea F todas la entradas deben de ser F..V con almenos una entrada V
            // F  F   F
            // F  V   V
            // V  F   V
            // V  V   V

            //if (a == 0 && b == 0)
            //{
            //    Console.WriteLine("a y b no valen 0");
            //}
            //else
            //{
            //    Console.WriteLine("a y b no valen 0");
            //}

            //bool valor = true;
            //if (valor)
            //{
            //    Console.WriteLine("valor es verdadero");
            //}
            //else
            //{
            //    Console.WriteLine("valor es falso");
            //}

            //Anidar
            /*if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a es Mayor");
                }
                else
                {
                    Console.WriteLine("c es Mayor");
                }

            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b es Mayor");
                }
                else
                {
                    Console.WriteLine("c es Mayor");
                }

                Console.WriteLine("Fin");

                
            }*/

            ////
            /*if (a==1)
            {
                Console.WriteLine("a vale 1");
            }

            if (a == 2)
            {
                Console.WriteLine("a vale 2");
            }

            if (a == 3)
            {
                Console.WriteLine("a vale 3");
            }
            */


            /*switch(a)
            {
                case 1:
                    Console.WriteLine("a vale 1");
                    break;
                case 2:
                    Console.WriteLine("a vale 2");
                    break;
                case 3:
                    Console.WriteLine("a vale 3");
                    break;
                    default:
                          Console.WriteLine("a fuera de rango");
                    break;
            }*/

            ///Ciclo
            //Console.WriteLine("C = " + c);
            //c++;  //c=c+1;
            //c--;  //c=c-1;
            //c+=2; //c=c+2;
            //c -= 4; //c=c-4;
            //c *= 3;

            //Console.WriteLine("C = " + c);
            //c++;
            //Console.WriteLine("C = " + c);
            //c++;
            //Console.WriteLine("C = " + c);
            //c++;

            // Ciclos for, while, do-while, foreach
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("i = "+i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("2 x "+i+" = " + (2*i));
            //}

            //
            //string respuesta = "S";
            //while (respuesta=="S")
            //{

            //    Console.WriteLine("Hola .. tu respuesta fur S");
            //    Console.WriteLine("respuesta S/N");
            //    respuesta = Console.ReadLine();
            //}

            string respuesta = "S";
            do
            {
                Console.WriteLine("Hola .. tu respuesta fur S");
                Console.WriteLine("respuesta S/N");
                respuesta = Console.ReadLine();
            } while (respuesta == "S");


            Console.ReadKey();
        }
    }

}
 


