using System.Text.Json;
using Hydro;

namespace razor_lit_demo.Pages.Shared.Components;

public class HydroArticle : HydroView
{
    public string Text { get; set; } = string.Empty;
    public bool Show { get; set; } = true;

    public string show_json => JsonSerializer.Serialize(Show);
}