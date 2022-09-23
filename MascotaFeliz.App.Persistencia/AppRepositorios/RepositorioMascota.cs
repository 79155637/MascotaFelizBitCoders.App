using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio.Entidades;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
  public class RepositorioMascota : IRepositorioMascota
  {
    private readonly AppContextDV _appContextDV;
    public RepositorioMascota(AppContextDV appContextDV)
    {
      _appContextDV = appContextDV;
    }
    Mascota IRepositorioMascota.AddMascota(Mascota mascota)
    {
      Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Mascota> mascotaAdicionado = _appContextDV.Mascotas.Add(mascota);
      _ = _appContextDV.SaveChanges();
      return mascotaAdicionado.Entity;

    }

    Mascota IRepositorioMascota.DeleteMascota(int idMascota)
    {
      var mascotaEncontrado = _appContextDV.Mascotas.Include(c => c.Cliente).Include(v => v.Veterinario).FirstOrDefault(p => p.Id == idMascota);
      if (mascotaEncontrado != null)
      {
        _appContextDV.Mascotas.Remove(mascotaEncontrado);
        _appContextDV.SaveChanges();
      }
       return mascotaEncontrado;
    }



    IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
    {
      return _appContextDV.Mascotas;
    }

    Mascota IRepositorioMascota.GetMascota(int idMascota)
    {
      return _appContextDV.Mascotas.Include(c => c.Cliente).Include(v => v.Veterinario).FirstOrDefault(p => p.Id == idMascota);
    }
    Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
    {
      var mascotaEncontrado = _appContextDV.Mascotas.Include(c => c.Cliente).Include(v => v.Veterinario).FirstOrDefault(p => p.Id == mascota.Id);
      if (mascotaEncontrado != null)
      {
        mascotaEncontrado.Id = mascota.Id;

        /* {
           var clienteEncontrado = _appContextDV.Clientes.FirstOrDefault(c => c.Id == mascota.ClienteId);
           return clienteEncontrado;
         }*/

        var clienteEncontrado = _appContextDV.Personas.OfType<Cliente>().FirstOrDefault(c => c.Id == mascota.Cliente.Id);
        if (clienteEncontrado != null)
        {
          mascotaEncontrado.Cliente = clienteEncontrado;
        }
        mascotaEncontrado.Nombre = mascota.Nombre;
        mascotaEncontrado.Color = mascota.Color;
        mascotaEncontrado.Raza = mascota.Raza;
        mascotaEncontrado.FechaNacimiento = mascota.FechaNacimiento;
        mascotaEncontrado.Veterinario = mascota.Veterinario;

        _appContextDV.SaveChanges();
      }
      return mascotaEncontrado;
    }
  }

}