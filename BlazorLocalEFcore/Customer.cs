using System.Text.Json.Serialization;

namespace BlazorLocalEFcore;

public class Customer
{
    public Guid Id { get; set; }

    [JsonPropertyName("Name")]
    public string FullName { get; set; } = string.Empty;

    [JsonPropertyName("Address")]
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

}
