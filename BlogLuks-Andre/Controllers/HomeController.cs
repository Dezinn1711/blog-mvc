using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogLuks_Andre.Models;

namespace BlogLuks_Andre.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Criar objetos
        Categoria Hisoka = new();
        Hisoka.Id = 1;
        Hisoka.Nome = "Hisoka Morrow";

        Categoria killua = new() 
        {
            Id= 2,
            Nome = "Killua Zoldyck"
        };

        Categoria kurapika = new (3,"kurapika");

        Categoria netero = new (4,"Isacc Netero");

        List<Postagem> postagens = [
            new (){
                Id = 1,
                Nome = "Hisoka Morrow ",
                CategoriaId = 1,
                Categoria = Hisoka,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Hisoka é um caçador que é viciado em lutar e fica procurando pessoas fortes para ter um duelo",
                Texto = "Lorem ipsum",
                Thumbnail = "/img/1.jpg",
                Foto = "/img/1.jpg"
            },

            new (){
                Id = 2,
                Nome = "Killua Zoldyck ",
                CategoriaId = 2,
                Categoria = killua,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Killua veio de uma fámilia assassina e gosta muito de seu amigo Gon",
                Texto = "Lorem ipsum",
                Thumbnail = "/img/2.jpg",
                Foto = "/img/2.jpg"
            },

            new (){
                Id = 3,
                Nome = "Kurapika",
                CategoriaId = 3,
                Categoria = kurapika,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Kurapika quer vingança pela seu clã que foi morto pela trupe fantasma",
                Texto = "Lorem ipsum",
                Thumbnail = "/img/3.jpg",
                Foto = "/img/3.jpg"
            },
            new (){
                Id = 4,
                Nome = "Isaac Netero",
                CategoriaId = 4,
                Categoria = netero,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Netero é um velho muito forte, que lutou contra o Rei Meruem",
                Texto = "Lorem ipsum",
                Thumbnail = "/img/4.jpg",
                Foto = "/img/4.jpg"
            }
        ]; 
        return View(postagens);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
