using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Image
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        [MaxLength(100)]
        public string Url { get; set; }

        public Book Book { get; set; }
    }
}
