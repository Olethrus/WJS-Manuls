Public Class Greeting

  Private _recipient As String

  Public Sub New()
    _recipient = "Stranger"
  End Sub

  Public Sub Display()
    Dim message As String = "Hello, " & _recipient
    Console.WriteLine(message)
  End Sub

  Public Property Recipient() As String
    Get
      Return _recipient
    End Get
    Set(ByVal value As String)
      _recipient = value
    End Set
  End Property
End Class
