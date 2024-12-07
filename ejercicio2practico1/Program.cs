using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno pepe = new Alumno("Pepe", 16, "A");
            
            Alumno marta = new Alumno("Marta", 17, "B");

            Console.WriteLine($"Alumno 1: Nombre = {pepe.getnombre()}, Edad = {pepe.getedad()}, Curso = {pepe.getcurso()}");
            Console.WriteLine($"Alumno 2: Nombre = {marta.getnombre()}, Edad = {marta.getedad()}, Curso = {marta.getcurso()}");

        }
    }
}
