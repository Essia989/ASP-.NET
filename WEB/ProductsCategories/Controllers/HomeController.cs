﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using ProductsCategories.Models;
namespace ProductsCategories.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Product> AllProducts = _context.Products.ToList();
        ViewBag.AllProducts = AllProducts;
        return View();
    }

    [HttpGet("/Categories")]
    public IActionResult Categories(Category newCategory)
    {
        List<Category> AllCategories = _context.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return View();
    }

    [HttpGet("/categories/{CategoryId}")]
    public IActionResult CreateAssociationCategory(int CategoryId)
    {
        Category? Category = _context.Categories.SingleOrDefault(cat => cat.CategoryId == CategoryId);
        List<Product> AllProducts = _context.Products.ToList();
        ViewBag.Category = Category;
        ViewBag.AllProducts = AllProducts;
        return View();
    }
    
    [HttpPost("/AddProd_Category")]
    public IActionResult AddProd_Category(Association newAssociation)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newAssociation);
            _context.SaveChanges(); 
            System.Console.WriteLine("New Association added successfully");
            System.Console.WriteLine(newAssociation.ProductId);
            System.Console.WriteLine(newAssociation.CategoryId);
            //string link = "/categories/"+newAssociation.CategoryId;
            return RedirectToAction("/categories");
        }
        else 
        {
            System.Console.WriteLine("NOT Valid new Product not added !");
            return RedirectToAction("/categories");
        }
    }

    [HttpGet("/products/{ProductId}")]
    public IActionResult CreateAssociationProduct(int ProductId)
    {
        Product? Product = _context.Products.SingleOrDefault(prod => prod.ProductId == ProductId);

        ViewBag.AllProdCategories = _context.Categories.Include(a=> a.ProdsInCategory).ThenInclude(m=> m.Product).ToList(); //
        //List<Product> ProductsForCategory = _context.Products.Include(prod => prod.InCategories).ThenInclude(sub => sub.Product).ToList();
        //ViewBag.ProductsForCategory1 = _context.Products.Include(pr => pr.InCategories).ThenInclude(mpt => mpt.Product).ToList();
        /*ViewBag.ProductsForCategory1 =_context.Products.Include(s => s.InCategories).ThenInclude(d => d.Category).ToList();
        foreach(Product a in ViewBag.ProductsForCategory2)
                {
                    System.Console.WriteLine("a.Name");
                }*/
        //_context.Products.Include(p => p.InCategories).ThenInclude(s => s.Product).ToList();
        List<Category> AllCategories = _context.Categories.ToList();
        ViewBag.Product = Product;
        ViewBag.AllCategories = AllCategories;
        return View();
    }
    [HttpPost("/AddCat_Product")]
    public IActionResult AddCat_Product(Association newAssociation)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newAssociation);
            _context.SaveChanges(); 
            System.Console.WriteLine("New Association added successfully");
            System.Console.WriteLine(newAssociation.ProductId);
            System.Console.WriteLine(newAssociation.CategoryId);
            return RedirectToAction("/products");
        }
        else 
        {
            System.Console.WriteLine("NOT Valid new Product not added !");
            return View("/products");
        }
    }
    [HttpPost("/CategoryAdd")]
    public IActionResult CategoryAdd(Category newCategory)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newCategory);
            _context.SaveChanges(); 
            System.Console.WriteLine("New Category added successfully");
            return RedirectToAction("Categories");
        }
        else 
        {
            System.Console.WriteLine("NOT Valid new Product not added !");
            return View("Index");
        }
    }

    [HttpPost("/ProductAdd")]
    public IActionResult AddnewChef(Product newProduct)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
            System.Console.WriteLine("New Product added successfully");
            return RedirectToAction("Index");
        
        }
        else 
        {
            System.Console.WriteLine("NOT Valid new Product not added !");
            return View("Index");
        }
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
