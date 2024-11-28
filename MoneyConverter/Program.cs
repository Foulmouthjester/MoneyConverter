// See https://aka.ms/new-console-template for more information

using System; 
using MoneyConverter;

class Program
{
  static void Main(string[] args)
  {
    //CurrencyConverter with predefined rates
    var converter = new CurrencyConverter(sek: 1, euro: 0.085m, dollar: 0.095m);

    //Money in SEK
    var myMoney = new Money(1000, Currency.SEK);

    //Initial Money
    Console.WriteLine($"Initial Money: {myMoney.Amount} {myMoney.Currency}");

    //Convert to Dollar
    myMoney.ChangeCurrency(converter, Currency.Dollar);
    Console.WriteLine($"After Conversion to Dollar: {myMoney.Amount:F2} {myMoney.Currency}");

    //Convert to Euro
    myMoney.ChangeCurrency(converter, Currency.Euro);
    Console.WriteLine($"After Conversion to Euro: {myMoney.Amount:F2} {myMoney.Currency}");
  }
}