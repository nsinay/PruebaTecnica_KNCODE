using System;


namespace PruebaTecnica
{
    class Program
    {
        private const double gravedad = 9.81;

        static void Main (string[]args)
        {
            Console.WriteLine("Ingrese la velocidad inicial m/s: ");
            double velocidadInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el angulo de salida en grados: ");
            double angulo = Convert.ToDouble(Console.ReadLine());

            calculoEnPantalla(velocidadInicial, angulo);
        }

         static void calculoEnPantalla(double velocidadInicial, double angulo)
        {
            double anguloR = Math.PI * angulo / 180; // conversion a radianes
            double intervaloTiempo = 0.1;//intervalo de tiempo en segundos
            double tiempo = 0;

           

            while (true)
            {
                double xDistancia = velocidadInicial * Math.Cos(anguloR) * tiempo;
                double yDistancia = velocidadInicial * Math.Sin(anguloR) * tiempo - 0.5 * gravedad
                    * tiempo * tiempo;

                if (yDistancia < 0)
                {
                    break;
                }

                GraficoEnPantalla(xDistancia, yDistancia);
                tiempo += intervaloTiempo;

            }

            
        }
        static void GraficoEnPantalla(double xDistancia, double yDistancia)
        {
            int escalaX = (int)Math.Round(xDistancia / 5); // escala para ajustar la grafica x
            int escalaY = (int)Math.Round(yDistancia / 5); // escala para ajustar la grafica y

            Console.SetCursorPosition(escalaX, Console.WindowHeight - escalaY);
            Console.WriteLine('*');
        }

    }
}
