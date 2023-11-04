using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
            //Round = Arredondamento
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            //1º divisão depois multiplicação
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 4)}");
            //Round = Arredondamento
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            //1º divisão depois multiplicação
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");
            //Round = Arredondamento
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}