Public Class LAtenciones

    Public Function consultarAtenciones() As DataTable
        Try
            Dim pa As New PAtenciones
            Dim dt As New DataTable

            dt = pa.consultarAtenciones()

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function cargarDatosPaciente(id As Integer) As DataTable
        Try
            Dim pa As New PAtenciones
            Dim dt As New DataTable

            dt = pa.cargarDatosPaciente(id)

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function cargarTxtId(tabla As String, nombre As String) As DataTable
        Try
            Dim pa As New PAtenciones
            Dim dt As New DataTable

            dt = pa.cargarTxtId(tabla, nombre)

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function cargarDatosCmb(tabla As String) As DataTable
        Try
            Dim pa As New PAtenciones
            Dim dt As New DataTable

            dt = pa.cargarDatosCmb(tabla)

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function cargarDatosCmb2(tabla As String, where As String) As DataTable
        Try
            Dim pa As New PAtenciones
            Dim dt As New DataTable

            dt = pa.cargarDatosCmb2(tabla, where)

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function agregarAtencion(id As Integer, fecha As String, idPac As Integer, idMed As String, idAct As String) As Boolean
        Dim pa As New PAtenciones(id, fecha, idPac, idMed, idAct)

        If pa.agregarAtencion(pa) = True Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
