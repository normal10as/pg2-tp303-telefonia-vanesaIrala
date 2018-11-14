Public Class Marca
    'Campos
    Private _nombreMarca As String

    'Constructor
    Sub New()
        _nombreMarca = ""
    End Sub

    'Constructor sobrecargado
    Sub New(nombreMarca As String)
        Me.NombreMarca = nombreMarca
    End Sub

    Public Property NombreMarca As String
        Get
            Return _nombreMarca
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 30 Then _nombreMarca = value
        End Set
    End Property

    'Metodos
    'ToString
    Public Overrides Function ToString() As String
        Return "Nombre de la Marca: " & NombreMarca
    End Function
End Class
