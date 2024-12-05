using System;

namespace BE
{
    public class EditorialBE
    {
        public EditorialBE() { }

        public EditorialBE(string descripcion)
        {
            Descripcion = descripcion;
        }

        public EditorialBE(int id, string descripcion)
        {
            ID = id;
            Descripcion = descripcion;
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
