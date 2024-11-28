using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter
{  
  public class Money
  {
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }

    public Money(decimal amount, Currency currency)
    {
      Amount = amount;
      Currency = currency;
    }

    public void ChangeCurrency(CurrencyConverter converter, Currency newCurrency)
    {
      if (Currency == newCurrency)
        return;

      switch (Currency)
      {
        case Currency.Dollar:
          Amount = newCurrency switch
          {
            Currency.SEK => converter.ConvertDollarToSEK(Amount),
            Currency.Euro => converter.ConvertDollarToEuro(Amount),
            _ => Amount
          };
          break;

        case Currency.Euro:
          Amount = newCurrency switch
          {
            Currency.SEK => converter.ConvertEuroToSEK(Amount),
            Currency.Dollar => converter.ConvertEuroToDollar(Amount),
            _ => Amount
          };
          break;

        case Currency.SEK:
          Amount = newCurrency switch
          {
            Currency.Dollar => converter.ConvertSEKToDollar(Amount),
            Currency.Euro => converter.ConvertSEKToEuro(Amount),
            _ => Amount
          };
          break;
      }

      Currency = newCurrency;
    }
  }

}
