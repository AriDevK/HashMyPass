using System.ComponentModel.DataAnnotations;

namespace HashMyPass.Forms;

public class HashingForm
{
    [Required]
    public string? Algorithm { get; set; }
    
    [Required]
    public string? Text { get; set; }
    public string? Salt { get; set; }
    public string? SaltPosition { get; set; }
}