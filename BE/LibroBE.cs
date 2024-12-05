using System;

namespace BE
{
    public class LibroBE
    {
        public LibroBE() {}

        public LibroBE(string isbn, string titulo, int edicion, int idGenero, int idEditorial)
        {
            ISBN = isbn;
            Titulo = titulo;
            Edicion = edicion;
            IdGenero = idGenero;
            IdEditorial = idEditorial;
        }

        public LibroBE( string titulo, int edicion, int idGenero, int idEditorial)
        {
        
            Titulo = titulo;
            Edicion = edicion;
            IdGenero = idGenero;
            IdEditorial = idEditorial;
        }

        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int Edicion { get; set; }
        public int IdGenero { get; set; }
        public int IdEditorial { get; set; }
    }
}
