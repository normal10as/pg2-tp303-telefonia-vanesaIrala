Public Class Dato
    Inherits Servicio
    'Constructor sobrecargado
    Sub New(dCredito As UInteger, dPrecio As Decimal)
        MyBase.New()
        Me.Credito = dCredito
        Me.Precio = dPrecio

    End Sub
    Public Overrides Sub NuevoConsumo(valor As UInteger)
        Console.WriteLine("NuevoConsumo overrides")
        Dim mBytes As Integer = 1024 * 1024
        If valor < mBytes Then
            If (valor + _consumo) <= Credito Then
                _consumo += valor
            End If

        End If

    End Sub

    'ToString
    Public Overrides Function ToString() As String
        Return "Mbytes."
    End Function
End Class
