Imports MySql.Data.MySqlClient

Public Class PAtenciones
    Inherits Conexion

    Private id_atencion As Integer
    Private fecha As String
    Private id_paciente As Integer
    Private id_medico As Integer
    Private id_actividad As Integer


    Private cmd As MySqlCommand

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, fech As String, pac As Integer, med As Integer, act As Integer)
        id_atencion = id
        fecha = fech
        id_paciente = pac
        id_medico = med
        id_actividad = act
    End Sub

    Public Property Ate_Id()
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value

        End Set
    End Property

    Public Property Ate_fecha()
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property

    Public Property Ate_pac()
        Get
            Return id_paciente

        End Get
        Set(value)
            id_paciente = value
        End Set
    End Property

    Public Property Ate_Med()
        Get
            Return id_medico
        End Get
        Set(value)
            id_medico = value
        End Set
    End Property

    Public Property Ate_act()
        Get
            Return id_actividad
        End Get
        Set(value)
            id_actividad = value

        End Set
    End Property

    Public Function consultarAtenciones() As DataTable

        Dim sql As String

        Try
            conectar()
            sql = "select ate.id_atencion, ate.fecha as 'Fecha', p.nombre as 'Paciente', m.nombre as 'Medico', a.nombre as 'Especialidad', a.nombre as 'Actividad'
                from atenciones as ate
                inner join pacientes as p on ate.id_pac=p.id_paciente
                inner join medicos as m on ate.id_medico=m.id_medicos
                inner join especialidades as esp on m.id_esp=esp.id_esp
                inner join actividades as a on ate.id_actividad=a.id_actividad;"

            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            con.Close()
        End Try

    End Function

    Public Function cargarDatosPaciente(id As Integer) As DataTable

        Dim sql As String

        Try
            conectar()
            sql = "SELECT * FROM pacientes where id_paciente = " & id

            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function cargarTxtId(tabla As String, nombre As String) As DataTable
        Dim sql As String

        Try
            conectar()
            sql = "SELECT * FROM " & tabla & " where nombre = '" & nombre & "'"

            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function cargarDatosCmb(tabla As String) As DataTable
        Dim sql As String
        Try
            conectar()
            sql = "SELECT * FROM " & tabla & ""
            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function cargarDatosCmb2(tabla As String, where As String) As DataTable
        Dim sql As String
        Try
            conectar()
            sql = "SELECT * FROM " & tabla & " WHERE id_esp = " & where & ""
            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function agregarAtencion(pa As PAtenciones) As Boolean
        Dim sql As String

        Try
            conectar()

            sql = "INSERT INTO atenciones (id_atencion, fecha, id_pac, id_medico, id_actividad) VALUES ('" &
            pa.id_atencion & "','" & pa.fecha & "','" & pa.id_paciente & "','" & pa.id_medico & "','" & pa.id_actividad & "')"
            cmd = New MySqlCommand(sql, con)


            If cmd.ExecuteNonQuery() Then
                MsgBox("La atención ID " & pa.id_atencion & " se ha ingresado correctamente")

                Return True
            Else
                Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        Finally
            desconectar()
        End Try
    End Function

End Class
