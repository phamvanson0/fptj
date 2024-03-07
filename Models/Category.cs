using System.ComponentModel.DataAnnotations;

namespace FPT_JOB.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public bool Status { get; set; }
        
        public virtual ICollection<Job>? Jobs { get; set; }
    }
}
