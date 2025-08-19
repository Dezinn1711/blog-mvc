using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogLuks_Andre.Models;

namespace BlogLuks_Andre.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Postagem> postagens;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    
        Categoria Lutador = new(1, "Hisoka Morrow"); 

        Categoria Assassino = new(2, "Killua Zoldyck");

        Categoria Corrente = new (3,"Kurapika");

        Categoria Velho = new (4,"Isacc Netero");

        Categoria Protagonista = new (5,"Gon Freecss");

        Categoria Líder = new (6,"Chrollo Lucilfer");
       

        postagens = [
            new (){
                Id = 1,
                Nome = "Hisoka Morrow",
                CategoriaId = 1,
                Categoria = Lutador,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Hisoka é um caçador que é viciado em lutar e fica procurando pessoas fortes para ter um duelo",
                Texto = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum ",
                Thumbnail = "/img/1.jpg",
                Foto = "/img/1.jpg"
            },

            new (){
                Id = 2,
                Nome = "Killua Zoldyck ",
                CategoriaId = 2,
                Categoria = Assassino,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Killua veio de uma fámilia assassina e gosta muito de seu amigo Gon",
                Texto = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum ",
                Thumbnail = "/img/2.jpg",
                Foto = "/img/2.jpg"
            },

            new (){
                Id = 3,
                Nome = "Kurapika",
                CategoriaId = 3,
                Categoria = Corrente,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Kurapika quer vingança pela seu clã que foi morto pela trupe fantasma",
                Texto = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum ",
                Thumbnail = "/img/3.jpg",
                Foto = "/img/3.jpg"
            },
            new (){
                Id = 4,
                Nome = "Isaac Netero",
                CategoriaId = 4,
                Categoria = Velho,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Netero é Foda. E lutou contra o Rei Meruem",
                Texto = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum ",
                Thumbnail = "/img/4.jpg",
                Foto = "/img/4.jpg"
            },
            new (){
                Id = 5,
                Nome = "Gon Freecss",
                CategoriaId = 5,
                Categoria = Protagonista,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Jovem Prodigio, filho do Homem mais forte do Mundo.",
                Texto = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum ",
                Thumbnail = "/img/5.jpg",
                Foto = "/img/5.jpg"
            },

            new (){
                Id = 6,
                Nome = "Chrollo Lucilfer",
                CategoriaId = 6,
                Categoria = Líder,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Copia e Cola.",
                Texto = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum ",
                Thumbnail = "/img/6.jpg",
                Foto = "/img/6.jpg"
            }
        ]; 
    }

    public IActionResult Index()
    {
        
        return View(postagens);
    }

    public IActionResult Postagem(int id)
    {
        var postagem = postagens
            .Where(p => p.Id == id)
            .SingleOrDefault();
        if(postagem == null)
            return NotFound();
        return View(postagem);
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
