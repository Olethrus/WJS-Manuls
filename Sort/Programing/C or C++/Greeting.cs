using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApplication
{
  class Greeting
  {
    private string _recipient;

    public Greeting()
    {
      _recipient = "Stranger";
    }

    public void Display()
    {
      string message = "Hello, " + _recipient;
      Console.WriteLine( message );
    }

    public string Recipient
    {
      get { return _recipient; }
      set { _recipient = value; }
    }
  }
}
