using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testing
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        public static List<Alumno> lstAlumnos = new List<Alumno>();

        private void btn_CargarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.NombreApellido = txt_nombre.Text;
            alumno.Dni = Convert.ToInt64(txt_dni.Text);
            alumno.Calificacion = Convert.ToInt16(txt_calificacion.Text);

            if (alumno.ValidacionNota())
            {
                dataGridView1.Rows.Clear();

                lstAlumnos.Add(alumno);

                for (int i = 0; i < lstAlumnos.Count(); i++)
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[i].Cells[0].Value = lstAlumnos[i].NombreApellido;
                    dataGridView1.Rows[i].Cells[1].Value = lstAlumnos[i].Dni;
                    dataGridView1.Rows[i].Cells[2].Value = lstAlumnos[i].Calificacion;
                }

                txt_nombre.Text = string.Empty;
                txt_dni.Text = string.Empty;
                txt_calificacion.Text = string.Empty;
            }
            else
                error.Show();
        }

        private void btn_CalcularPromedio_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            nota.Visible = true;
            nota.Text = alumno.CalculaPromedio(lstAlumnos).ToString();
        }
    }
}