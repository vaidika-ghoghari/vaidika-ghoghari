Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblpass.Click

    End Sub



    Private Sub txtusernm_Leave(sender As Object, e As EventArgs) Handles txtusernm.Leave
        If String.IsNullOrEmpty(txtusernm.Text) = True Then
            txtusernm.Focus()
            ErrorProvider1.SetError(Me.txtusernm, "Please Enter Username")
        Else
            ErrorProvider1.Clear()


        End If
    End Sub


    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave
        If String.IsNullOrEmpty(txtpass.Text) = True Then
            txtpass.Focus()
            ErrorProvider2.SetError(Me.txtpass, "Please Enter password")
        Else
            ErrorProvider2.Clear()


        End If
    End Sub

    Private Sub chbpass_CheckedChanged(sender As Object, e As EventArgs) Handles chbpass.CheckedChanged
        If chbpass.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim con As OleDbConnection(Provider=Microsoft.ACE.OLEDB.12.0;Data Source= "C:\Users\Admin\OneDrive\Tài liệu\Lace anagement System.accdb")
            con.open()
        Dim query As String = "select * from Login where Username=@user and Password=@pass"
        Dim cmd As oledbCommand(query, con)
        cmd.parameters.AddWithValue("@user", txtusernm.Text)
        cmd.parameters.AddWithValue("@user", txtpass.Text)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRow = True Then
            MessageBox.Show("Login Successfully.", "success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Login Failed.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If
    End Sub
End Class