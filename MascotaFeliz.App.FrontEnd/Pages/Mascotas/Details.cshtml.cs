using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio.Entidades;
using MascotaFeliz.App.Persistencia.AppRepositorios;


namespace MascotaFeliz.App.FrontEnd.Pages.Mascotas
{
    public class DetailsModel : PageModel
    {

        private readonly IRepositorioMascota repositorioMascotas;
        public Mascota Mascota { get; set; }

        public DetailsModel()
        {
            this.repositorioMascotas=new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppRepositorios.AppContextDV());
        }

        public IActionResult OnGet(int mascotaId)
        {
            Mascota = repositorioMascotas.GetMascota(mascotaId);
            if(Mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
