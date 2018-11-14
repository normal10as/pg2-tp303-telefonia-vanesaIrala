Imports TelefoniaEntidades
Module VozTest

    Sub Main()
        Dim voz1 As New Voz(1000, 10.8)
        Console.WriteLine("Credido: " & voz1.Credito)
        Console.WriteLine("Precio: " & voz1.Precio)
        voz1.NuevoConsumo(30)

        Console.WriteLine("*************Nuevo Credito de Voz1*****************")
        Console.WriteLine(voz1.getDisponible & " " & voz1.ToString)
        Console.WriteLine(voz1.getDisponible & " " & "disponibles.")
        Console.WriteLine("*******Interface*******")
        Console.WriteLine(voz1.getDisponibleToString)
        Console.WriteLine(voz1.getConsumosToString)
        voz1.NuevoConsumo(300)

        Console.WriteLine("*************Nuevo Credito de voz*****************")
        Console.WriteLine(voz1.getDisponible & " " & voz1.ToString)
        Console.WriteLine(voz1.getDisponible & " " & "disponibles.")
        Console.WriteLine("*******Interface*******")
        Console.WriteLine(voz1.getDisponibleToString)
        Console.WriteLine(voz1.getConsumosToString)
        voz1.NuevoConsumo(670)
        Console.WriteLine("*************Nuevo Credito de voz*****************")
        Console.WriteLine(voz1.getDisponible & " " & voz1.ToString)
        Console.WriteLine(voz1.getDisponible & " " & "disponibles.")
        Console.WriteLine("*******Interface*******")
        Console.WriteLine(voz1.getDisponibleToString)
        Console.WriteLine(voz1.getConsumosToString)

        Console.ReadKey()
    End Sub

End Module
