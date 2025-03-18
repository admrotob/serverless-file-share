using System.Net.Mail;

namespace Ui.Helpers
{
    /// <summary>
    /// A static collection of Email Validation APIs.
    /// </summary>
    public static class EmailValidators
    {
        /// <summary>
        /// Takes a given string and uses the System.Net.Mail API to validate that supplied input is a valid email.
        /// </summary>
        /// <param name="input">A string input to test a supplied email for validity.</param>
        /// <returns>bool (true/false)</returns>
        public static bool IsValidEmail(string input)
        {
            MailAddress? result;
            System.Net.Mail.MailAddress.TryCreate(input, out result);

            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
