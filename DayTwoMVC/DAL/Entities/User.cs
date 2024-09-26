namespace DayTwoMVC.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime IsCreated { get; set; } = DateTime.Now;
        public List<Post>? posts { get; set; }
    }
}
