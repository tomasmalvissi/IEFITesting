using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Alumno
    {
        private string nombreApellido;
        private long dni;
        private int calificacion;

        public string NombreApellido
        {
            get { return nombreApellido; }
            set { nombreApellido = value; }
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public bool ValidacionNota()
        {
            bool correcta = true;
            if (Calificacion > 10 || Calificacion < 1)
            {
                correcta = false;
            }

            return correcta;
        }

        public decimal CalculaPromedio(List<Alumno> lstAlumnos)
        {
            decimal promedio = 0;
            decimal sumatoria = 0;

            List<int> lista = lstAlumnos.Select(x => x.Calificacion).ToList();

            for (int i = 0; i < lista.Count(); i++)
            {
                sumatoria += lista[i];
            }

            promedio = sumatoria / lista.Count();

            return promedio;
        }
    }
}