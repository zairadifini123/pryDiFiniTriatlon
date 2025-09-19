namespace pryDiFiniTriatlon
{
    partial class frmTriatlon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblParticipantes = new Label();
            dgvParticipantes = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            lblPosiciones = new Label();
            dgvPosiciones = new DataGridView();
            Prueba = new DataGridViewTextBoxColumn();
            Participante1 = new DataGridViewTextBoxColumn();
            Participante2 = new DataGridViewTextBoxColumn();
            Participante3 = new DataGridViewTextBoxColumn();
            Participante4 = new DataGridViewTextBoxColumn();
            Participante5 = new DataGridViewTextBoxColumn();
            Participante6 = new DataGridViewTextBoxColumn();
            lblGanadores = new Label();
            dgvGanadores = new DataGridView();
            Puesto = new DataGridViewTextBoxColumn();
            Nombre2 = new DataGridViewTextBoxColumn();
            Pais2 = new DataGridViewTextBoxColumn();
            Puntos = new DataGridViewTextBoxColumn();
            btnAsignarParticipantes = new Button();
            btnDeterminarGanadores = new Button();
            btnSalir = new Button();
            picGanadores = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPosiciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGanadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGanadores).BeginInit();
            SuspendLayout();
            // 
            // lblParticipantes
            // 
            lblParticipantes.AutoSize = true;
            lblParticipantes.Location = new Point(12, 19);
            lblParticipantes.Name = "lblParticipantes";
            lblParticipantes.Size = new Size(75, 15);
            lblParticipantes.TabIndex = 0;
            lblParticipantes.Text = "Participantes";
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.AllowUserToAddRows = false;
            dgvParticipantes.AllowUserToDeleteRows = false;
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Columns.AddRange(new DataGridViewColumn[] { Numero, Nombre, Pais });
            dgvParticipantes.Location = new Point(12, 37);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.Size = new Size(617, 148);
            dgvParticipantes.TabIndex = 1;
            // 
            // Numero
            // 
            Numero.HeaderText = "Numero";
            Numero.Name = "Numero";
            Numero.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 225;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            Pais.Width = 225;
            // 
            // lblPosiciones
            // 
            lblPosiciones.AutoSize = true;
            lblPosiciones.Location = new Point(12, 201);
            lblPosiciones.Name = "lblPosiciones";
            lblPosiciones.Size = new Size(63, 15);
            lblPosiciones.TabIndex = 2;
            lblPosiciones.Text = "Posiciones";
            // 
            // dgvPosiciones
            // 
            dgvPosiciones.AllowUserToAddRows = false;
            dgvPosiciones.AllowUserToDeleteRows = false;
            dgvPosiciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPosiciones.Columns.AddRange(new DataGridViewColumn[] { Prueba, Participante1, Participante2, Participante3, Participante4, Participante5, Participante6 });
            dgvPosiciones.Location = new Point(12, 219);
            dgvPosiciones.Name = "dgvPosiciones";
            dgvPosiciones.Size = new Size(910, 115);
            dgvPosiciones.TabIndex = 3;
            // 
            // Prueba
            // 
            Prueba.HeaderText = "Prueba";
            Prueba.Name = "Prueba";
            Prueba.Width = 125;
            // 
            // Participante1
            // 
            Participante1.HeaderText = "Participante 1";
            Participante1.Name = "Participante1";
            Participante1.Width = 125;
            // 
            // Participante2
            // 
            Participante2.HeaderText = "Participante 2";
            Participante2.Name = "Participante2";
            Participante2.Width = 125;
            // 
            // Participante3
            // 
            Participante3.HeaderText = "Participante 3";
            Participante3.Name = "Participante3";
            Participante3.Width = 125;
            // 
            // Participante4
            // 
            Participante4.HeaderText = "Participante 4";
            Participante4.Name = "Participante4";
            Participante4.Width = 125;
            // 
            // Participante5
            // 
            Participante5.HeaderText = "Participante 5";
            Participante5.Name = "Participante5";
            Participante5.Width = 125;
            // 
            // Participante6
            // 
            Participante6.HeaderText = "Participante 6";
            Participante6.Name = "Participante6";
            Participante6.Width = 125;
            // 
            // lblGanadores
            // 
            lblGanadores.AutoSize = true;
            lblGanadores.Location = new Point(12, 401);
            lblGanadores.Name = "lblGanadores";
            lblGanadores.Size = new Size(63, 15);
            lblGanadores.TabIndex = 4;
            lblGanadores.Text = "Ganadores";
            // 
            // dgvGanadores
            // 
            dgvGanadores.AllowUserToAddRows = false;
            dgvGanadores.AllowUserToDeleteRows = false;
            dgvGanadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGanadores.Columns.AddRange(new DataGridViewColumn[] { Puesto, Nombre2, Pais2, Puntos });
            dgvGanadores.Location = new Point(12, 419);
            dgvGanadores.Name = "dgvGanadores";
            dgvGanadores.ReadOnly = true;
            dgvGanadores.Size = new Size(643, 171);
            dgvGanadores.TabIndex = 5;
            // 
            // Puesto
            // 
            Puesto.HeaderText = "Puesto";
            Puesto.Name = "Puesto";
            Puesto.ReadOnly = true;
            // 
            // Nombre2
            // 
            Nombre2.HeaderText = "Nombre";
            Nombre2.Name = "Nombre2";
            Nombre2.ReadOnly = true;
            Nombre2.Width = 200;
            // 
            // Pais2
            // 
            Pais2.HeaderText = "Pais";
            Pais2.Name = "Pais2";
            Pais2.ReadOnly = true;
            Pais2.Width = 200;
            // 
            // Puntos
            // 
            Puntos.HeaderText = "Puntos";
            Puntos.Name = "Puntos";
            Puntos.ReadOnly = true;
            // 
            // btnAsignarParticipantes
            // 
            btnAsignarParticipantes.Location = new Point(806, 37);
            btnAsignarParticipantes.Name = "btnAsignarParticipantes";
            btnAsignarParticipantes.Size = new Size(116, 45);
            btnAsignarParticipantes.TabIndex = 6;
            btnAsignarParticipantes.Text = "Asignar Participantes";
            btnAsignarParticipantes.UseVisualStyleBackColor = true;
            btnAsignarParticipantes.Click += btnAsignarParticipantes_Click;
            // 
            // btnDeterminarGanadores
            // 
            btnDeterminarGanadores.Location = new Point(806, 88);
            btnDeterminarGanadores.Name = "btnDeterminarGanadores";
            btnDeterminarGanadores.Size = new Size(116, 45);
            btnDeterminarGanadores.TabIndex = 7;
            btnDeterminarGanadores.Text = "Determinar Ganadores";
            btnDeterminarGanadores.UseVisualStyleBackColor = true;

            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(806, 140);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 45);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // picGanadores
            // 
            picGanadores.Image = Properties.Resources.ganadores;
            picGanadores.Location = new Point(661, 340);
            picGanadores.Name = "picGanadores";
            picGanadores.Size = new Size(261, 250);
            picGanadores.SizeMode = PictureBoxSizeMode.StretchImage;
            picGanadores.TabIndex = 9;
            picGanadores.TabStop = false;
            // 
            // frmTriatlon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 602);
            Controls.Add(picGanadores);
            Controls.Add(btnSalir);
            Controls.Add(btnDeterminarGanadores);
            Controls.Add(btnAsignarParticipantes);
            Controls.Add(dgvGanadores);
            Controls.Add(lblGanadores);
            Controls.Add(dgvPosiciones);
            Controls.Add(lblPosiciones);
            Controls.Add(dgvParticipantes);
            Controls.Add(lblParticipantes);
            Name = "frmTriatlon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Triatlon";
            Load += frmTriatlon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPosiciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGanadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGanadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblParticipantes;
        private DataGridView dgvParticipantes;
        private Label lblPosiciones;
        private DataGridView dgvPosiciones;
        private DataGridViewTextBoxColumn Prueba;
        private DataGridViewTextBoxColumn Participante1;
        private DataGridViewTextBoxColumn Participante2;
        private DataGridViewTextBoxColumn Participante3;
        private DataGridViewTextBoxColumn Participante4;
        private DataGridViewTextBoxColumn Participante5;
        private DataGridViewTextBoxColumn Participante6;
        private Label lblGanadores;
        private DataGridView dgvGanadores;
        private DataGridViewTextBoxColumn Puesto;
        private DataGridViewTextBoxColumn Nombre2;
        private DataGridViewTextBoxColumn Pais2;
        private DataGridViewTextBoxColumn Puntos;
        private Button btnAsignarParticipantes;
        private Button btnDeterminarGanadores;
        private Button btnSalir;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pais;
        private PictureBox picGanadores;
    }
}
