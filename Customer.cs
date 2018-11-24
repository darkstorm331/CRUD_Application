using System.ComponentModel.DataAnnotations;

namespace CRUD_Application
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}