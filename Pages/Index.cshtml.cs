using CodeMechanic.Shargs;
using CodeMechanic.Types;
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
    private readonly ArgsMap arguments;
    private readonly bool debug;

    public IndexModel(ArgsMap arguments)
    {
        this.arguments = arguments;
        this.debug = this.arguments.HasFlag("--debug");
    }

    private static string[] articles = new[]
    {
        @"Bark bark bark, bark! wooof bark woof woof.",
        "Everything is fine. Nothing to see here!",
        "Elon Musk meets with defence officials in Pentagon visit",
        "Sudan war: Army recaptures presidential palace in Khartoum from RSF",
        "Virginia man facing up to 5 years for taking classified documents"
    };

    public void OnGet()
    {
    }

    public IActionResult OnGetNews()
    {
        string article = articles.TakeFirstRandom();
        if (debug) Console.WriteLine(article);
        return Partial("_Article", article);
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