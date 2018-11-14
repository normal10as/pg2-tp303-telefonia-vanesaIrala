Imports TelefoniaEntidades

Public MustInherit Class Servicio
    Implements IPlan

    'Campos
    Private _credito As UInteger
    Private _precio As Decimal
    'Variable
    Protected _consumo As UInteger
    'Constructor
    'Sub New()

    'End Sub


    'Propiedades
    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property

    Public Property Precio As Decimal Implements IPlan.precio
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property


    'Metodos
    Public Overridable Sub NuevoConsumo(valor As UInteger)
        If (valor + _consumo) <= Credito Then
            _consumo = _consumo + valor

        Else
            Console.WriteLine("Credito insuficiente.")

        End If

    End Sub

    Public Function getDisponible() As UInteger
        Return Credito - _consumo
    End Function

    Public Function getDisponibleToString() As String Implements IPlan.getDisponibleToString
        Return Credito - _consumo & " " & ToString()
    End Function

    Public Function getConsumosToString() As String Implements IPlan.getConsumosToString
        Return _consumo & " Consumo Total"
    End Function
End Class
