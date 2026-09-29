using FinTrackAPI.Domain.DTOs.AuthController;

namespace FinTrackAPI.Domain.Entities
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? PasswordHash { get; set; }
        public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

        public User()
        {

        }
        public User(string name, string email, string passwordHash)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
        }
    }
}
