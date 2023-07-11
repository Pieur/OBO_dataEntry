
Public Class frmMain

    Private Sub TextBox20_TextChanged(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        loadAutoSuggest("SELECT ColumnName FROM TableName", TextBox1)

    End Sub

    Private Sub Label7_Click_1(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox12.CheckedChanged

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox11.CheckedChanged

    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox10.CheckedChanged

    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox9.CheckedChanged

    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Character_of_occupancy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub lstOptions_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label25_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox20_TextChanged_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label27_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox22_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label31_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label32_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label33_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        connect()
        frmLogin.ShowDialog()


    End Sub
End Class
