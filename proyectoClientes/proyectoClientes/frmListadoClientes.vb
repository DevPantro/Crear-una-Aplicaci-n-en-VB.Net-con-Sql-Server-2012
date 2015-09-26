Public Class frmListadoClientes

    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VALENCIADataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.VALENCIADataSet.CLIENTE)
        lblTotal.Text = DataGridView1.Rows.Count - 1



    End Sub
End Class