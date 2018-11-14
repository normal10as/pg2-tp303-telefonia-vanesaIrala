Imports TelefoniaEntidades
Module ModeloTests
    Sub Main()
        Dim modelo1 As New Modelo
        Dim Marca1 As New Marca("Nokia")
        Dim modelo2 As New Modelo("3-44", Marca1)

        modelo1.NombreModelo = "e-5"
        modelo1.Marca.NombreMarca = "Sony"


        Console.WriteLine("*************Modelo1*****************")
        Console.WriteLine("Modelo: " & modelo1.NombreModelo)
        Console.WriteLine("Marca: " & modelo1.Marca.NombreMarca)
        Console.WriteLine(modelo1.ToString)

        Console.WriteLine("*************Modelo2*****************")
        Console.WriteLine("Modelo: " & modelo2.NombreModelo)
        Console.WriteLine("Marca: " & modelo2.Marca.NombreMarca)
        Console.WriteLine(modelo2.ToString)

        Console.ReadKey()
    End Sub
End Module
