Public Class Linea
    'Campos
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String 'REadOnly
    Private _equipo As Equipo 'Asociación Simple
    Private _cliente As Cliente 'Asociación Simple (bidireccional)
    Private _plan As IPlan 'Asociación Simple

    'Variables
    Private _Activo As Boolean

    'Constructor
    Sub New()
        _codigoArea = 0
        _numero = 0
        _equipo = New Equipo
        Me.Cliente = Cliente


    End Sub

    'Constructor sobrecargado
    Sub New(codigoArea As UShort, numero As UInteger, equipo As Equipo, cliente As Cliente)
        Me.CodigoArea = codigoArea
        Me.Numero = numero
        Me.Equipo = equipo

        'cliente.addLinea(Me)
        'Me.Cliente = cliente
    End Sub

    'Propiedades
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value >= 100 And value <= 9999 Then _codigoArea = value

        End Set
    End Property

    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value >= 100000 And value <= 9999999 Then _numero = value

        End Set
    End Property


    Public ReadOnly Property Estado As String
        Get
            Return If(_Activo, "Activo", "Suspendido")
        End Get

    End Property

    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Set(value As Equipo)
            _equipo = value
        End Set
    End Property

    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get

        Set(value As Cliente)

            _cliente = value
        End Set
    End Property

    Public Property Plan As IPlan
        Get
            Return _plan
        End Get
        Set(value As IPlan)
            _plan = value
        End Set
    End Property

    'Metodos
    Public Sub Suspender()
        _Activo = False
    End Sub

    Public Sub Reactivar()
        _Activo = True
    End Sub

    'ToString
    Public Overrides Function ToString() As String
        Return "Codigo Area: " & CodigoArea & " " & "Numero: " & Numero & " " & "Estado: " & Estado
    End Function



End Class
