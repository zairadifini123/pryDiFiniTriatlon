namespace pryDiFiniTriatlon
{
    public partial class frmTriatlon : Form
    {
        public struct DATOS
        {
            public int participante;
            public int puntos;
        }
        public frmTriatlon()
        {
            InitializeComponent();
            // Asociar el evento al botón
            btnDeterminarGanadores.Click += btnDeterminarGanadores_Click; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTriatlon_Load(object sender, EventArgs e)
        {
            // inicializar formulario
            int i;
            // agregar 6 filas a la grilla de participantes
            for (i = 1; i <= 6; i++)
            {
                // asignar en cada fila sólo el número de participante (i)
                dgvParticipantes.Rows.Add(i.ToString());
            }
            // configurar la primera columna para que sea de sólo lectura
            dgvParticipantes.Columns[0].ReadOnly = true;
            // deshabilitar la grilla de posiciones
            dgvPosiciones.Enabled = false;
        }

        private void btnAsignarParticipantes_Click(object sender, EventArgs e)
        {
            int i;
            dgvPosiciones.Rows.Clear();
            // verificar que estén cargados todos los participantes
            for (i = 0; i < 6; i++)
            {
                if (dgvParticipantes.Rows[i].Cells[1].Value == null ||
                dgvParticipantes.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Debe completar los datos de todos los participantes",
                    "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            // configurar las columnas de la grilla
            for (i = 0; i < 6; i++)
            {
                dgvPosiciones.Columns[i + 1].HeaderText =
                dgvParticipantes.Rows[i].Cells[1].Value.ToString();
            }
            // configurar las filas con las 3 pruebas del Triatlón
            for (i = 0; i < 3; i++)
            {
                dgvPosiciones.Rows.Add();
            }
            dgvPosiciones.Rows[0].Cells[0].Value = "Natación";
            dgvPosiciones.Rows[1].Cells[0].Value = "Ciclismo";
            dgvPosiciones.Rows[2].Cells[0].Value = "Carrera";
            dgvPosiciones.Columns[0].ReadOnly = true;
            dgvParticipantes.ClearSelection();
            dgvPosiciones.Enabled = true;
        }

        private void btnDeterminarGanadores_Click(object sender, EventArgs e)
        {
            // Depuración rápida: confirmar que el botón funciona
            MessageBox.Show("Botón presionado");

            // Validar las posiciones antes de continuar
            if (!ValidarPosiciones())
            {
                return; // si hay error, se detiene
            }

            dgvPosiciones.ClearSelection();
            int[,] puestos = new int[3, 6]; // arreglo bidimensional para guardar los puestos

            // Copiar el contenido de la grilla al arreglo bidimensional
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 6; col++)
                {
                    string valor = dgvPosiciones.Rows[fila].Cells[col + 1].Value.ToString();
                    puestos[fila, col] = int.Parse(valor);
                }
            }

            // Inicializar el arreglo para computar los puntos de cada participante
            DATOS[] datos = new DATOS[6];
            for (int i = 0; i < 6; i++)
            {
                datos[i].participante = i + 1; // número de participante
                datos[i].puntos = 0;           // cantidad de puntos inicial
            }

            // Sumar los puntos según los puestos obtenidos en cada prueba
            for (int col = 0; col < 6; col++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    datos[col].puntos += ObtenerPuntos(puestos[fila, col]);
                }
            }

            // Arreglo para guardar los 3 ganadores
            DATOS[] ganadores = new DATOS[3];
            ganadores[0] = BuscarMayorPuntaje(datos, ganadores);
            ganadores[1] = BuscarMayorPuntaje(datos, ganadores);
            ganadores[2] = BuscarMayorPuntaje(datos, ganadores);

            // Cargar la grilla de ganadores
            dgvGanadores.Rows.Clear();
            for (int fila = 0; fila < 3; fila++)
            {
                dgvGanadores.Rows.Add();
                dgvGanadores.Rows[fila].Cells[0].Value = fila + 1; // puesto final

                int f = ganadores[fila].participante - 1; // índice en dgvParticipantes
                string nombre = dgvParticipantes.Rows[f].Cells[1].Value.ToString();
                string nacionalidad = dgvParticipantes.Rows[f].Cells[2].Value.ToString();

                dgvGanadores.Rows[fila].Cells[1].Value = nombre;
                dgvGanadores.Rows[fila].Cells[2].Value = nacionalidad;
                dgvGanadores.Rows[fila].Cells[3].Value = ganadores[fila].puntos.ToString();
            }

            dgvGanadores.ClearSelection();

            // Dibujar los nombres de los ganadores en el PictureBox
            EscribirGanadores();
        }

        private bool ValidarPosiciones()
        {
            for (int f = 0; f < dgvPosiciones.RowCount; f++) // recorre las filas (pruebas)
            {
                List<int> usados = new List<int>();
                for (int c = 1; c < dgvPosiciones.ColumnCount; c++) // recorre los participantes
                {
                    // verificar que la celda tenga valor
                    if (dgvPosiciones.Rows[f].Cells[c].Value == null)
                    {
                        MessageBox.Show($"Fila {f + 1}, columna {c} está vacía.", "Error", MessageBoxButtons.OK);
                        return false;
                    }

                    // convertir a número de forma segura
                    if (!int.TryParse(dgvPosiciones.Rows[f].Cells[c].Value.ToString(), out int valor))
                    {
                        MessageBox.Show($"Fila {f + 1}, columna {c} no es un número válido.", "Error", MessageBoxButtons.OK);
                        return false;
                    }

                    // verificar rango 1–6
                    if (valor < 1 || valor > 6)
                    {
                        MessageBox.Show($"Fila {f + 1}, columna {c} debe ser un número entre 1 y 6.", "Error", MessageBoxButtons.OK);
                        return false;
                    }

                    // verificar que no se repita en la misma fila
                    if (usados.Contains(valor))
                    {
                        MessageBox.Show($"Fila {f + 1}: el número {valor} ya fue usado en esta prueba.", "Error", MessageBoxButtons.OK);
                        return false;
                    }

                    usados.Add(valor);
                }
            }
            return true; // todo correcto
        }
        private int ObtenerPuntos(int puesto)
        {
            // arreglo con los puntos por el puesto en cada prueba:
            // puesto 1: 1000 puntos
            // puesto 2: 920 puntos
            // puesto 3: 830 puntos
            // puesto 4: 740 puntos
            // puesto 5: 650 puntos
            // puesto 6: 560 puntos
            int[] puntos = new int[6] { 1000, 920, 830, 740, 650, 560 };
            // se devuele el valor del elemento puesto-1
            return puntos[puesto - 1];
        }

        private DATOS BuscarMayorPuntaje(DATOS[] d, DATOS[] g)
        {
            DATOS resultado;
            int i;
            int f;
            int ganadorPrevio;
            resultado.participante = 0;
            resultado.puntos = 0;
            for (i = 0; i < 6; i++)
            {
                if (d[i].puntos > resultado.puntos)
                {
                    ganadorPrevio = 0;
                    for (f = 0; f < g.Length; f++) // recorre 'g' (ganadores)
                    {
                        if (d[i].participante == g[f].participante)
                        {
                            ganadorPrevio = 1;
                        }
                    }
                    if (ganadorPrevio == 0)
                    {
                        resultado.puntos = d[i].puntos;
                        resultado.participante = d[i].participante;
                    }
                }
            }
            return resultado;
        }

        private void EscribirGanadores()
        {
            // Asociar el evento Paint si aún no está asociado
            picGanadores.Paint -= PicGanadores_Paint; // evitar duplicados
            picGanadores.Paint += PicGanadores_Paint;

            // Forzar que se repinte el PictureBox
            picGanadores.Invalidate();
        }

        private void PicGanadores_Paint(object sender, PaintEventArgs e)
        {
            if (dgvGanadores.Rows.Count < 3) return; // Evitar errores si no hay suficientes filas

            int ancho = picGanadores.Width;
            int alto = picGanadores.Height;
            StringFormat formato = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Graphics gra = e.Graphics;

            // Ganador 1
            string nombre = dgvGanadores.Rows[0].Cells[1].Value?.ToString() ?? "";
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
                new PointF(ancho / 2f, alto / 4f), formato);

            // Ganador 2
            nombre = dgvGanadores.Rows[1].Cells[1].Value?.ToString() ?? "";
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
                new PointF(ancho / 4f, alto / 2.75f), formato);

            // Ganador 3
            nombre = dgvGanadores.Rows[2].Cells[1].Value?.ToString() ?? "";
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
                new PointF(ancho / 1.33f, alto / 2f), formato);
        }
    }
}
