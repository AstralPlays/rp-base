namespace astral_base.RPBASE;

public record ChatMessage
{
    public string Text { get; init; }
    public ulong Author { get; init; }
    public string DisplayName { get; init; }
    public DateTime Time { get; init; }
    public bool IsOOC { get; set; } = false;
    public bool IsActive { get; set; }
    public bool IsSytemMessage { get; set; }
}