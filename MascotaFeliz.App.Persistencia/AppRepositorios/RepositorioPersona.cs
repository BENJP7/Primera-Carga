/*
using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioPersona 
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
        
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

        public  Persona AddPersona(Persona persona)
        {
            var personaAdicionado = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;

        }
      
        public void DeletePersona(int idPersona)
        {
            var personaEncontrado = _appContext.Personas.FirstOrDefault(d => d.Id == idPersona);
            if (personaEncontrado == null)
                return;
            _appContext.Personas.Remove(personaEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Persona> GetAllPersonas()
        {
            return GetAllPersonas_();
        }

        public IEnumerable<Persona> GetPersonasPorFiltro(string filtro)
        {
            var persona = GetAllPersonas(); // Obtiene todos los saludos
            if (persona != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    personas = personas.Where(s => s.Nombres.Contains(filtro));
                }
            }
           return personas;
        }

        public IEnumerable<Persona> GetAllPersonas_()
        {
            return _appContext.Personas;
        }

        public Persona GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(d => d.Id == idPersona);
        }
        public Persona UpdatePersona(Persona Persona)
        {
            var personaEncontrado = _appContext.Personas.FirstOrDefault(d => d.Id == persona.Id);
            if (personaEncontrado != null)
            {
                personaEncontrado.Nombres = persona.Nombres;
                personaEncontrado.Apellidos = persona.Apellidos;
                personaoEncontrado.Direccion = persona.Direccion;
                personaEncontrado.Telefono = persona.Telefono;
                
               
                
                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }
    }

}
*/