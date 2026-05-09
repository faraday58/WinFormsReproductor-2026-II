using System.Drawing.Design;

namespace WinFormsReproductor_2026_II
{
    public partial class Form1 : Form
    {
        List<Cancion> canciones;

        public Form1()
        {
            InitializeComponent();
            canciones = new List<Cancion>();
            cargarCanciones();
        }


        private void cargarCanciones()
        {
            canciones.Add(new Cancion("Shakira", "WaKa Waka", "Listen UP! ", @"..\..\..\Resources\waka_waka.jpg"));
            canciones.Add(new Cancion("Counting Stars", "One Republic", "Native", @"..\..\..\Resources\counting_stars.jfif"));
            canciones.Add(new Cancion("Castle on the hill", "Ed Sheeran", "Divide", @"..\..\..\Resources\castle_on_the_hill.png"));

            foreach (Cancion cancion in canciones)
            {
                listbCanciones.Items.Add(cancion.Nombre);
            }
        }

        private void listbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            CancionSeleccionada();
        }

        private void CancionSeleccionada()
        {
            lbNombre.Text = canciones[listbCanciones.SelectedIndex].Nombre;
            lbArtista.Text = canciones[listbCanciones.SelectedIndex].Artista;
            lbAlbum.Text = canciones[listbCanciones.SelectedIndex].Album;
            ptbPortada.Image = Image.FromFile(canciones[listbCanciones.SelectedIndex].ImgDir);
        }

        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTiempoTrans.Text = contador.ToString();

            contador++;

        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
