using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2practico1
{
    internal class Alumno
    {
        private string nombre;
        private int edad;
        private string curso;

        public string getnombre()
        {
            return nombre;
        }

        public int getedad() 
        { 
            return edad;
        }

        public string getcurso() 
        {
            return curso;
        }

        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setedad(int edad) 
        { 
            this.edad = edad;
        }

        public void setcurso(string curso)
        {
            this.curso = curso;
        }

        public Alumno(string nombre, int edad, string curso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.curso = curso;
        }
    }
}
