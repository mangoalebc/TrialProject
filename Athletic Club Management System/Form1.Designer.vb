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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMNumber = New System.Windows.Forms.TextBox()
        Me.txtOMfee = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lstviewRaces = New System.Windows.Forms.ListView()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.dtpDateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.dtpRegistrationdate = New System.Windows.Forms.DateTimePicker()
        Me.btnAddAthlete = New System.Windows.Forms.Button()
        Me.btnUpdateAthlete = New System.Windows.Forms.Button()
        Me.btnDeleteAthlete = New System.Windows.Forms.Button()
        Me.btnClearAthlete = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.cbxEvent_distance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEvent_distance.FormattingEnabled = True
        Me.cbxEvent_distance.Items.AddRange(New Object() {"5KM", "10KM", "21KM", "42KM", "50KM", "90KM"})
        Me.cbxEvent_distance.Location = New System.Drawing.Point(302, 367)
        Me.cbxEvent_distance.Name = "cbxEvent_distance"
        Me.cbxEvent_distance.Size = New System.Drawing.Size(121, 21)
        Me.cbxEvent_distance.TabIndex = 14
        '
        'txtEvent_Location
        '
        Me.txtEvent_Location.Location = New System.Drawing.Point(302, 302)
        Me.txtEvent_Location.Name = "txtEvent_Location"
        Me.txtEvent_Location.Size = New System.Drawing.Size(200, 20)
        Me.txtEvent_Location.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(468, 446)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(357, 446)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(238, 446)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(129, 446)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtpEvent_Date
        '
        Me.dtpEvent_Date.Location = New System.Drawing.Point(302, 172)
        Me.dtpEvent_Date.Name = "dtpEvent_Date"
        Me.dtpEvent_Date.Size = New System.Drawing.Size(200, 20)
        Me.dtpEvent_Date.TabIndex = 8
        '
        'txtEvent_Reg_Fee
        '
        Me.txtEvent_Reg_Fee.Location = New System.Drawing.Point(302, 231)
        Me.txtEvent_Reg_Fee.Name = "txtEvent_Reg_Fee"
        Me.txtEvent_Reg_Fee.Size = New System.Drawing.Size(200, 20)
        Me.txtEvent_Reg_Fee.TabIndex = 7
        '
        'txtEvent_Name
        '
        Me.txtEvent_Name.Location = New System.Drawing.Point(302, 100)
        Me.txtEvent_Name.Name = "txtEvent_Name"
        Me.txtEvent_Name.Size = New System.Drawing.Size(200, 20)
        Me.txtEvent_Name.TabIndex = 6
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
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(677, 495)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Manage Results"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(306, 576)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 23)
        Me.btnClose.TabIndex = 1
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Membership Number"
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Races Competed and Results"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Gender"
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(91, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Name and Surname"
        '
        'txtMNumber
        '
        Me.txtMNumber.Location = New System.Drawing.Point(362, 66)
        Me.txtMNumber.Name = "txtMNumber"
        Me.txtMNumber.Size = New System.Drawing.Size(200, 20)
        Me.txtMNumber.TabIndex = 8
        '
        'txtOMfee
        '
        Me.txtOMfee.Location = New System.Drawing.Point(362, 303)
        Me.txtOMfee.Name = "txtOMfee"
        Me.txtOMfee.Size = New System.Drawing.Size(200, 20)
        Me.txtOMfee.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(362, 114)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 10
        '
        'lstviewRaces
        '
        Me.lstviewRaces.Location = New System.Drawing.Point(362, 350)
        Me.lstviewRaces.Name = "lstviewRaces"
        Me.lstviewRaces.Size = New System.Drawing.Size(211, 78)
        Me.lstviewRaces.TabIndex = 11
        Me.lstviewRaces.UseCompatibleStateImageBehavior = False
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(362, 208)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(90, 17)
        Me.radMale.TabIndex = 12
        Me.radMale.TabStop = True
        Me.radMale.Text = "RadioButton1"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(459, 208)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(90, 17)
        Me.radFemale.TabIndex = 13
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "RadioButton2"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'dtpDateofbirth
        '
        Me.dtpDateofbirth.Location = New System.Drawing.Point(362, 161)
        Me.dtpDateofbirth.Name = "dtpDateofbirth"
        Me.dtpDateofbirth.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateofbirth.TabIndex = 14
        '
        'dtpRegistrationdate
        '
        Me.dtpRegistrationdate.Location = New System.Drawing.Point(362, 255)
        Me.dtpRegistrationdate.Name = "dtpRegistrationdate"
        Me.dtpRegistrationdate.Size = New System.Drawing.Size(200, 20)
        Me.dtpRegistrationdate.TabIndex = 15
        '
        'btnAddAthlete
        '
        Me.btnAddAthlete.Location = New System.Drawing.Point(94, 458)
        Me.btnAddAthlete.Name = "btnAddAthlete"
        Me.btnAddAthlete.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAthlete.TabIndex = 16
        Me.btnAddAthlete.Text = "Add"
        Me.btnAddAthlete.UseVisualStyleBackColor = True
        '
        'btnUpdateAthlete
        '
        Me.btnUpdateAthlete.Location = New System.Drawing.Point(224, 458)
        Me.btnUpdateAthlete.Name = "btnUpdateAthlete"
        Me.btnUpdateAthlete.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateAthlete.TabIndex = 17
        Me.btnUpdateAthlete.Text = "Update"
        Me.btnUpdateAthlete.UseVisualStyleBackColor = True
        '
        'btnDeleteAthlete
        '
        Me.btnDeleteAthlete.Location = New System.Drawing.Point(362, 458)
        Me.btnDeleteAthlete.Name = "btnDeleteAthlete"
        Me.btnDeleteAthlete.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteAthlete.TabIndex = 18
        Me.btnDeleteAthlete.Text = "Delete"
        Me.btnDeleteAthlete.UseVisualStyleBackColor = True
        '
        'btnClearAthlete
        '
        Me.btnClearAthlete.Location = New System.Drawing.Point(498, 458)
        Me.btnClearAthlete.Name = "btnClearAthlete"
        Me.btnClearAthlete.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAthlete.TabIndex = 19
        Me.btnClearAthlete.Text = "Clear"
        Me.btnClearAthlete.UseVisualStyleBackColor = True
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

End Class
