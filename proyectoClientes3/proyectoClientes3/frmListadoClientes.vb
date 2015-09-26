Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmListadoClientes

    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
    End Sub
    Sub ListarClientes()
        Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        Using da As New SqlDataAdapter("sp_ListarClientes", cn)
            Using ds As New DataSet
                da.Fill(ds, "CLIENTE")
                DataGridView1.DataSource = ds.Tables("CLIENTE")
                lblTotal.Text = ds.Tables("CLIENTE").Rows.Count

            End Using

        End Using
    End Sub

End Class