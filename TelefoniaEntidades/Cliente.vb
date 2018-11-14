Public MustInherit Class Cliente
    'Campos
    Private _cuenta As UInteger
    Private _Linea As List(Of Linea) 'Asociación Multiple

    'Constructor
    'Sub New()
    '    _cuenta = 0
    '    _Linea = New List(Of Linea)
    'End Sub

    'Constructor Sobrecargado
    Sub New(cuenta As UInteger)
        Me.Cuenta = cuenta
        _Linea = New List(Of Linea)
    End Sub


    'Propiedades
    Public Property Cuenta As String
        Get
            Return _cuenta
        End Get
        Set(value As String)
            _cuenta = value
        End Set
    End Property


    'Metodos
    Public Sub addLinea(linea As Linea)
        _Linea.Add(linea)
    End Sub


    Public Function getAllLineas() As List(Of Linea)
        Return _Linea
    End Function

    Public Sub removeLinea(linea As Linea)
        _Linea.Remove(linea)
    End Sub

End Class
