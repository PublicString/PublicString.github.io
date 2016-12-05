using System.Globalization;

namespace Applicant_Reviewer.Classes
{
    class Money
    {
        public decimal Amount { get; set; }
        private readonly Currency currency;

        public Money(decimal amount, int currencyType)
        {
            this.Amount = amount;
            this.currency = (Currency)currencyType;
        }

        /// <summary>
        /// <para>Converts salary amount into (currencySymbol) + (salary decimal)</para>
        /// <para>Eg. $420.69</para>
        /// </summary>
        /// <param name="currencySymbolIndex"></param>
        /// <returns></returns>
        public string ConvertToCurrency(int currencySymbolIndex)
        {
            var culture = this.currency.ToString().Replace('_', '-');
            return this.Amount.ToString("C", CultureInfo.CreateSpecificCulture(culture)); // We can return it as a string as no
                                                                                          // operations are to be done to it.
        }
    }

    /// <summary>
    /// Enum containing all available currencies
    /// </summary>
    public enum Currency
    {
        en_GB, en_US, fr_FR, ja_JP
    }
}
