using System.ComponentModel.DataAnnotations;

namespace InventoryOfBookCollection.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; } 
        public List<Book>? ListOfBooks { get; set; }
    }
}
