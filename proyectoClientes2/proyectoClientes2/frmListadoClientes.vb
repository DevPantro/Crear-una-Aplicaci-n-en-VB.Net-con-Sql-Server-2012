Imports System.Data.SqlClient
Imports System.Data


Public Class frmListadoClientes

    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListarClientes()

    End Sub

    Sub ListarClientes()
        Dim cn As New SqlConnection("SERVER=.;DATABASE=VALENCIA;INTEGRATED SECURITY=SSPI")
        Dim sa As New SqlDataAdapter("SELECT CODI_CLI AS CODIGO, DESC_CLI AS CLIENTE, DNI_CLI AS DNI FROM CLIENTE", cn)
        Dim ds As New DataSet
        sa.Fill(ds, "CLIENTE")
        DataGridView1.DataSource = ds.Tables("CLIENTE")
        lblTotal.Text = ds.Tables("CLIENTE").Rows.Count


    End Sub
End Class