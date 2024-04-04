Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        a = txtmonthinc.Text
        b = txttranspo.Text
        c = txtgroc.Text
        d = txtenter.Text
        txttotalexp.Text = b + c + d
        txtremain.Text = (a) - (b + c + d)
        If txttotalexp.Text > txtmonthinc.Text Then MessageBox.Show("Your don't have remaining Balance!!")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtmonthinc.Text = String.Empty
        txttranspo.Text = String.Empty
        txtgroc.Text = String.Empty
        txtenter.Text = String.Empty
        txttotalexp.Text = String.Empty
        txtremain.Text = String.Empty
    End Sub
End Class
