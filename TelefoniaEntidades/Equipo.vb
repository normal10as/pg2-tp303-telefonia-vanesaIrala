Public Class Equipo
    'Campos
    Private _serie As String
    Private _FechaVenta As Date 'REadOnly
    Private _Modelo As Modelo 'Asociación Simple

    'Constructor
    Sub New()
        _serie = ""
        _Modelo = New Modelo
    End Sub

    'Constructor sobrecargado
    Sub New(Modelo As Modelo, Serie As String)

        Me.Serie = Serie
        Me.Modelo = Modelo
    End Sub

    'Propiedades
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 15 Then _serie = value
        End Set
    End Property

    Public ReadOnly Property FechaVenta As String
        Get
            Return _FechaVenta
        End Get

    End Property



    Public Property Modelo As Modelo
        Get
            Return _Modelo
        End Get
        Set(value As Modelo)
            _Modelo = value
        End Set
    End Property

    'Metodos

    Public Sub Vender(value As Date)
        _FechaVenta = value
    End Sub

    'ToString
    Public Overrides Function ToString() As String
        Return "Nombre de la Serie: " & Serie
    End Function


End Class
