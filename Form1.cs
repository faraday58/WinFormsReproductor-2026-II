using System.Drawing.Design;
using System.IO;


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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos de Texto (*.txt)|*.txt | Todos los archivos (*.*)|*.*";

            if ( sfd.ShowDialog() == DialogResult.OK   )  
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                try
                {
                    sw.WriteLine("Artista,Nombre,Album,RutaImagen");

                    foreach ( Cancion cancion in canciones  )
                    {
                        sw.WriteLine($"{cancion.Artista},{cancion.Nombre},{cancion.Album},{cancion.ImgDir}");
                    }

                }
                catch(Exception error)
                {
                    MessageBox.Show("Error: " + error );
                }
                finally
                {
                    sw.Close();
                }                       



            }

        }
    }
}
