using CodeMechanic.Diagnostics;
using CodeMechanic.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_lit_demo.Pages.Sandbox;

public class Index : PageModel
{
    private static List<Resource> items = new List<Resource>()
    {
        new Resource("buy milk", state: "Running"),
        new Resource("eat dinner", ""),
        new Resource("make bed", ""),
    };

    public void OnGet()
    {
    }

    public IActionResult OnGetContainers(string viewname = "")
    {
        Console.WriteLine(viewname);
        Console.WriteLine(nameof(OnGetContainers));
        if (viewname.IsEmpty())
            return Content($"<p>Hello, World!</p>");

        items.Dump("resources   ");
        return Partial(viewname, items);
    }
}