using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practical_20.Interface;
using Practical_20.Models;

namespace Practical_20.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger ,IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var users = await _unitOfWork.Users.GetAllAsync();
        return View(users);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(User user)
    {
        if (ModelState.IsValid)
        {
            user.Timestamp = DateTime.Now; 
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.SaveAsync();
            _logger.LogInformation("User created: {Name}", user.Name);
            return RedirectToAction(nameof(Index));
        }
        return View(user);
    }
}
