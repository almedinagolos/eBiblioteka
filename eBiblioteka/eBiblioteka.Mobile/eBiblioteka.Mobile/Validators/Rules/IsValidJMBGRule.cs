using System.Text.RegularExpressions;
using Xamarin.Forms.Internals;

namespace eBiblioteka.Mobile.Validators.Rules
{
    /// <summary>
    /// Validation Rule to check the email is valid or not.
    /// </summary>
    /// <typeparam name="T">Valid email rule parameter</typeparam>
    [Preserve(AllMembers = true)]
    public class IsValidJMBGRule<T> : IValidationRule<T>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Validation Message.
        /// </summary>
        public string ValidationMessage { get; set; }

        #endregion

        #region Method

        /// <summary>
        /// Check the email has valid or not
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns>returns bool value</returns>
        public bool Check(T value)
        {
            try
            {
                string jmbg = value.ToString();
                return Regex.IsMatch(jmbg, "^[0-9]{13}$");
            }
            catch
            {
                return false;
                throw;
            }
        }
        #endregion
    }
}
