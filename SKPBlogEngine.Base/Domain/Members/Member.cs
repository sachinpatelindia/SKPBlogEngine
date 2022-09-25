namespace SKPBlogEngine.Base.Domain.Members
{
    public class Member : BaseEntity
    {
        public string? DistplayName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }   
        public DateTime? CreatedDate { get; set; }
    }
}
