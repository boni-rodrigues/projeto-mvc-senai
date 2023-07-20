using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur", "12345678900", "email@email.com.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "Rodolfo", "12456894000", "email2@email.com.br", "Piter");
        Cliente cliente3 = new Cliente(03, "Rubens", "35485216975", "email3@email.com.br", "Spike");
        Cliente cliente4 = new Cliente(04, "Alfredo", "98745632100", "email4@email.com.br", "Belinha");
        Cliente cliente5 = new Cliente(06, "Manu", "12345698700", "email6@email.com.br", "Mandy");

        //Lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        //ViewBag tem esse nome por se assemelhar a uma "bolsa" que carrega as informações e direciona para a View.

        ViewBag.listaClientes = listaClientes;

        //Instancias do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-00", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(01, "Ctrl Alt Dog", "14.182.103/0001-00", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(01, "BootsPet INC", "14.182.104/0001-00", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(01, "Tik Tok Dogs", "14.182.105/0001-00", "noisnamidla@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(01, "Bilfinho Fortever", "14.182.106/0001-00", "contato@bff.us");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
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
