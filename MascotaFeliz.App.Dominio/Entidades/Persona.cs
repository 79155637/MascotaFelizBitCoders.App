using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio.Entidades
{
  public class Persona
  {
    public int Id { get; set; }
     [Required, StringLength(30)]

    public string Nombre { get; set; }
     [Required, StringLength(30)]

    public string Apellidos { get; set; }

    public string NumeroTelefono { get; set; }
    public string CorreoElectronico { get; set; }
  }
}