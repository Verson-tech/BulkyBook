using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        //to make the "Id" columnthe primary key use data annotation/attribute [Key]
        public int Id { get; set; }
        //to make sure that "Name" is a required property use [Required]
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
