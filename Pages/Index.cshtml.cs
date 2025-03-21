using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_lit_demo.Pages;

/// <summary>
/// We will be receiving events from the ServerEventsWorker service
/// about the need to update our UI. We've registered the worker
/// as a hosted service in our startup file (Program.cs).
/// </summary>
// [ResponseCache(Duration = 1 /* second */)]
public class IndexModel : PageModel
{
    public IndexModel()
    {
    }

    public void OnGet()
    {
    }

    public IActionResult OnGetPing()
    {
        return Content($"<p>Pong!</p>");
    }

    public ContentResult OnGetRandom()
    {
        Console.WriteLine(nameof(OnGetRandom));
        return Content($"<span>{Number.Value}</span>", "text/html");
    }
}