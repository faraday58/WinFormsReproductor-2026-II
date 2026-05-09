namespace WinFormsReproductor_2026_II
{
    public  class Cancion
    {

        #region Atributos
        private string artista;
        private string nombre;
        private string album;
        private string imgDir;

        #endregion

        #region Propiedades
        public string Artista { get => artista; set => artista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Album { get => album; set => album = value; }
        public string ImgDir { get => imgDir; set => imgDir = value; }
        #endregion

        #region Constructores
        public Cancion(string artista, string nombre, string album, string imgDir)
        {
            Artista = artista;
            Nombre = nombre;
            Album = album;
            ImgDir = imgDir;
        }      
        #endregion

    }
}
