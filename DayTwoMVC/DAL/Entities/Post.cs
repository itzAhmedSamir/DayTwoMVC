using System.ComponentModel.DataAnnotations.Schema;

namespace DayTwoMVC.DAL.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Body { get; set; }
        [ForeignKey("user")]
        public int? UserID { get; set; }
        public User? user { get; set; }

    }
}
