Imports TelefoniaEntidades
Module MarcaTest
    Sub Main()


        Dim marca1 As New Marca
        Dim marca2 As New Marca("Nokia")

        marca1.NombreMarca = "Samsung"


        Console.WriteLine("*************Marca1*****************")
        Console.WriteLine("Marca: " & marca1.NombreMarca)
        Console.WriteLine(marca1.ToString)

        Console.WriteLine("*************Marca2*****************")
        Console.WriteLine("Marca: " & marca2.NombreMarca)
        Console.WriteLine(marca2.ToString)


        Console.ReadKey()
    End Sub
End Module
