using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio.Entidades;
using MascotaFeliz.App.Persistencia.AppRepositorios;


namespace MascotaFeliz.App.FrontEnd.Pages
{
  public class DeleteModel : PageModel
  {
    private readonly IRepositorioMascota repositorioMascotas;

    [BindProperty]
    public Mascota Mascota { get; set; }

    public DeleteModel()
    {
      this.repositorioMascotas = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppRepositorios.AppContextDV());
    }


    public IActionResult OnGet(int? mascotaId)
    {
      if (mascotaId.HasValue)
      {
        Mascota = repositorioMascotas.GetMascota(mascotaId.Value);
      }
      if (Mascota == null)
      {
        return RedirectToPage("./NotFound");
      }
      else
      {
        return Page();
      }


    }

    public IActionResult OnPost(int mascotaId)
    {
      if (!ModelState.IsValid)
      {
        return Page();
      }
      if (Mascota.Id > 0)
      {
        repositorioMascotas.DeleteMascota(mascotaId);
      }

      return Page();
    }
  }
}