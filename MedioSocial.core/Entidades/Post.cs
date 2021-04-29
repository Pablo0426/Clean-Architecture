using System;

namespace MedioSocial.core.Entidades
{
    public class Post
    {
        public int PostId { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

    }
}
