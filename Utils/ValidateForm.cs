using System.Text.RegularExpressions;

namespace PRN211_ShoesStore.Utils
{
    public static class ValidateForm
    {
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Match match = Regex.Match(email, emailPattern);
            return match.Success;
        }
    }
}
