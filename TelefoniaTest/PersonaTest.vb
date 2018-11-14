Imports TelefoniaEntidades
Module PersonaTest
    Sub Main()
        'Dim persona1 As New Persona
        Dim persona2 As New Persona("Ibañez,", "Martin Gabriel.", 29989460, 8888)

        'persona1.Apellido = "Irala,"
        'persona1.Nombre = "Vanesa Soledad."
        'persona1.Documento = 31361145
        'persona1.Cuenta = 12345

        persona2.Cuenta = 23456

        Console.WriteLine("*************Persona1*****************")
        'Console.WriteLine(persona1.ToString)
        'Console.WriteLine("Numero de Documento: " & persona1.Documento)


        Console.WriteLine("*************Persona2*****************")
        Console.WriteLine(persona2.ToString)
        Console.WriteLine("Numero de Documento: " & persona2.Documento)


        Console.ReadKey()
    End Sub
End Module
