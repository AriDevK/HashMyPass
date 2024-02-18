using System.ComponentModel.DataAnnotations;
using HashMyPass.Services;

namespace HashMyPass.Forms;

public class HashingForm
{
    [Required]
    public HashAlgorithm Algorithm { get; set; }
    
    [Required]
    public string? Text { get; set; }
    public string? Salt { get; set; }
    public string? SaltPosition { get; set; }
}