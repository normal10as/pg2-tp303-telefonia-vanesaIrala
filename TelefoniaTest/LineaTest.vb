Imports TelefoniaEntidades

Module LineaTest
    Sub Main()
        Dim marca23 As New Marca("LG")
        Dim modelo23 As New Modelo("P7", marca23)
        Dim equipo23 As New Equipo(modelo23, "3232_p")
        Dim persona1 As New Persona("Irala", "vanesa", 31313133, 2323)
        Dim linea1 As New Linea(3764, 393939, equipo23, persona1)

        Dim paquete1 As New Paquete()
        paquete1.NombreP = "Total Prem"
        paquete1.precio = 1200
        paquete1.CreditoP = 20000
        Dim sms1 As New SMS(110, 20.3)
        Dim voz1 As New Voz(200, 24.9)
        Dim dato1 As New Dato(100, 30.6)

        paquete1.addServicio(sms1)
        paquete1.addServicio(voz1)
        paquete1.addServicio(dato1)
        linea1.Reactivar()
        linea1.Equipo.Vender(Today.AddDays(-3))

        Console.WriteLine("Linea1, Cliente Persona: ")
        mostrarLinea(linea1, paquete1, persona1)


        '***************************************************************************
        Dim marca1E As New Marca("LG")
        Dim modelo1E As New Modelo("P7", marca1E)
        Dim equipo1E As New Equipo(modelo1E, "3232_p1")
        Dim equipo2E As New Equipo(modelo1E, "3232_p2")
        Dim equipo3E As New Equipo(modelo1E, "3232_p3")

        Dim empresa1 As New Empresa("Carsa", "23-23232323-3", 5555)
        Dim linea1E As New Linea(3764, 393939, equipo1E, empresa1)
        Dim linea2E As New Linea(3764, 454545, equipo2E, empresa1)
        Dim linea3E As New Linea(3764, 878787, equipo3E, empresa1)

        Dim paquete2 As New Paquete()
        paquete2.NombreP = "Total Prem"
        paquete2.precio = 1200
        paquete2.CreditoP = 20000
        Dim sms2 As New SMS(110, 20.3)
        Dim voz2 As New Voz(200, 24.9)
        Dim dato2 As New Dato(100, 30.6)


        empresa1.addLinea(linea1E)
        empresa1.addLinea(linea2E)
        empresa1.addLinea(linea3E)


        paquete2.addServicio(sms1)
        paquete2.addServicio(voz1)
        paquete2.addServicio(dato1)
        linea1E.Reactivar()
        linea1E.Equipo.Vender(Today.AddDays(-3))
        linea2E.Reactivar()
        linea2E.Equipo.Vender(Today.AddDays(-5))
        linea3E.Reactivar()
        linea3E.Equipo.Vender(Today.AddDays(-1))

        Console.WriteLine("Lineas, Cliente Empresa: ")
        mostrarCliente(empresa1)
        Console.WriteLine("eliminamos una linea")
        empresa1.removeLinea(linea2E)

        mostrarCliente(empresa1)
        Console.ReadKey()
    End Sub

    Private Sub mostrarLinea(Linea As Linea, paquete1 As Paquete, persona1 As Cliente)
        Console.WriteLine(persona1.ToString)
        Console.WriteLine("Teléfono: (0" & Linea.CodigoArea & ") " & Linea.Numero & " Estado: " & Linea.Estado)
        mostrarEquipo(Linea.Equipo)
        Console.WriteLine()
        mostrarpaquete(paquete1)
    End Sub

    Private Sub mostrarEquipo(Equipo As Equipo)
        Console.WriteLine("Marca {0} Modelo {1} Serie {2}", Equipo.Modelo.Marca, Equipo.Modelo, Equipo.Serie)
        If Equipo.FechaVenta = Nothing Then
            Console.WriteLine("No fue vendido")
        Else
            Console.WriteLine("Fue vendido el día: " & Equipo.FechaVenta)
        End If
    End Sub

    'Private Sub mostrarServicio(paquete As Paquete)
    '    Console.WriteLine("Nombre: " & paquete.NombreP & ", Precio: " & paquete.precio & ", Disponible: " & paquete.getDisponibleToString)
    '    Console.WriteLine()

    'End Sub

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


    Private Sub mostrarCliente(Cliente As Cliente)
        Console.WriteLine(Cliente.ToString)
        If Cliente.getAllLineas.Count = 0 Then
            Console.WriteLine("**numero de cuenta: {0} no posee líneas" & vbNewLine, Cliente.Cuenta)
        Else
            Console.WriteLine("**Cliente : {0} posee las siguientes líneas:", Cliente.Cuenta)
            For Each Linea As Linea In Cliente.getAllLineas
                mostrarLineas(Linea)
            Next
        End If
    End Sub

    Private Sub mostrarLineas(Linea As Linea)
        Console.WriteLine("Teléfono: (0" & Linea.CodigoArea & ") " & Linea.Numero & " Estado: " & Linea.Estado)
        mostrarEquipo(Linea.Equipo)
        Console.WriteLine()
    End Sub
End Module
