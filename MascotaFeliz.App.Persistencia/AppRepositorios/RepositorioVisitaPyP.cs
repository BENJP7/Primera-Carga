
using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaPyP : IRepositorioVisitaPyP
    {
        /// <summary>
        /// Referencia al contexto de Dueno
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioVisitaPyP(AppContext appContext)
        {
            _appContext = appContext;
        }
/*
        public  VisitaPyP AddVisitaPyP(VisitaPyP visita)
        {
            var vistaPypAdicionado = _appContext.VisitasPyP.Add(visita);
            _appContext.SaveChanges();
            return vistaPypAdicionado.Entity;

        }
      
        public void DeleteVisitaPyP(int idVisitaPyP)
        {
            var visitPypEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
            if (visitPypEncontrado == null)
                return;
            _appContext.VisitasPyP.Remove(visitPypEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<VisitaPyP> GetAllVisitasPyPs()
        {
            return GetAllVisitasPyPs_();
        }

        public IEnumerable<VisitaPyP> GetVisitasPyPPorFiltro(DateTime filtro!)
        {
            var visitasPyP = GetAllVisitasPyPs(); // Obtiene todos los saludos
            if (visitasPyP != null)  //Si se tienen saludos
            {
                // if (!filtro.HasValue) // Si el filtro tiene algun valor
                // {
                    visitasPyP = visitasPyP.Where(s => s.FechaVisita.Contains(filtro));
                // }
            }
           return visitasPyP;
        }

        public IEnumerable<VisitaPyP> GetAllVisitasPyPs_()
        {
            return _appContext.VisitasPyP;
        }

        public VisitaPyP GetVisitaPyP(int idVisitaPyP)
        {
            return _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
        }


        // public VisitaPyP UpdateVisitaPyP(Veterinario VisitaPyP)
        // {
        //     var visitaPyPEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == VisitaPyP.Id);
        //     if (visitaPyPEncontrado != null)
        //     {
        //         visitaPyPEncontrado.Nombres = VisitaPyP.FechaVisita;
        //         visitaPyPEncontrado.Apellidos = VisitaPyP.Apellidos;
        //         visitaPyPEncontrado.Direccion = VisitaPyP.Direccion;
        //         visitaPyPEncontrado.Telefono = VisitaPyP.Telefono;
        //         visitaPyPEncontrado.TarjetaProfesional = VisitaPyP.TarjetaProfesional;
               
                
        //         _appContext.SaveChanges();
        //     }
        //     return veterinarioEncontrado;
        // }
*/
    }
}


