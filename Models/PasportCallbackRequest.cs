namespace PaSPortCallbackMiddleware.Models;

public class PasportCallbackRequest
{
    public string? CallbackId { get; set; }
    public string? Code { get; set; }
    public string? Message { get; set; }
}
