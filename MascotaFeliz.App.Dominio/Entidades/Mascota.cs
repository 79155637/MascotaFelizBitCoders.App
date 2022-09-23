using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio.Entidades
{
    public class Mascota
    {
        // Identificación UNICA de la Mascota
        public int Id { get; set; }
        public Cliente Cliente {get;set;}
        [Required, StringLength(30)]
        public string Nombre { get; set; }
         [Required, StringLength(20)]
        public string Color { get; set; }
         [Required, StringLength(30)]
        public string Raza { get; set; }
        public Genero Genero {get;set;}
        public DateTime FechaNacimiento { get; set; }

        //Veterinario Asignado a la Mascota
        public Veterinario Veterinario {get;set;}
        
    }
}