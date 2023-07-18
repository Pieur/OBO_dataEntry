Public Class frmApplicationIns


    Private Sub txtEstab_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEstab.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            txtESTABid.Text = Get_SingleData("SELECT establishmentid  FROM vwEstablishmentInformation where EstablishmentName ='" & txtEstab.Text & "'")
        End If
    End Sub

    Private Sub txtEstab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstab.TextChanged
        If Len(txtEstab.Text) = 2 Then
            loadAutoSuggest("SELECT x.EstablishmentName  FROM dbo.vwEstablishmentInformation AS x WHERE EstablishmentName LIKE '" & txtEstab.Text & "%'", txtEstab)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        sqL = "insert into tblBusinessInspection(insid,estabid,dateinspected,inspectiontype) values (@VarParam0,@VarParam1,@VarParam2,@VarParam3) "
        SaveUpdateV2(sqL, "Success Saving", "Failed Saving", {txtAppID.Text, txtESTABid.Text, dtInspection.Text, cmbTye.Text}, Nothing)
    End Sub

    Private Sub ApplicationIns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisbleTextBox(Me)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        EnableTextBox(Me)
        txtESTABid.Enabled = False
        txtAppID.Enabled = False
        txtAppID.Text = GetNextID("obo", "tblBusinessInspection", "iNSid", 8, False)

    End Sub

    Private Sub cmbTye_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTye.SelectedIndexChanged

    End Sub
End Class