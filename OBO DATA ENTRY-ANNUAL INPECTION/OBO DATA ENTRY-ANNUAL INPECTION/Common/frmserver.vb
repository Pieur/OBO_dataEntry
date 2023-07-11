Imports System.IO
Imports System.Data.SqlClient

Public Class frmserver

    Dim ch As Integer = 1
    Private Sub cmdconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdconnect.Click
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\conn.ini") Then
            File.SetAttributes(Application.StartupPath & "\conn.ini", FileAttributes.Normal)
        End If

        strServer = txtserver.Text
        strUser = txtuser.Text
        strPass = txtpass.Text
        strDbase = txtdbase.Text
        strStation = txtStation.Text.ToUpper.Trim

        Dim data As String() = {strServer, strUser, strPass, strDbase, strStation}
        Dim s As String
        Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\conn.ini")
            For Each s In data
                sw.WriteLine(MessageTransposition(s, True))
            Next s
            File.SetAttributes(Application.StartupPath & "\conn.ini", FileAttributes.Hidden)

        End Using

        '''''''Create Record of Server
        RecordServer()
        '============================
        connect()
        Me.Close()

    End Sub
    Private Sub RecordServer()
        Try
            strServer = txtserver.Text
            Dim data As String() = {strServer, strPass, strDbase, strStation}
            Dim s As String
            Using sw As StreamWriter = New StreamWriter("C:\POS\Config.txt")
                For Each s In data
                    sw.WriteLine(MessageTransposition(s, True))
                Next s
                File.SetAttributes("C:\POS\Config.txt", FileAttributes.Hidden)
            End Using
        Catch ex As Exception

        End Try

        Dispose()
    End Sub

#Region "Keydown Code"
    Private Sub txtserver_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtserver.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtuser.Focus()
        End If
    End Sub
    Private Sub txtport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpass.Focus()
        End If
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Close()
    End Sub
    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdbase.Focus()
        End If
    End Sub

    Private Sub txtdbase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdbase.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdconnect.PerformClick()
        End If
    End Sub
#End Region
      Private Sub frmserver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Directory.Exists("C:\POS") = True Then
            '    On Error Resume Next
            If My.Computer.FileSystem.FileExists("C:\POS\Config.txt") Then
                File.SetAttributes("C:\POS\Config.txt", FileAttributes.Normal)
                Try
                    Dim CON() As String = (File.ReadAllLines("C:\POS\Config.txt"))
                    txtserver.Text = MessageTransposition(CON(0).ToString, False)
                    txtpass.Text = MessageTransposition(CON(1).ToString, False)
                    txtdbase.Text = MessageTransposition(CON(2).ToString, False)
                    txtStation.Text = MessageTransposition(CON(3).ToString, False)
                Catch ex As Exception

                End Try
              
            Else
                RecordServer()
            End If
        Else
            Directory.CreateDirectory("C:\POS")
        End If

    End Sub
End Class