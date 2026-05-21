namespace WinFormsReproductor_2026_II
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listbCanciones = new ListBox();
            label1 = new Label();
            lbArtista = new Label();
            label3 = new Label();
            lbNombre = new Label();
            label5 = new Label();
            lbAlbum = new Label();
            ptbPortada = new PictureBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            reproducciónToolStripMenuItem = new ToolStripMenuItem();
            reproducirToolStripMenuItem = new ToolStripMenuItem();
            siguienteToolStripMenuItem = new ToolStripMenuItem();
            anteriorToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            pausaToolStripMenuItem = new ToolStripMenuItem();
            progressBar1 = new ProgressBar();
            lbTiempoTrans = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ptbPortada).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listbCanciones
            // 
            listbCanciones.FormattingEnabled = true;
            listbCanciones.Location = new Point(83, 108);
            listbCanciones.Name = "listbCanciones";
            listbCanciones.Size = new Size(255, 554);
            listbCanciones.TabIndex = 0;
            listbCanciones.SelectedIndexChanged += listbCanciones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 232);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Artista";
            // 
            // lbArtista
            // 
            lbArtista.AutoSize = true;
            lbArtista.Location = new Point(648, 232);
            lbArtista.Name = "lbArtista";
            lbArtista.Size = new Size(115, 25);
            lbArtista.TabIndex = 1;
            lbArtista.Text = "David Guetta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 297);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(648, 297);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(119, 25);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Say my name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 371);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 1;
            label5.Text = "Álbum";
            // 
            // lbAlbum
            // 
            lbAlbum.AutoSize = true;
            lbAlbum.Location = new Point(648, 371);
            lbAlbum.Name = "lbAlbum";
            lbAlbum.Size = new Size(119, 25);
            lbAlbum.TabIndex = 1;
            lbAlbum.Text = "Say my name";
            // 
            // ptbPortada
            // 
            ptbPortada.Image = Properties.Resources.counting_stars;
            ptbPortada.Location = new Point(1063, 155);
            ptbPortada.Name = "ptbPortada";
            ptbPortada.Size = new Size(330, 330);
            ptbPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbPortada.TabIndex = 2;
            ptbPortada.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, reproducciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1789, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(270, 34);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(270, 34);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // reproducciónToolStripMenuItem
            // 
            reproducciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reproducirToolStripMenuItem, siguienteToolStripMenuItem, anteriorToolStripMenuItem, stopToolStripMenuItem, pausaToolStripMenuItem });
            reproducciónToolStripMenuItem.Name = "reproducciónToolStripMenuItem";
            reproducciónToolStripMenuItem.Size = new Size(137, 29);
            reproducciónToolStripMenuItem.Text = "Reproducción";
            // 
            // reproducirToolStripMenuItem
            // 
            reproducirToolStripMenuItem.Image = Properties.Resources.play_button;
            reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            reproducirToolStripMenuItem.Size = new Size(200, 34);
            reproducirToolStripMenuItem.Text = "Reproducir";
            reproducirToolStripMenuItem.Click += reproducirToolStripMenuItem_Click;
            // 
            // siguienteToolStripMenuItem
            // 
            siguienteToolStripMenuItem.Image = Properties.Resources.right_arrow;
            siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            siguienteToolStripMenuItem.Size = new Size(200, 34);
            siguienteToolStripMenuItem.Text = "Siguiente";
            // 
            // anteriorToolStripMenuItem
            // 
            anteriorToolStripMenuItem.Image = Properties.Resources.left_arrow;
            anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            anteriorToolStripMenuItem.Size = new Size(200, 34);
            anteriorToolStripMenuItem.Text = "Anterior";
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Image = Properties.Resources.stop_button;
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(200, 34);
            stopToolStripMenuItem.Text = "Stop";
            // 
            // pausaToolStripMenuItem
            // 
            pausaToolStripMenuItem.Image = Properties.Resources.pause;
            pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            pausaToolStripMenuItem.Size = new Size(200, 34);
            pausaToolStripMenuItem.Text = "Pausa";
            pausaToolStripMenuItem.Click += pausaToolStripMenuItem_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(483, 552);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(461, 12);
            progressBar1.TabIndex = 4;
            // 
            // lbTiempoTrans
            // 
            lbTiempoTrans.AutoSize = true;
            lbTiempoTrans.Location = new Point(430, 539);
            lbTiempoTrans.Name = "lbTiempoTrans";
            lbTiempoTrans.Size = new Size(27, 25);
            lbTiempoTrans.TabIndex = 5;
            lbTiempoTrans.Text = "0 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(988, 539);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 5;
            label4.Text = "3:06 ";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 215, 96);
            ClientSize = new Size(1789, 760);
            Controls.Add(label4);
            Controls.Add(lbTiempoTrans);
            Controls.Add(progressBar1);
            Controls.Add(ptbPortada);
            Controls.Add(lbAlbum);
            Controls.Add(lbNombre);
            Controls.Add(lbArtista);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(listbCanciones);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptbPortada).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbCanciones;
        private Label label1;
        private Label lbArtista;
        private Label label3;
        private Label lbNombre;
        private Label label5;
        private Label lbAlbum;
        private PictureBox ptbPortada;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem reproducciónToolStripMenuItem;
        private ToolStripMenuItem reproducirToolStripMenuItem;
        private ToolStripMenuItem siguienteToolStripMenuItem;
        private ToolStripMenuItem anteriorToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ProgressBar progressBar1;
        private Label lbTiempoTrans;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem pausaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
    }
}
