using System.ComponentModel.DataAnnotations;

namespace BookManagementMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Giá sách không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá sách phải lớn hơn 0")]
        public decimal? Price { get; set; }
    }
}
