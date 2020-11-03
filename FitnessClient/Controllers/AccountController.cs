using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using FitnessClient.Models;
using System.Threading.Tasks;
using FitnessClient.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace FitnessClient.Controllers
{
  public class AccountController : Controller
  {
    private readonly FitnessClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, FitnessClientContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var user = new ApplicationUser
      {
        UserName = model.Email
        // Email = model.Email,
        // Height = model.Height,
        // Weight = model.Weight,
        // Age = model.Age,
        // FitnessLevel = model.FitnessLevel,
        // Gender = model.Gender
      };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        System.Console.WriteLine("SUCCESS");
        return RedirectToAction("Index");
      }
      else
      {
        System.Console.WriteLine("NOPE");
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}