Module Module1

  Sub Main()
    Dim theGreeting As Greeting
    theGreeting = New Greeting
    theGreeting.Recipient = "Eric"
    theGreeting.Display()
  End Sub

  Sub SayHelloWorld()
    Console.WriteLine("Hello, world!")
  End Sub

  Sub SayHelloTo(ByVal toWhom As String)
    Dim message As String
    message = CalculateGreeting(toWhom)
    Console.WriteLine(message)
  End Sub

  Function CalculateGreeting(ByVal toWhom As String) As String
    Dim message As String

    If toWhom = "Eric" Then
      message = "Hi, " & toWhom
    Else
      message = "Hello, " & toWhom
    End If

    Return message
  End Function

End Module
