Public Class Persona
    Inherits Cliente

    'Campos
    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger

    'Constructor
    'Sub New()
    '    _apellido = ""
    '    _nombre = ""
    '    _documento = 0
    'End Sub

    'Constructor sobrecargado
    Sub New(Apellido As String, Nombre As String, Documento As UInteger, cuenta As UInteger)
        MyBase.New(cuenta)
        Me.Apellido = Apellido
        Me.Nombre = Nombre
        Me.Documento = Documento
    End Sub

    'Propiedades
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 30 Then _apellido = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 50 Then _nombre = value
        End Set
    End Property

    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property

    'Metodos
    'ToString
    Public Overrides Function ToString() As String
        Return "Apellido: " & Apellido & " " & "Nombre: " & Nombre & " " & "Cuenta: " & Cuenta
    End Function
End Class
