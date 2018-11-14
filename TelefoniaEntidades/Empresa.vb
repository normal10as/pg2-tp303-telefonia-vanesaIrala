Public Class Empresa
    Inherits Cliente

    'Campos
    Private _razonSocial As String
    Private _cuit As String

    'Constructor
    'Sub New()

    '    _razonSocial = ""
    '    _cuit = ""
    'End Sub

    'Constructor sobrecargado
    Sub New(razonSocial As String, cuit As String, cuenta As UInteger)
        MyBase.New(cuenta)
        Me.RazonSocial = razonSocial
        Me.Cuit = cuit
    End Sub

    'Propiedades
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 80 Then _razonSocial = value
        End Set
    End Property

    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 13 Then _cuit = value
        End Set
    End Property

    'Metodos
    'ToString
    Public Overrides Function ToString() As String
        Return "Razon Social: " & RazonSocial & " - " & "Cuenta: " & Cuenta
    End Function
End Class
