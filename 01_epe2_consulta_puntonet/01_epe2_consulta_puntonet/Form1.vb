Public Class Form1
    Private Sub listarAtencionesBtn_Click(sender As Object, e As EventArgs) Handles listarAtencionesBtn.Click
        Dim la As New LAtenciones

        Try
            Dim dt = la.consultarAtenciones()

            dgvAtenciones.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datosPacBtn_Click(sender As Object, e As EventArgs) Handles datosPacBtn.Click
        Dim la As New LAtenciones
        Dim dr As DataRow
        Try
            Dim dt = la.cargarDatosPaciente(Integer.Parse(idPacienteTxt.Text))
            dr = dt.Rows.Item(0)

            nomCteTxt.Text = dr.Item("nombre")
            edadCteTxt.Text = dr.Item("edad")
            dirCteTxt.Text = dr.Item("direccion")
            telCteTxt.Text = dr.Item("telefono")
        Catch ex As Exception
            MsgBox("El cliente ingresado no existe.")

        End Try
    End Sub

    Private Sub cmbDatos(tabla As String, cmbDatos As ComboBox)
        Try

            Dim la As New LAtenciones

            Dim dt As New DataTable

            Dim dr As DataRow
            dt = la.cargarDatosCmb(tabla)


            For i = 0 To (dt.Rows.Count - 1)
                dr = dt.Rows(i)
                cmbDatos.Items.Add(dr.Item("nombre"))
            Next
        Catch ex As Exception

            MsgBox("No se cargaron los nombres")

        End Try
    End Sub

    Private Sub cmbDatos2(tabla As String, cmbDatos As ComboBox, where As String)
        Try

            Dim la As New LAtenciones

            Dim dt As New DataTable

            Dim dr As DataRow
            If where IsNot "" Then
                dt = la.cargarDatosCmb2(tabla, where)
                For i = 0 To (dt.Rows.Count - 1)
                    dr = dt.Rows(i)
                    cmbDatos.Items.Add(dr.Item("nombre"))
                Next
            End If

        Catch ex As Exception

            MsgBox("No se cargaron los nombres")

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDatos("especialidades", cmbEspecialidad)
        For i = 1 To 31
            cmbDia.Items.Add(i)
        Next

        For i = 1 To 12
            cmbMes.Items.Add(i)
        Next

        For i = 1985 To 2024
            cmbAnio.Items.Add(i)
        Next
    End Sub


    Private Sub txtIdEsp_TextChanged(sender As Object, e As EventArgs) Handles txtIdEsp.TextChanged
        cmbActividad.Items.Clear()
        cmbMedico.Items.Clear()
        Try
            cmbDatos2("medicos", cmbMedico, txtIdEsp.Text)
            cmbDatos2("actividades", cmbActividad, txtIdEsp.Text)
        Catch ex As Exception
            cmbActividad.Items.Clear()
            cmbMedico.Items.Clear()
        End Try

    End Sub

    Private Sub cmbEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecialidad.SelectedIndexChanged
        Dim la As New LAtenciones
        Dim dr As DataRow
        Try
            Dim dt = la.cargarTxtId("especialidades", cmbEspecialidad.Text)
            dr = dt.Rows.Item(0)

            txtIdEsp.Text = dr.Item(0)
        Catch ex As Exception
            MsgBox("La especialidad ingresado no existe.")

        End Try
    End Sub

    Private Sub cmbMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedico.SelectedIndexChanged
        Dim la As New LAtenciones
        Dim dr As DataRow
        Try
            Dim dt = la.cargarTxtId("medicos", cmbMedico.Text)
            dr = dt.Rows.Item(0)

            txtIdMed.Text = dr.Item(0)
        Catch ex As Exception
            MsgBox("El medico ingresado no existe.")

        End Try
    End Sub

    Private Sub cmbActividad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbActividad.SelectedIndexChanged
        Dim la As New LAtenciones
        Dim dr As DataRow
        Try
            Dim dt = la.cargarTxtId("actividades", cmbActividad.Text)
            dr = dt.Rows.Item(0)

            txtIdAct.Text = dr.Item(0)
        Catch ex As Exception
            MsgBox("La actividad ingresado no existe.")

        End Try
    End Sub

    Private Sub ingresarBtn_Click(sender As Object, e As EventArgs) Handles ingresarBtn.Click
        Try
            Dim la As New LAtenciones
            Dim fecha As String
            fecha = cmbDia.Text & "-" & "-" & cmbMes.Text & "-" & cmbAnio.Text
            If txtIdAte.Text IsNot "" And fecha IsNot "" And idPacienteTxt.Text IsNot "" And txtIdMed.Text IsNot "" And txtIdEsp.Text IsNot "" Then
                la.agregarAtencion(txtIdAte.Text, fecha, idPacienteTxt.Text, txtIdMed.Text, txtIdAct.Text)
            Else
                MsgBox("Los campos de texto y selección multiple no pueden estar vacios.")
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub
End Class
