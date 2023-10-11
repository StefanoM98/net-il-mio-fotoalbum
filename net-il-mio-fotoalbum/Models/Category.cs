﻿using System.ComponentModel.DataAnnotations;

namespace net_il_mio_fotoalbum.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Il nome della categoria è obbligatorio")]
        public string Name { get; set; }

        public List<Foto>? Fotos { get; set; }

        public Category() { }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
