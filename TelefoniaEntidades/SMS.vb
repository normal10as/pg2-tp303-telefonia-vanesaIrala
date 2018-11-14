Public Class SMS
    Inherits Servicio
    'Constructor sobrecargado
    Sub New(sCredito As UInteger, sPrecio As Decimal)
        MyBase.New()
        Me.Credito = sCredito
        Me.Precio = sPrecio

    End Sub

    'ToString
    Public Overrides Function ToString() As String
        Return "Mensajes."
    End Function
End Class
