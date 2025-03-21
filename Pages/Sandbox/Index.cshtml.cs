using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_lit_demo.Pages.Sandbox;

public class Index : PageModel
{
    public void OnGet()
    {
    }

    public IActionResult OnGetHello()
    {
        Console.WriteLine(nameof(OnGetHello));
        return Content($"<p>World</p>");
    }
}