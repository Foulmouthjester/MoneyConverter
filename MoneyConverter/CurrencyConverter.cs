using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter
{
  public class CurrencyConverter
  {
    public decimal Dollar { get; }
    public decimal Euro { get; }
    public decimal SEK { get; }

    public CurrencyConverter(decimal sek, decimal euro, decimal dollar)
    {
      SEK = sek;
      Euro = euro;
      Dollar = dollar;
    }

    public decimal ConvertDollarToSEK(decimal amount) => amount / Dollar;
    public decimal ConvertSEKToDollar(decimal amount) => amount * Dollar;

    public decimal ConvertEuroToSEK(decimal amount) => amount / Euro;
    public decimal ConvertSEKToEuro(decimal amount) => amount * Euro;

    public decimal ConvertDollarToEuro(decimal amount) => amount * (Euro / Dollar);
    public decimal ConvertEuroToDollar(decimal amount) => amount * (Dollar / Euro);
  }
}
