Imports TelefoniaEntidades
Module EquipoTest
    Sub Main()

        Dim equipo1 As New Equipo
        equipo1.Serie = "C.23"

        Dim Marca1 As New Marca("Samsung")

        Dim modelo1 As New Modelo("e-34", Marca1)



        equipo1.Vender(Today.AddDays(-3))

        equipo1.Modelo = modelo1


        Console.WriteLine("*************Equipo1*****************")
        Console.WriteLine("Fecha de Venta: " & equipo1.FechaVenta)
        Console.WriteLine("Equipo serie: " & equipo1.Serie)

        Console.WriteLine(equipo1.Modelo.ToString())

        Console.WriteLine("Marca: " & equipo1.Modelo.Marca.NombreMarca)
        Console.WriteLine("TOstring: " & equipo1.ToString)
        Console.ReadKey()
    End Sub
End Module
