using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.tork.challenge.DbRepository.V1.DTOs
{
    [Table("books")]
    public class BookDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int book_id { get; set; }
        [Column]
        public string title { get; set; }
        [Column]
        public string first_name { get; set; }
        [Column]
        public string last_name { get; set; }
        [Column]
        public int total_copies { get; set; }
        [Column]
        public int copies_in_use { get; set; }
        [Column]
        public string type { get; set; }
        [Column]
        public string isbn { get; set; }
        [Column]
        public string category { get; set; }
    }
}
