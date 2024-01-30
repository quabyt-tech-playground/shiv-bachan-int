using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }

        
        public  string Name { get; set; }

      public int VillaId { get; set; } = 0;
        
    }
}
