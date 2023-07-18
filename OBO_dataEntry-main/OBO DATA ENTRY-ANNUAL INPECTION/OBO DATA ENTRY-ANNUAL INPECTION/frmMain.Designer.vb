<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlAnnual = New System.Windows.Forms.Panel()
        Me.InspectGB = New System.Windows.Forms.GroupBox()
        Me.cmbInspectorName = New System.Windows.Forms.ComboBox()
        Me.dtInspection = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.InspectionTeamAddBtn = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.OtherCB = New System.Windows.Forms.CheckBox()
        Me.FireSafetyCB = New System.Windows.Forms.CheckBox()
        Me.ElectronicsCB = New System.Windows.Forms.CheckBox()
        Me.MechanicalCB = New System.Windows.Forms.CheckBox()
        Me.ArchitecturalCB = New System.Windows.Forms.CheckBox()
        Me.AccessibilityCB = New System.Windows.Forms.CheckBox()
        Me.InspectorID = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PlumbingCB = New System.Windows.Forms.CheckBox()
        Me.ElectricalCB = New System.Windows.Forms.CheckBox()
        Me.LineGradeCB = New System.Windows.Forms.CheckBox()
        Me.InteriorDsgnCB = New System.Windows.Forms.CheckBox()
        Me.SanitaryCB = New System.Windows.Forms.CheckBox()
        Me.CivilStructuralCB = New System.Windows.Forms.CheckBox()
        Me.InspectorNameTB = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LocationZoningCB = New System.Windows.Forms.CheckBox()
        Me.ChiefGB = New System.Windows.Forms.GroupBox()
        Me.BuildingOffclRB = New System.Windows.Forms.RadioButton()
        Me.DivisionChfRB = New System.Windows.Forms.RadioButton()
        Me.SectionChfRB = New System.Windows.Forms.RadioButton()
        Me.ChiefSearchBtn = New System.Windows.Forms.Button()
        Me.ChiefAddBtn = New System.Windows.Forms.Button()
        Me.EngnrNameTB = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EngrID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EstablishmentProfileGB = New System.Windows.Forms.GroupBox()
        Me.cbApplicationList = New System.Windows.Forms.ComboBox()
        Me.EstabID = New System.Windows.Forms.Label()
        Me.InsID = New System.Windows.Forms.Label()
        Me.ConfirmBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OwnerNameTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddressTb = New System.Windows.Forms.TextBox()
        Me.lstOptions = New System.Windows.Forms.ComboBox()
        Me.Character_of_occupancy = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAnnual = New System.Windows.Forms.Button()
        Me.btnCerts = New System.Windows.Forms.Button()
        Me.btnApplication = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnInsIDSearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlAnnual.SuspendLayout()
        Me.InspectGB.SuspendLayout()
        Me.ChiefGB.SuspendLayout()
        Me.EstablishmentProfileGB.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.pnlAnnual)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(262, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1511, 933)
        Me.Panel1.TabIndex = 3
        '
        'pnlAnnual
        '
        Me.pnlAnnual.Controls.Add(Me.InspectGB)
        Me.pnlAnnual.Controls.Add(Me.ChiefGB)
        Me.pnlAnnual.Controls.Add(Me.EstablishmentProfileGB)
        Me.pnlAnnual.Location = New System.Drawing.Point(0, 0)
        Me.pnlAnnual.Name = "pnlAnnual"
        Me.pnlAnnual.Size = New System.Drawing.Size(1509, 933)
        Me.pnlAnnual.TabIndex = 0
        Me.pnlAnnual.Visible = False
        '
        'InspectGB
        '
        Me.InspectGB.Controls.Add(Me.btnInsIDSearch)
        Me.InspectGB.Controls.Add(Me.cmbInspectorName)
        Me.InspectGB.Controls.Add(Me.dtInspection)
        Me.InspectGB.Controls.Add(Me.Label13)
        Me.InspectGB.Controls.Add(Me.InspectionTeamAddBtn)
        Me.InspectGB.Controls.Add(Me.TextBox4)
        Me.InspectGB.Controls.Add(Me.OtherCB)
        Me.InspectGB.Controls.Add(Me.FireSafetyCB)
        Me.InspectGB.Controls.Add(Me.ElectronicsCB)
        Me.InspectGB.Controls.Add(Me.MechanicalCB)
        Me.InspectGB.Controls.Add(Me.ArchitecturalCB)
        Me.InspectGB.Controls.Add(Me.AccessibilityCB)
        Me.InspectGB.Controls.Add(Me.InspectorID)
        Me.InspectGB.Controls.Add(Me.Label25)
        Me.InspectGB.Controls.Add(Me.PlumbingCB)
        Me.InspectGB.Controls.Add(Me.ElectricalCB)
        Me.InspectGB.Controls.Add(Me.LineGradeCB)
        Me.InspectGB.Controls.Add(Me.InteriorDsgnCB)
        Me.InspectGB.Controls.Add(Me.SanitaryCB)
        Me.InspectGB.Controls.Add(Me.CivilStructuralCB)
        Me.InspectGB.Controls.Add(Me.InspectorNameTB)
        Me.InspectGB.Controls.Add(Me.Label27)
        Me.InspectGB.Controls.Add(Me.LocationZoningCB)
        Me.InspectGB.Enabled = False
        Me.InspectGB.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InspectGB.Location = New System.Drawing.Point(9, 470)
        Me.InspectGB.Name = "InspectGB"
        Me.InspectGB.Size = New System.Drawing.Size(884, 430)
        Me.InspectGB.TabIndex = 32
        Me.InspectGB.TabStop = False
        Me.InspectGB.Text = "INSPECTION TEAM"
        '
        'cmbInspectorName
        '
        Me.cmbInspectorName.DropDownHeight = 120
        Me.cmbInspectorName.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInspectorName.FormattingEnabled = True
        Me.cmbInspectorName.IntegralHeight = False
        Me.cmbInspectorName.Location = New System.Drawing.Point(155, 45)
        Me.cmbInspectorName.MaximumSize = New System.Drawing.Size(480, 0)
        Me.cmbInspectorName.MinimumSize = New System.Drawing.Size(479, 0)
        Me.cmbInspectorName.Name = "cmbInspectorName"
        Me.cmbInspectorName.Size = New System.Drawing.Size(479, 33)
        Me.cmbInspectorName.TabIndex = 22
        '
        'dtInspection
        '
        Me.dtInspection.CalendarFont = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInspection.CustomFormat = "MM/dd/yyyy"
        Me.dtInspection.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInspection.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInspection.Location = New System.Drawing.Point(459, 87)
        Me.dtInspection.MaximumSize = New System.Drawing.Size(240, 31)
        Me.dtInspection.MinimumSize = New System.Drawing.Size(200, 30)
        Me.dtInspection.Name = "dtInspection"
        Me.dtInspection.Size = New System.Drawing.Size(200, 31)
        Me.dtInspection.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(301, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 25)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Inspection Date:"
        '
        'InspectionTeamAddBtn
        '
        Me.InspectionTeamAddBtn.BackColor = System.Drawing.Color.Coral
        Me.InspectionTeamAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.InspectionTeamAddBtn.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InspectionTeamAddBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InspectionTeamAddBtn.Location = New System.Drawing.Point(27, 372)
        Me.InspectionTeamAddBtn.Name = "InspectionTeamAddBtn"
        Me.InspectionTeamAddBtn.Size = New System.Drawing.Size(86, 38)
        Me.InspectionTeamAddBtn.TabIndex = 68
        Me.InspectionTeamAddBtn.Text = "&Save"
        Me.InspectionTeamAddBtn.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(224, 323)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(148, 31)
        Me.TextBox4.TabIndex = 21
        '
        'OtherCB
        '
        Me.OtherCB.AutoSize = True
        Me.OtherCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherCB.Location = New System.Drawing.Point(27, 323)
        Me.OtherCB.Name = "OtherCB"
        Me.OtherCB.Size = New System.Drawing.Size(191, 29)
        Me.OtherCB.TabIndex = 20
        Me.OtherCB.Text = "OTHERS (SPECIFY)"
        Me.OtherCB.UseVisualStyleBackColor = True
        '
        'FireSafetyCB
        '
        Me.FireSafetyCB.AutoSize = True
        Me.FireSafetyCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FireSafetyCB.Location = New System.Drawing.Point(677, 274)
        Me.FireSafetyCB.Name = "FireSafetyCB"
        Me.FireSafetyCB.Size = New System.Drawing.Size(141, 29)
        Me.FireSafetyCB.TabIndex = 19
        Me.FireSafetyCB.Text = "FIRE SAFETY"
        Me.FireSafetyCB.UseVisualStyleBackColor = True
        '
        'ElectronicsCB
        '
        Me.ElectronicsCB.AutoSize = True
        Me.ElectronicsCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElectronicsCB.Location = New System.Drawing.Point(677, 225)
        Me.ElectronicsCB.Name = "ElectronicsCB"
        Me.ElectronicsCB.Size = New System.Drawing.Size(154, 29)
        Me.ElectronicsCB.TabIndex = 16
        Me.ElectronicsCB.Text = "ELECTRONICS"
        Me.ElectronicsCB.UseVisualStyleBackColor = True
        '
        'MechanicalCB
        '
        Me.MechanicalCB.AutoSize = True
        Me.MechanicalCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MechanicalCB.Location = New System.Drawing.Point(677, 177)
        Me.MechanicalCB.Name = "MechanicalCB"
        Me.MechanicalCB.Size = New System.Drawing.Size(156, 29)
        Me.MechanicalCB.TabIndex = 13
        Me.MechanicalCB.Text = "MECHANICAL"
        Me.MechanicalCB.UseVisualStyleBackColor = True
        '
        'ArchitecturalCB
        '
        Me.ArchitecturalCB.AutoSize = True
        Me.ArchitecturalCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchitecturalCB.Location = New System.Drawing.Point(677, 130)
        Me.ArchitecturalCB.Name = "ArchitecturalCB"
        Me.ArchitecturalCB.Size = New System.Drawing.Size(180, 29)
        Me.ArchitecturalCB.TabIndex = 10
        Me.ArchitecturalCB.Text = "ARCHITECTURAL"
        Me.ArchitecturalCB.UseVisualStyleBackColor = True
        '
        'AccessibilityCB
        '
        Me.AccessibilityCB.AutoSize = True
        Me.AccessibilityCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessibilityCB.Location = New System.Drawing.Point(376, 274)
        Me.AccessibilityCB.Name = "AccessibilityCB"
        Me.AccessibilityCB.Size = New System.Drawing.Size(160, 29)
        Me.AccessibilityCB.TabIndex = 18
        Me.AccessibilityCB.Text = "ACCESSIBILITY"
        Me.AccessibilityCB.UseVisualStyleBackColor = True
        '
        'InspectorID
        '
        Me.InspectorID.Enabled = False
        Me.InspectorID.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InspectorID.Location = New System.Drawing.Point(155, 86)
        Me.InspectorID.Name = "InspectorID"
        Me.InspectorID.Size = New System.Drawing.Size(131, 31)
        Me.InspectorID.TabIndex = 45
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(22, 92)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(132, 25)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Inspector ID : "
        '
        'PlumbingCB
        '
        Me.PlumbingCB.AutoSize = True
        Me.PlumbingCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlumbingCB.Location = New System.Drawing.Point(376, 225)
        Me.PlumbingCB.Name = "PlumbingCB"
        Me.PlumbingCB.Size = New System.Drawing.Size(130, 29)
        Me.PlumbingCB.TabIndex = 15
        Me.PlumbingCB.Text = "PLUMBING"
        Me.PlumbingCB.UseVisualStyleBackColor = True
        '
        'ElectricalCB
        '
        Me.ElectricalCB.AutoSize = True
        Me.ElectricalCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElectricalCB.Location = New System.Drawing.Point(376, 177)
        Me.ElectricalCB.Name = "ElectricalCB"
        Me.ElectricalCB.Size = New System.Drawing.Size(137, 29)
        Me.ElectricalCB.TabIndex = 12
        Me.ElectricalCB.Text = "ELECTRICAL"
        Me.ElectricalCB.UseVisualStyleBackColor = True
        '
        'LineGradeCB
        '
        Me.LineGradeCB.AutoSize = True
        Me.LineGradeCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineGradeCB.Location = New System.Drawing.Point(376, 130)
        Me.LineGradeCB.Name = "LineGradeCB"
        Me.LineGradeCB.Size = New System.Drawing.Size(294, 29)
        Me.LineGradeCB.TabIndex = 9
        Me.LineGradeCB.Text = "LINE AND GRADE (GEODETIC)"
        Me.LineGradeCB.UseVisualStyleBackColor = True
        '
        'InteriorDsgnCB
        '
        Me.InteriorDsgnCB.AutoSize = True
        Me.InteriorDsgnCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InteriorDsgnCB.Location = New System.Drawing.Point(28, 274)
        Me.InteriorDsgnCB.Name = "InteriorDsgnCB"
        Me.InteriorDsgnCB.Size = New System.Drawing.Size(192, 29)
        Me.InteriorDsgnCB.TabIndex = 17
        Me.InteriorDsgnCB.Text = "INTERIOR DESIGN"
        Me.InteriorDsgnCB.UseVisualStyleBackColor = True
        '
        'SanitaryCB
        '
        Me.SanitaryCB.AutoSize = True
        Me.SanitaryCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanitaryCB.Location = New System.Drawing.Point(27, 225)
        Me.SanitaryCB.Name = "SanitaryCB"
        Me.SanitaryCB.Size = New System.Drawing.Size(123, 29)
        Me.SanitaryCB.TabIndex = 14
        Me.SanitaryCB.Text = "SANITARY"
        Me.SanitaryCB.UseVisualStyleBackColor = True
        '
        'CivilStructuralCB
        '
        Me.CivilStructuralCB.AutoSize = True
        Me.CivilStructuralCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CivilStructuralCB.Location = New System.Drawing.Point(28, 177)
        Me.CivilStructuralCB.Name = "CivilStructuralCB"
        Me.CivilStructuralCB.Size = New System.Drawing.Size(201, 29)
        Me.CivilStructuralCB.TabIndex = 11
        Me.CivilStructuralCB.Text = "CIVIL/STRUCTURAL"
        Me.CivilStructuralCB.UseVisualStyleBackColor = True
        '
        'InspectorNameTB
        '
        Me.InspectorNameTB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InspectorNameTB.Location = New System.Drawing.Point(459, 323)
        Me.InspectorNameTB.Name = "InspectorNameTB"
        Me.InspectorNameTB.Size = New System.Drawing.Size(339, 31)
        Me.InspectorNameTB.TabIndex = 6
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(47, 52)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 25)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Inspector :"
        '
        'LocationZoningCB
        '
        Me.LocationZoningCB.AutoSize = True
        Me.LocationZoningCB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationZoningCB.Location = New System.Drawing.Point(27, 130)
        Me.LocationZoningCB.Name = "LocationZoningCB"
        Me.LocationZoningCB.Size = New System.Drawing.Size(331, 29)
        Me.LocationZoningCB.TabIndex = 8
        Me.LocationZoningCB.Text = "LOCATION/ZONING OF LAND USE"
        Me.LocationZoningCB.UseVisualStyleBackColor = True
        '
        'ChiefGB
        '
        Me.ChiefGB.Controls.Add(Me.BuildingOffclRB)
        Me.ChiefGB.Controls.Add(Me.DivisionChfRB)
        Me.ChiefGB.Controls.Add(Me.SectionChfRB)
        Me.ChiefGB.Controls.Add(Me.ChiefSearchBtn)
        Me.ChiefGB.Controls.Add(Me.ChiefAddBtn)
        Me.ChiefGB.Controls.Add(Me.EngnrNameTB)
        Me.ChiefGB.Controls.Add(Me.Label11)
        Me.ChiefGB.Controls.Add(Me.EngrID)
        Me.ChiefGB.Controls.Add(Me.Label12)
        Me.ChiefGB.Enabled = False
        Me.ChiefGB.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChiefGB.Location = New System.Drawing.Point(899, 470)
        Me.ChiefGB.Name = "ChiefGB"
        Me.ChiefGB.Size = New System.Drawing.Size(601, 430)
        Me.ChiefGB.TabIndex = 33
        Me.ChiefGB.TabStop = False
        Me.ChiefGB.Text = "CHIEF'S"
        '
        'BuildingOffclRB
        '
        Me.BuildingOffclRB.AutoSize = True
        Me.BuildingOffclRB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildingOffclRB.Location = New System.Drawing.Point(43, 225)
        Me.BuildingOffclRB.Name = "BuildingOffclRB"
        Me.BuildingOffclRB.Size = New System.Drawing.Size(205, 29)
        Me.BuildingOffclRB.TabIndex = 26
        Me.BuildingOffclRB.TabStop = True
        Me.BuildingOffclRB.Text = "BUILDING OFFICIAL"
        Me.BuildingOffclRB.UseVisualStyleBackColor = True
        '
        'DivisionChfRB
        '
        Me.DivisionChfRB.AutoSize = True
        Me.DivisionChfRB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivisionChfRB.Location = New System.Drawing.Point(43, 177)
        Me.DivisionChfRB.Name = "DivisionChfRB"
        Me.DivisionChfRB.Size = New System.Drawing.Size(173, 29)
        Me.DivisionChfRB.TabIndex = 25
        Me.DivisionChfRB.TabStop = True
        Me.DivisionChfRB.Text = "DIVISION CHIEF"
        Me.DivisionChfRB.UseVisualStyleBackColor = True
        '
        'SectionChfRB
        '
        Me.SectionChfRB.AutoSize = True
        Me.SectionChfRB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionChfRB.Location = New System.Drawing.Point(43, 130)
        Me.SectionChfRB.Name = "SectionChfRB"
        Me.SectionChfRB.Size = New System.Drawing.Size(167, 29)
        Me.SectionChfRB.TabIndex = 24
        Me.SectionChfRB.TabStop = True
        Me.SectionChfRB.Text = "SECTION CHIEF"
        Me.SectionChfRB.UseVisualStyleBackColor = True
        '
        'ChiefSearchBtn
        '
        Me.ChiefSearchBtn.BackColor = System.Drawing.Color.Coral
        Me.ChiefSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChiefSearchBtn.Image = Global.OBO_DATA_ENTRY_ANNUAL_INPECTION.My.Resources.Resources.searchIcon
        Me.ChiefSearchBtn.Location = New System.Drawing.Point(457, 45)
        Me.ChiefSearchBtn.Name = "ChiefSearchBtn"
        Me.ChiefSearchBtn.Size = New System.Drawing.Size(36, 33)
        Me.ChiefSearchBtn.TabIndex = 70
        Me.ChiefSearchBtn.UseVisualStyleBackColor = False
        '
        'ChiefAddBtn
        '
        Me.ChiefAddBtn.BackColor = System.Drawing.Color.Coral
        Me.ChiefAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChiefAddBtn.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChiefAddBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChiefAddBtn.Location = New System.Drawing.Point(43, 374)
        Me.ChiefAddBtn.Name = "ChiefAddBtn"
        Me.ChiefAddBtn.Size = New System.Drawing.Size(86, 38)
        Me.ChiefAddBtn.TabIndex = 68
        Me.ChiefAddBtn.Text = "ADD"
        Me.ChiefAddBtn.UseVisualStyleBackColor = False
        '
        'EngnrNameTB
        '
        Me.EngnrNameTB.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EngnrNameTB.Location = New System.Drawing.Point(122, 45)
        Me.EngnrNameTB.Name = "EngnrNameTB"
        Me.EngnrNameTB.Size = New System.Drawing.Size(336, 31)
        Me.EngnrNameTB.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 25)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Engineer :"
        '
        'EngrID
        '
        Me.EngrID.Enabled = False
        Me.EngrID.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EngrID.Location = New System.Drawing.Point(122, 89)
        Me.EngrID.Name = "EngrID"
        Me.EngrID.Size = New System.Drawing.Size(186, 31)
        Me.EngrID.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 25)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "ENGR ID : "
        '
        'EstablishmentProfileGB
        '
        Me.EstablishmentProfileGB.Controls.Add(Me.cbApplicationList)
        Me.EstablishmentProfileGB.Controls.Add(Me.EstabID)
        Me.EstablishmentProfileGB.Controls.Add(Me.InsID)
        Me.EstablishmentProfileGB.Controls.Add(Me.ConfirmBtn)
        Me.EstablishmentProfileGB.Controls.Add(Me.Label6)
        Me.EstablishmentProfileGB.Controls.Add(Me.Label5)
        Me.EstablishmentProfileGB.Controls.Add(Me.OwnerNameTb)
        Me.EstablishmentProfileGB.Controls.Add(Me.Label4)
        Me.EstablishmentProfileGB.Controls.Add(Me.Label3)
        Me.EstablishmentProfileGB.Controls.Add(Me.Label2)
        Me.EstablishmentProfileGB.Controls.Add(Me.Label1)
        Me.EstablishmentProfileGB.Controls.Add(Me.AddressTb)
        Me.EstablishmentProfileGB.Controls.Add(Me.lstOptions)
        Me.EstablishmentProfileGB.Controls.Add(Me.Character_of_occupancy)
        Me.EstablishmentProfileGB.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstablishmentProfileGB.Location = New System.Drawing.Point(9, 33)
        Me.EstablishmentProfileGB.Name = "EstablishmentProfileGB"
        Me.EstablishmentProfileGB.Size = New System.Drawing.Size(670, 431)
        Me.EstablishmentProfileGB.TabIndex = 31
        Me.EstablishmentProfileGB.TabStop = False
        Me.EstablishmentProfileGB.Text = "ESTABLISHMENT PROFILE"
        '
        'cbApplicationList
        '
        Me.cbApplicationList.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbApplicationList.FormattingEnabled = True
        Me.cbApplicationList.Location = New System.Drawing.Point(15, 79)
        Me.cbApplicationList.MaximumSize = New System.Drawing.Size(480, 0)
        Me.cbApplicationList.MinimumSize = New System.Drawing.Size(479, 0)
        Me.cbApplicationList.Name = "cbApplicationList"
        Me.cbApplicationList.Size = New System.Drawing.Size(479, 33)
        Me.cbApplicationList.TabIndex = 21
        '
        'EstabID
        '
        Me.EstabID.AutoSize = True
        Me.EstabID.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstabID.Location = New System.Drawing.Point(364, 51)
        Me.EstabID.Name = "EstabID"
        Me.EstabID.Size = New System.Drawing.Size(78, 25)
        Me.EstabID.TabIndex = 20
        Me.EstabID.Text = "EstabID"
        '
        'InsID
        '
        Me.InsID.AutoSize = True
        Me.InsID.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsID.Location = New System.Drawing.Point(239, 51)
        Me.InsID.Name = "InsID"
        Me.InsID.Size = New System.Drawing.Size(57, 25)
        Me.InsID.TabIndex = 19
        Me.InsID.Text = "InsID"
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.BackColor = System.Drawing.Color.Coral
        Me.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmBtn.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmBtn.Location = New System.Drawing.Point(14, 373)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(127, 38)
        Me.ConfirmBtn.TabIndex = 6
        Me.ConfirmBtn.Text = "CONFIRM"
        Me.ConfirmBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(543, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Group"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Address"
        '
        'OwnerNameTb
        '
        Me.OwnerNameTb.Enabled = False
        Me.OwnerNameTb.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OwnerNameTb.Location = New System.Drawing.Point(14, 160)
        Me.OwnerNameTb.Name = "OwnerNameTb"
        Me.OwnerNameTb.Size = New System.Drawing.Size(632, 31)
        Me.OwnerNameTb.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Owner"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Application List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Character of Occupancy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 38)
        Me.Label1.TabIndex = 10
        '
        'AddressTb
        '
        Me.AddressTb.Enabled = False
        Me.AddressTb.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTb.Location = New System.Drawing.Point(14, 236)
        Me.AddressTb.Name = "AddressTb"
        Me.AddressTb.Size = New System.Drawing.Size(632, 31)
        Me.AddressTb.TabIndex = 3
        '
        'lstOptions
        '
        Me.lstOptions.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOptions.FormattingEnabled = True
        Me.lstOptions.Location = New System.Drawing.Point(544, 315)
        Me.lstOptions.Name = "lstOptions"
        Me.lstOptions.Size = New System.Drawing.Size(102, 33)
        Me.lstOptions.TabIndex = 5
        '
        'Character_of_occupancy
        '
        Me.Character_of_occupancy.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Character_of_occupancy.FormattingEnabled = True
        Me.Character_of_occupancy.Location = New System.Drawing.Point(15, 315)
        Me.Character_of_occupancy.Name = "Character_of_occupancy"
        Me.Character_of_occupancy.Size = New System.Drawing.Size(512, 33)
        Me.Character_of_occupancy.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.Controls.Add(Me.btnAnnual)
        Me.Panel2.Controls.Add(Me.btnCerts)
        Me.Panel2.Controls.Add(Me.btnApplication)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 1015)
        Me.Panel2.TabIndex = 1
        '
        'btnAnnual
        '
        Me.btnAnnual.BackColor = System.Drawing.Color.Coral
        Me.btnAnnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnual.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnual.Location = New System.Drawing.Point(0, 399)
        Me.btnAnnual.Name = "btnAnnual"
        Me.btnAnnual.Size = New System.Drawing.Size(262, 64)
        Me.btnAnnual.TabIndex = 24
        Me.btnAnnual.Text = "Annual"
        Me.btnAnnual.UseVisualStyleBackColor = False
        '
        'btnCerts
        '
        Me.btnCerts.BackColor = System.Drawing.Color.Coral
        Me.btnCerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerts.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerts.Location = New System.Drawing.Point(0, 462)
        Me.btnCerts.Name = "btnCerts"
        Me.btnCerts.Size = New System.Drawing.Size(262, 64)
        Me.btnCerts.TabIndex = 23
        Me.btnCerts.Text = "Certificates"
        Me.btnCerts.UseVisualStyleBackColor = False
        '
        'btnApplication
        '
        Me.btnApplication.BackColor = System.Drawing.Color.Coral
        Me.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplication.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplication.Location = New System.Drawing.Point(0, 337)
        Me.btnApplication.Name = "btnApplication"
        Me.btnApplication.Size = New System.Drawing.Size(262, 64)
        Me.btnApplication.TabIndex = 21
        Me.btnApplication.Text = "Application"
        Me.btnApplication.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(81, 260)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(114, 32)
        Me.Label33.TabIndex = 19
        Me.Label33.Text = "OFFICIAL"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(28, 228)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(212, 32)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "OF THE BUILDING"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(90, 196)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(91, 32)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "OFFICE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(262, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1511, 82)
        Me.Panel3.TabIndex = 2
        '
        'btnInsIDSearch
        '
        Me.btnInsIDSearch.BackColor = System.Drawing.Color.Coral
        Me.btnInsIDSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsIDSearch.Image = Global.OBO_DATA_ENTRY_ANNUAL_INPECTION.My.Resources.Resources.searchIcon
        Me.btnInsIDSearch.Location = New System.Drawing.Point(633, 45)
        Me.btnInsIDSearch.Name = "btnInsIDSearch"
        Me.btnInsIDSearch.Size = New System.Drawing.Size(37, 36)
        Me.btnInsIDSearch.TabIndex = 70
        Me.btnInsIDSearch.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1773, 1015)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "OBO"
        Me.Panel1.ResumeLayout(False)
        Me.pnlAnnual.ResumeLayout(False)
        Me.InspectGB.ResumeLayout(False)
        Me.InspectGB.PerformLayout()
        Me.ChiefGB.ResumeLayout(False)
        Me.ChiefGB.PerformLayout()
        Me.EstablishmentProfileGB.ResumeLayout(False)
        Me.EstablishmentProfileGB.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnApplication As System.Windows.Forms.Button
    Friend WithEvents btnCerts As System.Windows.Forms.Button
    Friend WithEvents pnlAnnual As System.Windows.Forms.Panel
    Friend WithEvents InspectGB As System.Windows.Forms.GroupBox
    Friend WithEvents dtInspection As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents InspectionTeamAddBtn As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents OtherCB As System.Windows.Forms.CheckBox
    Friend WithEvents FireSafetyCB As System.Windows.Forms.CheckBox
    Friend WithEvents ElectronicsCB As System.Windows.Forms.CheckBox
    Friend WithEvents MechanicalCB As System.Windows.Forms.CheckBox
    Friend WithEvents ArchitecturalCB As System.Windows.Forms.CheckBox
    Friend WithEvents AccessibilityCB As System.Windows.Forms.CheckBox
    Friend WithEvents InspectorID As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PlumbingCB As System.Windows.Forms.CheckBox
    Friend WithEvents ElectricalCB As System.Windows.Forms.CheckBox
    Friend WithEvents LineGradeCB As System.Windows.Forms.CheckBox
    Friend WithEvents InteriorDsgnCB As System.Windows.Forms.CheckBox
    Friend WithEvents SanitaryCB As System.Windows.Forms.CheckBox
    Friend WithEvents CivilStructuralCB As System.Windows.Forms.CheckBox
    Friend WithEvents InspectorNameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents LocationZoningCB As System.Windows.Forms.CheckBox
    Friend WithEvents ChiefGB As System.Windows.Forms.GroupBox
    Friend WithEvents BuildingOffclRB As System.Windows.Forms.RadioButton
    Friend WithEvents DivisionChfRB As System.Windows.Forms.RadioButton
    Friend WithEvents SectionChfRB As System.Windows.Forms.RadioButton
    Friend WithEvents ChiefAddBtn As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents EngrID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents EstablishmentProfileGB As System.Windows.Forms.GroupBox
    Friend WithEvents EstabID As System.Windows.Forms.Label
    Friend WithEvents InsID As System.Windows.Forms.Label
    Friend WithEvents ConfirmBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OwnerNameTb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddressTb As System.Windows.Forms.TextBox
    Friend WithEvents lstOptions As System.Windows.Forms.ComboBox
    Friend WithEvents Character_of_occupancy As System.Windows.Forms.ComboBox
    Friend WithEvents cbApplicationList As System.Windows.Forms.ComboBox
    Friend WithEvents btnAnnual As System.Windows.Forms.Button
    Friend WithEvents cmbInspectorName As System.Windows.Forms.ComboBox
    Friend WithEvents ChiefSearchBtn As System.Windows.Forms.Button
    Friend WithEvents EngnrNameTB As System.Windows.Forms.TextBox
    Friend WithEvents btnInsIDSearch As System.Windows.Forms.Button

End Class
