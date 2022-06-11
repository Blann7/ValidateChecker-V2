namespace ValidateChecker
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public decimal Money { get; set; }
        public long? BanMs { get; set; }
        public long? RoleValidityMs { get; set; }
        public bool? FullDostup { get; set; }
    }
}
