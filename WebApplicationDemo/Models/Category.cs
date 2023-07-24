using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
    

        public string Name { get; set; }
        
        public string DisplayOrder { get; set; }
    }

}
