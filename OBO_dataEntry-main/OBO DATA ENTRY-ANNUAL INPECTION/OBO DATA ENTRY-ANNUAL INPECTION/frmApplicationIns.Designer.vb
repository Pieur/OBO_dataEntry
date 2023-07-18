<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApplicationIns
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEstab = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAppID = New System.Windows.Forms.TextBox()
        Me.lblAppID = New System.Windows.Forms.Label()
        Me.txtESTABid = New System.Windows.Forms.TextBox()
        Me.lblEstabID = New System.Windows.Forms.Label()
        Me.dtInspection = New System.Windows.Forms.DateTimePicker()
        Me.cmbTye = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Business Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type of Inspection"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Inspection Date"
        '
        'txtEstab
        '
        Me.txtEstab.Location = New System.Drawing.Point(165, 54)
        Me.txtEstab.Name = "txtEstab"
        Me.txtEstab.Size = New System.Drawing.Size(338, 22)
        Me.txtEstab.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(428, 188)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtAppID
        '
        Me.txtAppID.Location = New System.Drawing.Point(165, 26)
        Me.txtAppID.Name = "txtAppID"
        Me.txtAppID.Size = New System.Drawing.Size(131, 22)
        Me.txtAppID.TabIndex = 0
        '
        'lblAppID
        '
        Me.lblAppID.AutoSize = True
        Me.lblAppID.Location = New System.Drawing.Point(98, 26)
        Me.lblAppID.Name = "lblAppID"
        Me.lblAppID.Size = New System.Drawing.Size(50, 17)
        Me.lblAppID.TabIndex = 9
        Me.lblAppID.Text = "App ID"
        '
        'txtESTABid
        '
        Me.txtESTABid.Location = New System.Drawing.Point(372, 26)
        Me.txtESTABid.Name = "txtESTABid"
        Me.txtESTABid.Size = New System.Drawing.Size(131, 22)
        Me.txtESTABid.TabIndex = 1
        '
        'lblEstabID
        '
        Me.lblEstabID.AutoSize = True
        Me.lblEstabID.Location = New System.Drawing.Point(305, 26)
        Me.lblEstabID.Name = "lblEstabID"
        Me.lblEstabID.Size = New System.Drawing.Size(57, 17)
        Me.lblEstabID.TabIndex = 11
        Me.lblEstabID.Text = "EstabID"
        '
        'dtInspection
        '
        Me.dtInspection.CustomFormat = "MM/dd/yyyy"
        Me.dtInspection.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInspection.Location = New System.Drawing.Point(165, 93)
        Me.dtInspection.Name = "dtInspection"
        Me.dtInspection.Size = New System.Drawing.Size(121, 22)
        Me.dtInspection.TabIndex = 3
        '
        'cmbTye
        '
        Me.cmbTye.FormattingEnabled = True
        Me.cmbTye.Items.AddRange(New Object() {"New", "Additional", "Annual", "Change Address"})
        Me.cmbTye.Location = New System.Drawing.Point(228, 138)
        Me.cmbTye.Name = "cmbTye"
        Me.cmbTye.Size = New System.Drawing.Size(197, 24)
        Me.cmbTye.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(101, 188)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmApplicationIns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 242)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbTye)
        Me.Controls.Add(Me.dtInspection)
        Me.Controls.Add(Me.txtESTABid)
        Me.Controls.Add(Me.lblEstabID)
        Me.Controls.Add(Me.txtAppID)
        Me.Controls.Add(Me.lblAppID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtEstab)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmApplicationIns"
        Me.Text = "Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEstab As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtAppID As System.Windows.Forms.TextBox
    Friend WithEvents lblAppID As System.Windows.Forms.Label
    Friend WithEvents txtESTABid As System.Windows.Forms.TextBox
    Friend WithEvents lblEstabID As System.Windows.Forms.Label
    Friend WithEvents dtInspection As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTye As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
