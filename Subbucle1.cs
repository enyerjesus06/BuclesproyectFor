

using System.Numerics;

namespace Buclesproyects
{
    public class Subbucle1
    {
        public void Calcularbucle1() 
        {
            int contador = 0;
            int cantidadNumeros = 0;
            int numero = 0;

            try
            {
                Console.WriteLine("Digite la cantidad de números que desea Ingresar:");
                cantidadNumeros = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < cantidadNumeros; i++)
                {
                    Console.WriteLine($"Ingrese el número {i + 1}:");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero >= 1000)
                    {
                        contador = contador + 1;
                    }
                }

                Console.WriteLine($"La cantidad de números mayores o iguales a 1000 es: {contador}");

            
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");

            }



        }


    

        public void Calcularbucle2() 
        {
            
            int Altura = 0;
            int Base = 0;
            int candetrig4 = 0;
            int result = 0;
            int var1 = 0;
            int superficie = 0;

            try
            {
                Console.WriteLine("Introduce la cantidad de triangulos: ");
                candetrig4 = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= candetrig4; i++)
                {
                    Console.WriteLine($"Para el triangulo {i} ");

                    Console.WriteLine($"Ingrese el valor de la Altura del triangulo: ");
                    Altura = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el valor de la Base del triangulo: ");
                    Base = Convert.ToInt32(Console.ReadLine());

                    var1 = (Base * Altura);
                    result = (var1 / 2);

                    Console.WriteLine($"Para el Triangulo {i}");

                    if (result > 12)
                    {
                        superficie = superficie + 1;

                    }

                    Console.WriteLine($"La medida de la Altura es {Altura}, la medida de la Base es: {Base} y la superficie es: {result}");

                }
                Console.WriteLine($"Triangulos con la superficie mayor a 12: {superficie} ");

            } catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }


        }

        public void Calcularbucle3() 
        {
            int iteracion = 5;
            int resultado = 0;


            try
            {
                Console.WriteLine($"Tabla de Multiplicación del número 5");



                for (int i = 1; i <= 50; i++)
                {
                    resultado = iteracion * i;

                    Console.WriteLine($" 5 * {i} = {resultado} ");


                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}"); 
            }






            }
    }
}
