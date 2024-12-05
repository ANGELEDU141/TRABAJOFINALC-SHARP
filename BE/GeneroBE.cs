using System;

namespace BE
{
    public class GeneroBE
    {
        public GeneroBE() { }

        public GeneroBE(string descripcion)
        {
            Descripcion = descripcion;
        }

        public GeneroBE(int id, string descripcion)
        {
            ID = id;
            Descripcion = descripcion;
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
