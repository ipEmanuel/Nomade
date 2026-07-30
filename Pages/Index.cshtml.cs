using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nomade.Models;

namespace Nomade.Pages;

public class IndexModel : PageModel
{
    public List<ProjectItem> Proyectos { get; } = new()
    {
        new ProjectItem
        {
            Id = "1",
            Titulo = "CAPATUR Gestión de Clientes",
            Descripcion = "Aplicación web desarrollada para digitalizar la gestión de clientes en un entorno real",
            Imagen = "img/Home.png",
            ImagenAlt = "Captura del proyecto CAPATUR desarrollado por Emanuel",
            GithubUrl = "https://github.com/ipEmanuel/ProyectoCRUD"
        },
        new ProjectItem
        {
            Id = "2",
            Titulo = "TurnosApp - administración de turnos, clientes y servicios",
            Descripcion = "Aplicación web desarrollada para salones de estética, resuelve la administración de turnos, gestión de usuarios y administración de servicios.",
            Imagen = "img/TurnosApp.png",
            ImagenAlt = "Captura del proyecto TurnosApp desarrollado por Emanuel",
            GithubUrl = "https://github.com/ipEmanuel/Turnos"
        }
    };


    public void OnGet()
    {

    }
}
