
Public Class frmMain
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT EstabID FROM tblBusinessInspection;"
        Me.WindowState = FormWindowState.Maximized
        connect()
        frmLogin.ShowDialog()
        'pnlAnnual.Visible = False
        btnApplication.FlatAppearance.BorderSize = 0
        btnCerts.FlatAppearance.BorderSize = 0
        LoadComboBox("select EstabID from tblBusinessInspection", cbApplicationList)
        LoadComboBox("select Fullname from tblInspectors", cmbInspectorName)
        If Len(InspectorNameTB.Text) = 2 Then
            loadAutoSuggestCmb("SELECT Fullname FROM tblInspectors where Fullname like '" & cmbInspectorName.Text & "%'", cmbInspectorName)
        End If
        ' LoadComboBox("SELECT distinct EstablishmentName FROM tblEstablishment WHERE EstablishmentID = (SELECT EstabID from tblBusinessInspection);", cbApplicationList)
    End Sub

    Private Sub ConfirmBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmBtn.Click
        InspectGB.Enabled = Not InspectGB.Enabled
        ChiefGB.Enabled = Not ChiefGB.Enabled
        'EstablishmentProfileGB.Enabled = Not ChiefGB.Enabled
        'BusinessNameLbl.Text = BusinessNameTb.Text
    End Sub

    Private Sub InspectorNameTB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            InspectorID.Text = Get_SingleData("SELECT x.InspectorID  FROM dbo.tblInspectors AS x WHERE Fullname ='" & InspectorNameTB.Text & "'")
        End If
    End Sub


    Private Sub TextBox22_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(InspectorNameTB.Text) = 2 Then
            loadAutoSuggest("SELECT Fullname FROM tblInspectors where Fullname like '" & InspectorNameTB.Text & "%'", InspectorNameTB)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        InspectorID.Text = Get_SingleData("SELECT x.InspectorID  FROM dbo.tblInspectors AS x WHERE Fullname ='" & InspectorNameTB.Text & "'")
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EngrID.Text = Get_SingleData("SELECT x.InspectorID  FROM dbo.tblInspectors AS x WHERE Fullname ='" & EngnrNameTB.Text & "'")

    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not String.IsNullOrWhiteSpace(InspectorNameTB.Text) Then
            SaveInspector(InspectGB)
        Else
            MessageBox.Show("Please enter a valid inspector name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
    Private Sub SaveInspector(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            SaveInspector(ctrl)
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).CheckState = CheckState.Checked Then
                    GetNextID(InsID.Text, "tblInspectorList", "InspectionID", 8, False)
                    sqL = "insert into tblInspectorList values(@VarParam0,@VarParam1,@VarParam2,@VarParam3,@VarParam4)"
                    SaveUpdateV2(sqL, "Success", "Failed", {VarCtrlNo, InsID.Text, InspectorID.Text, CType(ctrl, CheckBox).Text, dtInspection.Text}, Nothing)
                Else
                    MessageBox.Show("Please select at least 1 field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit For
                End If
            End If
        Next ctrl
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim checkboxes() As RadioButton = {SectionChfRB, DivisionChfRB, BuildingOffclRB}
        Dim anyCheckboxChecked As Boolean = False

        For Each checkbox As RadioButton In checkboxes
            If checkbox.Enabled AndAlso checkbox.Checked AndAlso EngrID.Text <> "" Then
                anyCheckboxChecked = True
                Exit For
            End If
        Next

        If anyCheckboxChecked Then
            For Each checkbox As RadioButton In checkboxes
                If checkbox.Checked Then
                    checkbox.Enabled = False
                End If
            Next
            EngnrNameTB.Text = ""
            EngrID.Text = ""
            MessageBox.Show("Added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrEmpty(EngrID.Text) Then
            MessageBox.Show("Please enter a valid chief name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Please select a field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each control As Control In Me.Controls
            If TypeOf control Is CheckBox Then
                DirectCast(control, CheckBox).Checked = False
            ElseIf TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplication.Click
        frmApplicationIns.ShowDialog()
        If (pnlAnnual.Visible = True) Then
            pnlAnnual.Visible = Not pnlAnnual.Visible
        End If
    End Sub
    Private Sub btnApplication_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplication.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.LightSalmon ' Set the background color when the button is hovered
        button.ForeColor = Color.Black ' Set the text color when the button is hovered
    End Sub

    Private Sub btnApplication_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplication.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.Coral ' Set the default background color when the mouse leaves the button
    End Sub

    Private Sub btnListings_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.LightSalmon ' Set the background color when the button is hovered
    End Sub

    Private Sub btnListings_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.Coral ' Set the default background color when the mouse leaves the button
    End Sub

    Private Sub btnCerts_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnCerts.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.LightSalmon ' Set the background color when the button is hovered
    End Sub

    Private Sub btnCerts_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles btnCerts.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.Coral ' Set the default background color when the mouse leaves the button
    End Sub


    Private Sub btnAnnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnual.Click
        If (pnlAnnual.Visible = False) Then
            pnlAnnual.Visible = Not pnlAnnual.Visible
        End If
    End Sub

    Private Sub cmbInspectorName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbInspectorName.SelectedIndexChanged
        If Len(InspectorNameTB.Text) = 2 Then
            loadAutoSuggestCmb("SELECT Fullname FROM tblInspectors where Fullname like '" & cmbInspectorName.Text & "%'", cmbInspectorName)
        End If
    End Sub

    Private Sub btnInsIDSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsIDSearch.Click
        InspectorID.Text = Get_SingleData("SELECT x.InspectorID  FROM dbo.tblInspectors AS x WHERE Fullname ='" & cmbInspectorName.Text & "'")
    End Sub
End Class
