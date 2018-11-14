Public Class Voz
    Inherits Servicio


    'Constructor sobrecargado
    Sub New(vCredito As UInteger, vPrecio As Decimal)
        MyBase.Credito = vCredito
        MyBase.Precio = vPrecio

    End Sub

    'ToString
    Public Overrides Function ToString() As String
        Return "Minutos."
    End Function
End Class
