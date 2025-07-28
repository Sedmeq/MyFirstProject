using System.ComponentModel.DataAnnotations;

namespace MyFirstProject.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string VAlue { get; set; }
        public string? Description { get; set; }
    }
}
