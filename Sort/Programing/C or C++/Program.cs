using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApplication
{
  class Program
  {
    static void Main( string[] args )
    {
      Console.Write( "Please enter your name: " );
      string name = Console.ReadLine();

      while ( name != "" )
      {
        SayHelloTo( name );
        Console.Write( "Please enter your name: " );
        name = Console.ReadLine();
      }
    }

    static void Main( string[] args )
    {
      Greeting theGreeting;
      theGreeting = new Greeting();
      theGreeting.Recipient = "Eric";
      theGreeting.Display();
    }

    static void SayHelloWorld()
    {
      Console.WriteLine( "Hello, World!" );
    }

    static void SayHelloTo( string toWhom )
    {
      string message = CalculateGreeting( toWhom );
      Console.WriteLine( message );
    }

    static string CalculateGreeting( string toWhom )
    {
      string message;
      if ( toWhom == "Eric" )
      {
        message = "Hi, " + toWhom;
      }
      else
      {
        message = "Hello, " + toWhom;
      }
      return message;
    }

  }
}
