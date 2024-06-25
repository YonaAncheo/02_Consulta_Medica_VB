Imports MySql.Data.MySqlClient

Public Class Conexion
    Protected con As New MySqlConnection("server=localhost;database=consulta_medica_epe2_vsnet;user=Yona;password='ipchile'")

    Public Function conectar() As Boolean
        Try
            con.Open()

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)

            Return False
        End Try
    End Function

    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then

                con.Close()

            End If
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub
End Class
