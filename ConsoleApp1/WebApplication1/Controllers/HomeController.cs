using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["FullName"] = "Kate Nicole Gelig";
        ViewData["Title"] = "Home";
        ViewData["ProfessionalTitle"] = "Aspiring Graphic Designer & Web Developer";
        ViewData["Introduction"] = "Welcome to my portfolio! I am an IT student passionate about building modern web applications, designing database schemas, and exploring network infrastructure & security.";
        return View();
    }

    public IActionResult About()
    {
        ViewData["Title"] = "About Me";
        ViewData["Bio1"] = "I am currently a college student taking a bachelor of science in information technology. While I am learning about modern software concepts, object-oriented programming, and computer networking, I am especially interested in the creative side of technology. I enjoy art, graphic design, and editing different types of digital content. My goal is to become a graphic designer and further develop my skills in visual design and creativity. I am also eager to learn more about web design and explore how technology and art can work together to create engaging and functional digital experiences.";
        ViewData["Bio2"] = "My career goal is to become a successful woman working in the technology field or a graphic designer who combines creativity and technology to create meaningful and visually engaging designs. I am passionate about digital art and enjoy exploring different forms of editing and visual design. Outside of my academic studies, I spend my free time creating digital art concepts, experimenting with editing, and exploring new ideas in web design. I hope to continue developing my creative and technical skills while learning how art and technology can work together.";
        return View();
    }

    public IActionResult Skills()
    {
        ViewData["Title"] = "Skills";
        return View();
    }

    public IActionResult Projects()
    {
        ViewData["Title"] = "Projects";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact";
        ViewData["Email"] = "katenicole@email.com";
        ViewData["Mobile"] = "+62 912 345 6789";
        ViewData["GitHub"] = "github.com/katenicole";
        ViewData["LinkedIn"] = "linkedin.com/in/katenicole";
        ViewData["Facebook"] = "facebook.com/katenicole";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}