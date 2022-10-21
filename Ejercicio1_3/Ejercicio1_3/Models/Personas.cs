using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicio1_3.Models
{
   public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int id { set; get; }

        [MaxLength(100)]
        public String Nombres { set; get; }

        [MaxLength(100)]
        public String Apellidos { set; get; }

        public int Edad { set; get; }

        [MaxLength(100)]
        public String Correo { set; get; }

        [MaxLength(100)]
        public String Direccion { set; get; }
    }
}
