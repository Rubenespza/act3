using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act3
{
    class AlumnosInf

    {
        int matricula;
        string nombre;
        string paterno;
        string materno;
        int edad;

        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Materno
        {
            get
            {
                return materno;
            }
            set
            {
                materno = value;
            }
        }
        public string Paterno
        {
            get
            {
                return paterno;
            }
            set
            {
                paterno = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
               edad = value;
            }
        }
    }
}
