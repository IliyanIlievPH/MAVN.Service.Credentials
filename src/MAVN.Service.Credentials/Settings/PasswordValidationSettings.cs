namespace MAVN.Service.Credentials.Settings
{
    public class PasswordValidationSettings
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public int MinUpperCase { get; set; }
        public int MinLowerCase { get; set; }
        public int MinSpecialSymbols { get; set; }
        public int MinNumbers { get; set; }
        public string AllowedSpecialSymbols { get; set; }
        public bool AllowWhiteSpaces { get; set; }
    }
}
