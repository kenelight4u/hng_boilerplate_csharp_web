using System.Text.Json.Serialization;

namespace Hng.Application.Features.OrganisationInvite.Dtos;

public record OrganizationInviteDto
{
    [JsonPropertyName("invite_id")]
    public string Id { get; init; }

    [JsonPropertyName("email")]
    public string Email { get; init; }

    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; init; }

    [JsonPropertyName("invite_link")]
    public string InviteLink { get; init; }
    [JsonPropertyName("status")]
    public string Status { get; init; }

    [JsonPropertyName("expires_at")]
    public DateTimeOffset ExpiresAt { get; init; }
}