Imports TelefoniaEntidades
Module PaqueteTest
    Sub Main()
        Dim paquete1 As Paquete
        paquete1 = New Paquete
        Dim paquete2 As New Paquete()


        Dim sms1 As New SMS(110, 20.3)
        Dim voz1 As New Voz(200, 24.9)
        Dim dato1 As New Dato(100, 30.6)
        paquete1.NombreP = "Total"
        paquete1.precio = 1200
        paquete1.CreditoP = 20000
        paquete1.addServicio(sms1)
        paquete1.addServicio(voz1)
        paquete1.addServicio(dato1)


        Console.WriteLine("*******Interface*******")
        Console.WriteLine(paquete1.getDisponibleToString)
        Console.WriteLine("*******Mostrar paquete 1*******")

        mostrarpaquete(paquete1)
        paquete1.removeServicio(dato1)
        voz1.NuevoConsumo(100)
        Console.WriteLine("*******Mostrar paquete 1 remover un servicio*******")
        mostrarpaquete(paquete1)
        Console.WriteLine("*******Mostrar paquete2 *******")

        mostrarpaquete(paquete2)
        Console.ReadKey()
    End Sub

    Private Sub mostrarpaquete(paquete As Paquete)
        Console.Write("El paquete")
        If paquete.getAllServicio.Count = 0 Then
            Console.WriteLine(" no posee servicios")
        Else
            Console.WriteLine(" posee los siguientes servicios:")
            For Each plan As Servicio In paquete.getAllServicio
                mostrarplan(plan)
            Next
        End If
        Console.WriteLine()
    End Sub

    Private Sub mostrarplan(servicios As Servicio)
        Console.WriteLine("Credito: {0} Precio: {1} getDisponible: {2}", servicios.Credito, servicios.Precio, servicios.getDisponibleToString)
    End Sub

End Module
