using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter
{
  public class Account
  {
    public int Id { get; set; }
    public required Money Balance { get; set; }
  }
}
