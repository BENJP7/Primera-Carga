
using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {

       ///private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
       ///private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
       private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
       ///private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
       ///private static IRepositoriovisitasPyP _repoVisistasPyP = new Repositorio(new Persistencia.AppContext());
       
       static void Main(string[] args)

        {
            Console.WriteLine("Hola amigos vamos a empezar a trabajar con tablas ");
           
           //ListarDuenosFiltro();
           ///AddDueno();
           //BuscarDueno(5);
            AddMascota();

           ///ListarVeterinariosFiltro();
           ///AddVeterinario();
           //BuscarVeterinario(1);
           ///AddHistoria();

        }
        
           private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Leonardo",
                Apellidos = "Rodriguez", 
                Direccion = "Calle 120",
                Telefono = "111258258",
                Correo = "Batman@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
         private static void BuscarDueno(int idDueno)
        {
          var dueno = _repoDueno.GetADueno(idDueno);
          Console.WriteLine(dueno.Nombres + " "+ dueno.Apellidos + " "+ dueno.Direccion + " " + dueno.Telefono + " "); 

        }
          private static void BuscarVeterinario(int idVeterinario)
        {
          var veterinario = _repoVeterinario.GetAVeterinario(idVeterinario);
          Console.WriteLine(veterinario.Nombres + " "+ dueno.Apellidos); 

        }
        
        
           private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                ///Cedula = "55555",
                Nombres = "Dodoria",
                Apellidos = "Frodo", 
                Direccion = "Carrera 300",
                Telefono = "111111",
                TarjetaProfesional = "TP001"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        

            private static void AddHistoria()
        {
            var historia = new Historia
            {
                ///Cedula = "55555",
                ///I
                FechaInicial = "12/12/1999" 
               ///cls VisitasPyP= "Carrera 300",
               
            };
            _repoHistoria.AddHistoria(historia);
        }
            private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Popis",
                Color = "Cafe", 
                Especie = "Felino",
                Raza = "Angoro",
                
            };
            _repoMascota.AddMascota(mascota);
        }
        
        
    }
}
