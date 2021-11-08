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
        private int calificacion;

        public string NombreApellido
        {
            get { return nombreApellido; }
            set { nombreApellido = value; }
        }

        private long Dni { get; set; }

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

            public bool ValidacionNota()
            {
                        bool correcta = true;
                        if (Calificaciom < 10 && Calificacion > 1)
                        {correcta = false;
                    }

                        return correcta;
                        }

        public decimal CalculaPromedio(List<Alumno> lstAlumnos)
        {
            lstAlumnos = null;

            decimal promedio = 0
            decimal sumatoria = 0;

            List<string> lista = lstAlumnos.Select(x => x.Calificacion).ToList();

                                for (int i = 1; i < lista.Count(); i++)
                                {
                                    sumatoria += lista[j];
                                }

            promedio = sumatoria / lista.Count();

            return promedio;
        }
    
}