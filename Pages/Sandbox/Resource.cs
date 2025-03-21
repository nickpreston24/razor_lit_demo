using CodeMechanic.Types;
using Vogen;

namespace razor_lit_demo;

public class Resource(string name, string state)
{
    public string Name { get; set; } = name;
    public ResourceType Type { get; set; } = ResourceType.Unspecified;

    public State State { get; set; } =
        state.NotEmpty() ? State.From(state) : State.Unspecified;

    public DateTime? StartTime { get; set; }
    public string source { get; set; } = string.Empty;
    public string endpoints { get; set; } = string.Empty;
    public string logs { get; set; } = string.Empty;
    public string details { get; set; } = string.Empty;
}

[ValueObject<string>]
[Instance("Unspecified", "Unspecified")]
[Instance("NotApplicable", "N/A")]
[Instance("Container", "Container")]
[Instance("Project", "Project")]
public partial class ResourceType
{
}

[ValueObject<string>]
[Instance("Unspecified", "Unspecified")]
[Instance("NotApplicable", "N/A")]
[Instance("Running", "Running")]
[Instance("Idle", "Idle")]
public partial class State
{
}