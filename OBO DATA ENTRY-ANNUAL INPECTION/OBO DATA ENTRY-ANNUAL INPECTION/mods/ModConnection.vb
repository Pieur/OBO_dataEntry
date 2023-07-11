
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Win32
Imports System.Net.NetworkInformation
Imports System.Configuration
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Public Module ModConnection

    Public cur As Form
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public sqlDT As New DataTable
    Public sqL As String
    Public store As String
    Public xUser_ID As String
    Public esadd, CONTACT As String
    Public tin As String
    Public autogo As Boolean = True
    Public vbmode As String
    Public strServer As String = "DRUGS-PC\DRUGS"
    Public strDbase As String = "posinventorydb"   'Database name
    Public strUser As String = "sa"                'Database user
    Public strPass As String = "powers"     'Database password
    Public strStation As String
    Public VarWholeSale As Boolean = False
    Public REGISTERED As Boolean = False
    Public initial As String
    Public manager As String
    Public position As String
    Public DocCtrlNo As String
    '''For Server Date TIme
    Public dtServerDateTime As DateTime
    Private tmrLocalTimer As New System.Windows.Forms.Timer()
    Public serverdatetime As String
    Public backdate As Date
    ' Flag to check whether it is First time run. 
    Dim IsFirstTime As Boolean = True
    Public autoload As Boolean = True
    Public recurring As Boolean = False
    Public prevdate As Date
    Public ADDING As Boolean = False
    Public VarYesNo As Boolean
    Public VarContinue As Boolean = True
    Public VarDateFrom As Date
    Public VarDateTo As Date
    Public VARYEAR As Integer

    Public Vartype As String
    Public VarIDNo As String
    Public VarUniInteger As Integer
    '====================

    Public VargetBrgyID As String
    Public VargetProfID As String
    Public VarPayment As String
    Public VarProfID As String
    Public VarBillingID As String

    Public strPre As String

    Public VarAdder As Boolean
    Public VarEditor As Boolean
    Public VarDeleter As Boolean
    Public updating As Boolean
    Public Deleting As Boolean


    Public VarForm As Form
    Public VarPB As PictureBox


    Public BarangayUser As Boolean
    Public VarCertType As String
    Public ans As String 'for messagebox answering
    Public menues As New List(Of Button)

#Region "FORMDETECT"
    Public tmpuser As Boolean = False
    Public audittrail As Boolean = False
    Public IncomingDocu As Boolean = False
    Public OutgoingDocu As Boolean = False
#End Region

    Public Sub connect()
        'docutrac
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\conn.ini") Then
            File.SetAttributes(Application.StartupPath & "\conn.ini", FileAttributes.Normal)

            Dim CON() As String = (File.ReadAllLines(Application.StartupPath & "\conn.ini"))
            strServer = MessageTransposition(CON(0), False).ToString
            strUser = MessageTransposition(CON(1), False).ToString
            strPass = MessageTransposition(CON(2), False).ToString
            strDbase = MessageTransposition(CON(3), False).ToString
            Try
                strStation = MessageTransposition(CON(4), False).ToString
            Catch ex As Exception
                strStation = ""
            End Try

            File.SetAttributes(Application.StartupPath & "\conn.ini", FileAttributes.Hidden)
        Else
            frmserver.ShowDialog()
        End If

    End Sub
    Public Sub SERIALS()
        'If My.Computer.FileSystem.FileExists(System.Environment.GetEnvironmentVariable("windir") & "\KEY.ini") Then
        '    File.SetAttributes(System.Environment.GetEnvironmentVariable("windir") & "\KEY.ini", FileAttributes.Normal)
        Dim KEYS As String = "IAMTHEMASTER"

        '    Dim NumericCharacters As New System.Text.RegularExpressions.Regex("[0-9]")

        '    Dim CON() As String = (File.ReadAllLines(System.Environment.GetEnvironmentVariable("windir") & "\KEY.ini"))


        '    If KEYS = NumericCharacters.Replace(MessageTransposition(CON(0), False).ToString, String.Empty) Then
        '        REGISTERED = True
        '        frmMain.UnregisteredToolStripMenuItem.Text = "Registered"
        '    Else
        '        MsgBox("Incorrect Serial", MsgBoxStyle.Information, "System Reminder")
        '        REGISTERED = False
        '    End If

        '    File.SetAttributes(System.Environment.GetEnvironmentVariable("windir") & "\KEY.ini", FileAttributes.Hidden)

        'End If
        Dim regKey As RegistryKey
        Dim NumericCharacters As New System.Text.RegularExpressions.Regex("[0-9]")

        Dim key As String
        regKey = Registry.LocalMachine.OpenSubKey("Software\POSApp", True)
        key = regKey.GetValue("ProductKey", 0.0)

        If KEYS = NumericCharacters.Replace(MessageTransposition(key, False).ToString, String.Empty) Then
            REGISTERED = True

        Else
            MsgBox("Incorrect Serial", MsgBoxStyle.Information, "System Reminder")
            REGISTERED = False
        End If


    End Sub
    Public Sub ConnDB()
        Dim tryconnect As Integer
        Try
            If tryconnect = 3 Then
                MsgBox("Unable to Connect to Server..!")
                End
            End If

            If strServer <> "" Or strUser <> "" Or strPass <> "" Then
                conn = New SqlConnection("Server=" & strServer.Trim & "; " & _
                           "Initial Catalog=" & strDbase.Trim & ";User ID=" & strUser.Trim & ";Password=" & strPass.Trim & ";MultipleActiveResultSets=True;Connect Timeout=30")

                conn.Open()
            End If
        Catch ex As Exception
            tryconnect += 1
            MessageBox.Show("Failed to connect to data source or server!")
            End
        End Try
    End Sub

    Public Sub Audit_Trail(ByVal user_ID As String, ByVal xAction As String)

        Dim sqlstr_Audit As String
        sqlstr_Audit = "INSERT INTO TBL_Audit_Trail (User_ID, Action, Date, Timex) " & _
                 "VALUES ('" & user_ID & "', " _
                            & "@VarParam1, " _
                            & "'" & Format(dtServerDateTime, "MM/dd/yyyy") & "', " _
                            & "'" & TimeOfDay & "')"
        '& "'" & Format(DateTime.Now, "H:m:tt") & "')"
        ' MsgBox(sqlSTR)
        Try
            SaveUpdate(sqlstr_Audit, "", "", xAction, "", "", "", "", "")
        Catch ex As Exception
            ErrorMessage(ex.Message, "Function Audit_Trail")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Public Sub FILLComboBox(ByVal sql As String, ByVal cb As ComboBox)
        cb.Items.Clear()
        Try
            conn.Open()
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.Items.Add(rdr(0).ToString)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadComboBox(ByVal sql As String, ByVal cb As ComboBox)
        cb.Items.Clear()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.Items.Add(rdr(0).ToString)
                cb.Text = rdr(0).ToString
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Class serverdateandtime
        Public Sub TimerEventProcessor(ByVal myObject As Object, ByVal myEventArgs As EventArgs)
            'Check whether it is First time run. 
            ' If yes then Get Server time and display it in the ToolStripStatusLabel.
            If IsFirstTime = True Then
                Dim cmd As SqlCommand
                Dim tmpConnection As SqlConnection = Nothing
                Dim strConnectionString As String
                Try
                    ' Read ConnectionString from Application Configuration file.
                    strConnectionString = "Server=" & strServer.Trim & "; " &
                           "Initial Catalog=" & strDbase.Trim & ";User ID=" & strUser.Trim & ";Password=" & strPass
                    'System.Configuration.ConfigurationManager.AppSettings("ServerConnectionString")
                    '        strConnectionString = "Server=" & strServer.Trim & "; " & _
                    '"Initial Catalog=" & strDbase.Trim & ";User ID=" & strUser.Trim & ";Password=" & strPass
                    tmpConnection = New SqlConnection(strConnectionString)
                    ' Open the Connection
                    tmpConnection.Open()
                    ' Initialize the Command object with commandText and SQLConnection
                    cmd = New SqlCommand("Select GetDate()", tmpConnection)
                    'Execute the query and return the Server Date Time
                    dtServerDateTime = CDate(cmd.ExecuteScalar)
                    ' Display the Server Date Time in the ToolStripStatusLabel of the MainForm
                    serverdatetime = Format(dtServerDateTime, "MMM dd, yyyy")

                    ' Set the Flag to False
                    IsFirstTime = False
                Catch ex As Exception
                    ErrorMessage(ex.Message, "Function TimerEventProcessor")
                Finally
                    If tmpConnection.State = ConnectionState.Open Then
                        cmd = Nothing
                        tmpConnection.Close()
                    End If
                End Try
            Else
                'Add one Second to the dtServerDateTime
                dtServerDateTime = DateAdd(DateInterval.Second, 1, dtServerDateTime)
            End If
            tmrLocalTimer.Enabled = True
            ' Display the Server Date Time in the ToolStripStatusLabel of the MainForm
            serverdatetime = Format(dtServerDateTime, "MM/dd/yyyy hh:mm:ss tt")
        End Sub

        Public Sub GetServerDateTime()
            AddHandler tmrLocalTimer.Tick, AddressOf TimerEventProcessor
            ' Sets the timer interval to 1 second.
            tmrLocalTimer.Interval = 1000
            tmrLocalTimer.Start()
        End Sub
    End Class
    Public Function MessageTransposition(ByVal StrDataIn As String, ByVal ED As Boolean) As String '''''CODE TO ENCRYPT TEXT

        Dim ChkXOR As New CheckBox

        '>>> if neded xor, use this code
        Dim XORCode As Integer
        XORCode = 165

        Dim rowind As Integer     'index row
        Dim colind As Integer     'index column

        rowind = 5
        colind = 5
        '>>> create the array
        Dim DataArray(rowind, colind) As String
        Dim i, j As Integer
        Dim r, c As Integer
        Dim output As String
        output = ""
        i = 1
        '>>> loop to total length
        While i <= StrDataIn.Length

            '>>> clear the array
            For r = 0 To rowind
                For c = 0 To colind
                    DataArray(r, c) = Chr(1)
                Next
            Next

            '>>> check the loop last postion
            Dim LastPos As Integer
            If i + (rowind * colind) - 1 <= StrDataIn.Length Then
                LastPos = i + (rowind * colind) - 1
            Else
                LastPos = StrDataIn.Length
            End If

            '>>> store strdata in into array character by character
            '>>> initial the array indexer
            r = 0
            c = 0
            For j = i To LastPos

                ChkXOR.Checked = True
                '>>> check if need to XOR the character
                If ChkXOR.Checked = True Then
                    Dim TempChar As String
                    TempChar = Mid(StrDataIn, j, 1)
                    DataArray(r, c) = Chr(Asc(TempChar) Xor XORCode)
                Else
                    DataArray(r, c) = Mid(StrDataIn, j, 1)
                End If

                c = c + 1


                '>>> reset the array indexer
                If r > rowind - 1 Then
                    r = 0
                    c = 0
                End If
                If c > colind - 1 Then
                    c = 0
                    r = r + 1
                End If
            Next

            '>>> add array value to string coulumn nad row wise
            If ED = True Then
                For c = 0 To colind - 1
                    For r = 0 To rowind - 1
                        output = output & DataArray(r, c)
                    Next
                Next
            Else
                '>>> decrypt logics
                Dim StrTemp As String
                StrTemp = ""
                Dim p, p1 As Integer
                p = 1
                p1 = 1
                For r = 0 To rowind - 1
                    For c = 0 To colind - 1
                        StrTemp = StrTemp & DataArray(r, c)
                    Next
                Next

                While p <= StrTemp.Length
                    '>>> replace array filling character
                    '>>> check if it is xor 
                    ChkXOR.Checked = True
                    If ChkXOR.Checked = True Then
                        output = output & Replace(Mid(StrTemp, p1, 1), Chr(Asc(Chr(1)) Xor XORCode), "")
                    Else
                        output = output & Replace(Mid(StrTemp, p1, 1), Chr(1), "")
                    End If


                    p = p + 1

                    '>>> increment position by row
                    p1 = p1 + rowind
                    If p1 > StrTemp.Length Then
                        p1 = p1 - StrTemp.Length + 1
                    End If
                End While
            End If
            i = i + rowind * colind
        End While

        MessageTransposition = output

    End Function
    Function CntrlExistsIn(ByVal ctrlName As String, ByVal parent As Control) As Boolean
        Dim bResult As Boolean = False

        For Each elem As Control In parent.Controls
            If elem.Name = ctrlName Then
                bResult = True
                Exit For
            End If
        Next

        Return bResult
    End Function
    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Public Sub UpperTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            UpperTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = CType(ctrl, TextBox).Text.ToUpper
                'StrConv(CType(ctrl, TextBox).Text, VbStrConv.Uppercase)
            End If
        Next ctrl
    End Sub
    Public Sub EnableTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            EnableTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = True
            End If

            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = True
            End If

            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = True
            End If

            If TypeOf ctrl Is GroupBox Then
                CType(ctrl, GroupBox).Enabled = True
            End If
            If TypeOf ctrl Is MaskedTextBox Then
                CType(ctrl, MaskedTextBox).Enabled = True
            End If
        Next ctrl
    End Sub
    Public Sub DisbleTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            DisbleTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = False
            End If

            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = False
            End If

            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = False
            End If

            If TypeOf ctrl Is GroupBox Then
                CType(ctrl, GroupBox).Enabled = False
            End If

            If TypeOf ctrl Is MaskedTextBox Then
                CType(ctrl, MaskedTextBox).Enabled = False
            End If
        Next ctrl
    End Sub
    Public Sub EnableComboBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            EnableComboBox(ctrl)
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = True
                'StrConv(CType(ctrl, TextBox).Text, VbStrConv.Uppercase)
            End If
        Next ctrl
    End Sub
    Public Sub DisbleComboBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            DisbleComboBox(ctrl)
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = False

            End If
        Next ctrl
    End Sub
    Public Sub ClearCombo(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearCombo(ctrl)
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Public Sub TOUPPERCASE(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            TOUPPERCASE(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = CType(ctrl, TextBox).Text.ToUpper()
            End If
        Next ctrl
    End Sub
    Function getMacAddress() As String
        Dim nics() As NetworkInterface =
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function
    Public Sub GetNumber(ByVal root As Control)
        VarRequired = False
        For Each ctrl As Control In root.Controls
            GetNumber(ctrl)
            If TypeOf ctrl Is TextBox Then
                If IsNumeric(CType(ctrl, TextBox).Text) = False Then
                    CType(ctrl, TextBox).BackColor = Color.LightGreen
                    CType(ctrl, TextBox).Text = "0.00"
                    VarRequired = True
                Else
                    CType(ctrl, TextBox).BackColor = Color.White
                End If
            End If
        Next ctrl
    End Sub

#Region "Buttons"
    Public Sub EnableButtons(ByVal root As ToolStrip)
        For Each ctrl As ToolStripItem In root.Items
            If TypeOf ctrl Is ToolStripItem Then
                If CType(ctrl, ToolStripItem).Name = "btnAdd" Then
                    CType(ctrl, ToolStripItem).Enabled = True
                ElseIf CType(ctrl, ToolStripItem).Name = "btnUpdate" Then
                    CType(ctrl, ToolStripItem).Enabled = True
                ElseIf CType(ctrl, ToolStripItem).Name = "btnSearch" Then
                    CType(ctrl, ToolStripItem).Enabled = True
                ElseIf CType(ctrl, ToolStripItem).Name = "btnPrint" Then
                    CType(ctrl, ToolStripItem).Enabled = True
                ElseIf CType(ctrl, ToolStripItem).Name = "btnClose" Then
                    CType(ctrl, ToolStripItem).Enabled = True
                ElseIf CType(ctrl, ToolStripItem).Name = "btnSave" Then
                    CType(ctrl, ToolStripItem).Enabled = False
                ElseIf CType(ctrl, ToolStripItem).Name = "btnCancel" Then
                    CType(ctrl, ToolStripItem).Enabled = False

                End If
            End If
        Next ctrl

    End Sub
    Public Sub DisableButtons(ByVal root As ToolStrip)
        For Each ctrl As ToolStripItem In root.Items
            If TypeOf ctrl Is ToolStripItem Then
                If CType(ctrl, ToolStripItem).Name = "btnAdd" Then
                    CType(ctrl, ToolStripItem).Enabled = False
                ElseIf CType(ctrl, ToolStripItem).Name = "btnUpdate" Then
                    CType(ctrl, ToolStripItem).Enabled = False
                ElseIf CType(ctrl, ToolStripItem).Name = "btnSearch" Then
                    CType(ctrl, ToolStripItem).Enabled = False
                ElseIf CType(ctrl, ToolStripItem).Name = "btnPrint" Then
                    CType(ctrl, ToolStripItem).Enabled = False
                ElseIf CType(ctrl, ToolStripItem).Name = "btnClose" Then
                    CType(ctrl, ToolStripItem).Enabled = False
                ElseIf CType(ctrl, ToolStripItem).Name = "btnSave" Then
                    CType(ctrl, ToolStripItem).Enabled = True
                ElseIf CType(ctrl, ToolStripItem).Name = "btnCancel" Then
                    CType(ctrl, ToolStripItem).Enabled = True
                End If
            End If
        Next ctrl

    End Sub

#End Region

    Public Sub SetNumberZero(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            GetNumber(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = "0.00"
            End If
        Next ctrl
    End Sub
    Public VarCtrlNo As String
    Public VarCtrlNo1 As String
    Public VarCtrlNo2 As String
    Public VarCtrlNo3 As String
    Public VarCtrlNo4 As String
    Public Function GetNextID(ByVal tmpInitial As String, ByVal tmpTable As String, ByVal varOrder As String, ByVal VarLength As Integer, ByVal VarYear As Boolean)
        Dim DisYr As String
        If VarYear = True Then
            DisYr = Format(Now(), "yy") & tmpInitial & strStation & "-"
        Else
            If tmpInitial = "".Trim Then
                DisYr = ""
            Else
                DisYr = tmpInitial & "-"
            End If

        End If

        Dim VarSQL As String
        Try

            ConnDB()
            VarLength = Len(DisYr)
            VarSQL = "SELECT top 1 isnull(RIGHT(" & varOrder & ",4)+ 1,1)  as pernum FROM " & tmpTable & "  AS x WHERE left(" & varOrder & "," & VarLength & ") ='" & DisYr & "' "

            If DisYr = "".Trim Then
                VarSQL += "ORDER BY convert(integer,RIGHT(ProductID,4)) DESC"
            Else
                VarSQL += "ORDER BY RIGHT(" & varOrder & ",4) DESC"
            End If
            cmd = New SqlCommand(VarSQL, conn)
retry:      dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                VarCtrlNo = dr("Pernum")
                VarCtrlNo = DisYr & Format(CDec(VarCtrlNo), "###00000")
                VarCtrlNo = VarCtrlNo
            Else
                '   txtpno.Text = "00001"
                Dim varfirst As String = "0001"
                VarCtrlNo = DisYr & Format(CDec(varfirst), "###00000")
            End If
            Return VarCtrlNo
        Catch ex As Exception
            GoTo retry
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Function
    Public Sub GetNextID1(ByVal tmpInitial1 As String, ByVal tmpTable1 As String, ByVal varOrder1 As String, ByVal VarLength1 As Integer, ByVal VarYear1 As Boolean)
        Dim DisYr1 As String
        If VarYear1 = True Then
            DisYr1 = Format(Now(), "yy") & tmpInitial1 & strStation & "-"
        Else
            If tmpInitial1 = "".Trim Then
                DisYr1 = ""
            Else
                DisYr1 = tmpInitial1 & "-"
            End If

        End If

        Dim VarSQL As String
        Try

            ConnDB()
            VarLength1 = Len(DisYr1)
            VarSQL = "SELECT top 1 isnull(RIGHT(" & varOrder1 & ",4)+ 1,1)  as pernum FROM " & tmpTable1 & "  AS x WHERE left(" & varOrder1 & "," & VarLength1 & ") ='" & DisYr1 & "' "

            If DisYr1 = "".Trim Then
                VarSQL += "ORDER BY convert(integer,RIGHT(ProductID,4)) DESC"
            Else
                VarSQL += "ORDER BY RIGHT(" & varOrder1 & ",4) DESC"
            End If
            cmd = New SqlCommand(VarSQL, conn)
retry:      dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                VarCtrlNo1 = dr("Pernum")
                VarCtrlNo1 = DisYr1 & Format(CDec(VarCtrlNo1), "###00000")
                VarCtrlNo1 = VarCtrlNo1
            Else
                '   txtpno.Text = "00001"
                Dim varfirst1 As String = "0001"
                VarCtrlNo1 = DisYr1 & Format(CDec(varfirst1), "###00000")
            End If
        Catch ex As Exception
            GoTo retry
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Public Sub GetNextID2(ByVal tmpInitial2 As String, ByVal tmpTable2 As String, ByVal varOrder2 As String, ByVal VarLength2 As Integer, ByVal VarYear2 As Boolean)
        Dim DisYr2 As String
        If VarYear2 = True Then
            DisYr2 = Format(Now(), "yy") & tmpInitial2 & strStation & "-"
        Else
            If tmpInitial2 = "".Trim Then
                DisYr2 = ""
            Else
                DisYr2 = tmpInitial2 & "-"
            End If

        End If

        Dim VarSQL As String
        Try

            ConnDB()
            VarLength2 = Len(DisYr2)
            VarSQL = "SELECT top 1 isnull(RIGHT(" & varOrder2 & ",4)+ 1,1)  as pernum FROM " & tmpTable2 & "  AS x WHERE left(" & varOrder2 & "," & VarLength2 & ") ='" & DisYr2 & "' "

            If DisYr2 = "".Trim Then
                VarSQL += "ORDER BY convert(integer,RIGHT(ProductID,4)) DESC"
            Else
                VarSQL += "ORDER BY RIGHT(" & varOrder2 & ",4) DESC"
            End If
            cmd = New SqlCommand(VarSQL, conn)
retry:      dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                VarCtrlNo2 = dr("Pernum")
                VarCtrlNo2 = DisYr2 & Format(CDec(VarCtrlNo2), "###00000")
                VarCtrlNo2 = VarCtrlNo2
            Else
                '   txtpno.Text = "00001"
                Dim varfirst2 As String = "0001"
                VarCtrlNo2 = DisYr2 & Format(CDec(varfirst2), "###00000")
            End If
        Catch ex As Exception
            GoTo retry
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Public Sub GetNextID3(ByVal tmpInitial3 As String, ByVal tmpTable3 As String, ByVal varOrder3 As String, ByVal VarLength3 As Integer, ByVal VarYear3 As Boolean)
        Dim DisYr3 As String
        If VarYear3 = True Then
            DisYr3 = Format(Now(), "yy") & tmpInitial3 & strStation & "-"
        Else
            If tmpInitial3 = "".Trim Then
                DisYr3 = ""
            Else
                DisYr3 = tmpInitial3 & "-"
            End If

        End If

        Dim VarSQL As String
        Try

            ConnDB()
            VarLength3 = Len(DisYr3)
            VarSQL = "SELECT top 1 isnull(RIGHT(" & varOrder3 & ",4)+ 1,1)  as pernum FROM " & tmpTable3 & "  AS x WHERE left(" & varOrder3 & "," & VarLength3 & ") ='" & DisYr3 & "' "

            If DisYr3 = "".Trim Then
                VarSQL += "ORDER BY convert(integer,RIGHT(ProductID,4)) DESC"
            Else
                VarSQL += "ORDER BY RIGHT(" & varOrder3 & ",4) DESC"
            End If
            cmd = New SqlCommand(VarSQL, conn)
retry:      dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                VarCtrlNo3 = dr("Pernum")
                VarCtrlNo3 = DisYr3 & Format(CDec(VarCtrlNo3), "###00000")
                VarCtrlNo3 = VarCtrlNo3
            Else
                '   txtpno.Text = "00001"
                Dim varfirst As String = "0001"
                VarCtrlNo3 = DisYr3 & Format(CDec(varfirst), "###00000")
            End If
        Catch ex As Exception
            GoTo retry
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Public Sub GetNextID4(ByVal tmpInitial4 As String, ByVal tmpTable4 As String, ByVal varOrder4 As String, ByVal VarLength4 As Integer, ByVal VarYear4 As Boolean)
        Dim DisYr4 As String
        If VarYear4 = True Then
            DisYr4 = Format(Now(), "yy") & tmpInitial4 & strStation & "-"
        Else
            If tmpInitial4 = "".Trim Then
                DisYr4 = ""
            Else
                DisYr4 = tmpInitial4 & "-"
            End If

        End If

        Dim VarSQL As String
        Try

            ConnDB()
            VarLength4 = Len(DisYr4)
            VarSQL = "SELECT top 1 isnull(RIGHT(" & varOrder4 & ",4)+ 1,1)  as pernum FROM " & tmpTable4 & "  AS x WHERE left(" & varOrder4 & "," & VarLength4 & ") ='" & DisYr4 & "' "

            If DisYr4 = "".Trim Then
                VarSQL += "ORDER BY convert(integer,RIGHT(ProductID,4)) DESC"
            Else
                VarSQL += "ORDER BY RIGHT(" & varOrder4 & ",4) DESC"
            End If
            cmd = New SqlCommand(VarSQL, conn)
retry:      dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                VarCtrlNo4 = dr("Pernum")
                VarCtrlNo4 = DisYr4 & Format(CDec(VarCtrlNo4), "###00000")
                VarCtrlNo4 = VarCtrlNo4
            Else
                '   txtpno.Text = "00001"
                Dim varfirst As String = "0001"
                VarCtrlNo4 = DisYr4 & Format(CDec(varfirst), "###00000")
            End If
        Catch ex As Exception
            GoTo retry
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Public Sub FindID(ByVal tmpInitial As String, ByVal tmpTable As String, ByVal varOrder As String, ByVal VarLength As Integer, ByVal VarCOndition As String)
        Dim DisYr As String = Format(Now(), "yyyy") & tmpInitial & "-"

        Dim VarSQL As String
        Try
            VarSQL = "SELECT top 1 BillSeries as pernum FROM " & tmpTable & "  AS x WHERE left(" & varOrder & "," & VarLength & ") ='" & DisYr & "' "

            If VarCOndition <> "".Trim Then
                VarSQL += " and " & VarCOndition & " "
            End If
            VarSQL += " ORDER BY RIGHT(" & varOrder & ",4) DESC"

            ConnDB()
            cmd = New SqlCommand(VarSQL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                VarCtrlNo = dr("Pernum")
                VarCtrlNo = VarCtrlNo
            Else
                VarCtrlNo = "NOTHING"
            End If
        Catch ex As Exception

        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Public VarNExtOR As String
    Public Sub loadAutoSuggest(ByVal mySql As String, ByVal myTextbox As TextBox)
        Try
            Dim tmpds As New DataSet
            tmpds.Clear()
            da.SelectCommand = New SqlCommand(mySql, conn)
            da.Fill(tmpds)

            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To tmpds.Tables(0).Rows.Count - 1
                col.Add(tmpds.Tables(0).Rows(i)(0).ToString())
            Next

            myTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource
            myTextbox.AutoCompleteCustomSource = col
            myTextbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception
            ErrorMessage(ex.Message)
        End Try

    End Sub
     Public Function Get_SingleData(ByVal mysql As String)
        Try
            ConnDB()
            Dim myValue As String = Nothing
            Dim TempDR As SqlDataReader
            cmd = New SqlCommand(mysql, conn)
            TempDR = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            sqlDT.Reset()
            If TempDR.HasRows Then
                While TempDR.Read()
                    myValue = TempDR(0).ToString()
                End While
            End If

            Return myValue
        Catch ex As Exception
            ErrorMessage(ex.Message, "Function Get_SingleData")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function
    Public Function Get_recordID(ByVal VarTable As String, ByVal VarID As String, ByVal VarCondition As String, ByVal VarValue As String)
        Try
            '  varProfiD = Get_SingleData("SELECT ProfileID FROM dbo.vwProfile where name ='" & txtprofileidÅ.Text & "'")
            Dim mysql As String
            mysql = "select top 1  " & VarID & "  from  " & VarTable & "  where  " & VarCondition & "  ='" & VarValue & "'"
            ConnDB()
            Dim myValue As String = Nothing
            Dim TempDR As SqlDataReader
            cmd = New SqlCommand(mysql, conn)
            TempDR = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            sqlDT.Reset()
            If TempDR.HasRows Then
                While TempDR.Read()
                    myValue = TempDR(0).ToString()
                End While
            End If

            Return myValue
        Catch ex As Exception
            ErrorMessage(ex.Message, "Function Get_SingleData")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function
    Public Function Get_SingleData2(ByVal mysql As String, ByVal VarParam1 As String, ByVal VarParam2 As String)
        Try
            ConnDB()
            Dim myValue As String = Nothing
            Dim TempDR As SqlDataReader
            cmd = New SqlCommand(mysql, conn)

            cmd.Parameters.Add(New SqlParameter("@VarParam1", SqlDbType.NVarChar, (99999))).Value = VarParam1
            cmd.Parameters.Add(New SqlParameter("@VarParam2", SqlDbType.NVarChar, (99999))).Value = VarParam2

            TempDR = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            sqlDT.Reset()
            If TempDR.HasRows Then
                While TempDR.Read()
                    myValue = TempDR(0).ToString()
                End While
            End If

            If myValue = Nothing Then
                myValue = ""
            End If

            Return myValue
        Catch ex As Exception
            ErrorMessage(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function GetState(ByVal mysql As String)
        Try
            ConnDB()
            Dim myValue As Boolean = False
            Dim TempDR As SqlDataReader
            cmd = New SqlCommand(mysql, conn)
            TempDR = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            sqlDT.Reset()
            If TempDR.HasRows Then
                myValue = True
            Else
                myValue = False
            End If

            Return myValue
        Catch ex As Exception
            ErrorMessage(ex.Message, "Function Function GetState")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function
#Region "Number to Words"
    '====================== Number to Words
    Public Function ConvertNumberToENG(ByVal amount As String) As String

        Dim dollars, cents, temp
        Dim decimalPlace, count
        Dim place(9) As String
        place(2) = " Thousand "
        place(3) = " Million "
        place(4) = " Billion "
        place(5) = " Trillion "

        ' String representation of amount.
        amount = amount.Trim()
        amount = amount.Replace(",", "")
        ' Position of decimal place 0 if none.
        decimalPlace = amount.IndexOf(".")
        ' Convert cents and set string amount to dollar amount.
        If decimalPlace > 0 Then
            cents = GetTens(amount.Substring(decimalPlace + 1).PadRight(2, "0").Substring(0, 2))
            amount = amount.Substring(0, decimalPlace).Trim()
        End If

        count = 1
        Do While amount <> ""
            temp = GetHundreds(amount.Substring(Math.Max(amount.Length, 3) - 3))
            If temp <> "" Then dollars = temp & place(count) & dollars
            If amount.Length > 3 Then
                amount = amount.Substring(0, amount.Length - 3)
            Else
                amount = ""
            End If
            count = count + 1
        Loop

        Select Case dollars
            Case ""
                dollars = "No Peso"
            Case "One"
                dollars = "One Peso"
            Case Else
                dollars = dollars & " Pesos"
        End Select

        Select Case cents
            Case ""
                cents = " and Zero Cents"
            Case "One"
                cents = " and One Cent"
            Case Else
                cents = " and " & cents & " Cents"
        End Select

        ConvertNumberToENG = dollars & cents
    End Function

    ' Converts a number from 100-999 into text
    Function GetHundreds(ByVal amount As String) As String
        Dim Result As String
        If Not Integer.Parse(amount) = 0 Then
            amount = amount.PadLeft(3, "0")
            ' Convert the hundreds place.
            If amount.Substring(0, 1) <> "0" Then
                Result = GetDigit(amount.Substring(0, 1)) & " Hundred "
            End If
            ' Convert the tens and ones place.
            If amount.Substring(1, 1) <> "0" Then
                Result = Result & GetTens(amount.Substring(1))
            Else
                Result = Result & GetDigit(amount.Substring(2))
            End If
            GetHundreds = Result
        End If
    End Function

    ' Converts a number from 10 to 99 into text.
    Private Function GetTens(ByRef TensText As String) As String
        Dim Result As String
        Result = ""           ' Null out the temporary function value.
        If TensText.StartsWith("1") Then   ' If value between 10-19...
            Select Case Integer.Parse(TensText)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else                                 ' If value between 20-99...
            Select Case Integer.Parse(TensText.Substring(0, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select
            Result = Result & GetDigit(TensText.Substring(1, 1))  ' Retrieve ones place.
        End If
        GetTens = Result
    End Function

    ' Converts a number from 1 to 9 into text.
    Private Function GetDigit(ByRef Digit As String) As String
        Select Case Integer.Parse(Digit)
            Case 1 : GetDigit = "One"
            Case 2 : GetDigit = "Two"
            Case 3 : GetDigit = "Three"
            Case 4 : GetDigit = "Four"
            Case 5 : GetDigit = "Five"
            Case 6 : GetDigit = "Six"
            Case 7 : GetDigit = "Seven"
            Case 8 : GetDigit = "Eight"
            Case 9 : GetDigit = "Nine"
            Case Else : GetDigit = ""
        End Select
    End Function
    '===============================
#End Region
    Public Function FeetoMeter(ByVal VarFeet As Double)
        Try

            Dim myValue As String = Nothing

            myValue = VarFeet * 30.48

            Return myValue
        Catch ex As Exception
            ErrorMessage(ex.Message, "Function FeetoMeter")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function
    Function RemoveWhitespace(ByVal fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function
    '=======Get the Value of the Datagrid
    Public rowindex As String
    <System.Runtime.CompilerServices.Extension()> _
    Function FindValue(ByRef dgv As DataGridView, ByVal metric_key As Object, ByVal VarColumn As String) As DataGridViewRow
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells.Item(VarColumn).Value = metric_key Then
                rowindex = row.Index.ToString()
                Return row
            End If
        Next
        Return Nothing
    End Function
    Public Function Get_Date()
        Dim MYSQL As String = "Select getdate()"
        Try
            ConnDB()
            Dim myValue As String = Nothing
            Dim TempDR As SqlDataReader
            cmd = New SqlCommand(MYSQL, conn)
            TempDR = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            sqlDT.Reset()
            If TempDR.HasRows Then
                While TempDR.Read()
                    '   myValue = TempDR(0)

                    myValue = Format(TempDR(0), "MM/dd/yyyy hh:mm:ss tt")
                End While
            End If

            Return myValue
        Catch ex As Exception
            ErrorMessage(ex.Message, "Function Get_Date")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Function
    Public Sub SaveUpdate(ByVal VarSQL As String, ByVal VarSuccess As String, ByVal VarFailed As String, ByVal VarParam1 As String, ByVal VarParam2 As String, ByVal VarParam3 As String, ByVal VarParam4 As String, ByVal VarParam5 As String, ByVal VarParam6 As String)
        Try
            ConnDB()
            cmd = New SqlCommand(VarSQL, conn)

            cmd.Parameters.Add(New SqlParameter("@VarParam1", SqlDbType.NVarChar, (99999))).Value = VarParam1
            cmd.Parameters.Add(New SqlParameter("@VarParam2", SqlDbType.NVarChar, (99999))).Value = VarParam2
            cmd.Parameters.Add(New SqlParameter("@VarParam3", SqlDbType.NVarChar, (99999))).Value = VarParam3
            cmd.Parameters.Add(New SqlParameter("@VarParam4", SqlDbType.NVarChar, (99999))).Value = VarParam4
            cmd.Parameters.Add(New SqlParameter("@VarParam5", SqlDbType.NVarChar, (99999))).Value = VarParam5
            cmd.Parameters.Add(New SqlParameter("@VarParam6", SqlDbType.NVarChar, (99999))).Value = VarParam6


            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then

                If VarSuccess <> "".Trim Then
                    MsgBox(VarSuccess, MsgBoxStyle.Information, "System Reminder")
                End If
                VarContinue = True
            Else
                If VarFailed <> "".Trim Then
                    MsgBox(VarFailed, MsgBoxStyle.Critical, "System Reminder")
                    VarContinue = False
                End If
            End If
        Catch ex As Exception
            ErrorMessage(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub SaveUpdateV2(ByVal VarSQL As String, ByVal VarSuccess As String, _
                       ByVal VarFailed As String, _
                       ByVal VarParam() As String, _
                       ByVal VarParamImage As Image)
        If ADDING = True Then
            If VarAdder = False Then
                MsgBox("Your account is not authorize to Add Record!", MsgBoxStyle.Critical, "Please see the Administrator")
                Exit Sub
            End If
        ElseIf updating = True Then
            If VarEditor = False Then
                MsgBox("Your account is not authorize to Edit or Update Record!", MsgBoxStyle.Critical, "Please see the Administrator")
                Exit Sub
            End If
        ElseIf Deleting = True Then
            If VarDeleter = False Then
                MsgBox("Your account is not authorize to Remove Record!", MsgBoxStyle.Critical, "Please see the Administrator")
                Exit Sub
            End If
        End If

        Try
            ConnDB()
            cmd = New SqlCommand(VarSQL, conn)
            For P As Integer = 0 To VarParam.Length - 1
                cmd.Parameters.Add(New SqlParameter("@VarParam" + CStr(P), SqlDbType.NVarChar, (99999))).Value = VarParam(P)
            Next

            'If IsNothing(VarParamImage) = False Then
            '    cmd.Parameters.AddWithValue("@Photo", ImageConverter.ImageToByte(VarParamImage))
            'End If

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then

                If VarSuccess <> "".Trim Then
                    MsgBox(VarSuccess, MsgBoxStyle.Information, "System Reminder")
                End If
                VarContinue = True
            Else
                If VarFailed <> "".Trim Then
                    MsgBox(VarFailed, MsgBoxStyle.Critical, "System Reminder")
                    VarContinue = False
                End If
            End If
        Catch ex As Exception
            ErrorMessage(ex.Message, "SaveUpdate")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    'Public Function getpics(ByVal VarField As String, ByVal VarTable As String, ByVal VarFieldCondition As String, ByVal VarValue As String)
    '    Try
    '        VarPB = Nothing
    '        sqL = "SELECT " & VarField & " from " & VarTable & " where " & VarFieldCondition & " ='" & VarValue & "'"
    '        Dim tmprdDB As SqlDataReader
    '        ConnDB()
    '        cmd = New SqlCommand(sqL, conn)
    '        tmprdDB = cmd.ExecuteReader(CommandBehavior.CloseConnection)

    '        If tmprdDB.Read = True Then

    '            Return ImageConverter.ByteToImage(TryCast(tmprdDB.Item("" & VarField & ""), Byte()))

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        cmd.Dispose()
    '        conn.Close()
    '    End Try


    'End Function

    Public Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function
    Public VarRequired As Boolean
    Public Sub HidePanels(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            If TypeOf ctrl Is Panel Then
                If CType(ctrl, Panel).Name.Contains("Å") Then
                    CType(ctrl, Panel).Visible = False
                End If
            End If
        Next ctrl
    End Sub
    Public FormPresent As Boolean
    Public Function CheckForm(ByVal root As Control)
        FormPresent = False

        For Each ctrl As Control In root.Controls
            If TypeOf ctrl Is Form Then
                FormPresent = True
            End If
        Next ctrl
        Return FormPresent
    End Function
    Public Function CheckForm(ByVal root As Control, ByVal VarForm As Form)
        FormPresent = False

        For Each ctrl As Control In root.Controls
            If TypeOf ctrl Is Form Then
                If VarForm.Name <> Nothing Then
                    If CType(ctrl, Form).Text = VarForm.Text Then
                        FormPresent = True
                    End If
                Else
                    FormPresent = True
                End If

            End If
        Next ctrl
        Return FormPresent
    End Function
    Public Sub OpenForm(ByVal VarForm As Form, ByVal VarPanel As Panel)
        With VarForm
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            VarPanel.Visible = True
            VarPanel.Controls.Add(VarForm)
            .BringToFront()
            VarForm.Show()
        End With
    End Sub
    Public Sub CloseForm(ByVal VarForm As Form, ByVal VarPanel As Panel)
        VarForm.Dispose()
        If CheckForm(VarPanel) = False Then
            VarPanel.Visible = False
        End If

    End Sub
    Public Sub RequiredFields(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            VarRequired = False
            RequiredFields(ctrl)
            If TypeOf ctrl Is TextBox Then
                If CType(ctrl, TextBox).Name.Contains("Å") Then
                    If CType(ctrl, TextBox).Text = "".Trim Then
                        VarRequired = True
                        CType(ctrl, TextBox).BackColor = Color.MistyRose
                    Else
                        CType(ctrl, TextBox).BackColor = Color.White
                    End If
                Else
                    CType(ctrl, TextBox).BackColor = Color.White
                End If
            End If


            If TypeOf ctrl Is ComboBox Then
                If CType(ctrl, ComboBox).Name.Contains("Å") Then
                    If CType(ctrl, ComboBox).Text = "".Trim Then
                        VarRequired = True
                        CType(ctrl, ComboBox).BackColor = Color.MistyRose
                    Else
                        CType(ctrl, ComboBox).BackColor = Color.White
                    End If
                Else
                    CType(ctrl, ComboBox).BackColor = Color.White
                End If
            End If
        Next ctrl
    End Sub
    Public Sub normalbackground(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            normalbackground(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).BackColor = Color.White
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).BackColor = Color.White
            End If
        Next ctrl
    End Sub
    Function SafeSqlLiteral(ByVal strValue, ByVal intLevel) As String

        '*** Written by user CWA, CoolWebAwards.com Forums. 2 February 2010
        '*** http://forum.coolwebawards.com/threads/11-Preventing-SQL-injection-attacks-using-VB-NET

        ' intLevel represent how thorough the value will be checked for dangerous code
        ' intLevel (1) - Do just the basic. This level will already counter most of the SQL injection attacks
        ' intLevel (2) - &nbsp; (non breaking space) will be added to most words used in SQL queries to prevent unauthorized access to the database. Safe to be printed back into HTML code. Don't use for usernames or passwords

        If Not IsDBNull(strValue) Then
            If intLevel > 0 Then
                strValue = Replace(strValue, "'", "''") ' Most important one! This line alone can prevent most injection attacks
                strValue = Replace(strValue, "--", "")
                strValue = Replace(strValue, "[", "[[]")
                strValue = Replace(strValue, "%", "[%]")
            End If

            If intLevel > 1 Then
                Dim myArray As Array
                myArray = Split("xp_ ;update ;insert ;select ;drop ;alter ;create ;rename ;delete ;replace ", ";")
                Dim i, i2, intLenghtLeft As Integer
                For i = LBound(myArray) To UBound(myArray)
                    Dim rx As New Regex(myArray(i), RegexOptions.Compiled Or RegexOptions.IgnoreCase)
                    Dim matches As MatchCollection = rx.Matches(strValue)
                    i2 = 0
                    For Each match As Match In matches
                        Dim groups As GroupCollection = match.Groups
                        intLenghtLeft = groups.Item(0).Index + Len(myArray(i)) + i2
                        strValue = Left(strValue, intLenghtLeft - 1) & "&nbsp;" & Right(strValue, Len(strValue) - intLenghtLeft)
                        i2 += 5
                    Next
                Next
            End If

            'strValue = replace(strValue, ";", ";&nbsp;")
            'strValue = replace(strValue, "_", "[_]")

            Return strValue
        Else
            Return strValue
        End If

    End Function
    Public Sub DisableTab(ByVal myTabControl As TabControl, ByVal VarTabName As String)

        Dim VarTabPage As TabPage

        For Each VarTabPage In myTabControl.TabPages
            If VarTabPage.Text <> VarTabName Then
                VarTabPage.Enabled = False
            End If
        Next

    End Sub
    Public Sub EnableTab(ByVal myTabControl As TabControl)

        Dim VarTabPage As TabPage

        For Each VarTabPage In myTabControl.TabPages

            VarTabPage.Enabled = True

        Next

    End Sub
    Public Function IsNetworkConnected() As Boolean
        Dim networkCards As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim connected As Boolean = False

        ' Loop through to find the one we want to check for connectivity.
        ' Connection can have different numbers appended so check that the 
        ' network connections start with the conditions checked below.
        For Each nc As NetworkInterface In networkCards
            ' Check LAN
            If nc.Name.StartsWith("Local Area Connection") Then
                If nc.OperationalStatus = OperationalStatus.Up Then
                    connected = True
                End If
            End If

            ' Check for Wireless
            If nc.Name.StartsWith("Wireless Network Connection") Then
                If nc.OperationalStatus = OperationalStatus.Up Then
                    connected = True
                End If
            End If
        Next

        Return connected
    End Function
    Public Sub ErrorMessage(ByVal ErrorMess As String, ByVal VarModule As String)
        MsgBox(ErrorMess)
        If Directory.Exists("C:\log") = True Then
            System.IO.File.AppendAllText("c:\log\doi.txt", Format(dtServerDateTime, "MM/dd/yyyy hh:mm tt") & vbNewLine & ErrorMess & vbNewLine & "Module:" & VarModule & vbNewLine & vbNewLine)
        Else
            Directory.CreateDirectory("C:\log")
        End If

    End Sub
    Public Sub ButtonFlatStyle(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            If TypeOf ctrl Is Button Then
                CType(ctrl, Button).FlatStyle = FlatStyle.Flat
                CType(ctrl, Button).FlatAppearance.BorderColor = CType(ctrl, Button).Parent.BackColor
            End If
        Next ctrl
    End Sub
  


    Public Function IsConnected(ByVal ServerName As String, ByVal UserID As String, ByVal Password As String) As Boolean
        Dim connStr As String = String.Format("Data Source={0}", ServerName)
        If Not String.IsNullOrEmpty(UserID) Then
            connStr &= String.Format(";User ID={0};Password={1}", UserID, Password)
            connStr &= "; MultipleActiveResultSets=True;Connect Timeout=30"
        Else
            connStr &= ";MultipleActiveResultSets=True;Connect Timeout=30"
        End If
        Return IsConnected(connStr)
    End Function
    Public Function IsConnected(ByVal Connection As String) As Boolean
        Static conn As SqlConnection
        Try
            If conn Is Nothing Then
                conn = New SqlConnection(Connection)
                conn.Open()
            End If
            conn = New SqlConnection(Connection)
            conn.Open()
            Return IsConnected(conn)

        Catch ex As Exception
            frmserver.ShowDialog()
        End Try
    End Function

    Public Function IsConnected(ByRef Conn As SqlConnection) As Boolean
        If Conn IsNot Nothing Then Return (Conn.State = ConnectionState.Open)
        Return False
    End Function
    Public Sub ErrorMessage(ByVal ErrorMess As String)
        MsgBox(ErrorMess)
        If Directory.Exists("C:\log") = True Then
            System.IO.File.AppendAllText("c:\log\doi.txt", Format(dtServerDateTime, "MM/dd/yyyy hh:mm tt") & vbNewLine & ErrorMess & vbNewLine & vbNewLine)
        Else
            Directory.CreateDirectory("C:\log")
        End If
    End Sub
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501
    Public Sub SetCueText(ByVal control As Control, ByVal text As String)
        If TypeOf control Is ComboBox Then
            Dim Edit_hWnd As IntPtr = FindWindowEx(control.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not Edit_hWnd = IntPtr.Zero Then
                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf control Is TextBox Then
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub
    Public Function isFontInstalled(ByVal FontName As String) As Boolean
        Try
            Dim FontFamily As New FontFamily(FontName)
            FontFamily.Dispose()
            Return True
        Catch
            Return False
        End Try
    End Function
    Public Function Font_Is_Installed(ByVal FontName As String) As Boolean
        Dim AllFonts As New Drawing.Text.InstalledFontCollection
        Dim FontFamily As New FontFamily(FontName)
        If AllFonts.Families.ToList().Contains(FontFamily) Then Return True Else Return False
    End Function
#Region "COLLECTION"
    Public Sub GetNextOR(ByVal VarAFtype As String, ByVal VarCollector As String)

        Try
            sqL = "SELECT top 1 seriesno as pernum FROM tblors  AS x WHERE collector ='" & VarCollector & "' and AFType = '" & VarAFtype & "' ORDER BY  seriesno"

            ConnDB()
            cmd = New SqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                VarNExtOR = dr("Pernum")
            Else
                VarNExtOR = ""

                If VarAFtype = "CTCI" Then
                    VarAFtype = "CTC"
                    CTCcHECKING(VarAFtype, VarCollector)
                Else
                    MsgBox("No Available Receipt for Current User!", MsgBoxStyle.Information, "System Reminder")
                End If


            End If
        Catch ex As Exception
            MsgBox("Transaction Failed")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Public Sub CTCcHECKING(ByVal VarAFtype As String, ByVal VarCollector As String)
        Try
            sqL = "SELECT top 1 seriesno as pernum FROM tblors  AS x WHERE collector ='" & VarCollector & "' and AFType = '" & VarAFtype & "' ORDER BY  seriesno"

            ConnDB()
            cmd = New SqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                VarNExtOR = dr("Pernum")
            Else
                VarNExtOR = ""
                MsgBox("No Available Receipt for Current User!", MsgBoxStyle.Information, "System Reminder")

            End If
        Catch ex As Exception
            MsgBox("Transaction Failed")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub

    Public Sub RemoveNextOR(ByVal VarAFtype As String, ByVal VarCollector As String, ByVal VarOR As String)

        Try
            sqL = "delete FROM tblors WHERE collector ='" & VarCollector & "' and AFType = '" & VarAFtype & "' and seriesno = '" & VarOR & "' "

            ConnDB()
            cmd = New SqlCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Success Removing Series No.!", MsgBoxStyle.Information, "System Reminder")
            End If
        Catch ex As Exception
            MsgBox("Transaction Failed")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Public Sub RemoveOR(ByVal VarAFtype As String, ByVal VarCollector As String)

        sqL = "delete tblors where seriesno in (select [OR] from tblpayment) and collector ='" & VarCollector & "' and AFType = '" & VarAFtype & "'"
        SaveUpdate(sqL, "", "", "", "", "", "", "", "")


    End Sub
    Public Sub RemoveOR1(ByVal VarAFtype As String, ByVal VarCollector As String)

        sqL = "delete tblors where seriesno not in (select [OR] from tblpayment) and collector ='" & VarCollector & "' and AFType = '" & VarAFtype & "' "
        SaveUpdate(sqL, "Remove Success", "Failed Removing", "", "", "", "", "", "")


    End Sub

#End Region

    Public Sub GetMenues(ByVal root As Control, ByRef menues As List(Of Button))
        menues.Add(root)
        For Each ctrl As Control In root.Controls
            If TypeOf ctrl Is Button Then
                GetMenues(ctrl, menues)
            End If

        Next ctrl
    End Sub
    Public Sub GetListMenus(ByVal root As Control)
        For Each Control In root.Controls
            If TypeOf Control Is Button Then
                menues.Add(Control)
            ElseIf TypeOf Control Is Panel Then
                GetListMenus(Control)
            End If
        Next
    End Sub
    Public Sub DisableMenusButtons()

        For Each t As Button In menues
            If Get_SingleData("select module from tblUsersModule where UserID ='" & xUser_ID & "' and Module ='" & t.Name & "'") = Nothing Then
                t.Enabled = False
            Else
                t.Enabled = True
            End If
        Next
    End Sub

End Module
