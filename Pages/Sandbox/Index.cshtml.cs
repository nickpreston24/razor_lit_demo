using CodeMechanic.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_lit_demo.Pages.Sandbox;

public class Index : PageModel
{
    private static List<Todo> todo_list = new List<Todo>()
    {
        new Todo("buy milk"),
        new Todo("eat dinner"),
        new Todo("make bed"),
    };

    public void OnGet()
    {
    }

    public IActionResult OnGetTodos(string viewname = "")
    {
        Console.WriteLine(viewname);
        Console.WriteLine(nameof(OnGetTodos));
        if (viewname.IsEmpty())
            return Content($"<p>Hello, World!</p>");

        return Partial(viewname, todo_list);
    }
}