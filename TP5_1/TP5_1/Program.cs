using System;
using System.Text.RegularExpressions;

namespace TP5_1
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            //ApartadoUno();

            //ApartadoDos();

            //ApartadoTres();

            //ApartadoCuatro();

            ApartadoCinco();



        }
        private unsafe static void InvertirNum (int *numero)
        {
            int n = 0;
            int inverso = 0;
            int resto = 0;
            if (*numero > 0)
            {
                while (*numero > 10)
                {
                    n = *numero;
                    *numero = n / 10;
                    resto = n % 10;
                    inverso = (resto + inverso)*10;                    
                }
                inverso = inverso + *numero;
                *numero=inverso;
            } 
            
        }

        private unsafe static void ApartadoUno ()
        {
            Console.WriteLine("------------ EJERCICIO NUMERO 1 ------------\n");
            Console.WriteLine("Ingrese un numero entero de n cifras: ");
            int numeroIngresado = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero ingresado es " + numeroIngresado);
            InvertirNum(&numeroIngresado);
            Console.WriteLine("El numero ingresado invertido es " + numeroIngresado);
            Console.WriteLine("\n--------------------------------------------\n");
        }

        private static void ApartadoDos ()
        {
            Console.WriteLine("------------ EJERCICIO NUMERO 2 ------------\n");
            int seguir;
            Console.WriteLine("\nCALCULADORA BÁSICA\n");
            Console.WriteLine("Operaciones soportadas\n");
            do
            {
                Console.WriteLine("| presione 1 para SUMA |\n| presione 2 para RESTA |\n| presione 3 para PRODUCTO |\n| presione 4 para DIVISION |");
                Console.WriteLine("\nIngrese los numeros para calcular: ");
                int num1 = int.Parse(Console.ReadLine()); int num2 = int.Parse(Console.ReadLine());
                
                Console.WriteLine("\nEscriba la operacion a realizar: ");
                int operacion = int.Parse(Console.ReadLine());


                if (operacion == 1)
                {
                    Console.WriteLine("\nUsted eligió realizar una SUMA\n");
                    int suma = num1 + num2;
                    //Console.WriteLine(num1 + " + " + num2 + " = " + suma);
                    Console.WriteLine("La suma de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + suma.ToString());
                }

                if (operacion == 2)
                {
                    Console.WriteLine("\nUsted eligió realizar una RESTA\n");
                    int resta = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + resta);
                }

                if (operacion == 3)
                {
                    Console.WriteLine("\nUsted eligió realizar un PRODUCTO\n");
                    int prod = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + prod);
                }

                if (operacion == 4)
                {
                    Console.WriteLine("\nUsted eligió realizar una DIVISION\n");
                    int div = num1 / num2;
                    Console.WriteLine(num1 + " / " + num2 + " = " + div);
                }

                Console.WriteLine("\nPresione 0 para terminar, 1 para hacer otro cálculo");
                seguir = int.Parse(Console.ReadLine());
            
            } while (seguir == 1);            
                
            Console.WriteLine("\n--------------------------------------------\n");
        }

        private static void ApartadoTres()
        {
            Console.WriteLine("------------ EJERCICIO NUMERO 3 ------------\n");
            Console.WriteLine("\nCALCULADORA MEJORADA\n");
            
            Console.WriteLine("Ingrese un numero: ");
            float numero = float.Parse(Console.ReadLine());

            Console.WriteLine("\nValor absoluto: " + Math.Abs(numero) +"\n");
            Console.WriteLine("Cuadrado: " + Math.Pow(numero,2) + "\n");
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(numero) + "\n");
            Console.WriteLine("Seno: " + Math.Sin(numero) + "\n");
            Console.WriteLine("Coseno: " + Math.Cos(numero) + "\n");
            Console.WriteLine("Parte entera: " + Math.Truncate(numero) + "\n");

            Console.WriteLine("\n\nMÁXIMO y MÍNIMO entre dos numeros\n");
            Console.WriteLine("Ingrese dos numeros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero máximo es " + Math.MaxMagnitude(num1, num2));
            Console.WriteLine("El numero mínimo es " + Math.MinMagnitude(num1, num2));


            Console.WriteLine("\n--------------------------------------------\n");
        }

        private static void ApartadoCuatro()
        {
            Console.WriteLine("Ingrese una cadena de caracteres");
            string cadena = Console.ReadLine();

            // LONGITUD DE LA CADENA
            Console.WriteLine("\n--------- LONGITUD DE CADENA ---------\n");
            Console.WriteLine("La cadena tiene una logitud de " + cadena.Length + " caracteres");
            Console.ReadKey();

            // CONCATENAR CADENAS
            Console.WriteLine("\n--------- CONCATENAR CADENAS ---------\n");
            Console.WriteLine("Ingrese otra una cadena de caracteres");
            string cadena2 = Console.ReadLine();
            string cadena3 = cadena + cadena2;
            Console.WriteLine("Cadenas 1 y 2 concatenadas: " + cadena3);
            Console.ReadKey();

            // EXTRAER UNA SUB CADENA
            Console.WriteLine("\n--------- EXTRAER SUBCADENAS ---------\n");
            Console.WriteLine("Escriba una frase cualquiera");
            string frase = Console.ReadLine();
            string subcadena = frase.Substring(2, 5);
            Console.WriteLine("subcadena extraida: " + subcadena);
            Console.ReadKey();

            // USANDO CALCULADORA CREADA ANTERIORMENTE
            //Console.WriteLine("\n--------- RESULTADO EN TEXTO ---------\n");

            // RECCORER CADENA CON FOREACH
            Console.WriteLine("\n--------- ELEMENTO POR ELEMENTO CON FOREACH ---------\n");
            string frase2 = Console.ReadLine();
            foreach(var elemento in frase2)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadKey();

            // BUSCAR PALABRA DETERMINADA EN CADENA
            Console.WriteLine("\n--------- BUSCAR PALABRA EN UNA FRASE ---------\n");
            Console.WriteLine("Ingrese la palabra que desea buscar");
            string search = Console.ReadLine();
            bool busqueda = frase2.Contains(search);
            if(busqueda)
            {
                Console.WriteLine("Se encontró la palabra buscada");
            }
            else
            {
                Console.WriteLine("No se encontró la palabra buscada");
            }
            Console.ReadKey();

            // MAYUSCULAS Y MINUSCULAS
            Console.WriteLine("\n--------- FRASE EN MAYUSCULAS Y MINUSCULAS ---------\n");
            Console.WriteLine("Frase en mayúsculas");
            Console.WriteLine(frase2.ToUpper());
            Console.WriteLine("\nFrase en minúsculas");
            Console.WriteLine(frase2.ToLower());
            Console.ReadKey();

            // COMPRAR DOS CADENAS
            Console.WriteLine("\n--------- COMPARAR CADENAS ---------\n");
            Console.WriteLine("Ingrese una nueva cadena");
            string cadena4 = Console.ReadLine();

            if (cadena4 == cadena2)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas no son iguales");
            }
            Console.ReadKey();

            // SPLIT
            Console.WriteLine("\n--------- DELIMITAR CON SPLIT ---------\n");
            string cadena5 = "Nombre: Lucas Villafañe Acosta;Carrera: Programador universitario;Asignatura: Taller de lenguajes 1;Año:2021";
            char delimitador = ';';
            string[] separado = cadena5.Split(delimitador);
            
            foreach (var elementos in separado)
            {
                Console.WriteLine(elementos);
            }
            Console.ReadKey();

            // CALCULADORA
            Console.WriteLine("\n--------- CALCULADORA ---------\n");
            Console.WriteLine("Ingrese la operacion (+,-,/,*) que desea resolver, ejemplo 2+10");
            string calculadora = Console.ReadLine();       
                        

            if (calculadora.Contains('+'))
            {
                char operacion = '+';
                string[] datos = calculadora.Split(operacion);
                int dato0 = int.Parse(datos[0]);
                int dato1 = int.Parse(datos[1]);
                int resultado = dato0 + dato1;
                Console.WriteLine(resultado);
            }
            else if (calculadora.Contains('-'))
            {
                char operacion = '-';
                string[] datos = calculadora.Split(operacion);
                int dato0 = int.Parse(datos[0]);
                int dato1 = int.Parse(datos[1]);
                int resultado = dato0 - dato1;
                Console.WriteLine(resultado);
            }
            else if (calculadora.Contains('*'))
            {
                char operacion = '*';
                string[] datos = calculadora.Split(operacion);
                int dato0 = int.Parse(datos[0]);
                int dato1 = int.Parse(datos[1]);
                int resultado = dato0 * dato1;
                Console.WriteLine(resultado);
            }
            else if (calculadora.Contains('/'))
            {
                char operacion = '/';
                string[] datos = calculadora.Split(operacion);
                int dato0 = int.Parse(datos[0]);
                int dato1 = int.Parse(datos[1]);
                int resultado = dato0 / dato1;
                Console.WriteLine(resultado);
            }
            Console.ReadKey();
        }

        private static void ApartadoCinco()
        {
            Console.WriteLine("------------ EJERCICIO NUMERO 5 ------------\n");
            Console.WriteLine("Ingrese una direccion web");
            string url = Console.ReadLine();
            //string regex = @"\A[w]{3}(\.)[a-z0-9]+(\.)[com|org|net|com.ar|info]\Z";
            ValidarURL(url);

            Console.WriteLine("Ingrese su mail");
            string mail = Console.ReadLine();
            ValidarMail(mail);            
        }

        private static void ValidarURL(string url)
        {
            string regex = @"(https?:\/\/(?:www\.|(?!www))[^\s\.]+\.[^\s]{2,}|www\.[^\s]+\.[^\s]{2,})";

            bool resultIsMatch = Regex.IsMatch(url, regex);

            if (resultIsMatch)
            {
                Console.WriteLine("La cadena ingresada es una dirección web valida");
            }
            else
            {
                Console.WriteLine("La cadena ingresada no es una dirección web valida");
            }
        }

        private static void ValidarMail(string mail)
        {
            string regex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";            

            bool resultIsMatch = Regex.IsMatch(mail, regex);

            if (resultIsMatch)
            {
                Console.WriteLine("La cadena ingresada es un mail valido");
            }
            else
            {
                Console.WriteLine("La cadena ingresada no es un mail valido");
            }
        }

       
    }
}
