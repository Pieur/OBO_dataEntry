Public Class frmScanCode

    Private Sub txtScan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScan.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim varID As String = Split(txtScan.Text, "%")(1)
                If Get_SingleData("select staffid from staff where staffid ='" & varID & "'") = Nothing Then
                    MsgBox("Invalid Code Entered!", MsgBoxStyle.Information, "System Reminder")
                Else
                    frmLogin.txtUsername.Text = Get_SingleData("select username from users where staffid ='" & varID & "'")
                    frmLogin.txtPassword.Text = Get_SingleData("select pwd from users where staffid ='" & varID & "'")
                    frmLogin.btnlogin.PerformClick()
                    Dispose()

                End If
            Catch ex As Exception
                MsgBox("Invalid Code Entered!", MsgBoxStyle.Information, "System Reminder")
                txtScan.Clear()
                Exit Sub
            End Try
          
        ElseIf e.KeyCode = Keys.F1 Then
            Dispose()
        End If
    End Sub

    Private Sub txtScan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScan.TextChanged

    End Sub

    Private Sub frmScanCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dispose()
        End If
    End Sub

    Private Sub frmScanCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class