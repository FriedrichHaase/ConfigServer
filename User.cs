using System.ComponentModel.DataAnnotations;

namespace TestConfigServer
{
    public class User
    {

        [Key]
        [Required]
        public string UserID { get => NewUserID(); set => NewUserID(); }

        [Required(ErrorMessage = "Please enter your e-mail adress")]
        [Display(Name = "EMail")]
        public string? EMail { get; set; }

        [Required(ErrorMessage ="Please enter a password")]
        [DataType(DataType.Password)]   
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string? ConfPassword { get; set; }

        [Required(ErrorMessage = "Please enter your firstname")]
        [Display(Name = "Firstname")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage ="Please enter your surname")]
        [Display(Name = "Surname")]
        public string? Surname { get; set; }

        [Required]
        public string? CreationDate { get => CurrentDate(); set => CurrentDate(); }

        public User(string eM, string ps, string cps, string fn, string sn)
        {
            NewUserID();
            CurrentDate();
            EMail = eM;
            Password = ps;
            ConfPassword = cps;
            Firstname = fn;
            Surname = sn;
        }

        public User()
        {
            NewUserID();
            CurrentDate();
        }

        private string NewUserID()
        {
            Guid UserID = Guid.NewGuid();
            return UserID.ToString();
        }

        private static string CurrentDate()
        {
            string today = DateTime.UtcNow.ToShortDateString();

            return today;
        }
    }
}
