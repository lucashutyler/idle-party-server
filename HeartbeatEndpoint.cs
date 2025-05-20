public static class HeartbeatEndpoint
{
    public static void MapHeartbeatEndpoint(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/heartbeat", () => Results.Ok("alive"));
    }
}
