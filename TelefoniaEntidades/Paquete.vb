Imports TelefoniaEntidades

Public Class Paquete
    Implements IPlan
    'Campos
    Private _nombreP As String
    Private _servicio As List(Of Servicio) 'Asociación Multiple
    Private _creditoP As UInteger
    Private _precio As Decimal
    'Variable
    Protected _consumoP As UInteger
    'Constructor
    Sub New()
        _nombreP = ""
        _servicio = New List(Of Servicio)
    End Sub

    Public Property CreditoP As UInteger
        Get
            Return _creditoP
        End Get
        Set(value As UInteger)
            _creditoP = value
        End Set
    End Property
    'Propiedades
    Public Property NombreP As String
        Get
            Return _nombreP
        End Get
        Set(value As String)
            _nombreP = value
        End Set
    End Property

    Public Property precio As Decimal Implements IPlan.precio
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    'Metodos
    Public Sub addServicio(Servicio As Servicio)
        _servicio.Add(Servicio)
    End Sub

    Public Sub removeServicio(Servicio As Servicio)
        _servicio.Remove(Servicio)
    End Sub

    Public Function getAllServicio() As List(Of Servicio)
        Return _servicio
    End Function

    Public Function getDisponibleToString() As String Implements IPlan.getDisponibleToString
        Return CreditoP - _consumoP & " Disponible"
    End Function

    Public Function getConsumosToString() As String Implements IPlan.getConsumosToString
        Return _consumoP & " Consumo Total"
    End Function
End Class
