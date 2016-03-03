<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbxEvent_distance = New System.Windows.Forms.ComboBox()
        Me.txtEvent_Location = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtpEvent_Date = New System.Windows.Forms.DateTimePicker()
        Me.txtEvent_Reg_Fee = New System.Windows.Forms.TextBox()
        Me.txtEvent_Name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnClearAthlete = New System.Windows.Forms.Button()
        Me.btnDeleteAthlete = New System.Windows.Forms.Button()
        Me.btnUpdateAthlete = New System.Windows.Forms.Button()
        Me.btnAddAthlete = New System.Windows.Forms.Button()
        Me.dtpRegistrationdate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.lstviewRaces = New System.Windows.Forms.ListView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtOMfee = New System.Windows.Forms.TextBox()
        Me.txtMNumber = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbmNumber = New System.Windows.Forms.ComboBox()
        Me.cmbEName = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.numSeconds = New System.Windows.Forms.NumericUpDown()
        Me.numMinutes = New System.Windows.Forms.NumericUpDown()
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnrDelete = New System.Windows.Forms.Button()
        Me.btnrUpdate = New System.Windows.Forms.Button()
        Me.btnrClear = New System.Windows.Forms.Button()
        Me.btnrAdd = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(40, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(685, 521)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleDescription = ""
        Me.TabPage1.AccessibleName = ""
        Me.TabPage1.Controls.Add(Me.cbxEvent_distance)
        Me.TabPage1.Controls.Add(Me.txtEvent_Location)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnUpdate)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.dtpEvent_Date)
        Me.TabPage1.Controls.Add(Me.txtEvent_Reg_Fee)
        Me.TabPage1.Controls.Add(Me.txtEvent_Name)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(677, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manage Events"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbxEvent_distance
        '
        Me.cbxEvent_distance.AccessibleDescription = ""
        Me.cbxEvent_distance.AccessibleName = ""
        Me.cbxEvent_distance.FormattingEnabled = True
        Me.cbxEvent_distance.Items.AddRange(New Object() {"5KM", "10KM", "21KM", "42KM", "50KM", "90KM"})
        Me.cbxEvent_distance.Location = New System.Drawing.Point(302, 367)
        Me.cbxEvent_distance.Name = "cbxEvent_distance"
        Me.cbxEvent_distance.Size = New System.Drawing.Size(121, 21)
        Me.cbxEvent_distance.TabIndex = 5
        Me.cbxEvent_distance.Tag = ""
        Me.cbxEvent_distance.Text = "Select"
        '
        'txtEvent_Location
        '
        Me.txtEvent_Location.Location = New System.Drawing.Point(302, 302)
        Me.txtEvent_Location.Name = "txtEvent_Location"
        Me.txtEvent_Location.Size = New System.Drawing.Size(200, 20)
        Me.txtEvent_Location.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(468, 446)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(357, 446)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(238, 446)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(129, 446)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtpEvent_Date
        '
        Me.dtpEvent_Date.Location = New System.Drawing.Point(302, 172)
        Me.dtpEvent_Date.Name = "dtpEvent_Date"
        Me.dtpEvent_Date.Size = New System.Drawing.Size(200, 20)
        Me.dtpEvent_Date.TabIndex = 2
        '
        'txtEvent_Reg_Fee
        '
        Me.txtEvent_Reg_Fee.Location = New System.Drawing.Point(302, 231)
        Me.txtEvent_Reg_Fee.Name = "txtEvent_Reg_Fee"
        Me.txtEvent_Reg_Fee.Size = New System.Drawing.Size(200, 20)
        Me.txtEvent_Reg_Fee.TabIndex = 3
        '
        'txtEvent_Name
        '
        Me.txtEvent_Name.Location = New System.Drawing.Point(302, 100)
        Me.txtEvent_Name.Name = "txtEvent_Name"
        Me.txtEvent_Name.Size = New System.Drawing.Size(200, 20)
        Me.txtEvent_Name.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Distance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Event Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Registration Fee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Event Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Event Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Athletic Events"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnClearAthlete)
        Me.TabPage2.Controls.Add(Me.btnDeleteAthlete)
        Me.TabPage2.Controls.Add(Me.btnUpdateAthlete)
        Me.TabPage2.Controls.Add(Me.btnAddAthlete)
        Me.TabPage2.Controls.Add(Me.dtpRegistrationdate)
        Me.TabPage2.Controls.Add(Me.dtpDateofbirth)
        Me.TabPage2.Controls.Add(Me.radFemale)
        Me.TabPage2.Controls.Add(Me.radMale)
        Me.TabPage2.Controls.Add(Me.lstviewRaces)
        Me.TabPage2.Controls.Add(Me.txtName)
        Me.TabPage2.Controls.Add(Me.txtOMfee)
        Me.TabPage2.Controls.Add(Me.txtMNumber)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(677, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Athletes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnClearAthlete
        '
        Me.btnClearAthlete.Location = New System.Drawing.Point(498, 458)
        Me.btnClearAthlete.Name = "btnClearAthlete"
        Me.btnClearAthlete.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAthlete.TabIndex = 11
        Me.btnClearAthlete.Text = "Clear"
        Me.btnClearAthlete.UseVisualStyleBackColor = True
        '
        'btnDeleteAthlete
        '
        Me.btnDeleteAthlete.Location = New System.Drawing.Point(362, 458)
        Me.btnDeleteAthlete.Name = "btnDeleteAthlete"
        Me.btnDeleteAthlete.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteAthlete.TabIndex = 10
        Me.btnDeleteAthlete.Text = "Delete"
        Me.btnDeleteAthlete.UseVisualStyleBackColor = True
        '
        'btnUpdateAthlete
        '
        Me.btnUpdateAthlete.Location = New System.Drawing.Point(224, 458)
        Me.btnUpdateAthlete.Name = "btnUpdateAthlete"
        Me.btnUpdateAthlete.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateAthlete.TabIndex = 9
        Me.btnUpdateAthlete.Text = "Update"
        Me.btnUpdateAthlete.UseVisualStyleBackColor = True
        '
        'btnAddAthlete
        '
        Me.btnAddAthlete.Location = New System.Drawing.Point(94, 458)
        Me.btnAddAthlete.Name = "btnAddAthlete"
        Me.btnAddAthlete.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAthlete.TabIndex = 8
        Me.btnAddAthlete.Text = "Add"
        Me.btnAddAthlete.UseVisualStyleBackColor = True
        '
        'dtpRegistrationdate
        '
        Me.dtpRegistrationdate.Location = New System.Drawing.Point(362, 255)
        Me.dtpRegistrationdate.Name = "dtpRegistrationdate"
        Me.dtpRegistrationdate.Size = New System.Drawing.Size(200, 20)
        Me.dtpRegistrationdate.TabIndex = 6
        '
        'dtpDateofbirth
        '
        Me.dtpDateofbirth.Location = New System.Drawing.Point(362, 161)
        Me.dtpDateofbirth.Name = "dtpDateofbirth"
        Me.dtpDateofbirth.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateofbirth.TabIndex = 3
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(459, 208)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 5
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Location = New System.Drawing.Point(362, 208)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 4
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'lstviewRaces
        '
        Me.lstviewRaces.AllowColumnReorder = True
        Me.lstviewRaces.AllowDrop = True
        Me.lstviewRaces.Location = New System.Drawing.Point(362, 350)
        Me.lstviewRaces.Name = "lstviewRaces"
        Me.lstviewRaces.Size = New System.Drawing.Size(265, 78)
        Me.lstviewRaces.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstviewRaces.TabIndex = 11
        Me.lstviewRaces.UseCompatibleStateImageBehavior = False
        Me.lstviewRaces.View = System.Windows.Forms.View.List
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(362, 114)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 2
        '
        'txtOMfee
        '
        Me.txtOMfee.Location = New System.Drawing.Point(362, 303)
        Me.txtOMfee.Name = "txtOMfee"
        Me.txtOMfee.Size = New System.Drawing.Size(200, 20)
        Me.txtOMfee.TabIndex = 7
        '
        'txtMNumber
        '
        Me.txtMNumber.Location = New System.Drawing.Point(362, 66)
        Me.txtMNumber.MaxLength = 14
        Me.txtMNumber.Name = "txtMNumber"
        Me.txtMNumber.Size = New System.Drawing.Size(200, 20)
        Me.txtMNumber.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(91, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Name and Surname"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(91, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Date of Birth"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Gender"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(91, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Date of Registration"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Races Competed and Results"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(91, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Outstanding Membership Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Membership Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(278, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Manage Athletes"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.cmbmNumber)
        Me.TabPage3.Controls.Add(Me.cmbEName)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.numSeconds)
        Me.TabPage3.Controls.Add(Me.numMinutes)
        Me.TabPage3.Controls.Add(Me.numHours)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.btnrDelete)
        Me.TabPage3.Controls.Add(Me.btnrUpdate)
        Me.TabPage3.Controls.Add(Me.btnrClear)
        Me.TabPage3.Controls.Add(Me.btnrAdd)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(677, 495)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Manage Results"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(323, 190)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Minute(s)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(398, 190)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Second(s)"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(250, 190)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Hour(s)"
        '
        'cmbmNumber
        '
        Me.cmbmNumber.FormattingEnabled = True
        Me.cmbmNumber.Location = New System.Drawing.Point(250, 69)
        Me.cmbmNumber.Name = "cmbmNumber"
        Me.cmbmNumber.Size = New System.Drawing.Size(200, 21)
        Me.cmbmNumber.TabIndex = 1
        Me.cmbmNumber.Text = "Select Membership Number"
        '
        'cmbEName
        '
        Me.cmbEName.FormattingEnabled = True
        Me.cmbEName.Location = New System.Drawing.Point(250, 141)
        Me.cmbEName.Name = "cmbEName"
        Me.cmbEName.Size = New System.Drawing.Size(200, 21)
        Me.cmbEName.TabIndex = 2
        Me.cmbEName.Text = "Select Event Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(306, 211)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(10, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(382, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = ":"
        '
        'numSeconds
        '
        Me.numSeconds.Location = New System.Drawing.Point(401, 209)
        Me.numSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numSeconds.Name = "numSeconds"
        Me.numSeconds.Size = New System.Drawing.Size(49, 20)
        Me.numSeconds.TabIndex = 5
        '
        'numMinutes
        '
        Me.numMinutes.Location = New System.Drawing.Point(326, 209)
        Me.numMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numMinutes.Name = "numMinutes"
        Me.numMinutes.Size = New System.Drawing.Size(50, 20)
        Me.numMinutes.TabIndex = 4
        '
        'numHours
        '
        Me.numHours.AllowDrop = True
        Me.numHours.Location = New System.Drawing.Point(250, 209)
        Me.numHours.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(48, 20)
        Me.numHours.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(69, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Race Results"
        '
        'btnrDelete
        '
        Me.btnrDelete.Location = New System.Drawing.Point(273, 308)
        Me.btnrDelete.Name = "btnrDelete"
        Me.btnrDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnrDelete.TabIndex = 8
        Me.btnrDelete.Text = "Delete"
        Me.btnrDelete.UseVisualStyleBackColor = True
        '
        'btnrUpdate
        '
        Me.btnrUpdate.Location = New System.Drawing.Point(172, 308)
        Me.btnrUpdate.Name = "btnrUpdate"
        Me.btnrUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnrUpdate.TabIndex = 7
        Me.btnrUpdate.Text = "Update"
        Me.btnrUpdate.UseVisualStyleBackColor = True
        '
        'btnrClear
        '
        Me.btnrClear.Location = New System.Drawing.Point(375, 308)
        Me.btnrClear.Name = "btnrClear"
        Me.btnrClear.Size = New System.Drawing.Size(75, 23)
        Me.btnrClear.TabIndex = 9
        Me.btnrClear.Text = "Clear"
        Me.btnrClear.UseVisualStyleBackColor = True
        '
        'btnrAdd
        '
        Me.btnrAdd.Location = New System.Drawing.Point(69, 308)
        Me.btnrAdd.Name = "btnrAdd"
        Me.btnrAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnrAdd.TabIndex = 6
        Me.btnrAdd.Text = "Add"
        Me.btnrAdd.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(288, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Maintain Race Results"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(66, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Event Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(66, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Membership Number"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(306, 576)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close "
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(496, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 651)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtEvent_Reg_Fee As System.Windows.Forms.TextBox
    Friend WithEvents txtEvent_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cbxEvent_distance As System.Windows.Forms.ComboBox
    Friend WithEvents txtEvent_Location As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dtpEvent_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents lstviewRaces As System.Windows.Forms.ListView
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtOMfee As System.Windows.Forms.TextBox
    Friend WithEvents txtMNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpRegistrationdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnClearAthlete As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAthlete As System.Windows.Forms.Button
    Friend WithEvents btnUpdateAthlete As System.Windows.Forms.Button
    Friend WithEvents btnAddAthlete As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnrDelete As System.Windows.Forms.Button
    Friend WithEvents btnrUpdate As System.Windows.Forms.Button
    Friend WithEvents btnrClear As System.Windows.Forms.Button
    Friend WithEvents btnrAdd As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents numSeconds As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMinutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents numHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbEName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label

End Class
