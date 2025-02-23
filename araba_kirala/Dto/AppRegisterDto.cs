namespace araba_kirala.Dto
{
    public class AppRegisterDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserName { get; set;} = string.Empty;
        public string Email { get; set; } =string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public int ? ConfirmCode { get; set; } 
    }
}
