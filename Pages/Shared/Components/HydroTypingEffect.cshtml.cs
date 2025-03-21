using System.Text.Json;
using Hydro;

namespace razor_lit_demo.Pages.Shared.Components;

public class HydroTypingEffect : HydroView
{
    public string[] Messages { set; get; } =
    [
        "Alpine JS is Amazing", "It is Truly Awesome!",
        "You Have to Try It!"
    ];

    public string msg_json => JsonSerializer.Serialize(Messages);
}