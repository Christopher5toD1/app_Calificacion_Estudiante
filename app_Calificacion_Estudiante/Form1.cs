namespace app_Calificacion_Estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Nota_1, Nota_2, Nota_3, Nota_4, Promedio_Final;

            Double? Prueba_Completivo = null, Nota_Completivo, Promedio_Completivo;

            string Situacion, Situacion_Completivo;

            Nota_1 = int.Parse(TxNota1.Text);
            Nota_2 = int.Parse(TxNota2.Text);
            Nota_3 = int.Parse(TxNota3.Text);
            Nota_4 = int.Parse(TxNota4.Text);


            Promedio_Final = (Nota_1 + Nota_2 + Nota_3 + Nota_4) / 4;



            TxNotaCompletivo.Enabled = false;
            TxPruebaCompletivo.Enabled = false;
            TxPromedioCompletivo.Enabled = false;
            TxSituacionCompletivo.Enabled = false;


            Nota_Completivo = Promedio_Final / 2;
            TxPruebaCompletivo.Text = Prueba_Completivo.ToString();

            Promedio_Completivo = Nota_Completivo + Prueba_Completivo / 2;
            TxPromedio.Text = Promedio_Final.ToString();

            TxNotaCompletivo.Text = Nota_Completivo.ToString();
            TxPruebaCompletivo.Text = Prueba_Completivo.ToString();
            TxPromedioCompletivo.Text = Promedio_Completivo.ToString();


            if (Promedio_Final >= 70)

            {
                Situacion = "Aprobado";
                TxPromedio.ForeColor = Color.Green;
                TxSituacion.ForeColor = Color.Green;



                TxNotaCompletivo.Enabled = false;
                TxPruebaCompletivo.Enabled = false;
                TxPromedioCompletivo.Enabled = false;
                TxSituacionCompletivo.Enabled = false;
            }



            else
            {




                Situacion = "Reprobado";
                TxPromedio.ForeColor = Color.Red;
                TxSituacion.ForeColor = Color.Red;
                TxNotaCompletivo.ForeColor = Color.Red;



                TxNotaCompletivo.Enabled = true;
                TxPruebaCompletivo.Enabled = true;
                TxPromedioCompletivo.Enabled = true;
                TxSituacionCompletivo.Enabled = true;



            }


            TxSituacion.Text = Situacion;


        }

        private void CalcularCompletivo_Click(object sender, EventArgs e)
        {
            int Nota1, Nota2, Nota3, Nota4, Promedio_Final;



            Double? Prueba_Completivo = null, Nota_Completivo,
               Promedio_Completivo;

            Prueba_Completivo = Double.Parse(TxPruebaCompletivo.Text);
            String Situacion, Situacion_Completivo;

            Nota1 = int.Parse(TxNota1.Text);
            Nota2 = int.Parse(TxNota2.Text);
            Nota3 = int.Parse(TxNota3.Text);
            Nota4 = int.Parse(TxNota4.Text);


            Promedio_Final = (Nota1 + Nota2 + Nota3 + Nota4) / 4;



            TxNotaCompletivo.Enabled = false;
            TxPruebaCompletivo.Enabled = false;
            TxPromedioCompletivo.Enabled = false;
            TxSituacionCompletivo.Enabled = false;

            Nota_Completivo = Promedio_Final / 2;
            TxPruebaCompletivo.Text = Prueba_Completivo.ToString();

            Promedio_Completivo = Nota_Completivo + Prueba_Completivo / 2;

            TxPromedio.Text = Promedio_Final.ToString();

            TxNotaCompletivo.Text = Nota_Completivo.ToString();
            TxPruebaCompletivo.Text = Prueba_Completivo.ToString();
            TxPromedioCompletivo.Text = Promedio_Completivo.ToString();



            if (Promedio_Final < 70 && Promedio_Completivo >= 70)
            {






                TxNotaCompletivo.ForeColor = Color.Red;
                TxPruebaCompletivo.ForeColor = Color.Red;
                TxPromedioCompletivo.ForeColor = Color.Green;



                TxNotaCompletivo.Enabled = true;
                TxPruebaCompletivo.Enabled = true;
                TxPromedioCompletivo.Enabled = true;
                TxSituacionCompletivo.Enabled = true;


                Situacion_Completivo = "Aprobado";

            }

            else
            {
                Situacion = "Reprobado";


                TxNotaCompletivo.ForeColor = Color.Red;
              
                TxPromedioCompletivo.ForeColor = Color.Red;
                TxSituacionCompletivo.ForeColor = Color.Red;


                TxNotaCompletivo.Enabled = true;
                TxPruebaCompletivo.Enabled = true;
                TxPromedioCompletivo.Enabled = true;
                TxSituacionCompletivo.Enabled = true;

                Situacion_Completivo = "Reprobado";



            }
            TxSituacionCompletivo.Text = Situacion_Completivo;

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TxNota1.Clear();
            TxNota2.Clear();
            TxNota3.Clear();
            TxNota4.Clear();
            TxPromedio.Clear();
            TxSituacion.Clear();
            TxNotaCompletivo.Clear();
            TxPruebaCompletivo.Clear();
            TxPromedioCompletivo.Clear();
            TxSituacionCompletivo.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
