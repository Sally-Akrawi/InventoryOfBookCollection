using System.ComponentModel.DataAnnotations;

namespace InventoryOfBookCollection.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }   
        public int AuthorId { get; set; } 
        public Author? Author { get; set; }
    }
}