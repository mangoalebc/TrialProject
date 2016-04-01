
Imports System.IO                               'references to the System Input Output classes
Imports System.Data.OleDb

Public Class MainMenu


    'Declaration of events variables
    Dim eventName As String
    Dim eventDate As Date
    Dim eventLocation As String
    Dim regFee As Double
    Dim eventDistance As String

    'Declaration of athletes variables
    Dim mNumber As String
    Dim nSurname As String
    Dim bDate As Date
    Dim Gender As String
    Dim rDate As Date
    Dim omFee As Double
    Dim racesCompleted As String

    'Declaration of results
    Dim results As String



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() ' closing of system
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
       
        'getting the values from the form
        eventName = txtEvent_Name.Text
        eventDate = dtpEvent_Date.Value
        eventLocation = txtEvent_Location.Text
        Double.TryParse(txtEvent_Reg_Fee.Text, regFee)
        eventDistance = cbxEvent_distance.SelectedItem


        Dim myNewRow As New EventsAddRow()
        myNewRow.AddEvent(eventName, eventDate, eventLocation, eventDistance, regFee)
       




    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clearing the fields
        txtEvent_Name.Text = ""
        dtpEvent_Date.Refresh()
        txtEvent_Reg_Fee.Text = ""
        txtEvent_Location.Clear()
        cbxEvent_distance.ResetText()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        eventDate = dtpEvent_Date.Value
        eventLocation = txtEvent_Location.Text
        Double.TryParse(txtEvent_Reg_Fee.Text, regFee)
        eventDistance = cbxEvent_distance.SelectedItem
        eventName = txtEvent_Name.Text

        Dim myUpdateRow As New EventsUpdateRow()

        myUpdateRow.UpdateEvent(eventName, eventDate, eventLocation, eventDistance, regFee)

       

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim myDelete = New DeleteFromEvents()
        myDelete.DeleteRow(txtEvent_Name.Text)



    End Sub

    Private Sub btnAddAthlete_Click(sender As Object, e As EventArgs) Handles btnAddAthlete.Click
        'Add Athlete

        'Check the validity of membership number
        Dim regYear As String = dtpRegistrationdate.Value.Year.ToString.Substring(2)
        Dim bYear As String = dtpDateofbirth.Value.Year.ToString.Substring(0)
        Dim bMonth As String = dtpDateofbirth.Value.Month.ToString.Substring(0)
        Dim bDay As String = dtpDateofbirth.Value.Day.ToString.Substring(0)

        'assigning of zero values to maintain the 14 number digit membership
        If bMonth.Length = 1 Then
            bMonth = "0" & bMonth
        End If

        If bDay.Length = 1 Then
            bDay = "0" & bDay
        End If

        If bYear.Length = 3 Then
            bYear = "0" & bYear
        ElseIf bYear.Length = 2 Then
            bYear = "00" & bYear
        ElseIf bYear.Length = 1 Then
            bYear = "000" & bYear
        End If

        If regYear.Length = 1 Then
            regYear = "0" & regYear
        End If

        Dim randNum As String = CInt(Int((1000 * Rnd())))
        If randNum.Length = 3 Then
            randNum = "0" & randNum
        ElseIf randNum.Length = 2 Then
            randNum = "00" & randNum
        End If

        'combining the values
        Dim mNumb As String = regYear & bYear & bMonth & bDay & randNum

        Dim count As Integer = 0
        Dim mNum As Integer = 0
        Dim checkDigit As Integer

        'converting to number values
        Do While count < mNumb.Length
            mNum = mNum + (Convert.ToDouble(mNumb.Substring(count, 1)))
            count = count + 1
        Loop

        'Generating check digit
        checkDigit = mNum Mod 10
        If checkDigit = 0 Or txtMNumber.Text.ToString.Length <> 14 Then
            MessageBox.Show("Membership " & mNumb & " entered is invalid please re-enter correct 14 digit membership number" & " check digit :" & checkDigit)
        Else
            checkDigit = 10 - (mNum Mod 10)

            
        End If

       


        'assigning values from the form
        mNumber = txtMNumber.Text
        nSurname = txtName.Text
        bDate = dtpDateofbirth.Value

        If radMale.Checked = True Then
            Gender = "Male"
        Else
            Gender = "Female"
        End If

        rDate = dtpRegistrationdate.Value
        Double.TryParse(txtOMfee.Text, omFee)

        Dim myNewRow As New AtlhetesAddRow()
        myNewRow.AddAtlhetes(mNumber, nSurname, bDate, rDate, Gender, omFee)
       

    End Sub

    Private Sub btnClearAthlete_Click(sender As Object, e As EventArgs) Handles btnClearAthlete.Click
        'Clearing fields
        txtMNumber.Text = ""
        txtName.Text = ""
        dtpDateofbirth.Refresh()
        dtpRegistrationdate.Refresh()
        txtOMfee.Text = ""
        lstviewRaces.Clear()
    End Sub

    Private Sub btnUpdateAthlete_Click(sender As Object, e As EventArgs) Handles btnUpdateAthlete.Click


        nSurname = txtName.Text
        bDate = dtpDateofbirth.Value

        If radMale.Checked Then
            Gender = "Male"
        Else
            Gender = "Female"
        End If

        rDate = dtpRegistrationdate.Value
        Double.TryParse(txtOMfee.Text, omFee)

        Dim athleteUpdate As New UpdateAthletes()
        athleteUpdate.UpdateAthlete(mNumber, nSurname, bDate, Gender, rDate, omFee)


    End Sub

    Private Sub btnDeleteAthlete_Click(sender As Object, e As EventArgs) Handles btnDeleteAthlete.Click

        Dim deleteAthlete As New DeleteFromAthletes()   'instantiating the deleteFromAthletes class

        deleteAthlete.DeleteRowA(txtMNumber.Text)   'calling the function to delete a row
        
    End Sub

    Private Sub btnrAdd_Click(sender As Object, e As EventArgs) Handles btnrAdd.Click

        

        mNumber = cmbmNumber.SelectedItem
        eventName = cmbEName.SelectedItem


        Dim myRace = New AddRaceResult()
        myRace.AddNewEntry(eventName, mNumber, numHours.Value, numMinutes.Value, numSeconds.Value)

        
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb" 'creating a connection to the database
        Dim connection As New OleDbConnection(connetionString)

        Dim myQuery As String = "SELECT MemberNum FROM tblAthletes" 'select all the member numbers available in the database
        Dim dbReader As OleDbDataReader
        Dim cmd As New OleDbCommand(myQuery, connection)


        'loading a combobox for the events
        Try
            connection.Open() 'open the connection
            dbReader = cmd.ExecuteReader()

            While dbReader.Read()
                cmbmNumber.Items.Add(dbReader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show("eror" & ex.Message & ex.GetType.ToString)

        End Try

        connection.Close()




        Dim myOtherQuery As String = "SELECT EventTitle FROM tblEvents" 'get the events from database
        Dim dbOtherReader As OleDbDataReader
        Dim mycmd As New OleDbCommand(myOtherQuery, connection)


        ''loading a combobox for the Member numbers
        Try
            connection.Open()
            dbOtherReader = mycmd.ExecuteReader()

            While dbOtherReader.Read()
                cmbEName.Items.Add(dbOtherReader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show("eror" & ex.Message & ex.GetType.ToString)

        End Try

        connection.Close()







    End Sub

    Private Sub btnrUpdate_Click(sender As Object, e As EventArgs) Handles btnrUpdate.Click

        
        mNumber = cmbmNumber.SelectedItem
        eventName = cmbEName.SelectedItem


        Dim newRace As New UpdateRaceResults()
        newRace.UpdateRace(eventName, numHours.Value, numMinutes.Value, numSeconds.Value, mNumber)


        

    End Sub

    Private Sub btnrDelete_Click(sender As Object, e As EventArgs) Handles btnrDelete.Click

        mNumber = cmbmNumber.SelectedItem


        Dim deleteRace As New DeleteRace()
        deleteRace.DeleteRow(mNumber)




    End Sub

    Private Sub txtEvent_Name_TextChanged(sender As Object, e As EventArgs) Handles txtEvent_Name.TextChanged

    End Sub

    Private Sub txtMNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMNumber.LostFocus

        ' mNumber = txtMNumber.Text

        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb" 'creating a connection to the database
        Dim connection As New OleDbConnection(connetionString)

        Dim myQuery As String = "SELECT * FROM tblRace WHERE MemberNum = '" & txtMNumber.Text & "'" 'select all the member numbers available in the database
        Dim dbReader As OleDbDataReader
        Dim cmd As New OleDbCommand(myQuery, connection)


        'loading a combobox for the events
        Try
            connection.Open() 'open the connection
            dbReader = cmd.ExecuteReader()

            Dim x As Integer
            Dim txt As String
            lstviewRaces.Items.Clear()
            While dbReader.Read()
                
                txt = dbReader.Item(0).ToString
                For x = 1 To dbReader.FieldCount - 1
                    txt &= " " & vbTab & dbReader.Item(x).ToString & " "
                Next x

                lstviewRaces.Items.Add(txt)


            End While
        Catch ex As Exception
            MessageBox.Show("eror" & ex.Message & ex.GetType.ToString)

        End Try

        connection.Close()

    End Sub


    Private Sub cmbmNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmNumber.SelectedIndexChanged


    End Sub


    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
       
    End Sub

    Private Sub txtMNumber_TextChanged_1(sender As Object, e As EventArgs) Handles txtMNumber.TextChanged

    End Sub
End Class
