Public Class Modelo
    'Campos
    Private _nombreModelo As String
    Private _Marca As Marca 'Asociación Simple
    'Constructor
    Sub New()
        _nombreModelo = ""
        _Marca = New Marca

    End Sub

    'Constructor sobrecargado
    Sub New(nombreModelo As String, marca As Marca)
        Me.Marca = marca
        Me.NombreModelo = nombreModelo
    End Sub

    'Propiedades
    Public Property NombreModelo As String
        Get
            Return _nombreModelo
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 50 Then _nombreModelo = value
        End Set
    End Property

    Public Property Marca As Marca
        Get
            Return _Marca
        End Get
        Set(value As Marca)
            _Marca = value
        End Set
    End Property

    'Metodos
    'ToString
    Public Overrides Function ToString() As String
        Return "Modelo: " & NombreModelo
    End Function
End Class
