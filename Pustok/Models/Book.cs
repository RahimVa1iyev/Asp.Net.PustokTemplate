using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{
    public class Book
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public int GenreId { get; set; }

        public string Name { get; set; }
        [Column(TypeName="decimal(6,2)")]

        public decimal Price { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<BookTag> BookTags { get; set; }

        public Author Author { get; set; }

        public Genre Genre { get; set; }
    }
}
