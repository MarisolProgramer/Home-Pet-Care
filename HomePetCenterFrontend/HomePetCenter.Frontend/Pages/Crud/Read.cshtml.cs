using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomePetCenter.Frontend.Pages
{
    public class ReadModel : PageModel
    {
        /*Seudopersistencia*/
        private string[] personas = {"Katerin", "Carlos", "Sebastian"};

        /*Propiedad*/
        public List<string> ListaPersonas {get;set;}

    /*Metodo que se ejecuta cuando se hace el llamdado a la pagina html Read*/
        public void OnGet()
        {
            /*Crear objeto lista saludos y adiciona los saludos de arriba*/
            ListaPersonas = new List<string>();
            ListaPersonas.AddRange(personas);
        }
    }
}
