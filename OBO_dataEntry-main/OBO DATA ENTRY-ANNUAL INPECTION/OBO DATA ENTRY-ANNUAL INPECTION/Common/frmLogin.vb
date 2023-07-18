
Imports System.Data.SqlClient

Public Class frmLogin
    ' Private CS As New ChatServer
    Private Sub Login()
        BarangayUser = False
        Try

            sqL = "SELECT * FROM tblLogin " & _
                "WHERE  Username = '" & txtUsername.Text & "' AND pw ='" & txtPassword.Text & "'"
            ConnDB()
            cmd = New SqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)


            If dr.Read = True Then
              
                
                xUser_ID = dr!idno.ToString
                Audit_Trail(xUser_ID, "Log-in")

                Dispose()
                 
                frmMain.Text = StrConv(store, VbStrConv.ProperCase) & "    Version : " & My.Application.Deployment.CurrentVersion.ToString

            Else
                MsgBox("Ïnvalid Account")
            End If
        Catch ex As Exception
            ErrorMessage(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If lblStatus.Text = "Offline" Then
            If IsConnected(strServer, strUser, strPass) = True Then
                lblStatus.Text = "Online"
            Else
                lblStatus.Text = "Offline"
            End If
        End If

        If lblStatus.Text = "Offline" Then
            MsgBox("Server Cannot be Reached!", MsgBoxStyle.Critical, "Please Check and Verify Server Configuration")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        lblwait.Visible = True
        lblwait.Text = "Please wait....."
        Login()
          Dim objServerDateTime As New serverdateandtime
        objServerDateTime.GetServerDateTime()
        'GEt COunter No and Machine if Registered

        Me.Cursor = Cursors.WaitCursor
        lblwait.Visible = False


       
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmScanCode.Dispose()
            frmScanCode.ShowDialog()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar() = ControlChars.Cr Then
            btnlogin.PerformClick()

        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmScanCode.Dispose()
            frmScanCode.ShowDialog()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar() = ControlChars.Cr Then
            '' Login()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmMain.Dispose()
        End
    End Sub
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreVentFlicker()
        DoubleBuffered = True
        SuspendLayout()
        ResumeLayout()
        txtPassword.Text = ""
        txtUsername.Text = ""

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        ButtonFlatStyle(Me)
        Me.BackColor = Color.Transparent
        If IsConnected(strServer, strUser, strPass) = True Then
            lblStatus.Text = "Online"
        Else
            lblStatus.Text = "Offline"
        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label3.Click
        frmserver.Dispose()
        frmserver.ShowDialog()
        connect()
        If IsConnected(strServer, strUser, strPass) = True Then
            lblStatus.Text = "Online"
        Else
            lblStatus.Text = "Offline"
        End If
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        frmScanCode.Dispose()
        frmScanCode.ShowDialog()
    End Sub

End Class