
using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {

       private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
       private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
       private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
       private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
      // private static IRepositoriovisitasPyP _repoVisistasPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
       
       static void Main(string[] args)

        {
            Console.WriteLine("Hola amigos vamos a empezar a trabajar con tablas ");
           
           //ListarDuenosFiltro();
            //    AddDueno();
            //    BuscarDueno(2);
        // AddMascota();
        Console.WriteLine("Buscar Mascota\n");
         BuscarMascota(3);
         Console.WriteLine("Listado de Todas las Mascotas\n");
        ListarMascotas();
        // ListarVeterinariosFiltro();
        // AddVeterinario();
        // BuscarVeterinario(8);
           ///AddHistoria();

        }
        
           private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Astrid",
                Apellidos = "Ardila", 
                Direccion = "Calle 120",
                Telefono = "111258258",
                Correo = "Batman@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void BuscarDueno(int idDueno)
        {
          var dueno = _repoDueno.GetDueno(idDueno);
          Console.WriteLine("Nombre: " + dueno.Nombres + "\n Apellido: "+ dueno.Apellidos + "\n Dirreción: "+ dueno.Direccion + "\n Telefono: " + dueno.Telefono + " "); 

        }
        
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                ///Cedula = "55555",
                Nombres = "Lucas",
                Apellidos = "Frodo", 
                Direccion = "Carrera 300",
                Telefono = "111111",
                TarjetaProfesional = "TP001"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        
        private static void BuscarVeterinario(int idVeterinario)
        {
          var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
          Console.WriteLine("Nombre: "+veterinario.Nombres + "\n Apellido " + veterinario.Apellidos + "\nTarjeta Prof:" + veterinario.TarjetaProfesional); 

        }
/*
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
*/
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Pewee",
                Color = "Café", 
                Especie = "Gatuno",
                Raza = "xxx",
                
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void BuscarMascota(int idMascota)
        {
          var mascota = _repoMascota.GetMascota(idMascota);
          Console.WriteLine("Nombre: " + mascota.Nombre + "\n Color: "+ mascota.Color + "\n Especie: "+ mascota.Especie + "\n Raza: " 
          + mascota.Raza + " "); 

        }        

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota mascota in mascotas)
            {
                Console.WriteLine("Nombre: " + mascota.Nombre + "\tColor: " + mascota.Color + "\t Raza: " + mascota.Raza);           
            };
        }
        
    }
}
