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
        //Instância do tipo cliente
        Cliente cliente1 = new Cliente(01, "Marcos Felipe", "09806556410","marcos@gmail.com","Snow");
        Cliente cliente2 = new Cliente(02, "Raissa Maria", "10873004442","raissa@gmail.com","Snow");
        Cliente cliente3 = new Cliente(03, "Romulo Magalhaes", "02101754984","romulo@gmail.com","Snow");
        Cliente cliente4 = new Cliente(04, "Goretti Pedroza", "02101759489","goretti@gmail.com","Snow");
        Cliente cliente5 = new Cliente(05, "Marcia Cavalcante", "15665489710","marcia@gmail.com","Snow");

        //lista de cliente
        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);
        listaCliente.Add(cliente5);

        ViewBag.listaCliente = listaCliente;

        //Instância do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Marcos Felipe", "09806556410","marcos@gmail.com","Snow");
        Fornecedor fornecedor2 = new Fornecedor(02, "Raissa Maria", "10873004442","raissa@gmail.com","Snow");
        Fornecedor fornecedor3 = new Fornecedor(03, "Romulo Magalhaes", "02101754984","romulo@gmail.com","Snow");
        Fornecedor fornecedor4 = new Fornecedor(04, "Goretti Pedroza", "02101759489","goretti@gmail.com","Snow");
        Fornecedor fornecedor5 = new Fornecedor(05, "Marcia Cavalcante", "15665489710","marcia@gmail.com","Snow");
        
        //lista de cliente
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);
        listaFornecedor.Add(fornecedor4);
        listaFornecedor.Add(fornecedor5);

        ViewBag.listaFornecedor = listaFornecedor;

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
