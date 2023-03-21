using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGUASPROYECTO.MODELS
{
    class AGUAH
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(4)]
        public int  Codigo { get; set; }

        [MaxLength(200)]
        public string  NombreC { get; set; }

        [MaxLength(200)]
        public string Pais { get; set; }

        [MaxLength(200)]
        public string txtMunicipio  { get; set; }
    }
}
