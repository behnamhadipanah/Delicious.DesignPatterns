public record RequestContext
{
    public long UserId { get; set; }
    public Point Origin { get; set; }
    public Point Destination { get; set; }
}