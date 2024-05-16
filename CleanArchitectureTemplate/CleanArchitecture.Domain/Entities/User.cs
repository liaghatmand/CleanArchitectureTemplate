namespace CleanArchitecture.Domain.Entities;

    public class User :BaseEntity
    {
        public string? FIrstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? Password { get; set; }
        public string? Email { get; set; }
        public ValueObject? Address { get; set; }
        public Gender Gender { get; set; }
    }

