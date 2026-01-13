//namespace EmailSend.Models
//{
//    using System.ComponentModel.DataAnnotations;
//    public class FormModel
//    {
//        [Required]
//        public string Name { get; set; }
//        [Required]
//        public string Phone { get; set; }
//        [Required]
//        public string Message { get; set; }

//        [Required]
//        [EmailAddress]
//        public string Email { get; set; }

//    }
//}
namespace EmailSend.Models
{
    using System.ComponentModel.DataAnnotations;

    public class FormModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Message { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
