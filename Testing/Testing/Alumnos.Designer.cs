namespace Testing
{
    partial class Alumnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.Label();
            this.btn_CargarAlumno = new System.Windows.Forms.Button();
            this.btn_CalcularPromedio = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_calificacion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.Label();
            this.nota = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(285, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(170, 24);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Lista de Alumnos";
            // 
            // btn_CargarAlumno
            // 
            this.btn_CargarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarAlumno.Location = new System.Drawing.Point(544, 84);
            this.btn_CargarAlumno.Name = "btn_CargarAlumno";
            this.btn_CargarAlumno.Size = new System.Drawing.Size(141, 27);
            this.btn_CargarAlumno.TabIndex = 1;
            this.btn_CargarAlumno.Text = "Cargar alumno";
            this.btn_CargarAlumno.UseVisualStyleBackColor = true;
            this.btn_CargarAlumno.Click += new System.EventHandler(this.btn_CargarAlumno_Click);
            // 
            // btn_CalcularPromedio
            // 
            this.btn_CalcularPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularPromedio.Location = new System.Drawing.Point(544, 167);
            this.btn_CalcularPromedio.Name = "btn_CalcularPromedio";
            this.btn_CalcularPromedio.Size = new System.Drawing.Size(141, 27);
            this.btn_CalcularPromedio.TabIndex = 2;
            this.btn_CalcularPromedio.Text = "Calcular promedio";
            this.btn_CalcularPromedio.UseVisualStyleBackColor = true;
            this.btn_CalcularPromedio.Click += new System.EventHandler(this.btn_CalcularPromedio_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(225, 87);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(269, 21);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(225, 131);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(269, 21);
            this.txt_dni.TabIndex = 4;
            // 
            // txt_calificacion
            // 
            this.txt_calificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calificacion.Location = new System.Drawing.Point(225, 178);
            this.txt_calificacion.MaxLength = 2;
            this.txt_calificacion.Name = "txt_calificacion";
            this.txt_calificacion.Size = new System.Drawing.Size(269, 21);
            this.txt_calificacion.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.Black;
            this.nombre.Location = new System.Drawing.Point(81, 87);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(124, 15);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "Nombre y Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "DNI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreApellido,
            this.DNI,
            this.Calificacion});
            this.dataGridView1.Location = new System.Drawing.Point(84, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(410, 166);
            this.dataGridView1.TabIndex = 9;
            // 
            // NombreApellido
            // 
            this.NombreApellido.HeaderText = "Nombre y Apellido";
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            // 
            // Promedio
            // 
            this.Promedio.AutoSize = true;
            this.Promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Promedio.ForeColor = System.Drawing.Color.Black;
            this.Promedio.Location = new System.Drawing.Point(566, 296);
            this.Promedio.Name = "Promedio";
            this.Promedio.Size = new System.Drawing.Size(69, 15);
            this.Promedio.TabIndex = 10;
            this.Promedio.Text = "Promedio";
            // 
            // nota
            // 
            this.nota.AutoSize = true;
            this.nota.BackColor = System.Drawing.Color.Transparent;
            this.nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nota.Location = new System.Drawing.Point(574, 338);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(50, 24);
            this.nota.TabIndex = 11;
            this.nota.Text = "nota";
            this.nota.Visible = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(222, 202);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(274, 13);
            this.error.TabIndex = 12;
            this.error.Text = "Error de datos. Valores entre 1 y 10 solamente.";
            this.error.Visible = false;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 469);
            this.Controls.Add(this.error);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.Promedio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txt_calificacion);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_CalcularPromedio);
            this.Controls.Add(this.btn_CargarAlumno);
            this.Controls.Add(this.titulo);
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btn_CargarAlumno;
        private System.Windows.Forms.Button btn_CalcularPromedio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_calificacion;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.Label Promedio;
        private System.Windows.Forms.Label nota;
        private System.Windows.Forms.Label error;
    }
}

