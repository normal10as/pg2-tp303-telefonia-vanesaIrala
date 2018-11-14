Imports TelefoniaEntidades
Module DatoTest
    Sub Main()
        Dim dato1 As New Dato(1000000, 10.8)

        Console.WriteLine("Credido: " & dato1.Credito)
        Console.WriteLine("Precio: " & dato1.Precio)
        Console.WriteLine(dato1.ToString)
        dato1.NuevoConsumo(300000)

        Console.WriteLine(dato1.getDisponible & " " & dato1.ToString)
        Console.WriteLine(dato1.getDisponible & " " & "disponibles.")
        Console.WriteLine("*******Interface*******")
        Console.WriteLine(dato1.getDisponibleToString)
        Console.WriteLine(dato1.getConsumosToString)
        dato1.NuevoConsumo(9000)

        Console.WriteLine("*************Nuevo Credito de voz1*****************")
        Console.WriteLine(dato1.getDisponible & " " & dato1.ToString)
        Console.WriteLine(dato1.getDisponible & " " & "disponibles.")
        Console.WriteLine("*******Interface*******")
        Console.WriteLine(dato1.getDisponibleToString)
        Console.WriteLine(dato1.getConsumosToString)
        dato1.NuevoConsumo(6000)
        Console.WriteLine("*************Nuevo Credito de voz2*****************")
        Console.WriteLine(dato1.getDisponible & " " & dato1.ToString)
        Console.WriteLine(dato1.getDisponible & " " & "disponibles.")
        Console.WriteLine("*******Interface*******")
        Console.WriteLine(dato1.getDisponibleToString)
        Console.WriteLine(dato1.getConsumosToString)

        Console.ReadKey()
    End Sub
End Module
