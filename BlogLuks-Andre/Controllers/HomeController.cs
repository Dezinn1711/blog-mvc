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
    
        Categoria Hisoka = new(1, "Vilão"); 

        Categoria Killua = new(2, "Protagonista");

        Categoria Kurapika = new (3,"Protagonista");

        Categoria Netero = new (4,"Protagonista");

        Categoria Gon = new (5,"Protagonista");

        Categoria Chrollo = new (6,"Vilão");

        Categoria Pitou = new (7,"Vilão");

        Categoria Feitan = new (8,"Vilão");
       

        postagens = [
            new (){
                Id = 1,
                Nome = "Hisoka Morrow",
                CategoriaId = 1,
                Categoria = Hisoka,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Hisoka é um mágico e lutador sádico, fascinado por oponentes poderosos. Ele vê as batalhas como um espetáculo sensual e sóbrio, muitas vezes poupando adversários que ainda têm potencial para diverti-lo mais tarde. É imprevisível, cruel e habilidoso com o Nen do tipo Transmutação.",
                Texto = "Hisoka vive pelo prazer do combate. Cada luta é uma dança, e cada oponente promissor, uma futura obra-prima. Seus jogos mentais e sorriso sinistro o tornam um dos personagens mais enigmáticos e perigosos da série.",
                Thumbnail = "/img/hisoka.jpg",
                Foto = "/img/1.jpg"
            },

            new (){
                Id = 2,
                Nome = "Killua Zoldyck ",
                CategoriaId = 2,
                Categoria = Killua,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Membro da família de assassinos Zoldyck, Killua é extremamente talentoso, inteligente e veloz. Apesar de seu passado sombrio, ele encontra um novo caminho ao lado de Gon. É usuário de Nen do tipo Transmutação e desenvolve técnicas com eletricidade, como o famoso Godspeed.",
                Texto = "Killua luta contra o peso de seu passado enquanto se agarra à amizade com Gon. Entre sombras e relâmpagos, ele busca redenção — e liberdade. ",
                Thumbnail = "/img/killua.jpg",
                Foto = "/img/2.jpg"
            },

            new (){
                Id = 3,
                Nome = "Kurapika",
                CategoriaId = 2,
                Categoria = Kurapika,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Último sobrevivente do clã Kurta, Kurapika é movido por um desejo profundo de justiça — ou vingança. Ao ativar seus olhos escarlates, ele se torna especialista em todas as categorias de Nen, mas concentra-se em suas correntes conjuradas para caçar a Trupe Fantasma.",
                Texto = "Kurapika é silêncio e fúria. Suas correntes não são só armas — são laços com um passado que nunca o deixa. Ele luta não por glória, mas por dignidade. ",
                Thumbnail = "/img/kurapika.jpg",
                Foto = "/img/3.jpg"
            },
            new (){
                Id = 4,
                Nome = "Isaac Netero",
                CategoriaId = 2,
                Categoria = Netero,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Ex-presidente da Associação dos Hunters, Netero é um mestre das artes marciais e do Nen. Apesar da idade avançada, é incrivelmente rápido e forte. Seu ataque final, o Zero Hand, é uma das técnicas mais destrutivas do anime. Lutou bravamente contra Meruem, o rei das Chimera Ants.",
                Texto = "Netero é a prova de que idade não define poder. Em sua batalha final, ele mostra que mesmo os mais sábios podem ser explosivos quando lutam pelo que acreditam. ",
                Thumbnail = "/img/netero.jpg",
                Foto = "/img/4.jpg"
            },
            new (){
                Id = 5,
                Nome = "Gon Freecss",
                CategoriaId = 2,
                Categoria = Gon,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Filho do lendário Hunter Ging, Gon é determinado, corajoso e de espírito puro. É usuário de Nen do tipo Reforço, com o golpe Jajanken. Sua jornada é uma busca por seu pai — e por entender o mundo que ele deixou para trás.",
                Texto = "Gon é esperança encarnada. Mesmo diante da dor, ele segue em frente com brilho nos olhos e socos carregados de emoção. ",
                Thumbnail = "/img/gon.jpg",
                Foto = "/img/5.jpg"
            },

            new (){
                Id = 6,
                Nome = "Chrollo Lucilfer",
                CategoriaId = 1,
                Categoria = Chrollo,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Líder carismático e estrategista da Trupe Fantasma, Chrollo é calmo, enigmático e letal. Possui a habilidade Skill Hunter, que lhe permite roubar habilidades Nen de outras pessoas.",
                Texto = "Chrollo é a mente por trás do caos. Seu olhar sereno esconde uma alma fria, movida por ideais sombrios e uma curiosa busca por significado.",
                Thumbnail = "/img/chrollo.jpg",
                Foto = "/img/6.jpg"
            },

            new (){
                Id = 7,
                Nome = "Neferpitou",
                CategoriaId = 1,
                Categoria = Pitou,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Um dos três guardas reais do Rei Meruem, Pitou é uma Chimera Ant com comportamento felino, instintos protetores e uma crueldade intensa. Suas habilidades Nen incluem manipulação e cura.",
                Texto = "Pitou é uma fera com sentimentos complexos. Entre brutalidade e lealdade, deixa um rastro de medo — e momentos inesquecíveis na série. ",
                Thumbnail = "/img/pitou.jpg",
                Foto = "/img/7.jpg"
            },

            new (){
                Id = 8,
                Nome = "Feitan portor",
                CategoriaId = 1,
                Categoria = Feitan,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Membro da Trupe Fantasma, Feitan é sádico, misterioso e extremamente veloz. Sua habilidade Pain Packer permite transformar a dor sofrida em um ataque devastador.",
                Texto = "Feitan é a dor personificada. Silencioso e mortal, cada batalha para ele é um espetáculo de sofrimento meticuloso. ",
                Thumbnail = "/img/feitan.jpg",
                Foto = "/img/8.jpg"
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
