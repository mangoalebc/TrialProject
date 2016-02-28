
Imports System.IO                               'references to the System Input Output classes
Public Class MainMenu
    Private Const Dir As String = "D:\VB 2012\Files\"     'reference to the directory where file is stored
    Private Const Path As String = Dir & "EventsFile.txt" 'check if file is available, if so it deletes it
    Private Const APath As String = Dir & "AthletesFile.txt" 'check if file is available, if so it deletes it
    Private Const RPath As String = Dir & "ResultsFile.txt" 'check if file is available, if so it deletes it


    'declaration of stacks of events
    Dim nameStack As New Stack(Of String)
    Dim dateStack As New Stack(Of String)
    Dim regfeeStack As New Stack(Of String)
    Dim locationStack As New Stack(Of String)
    Dim distanceStack As New Stack(Of String)

    'declaration of stacks of athletes
    Dim mNumbeStack As New Stack(Of String)
    Dim nSurnameStack As New Stack(Of String)
    Dim bDateStack As New Stack(Of String)
    Dim GenderStack As New Stack(Of String)
    Dim rDateStack As New Stack(Of String)
    Dim omFeeStack As New Stack(Of String)
    Dim racesCompletedStack As New Stack(Of String)

    'declaration of stacks for results
    Dim resultsStack As New Stack(Of String)

    'Declaration of events variables
    Dim eventName As String
    Dim eventDate As Date
    Dim eventLocation As String
    Dim regFee As Decimal
    Dim eventDistance As String

    'Declaration of athletes variables
    Dim mNumber As String
    Dim nSurname As String
    Dim bDate As Date
    Dim Gender As String
    Dim rDate As Date
    Dim omFee As Decimal
    Dim racesCompleted As String

    'Declaration of results
    Dim results As String



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))

        Dim namestackstring As String = ""
        Dim eventExists As Boolean
        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            eventName = columns(0)

            'For display purpose
            eventDate = columns(1)
            regFee = columns(2)
            eventLocation = columns(3)
            eventDistance = columns(4)
            'end

            If eventName = txtEvent_Name.Text Then
                eventExists = True
                MessageBox.Show(eventName & " event already exists, please recapture unique event title!")

            End If
            'For display purpose
            nameStack.Push(eventName)
            dateStack.Push(eventDate)
            regfeeStack.Push(regFee)
            locationStack.Push(eventLocation)
            distanceStack.Push(eventDistance)

            namestackstring &= nameStack.Pop & " " & dateStack.Pop & " " & regfeeStack.Pop & " " & locationStack.Pop & " " & distanceStack.Pop & " " & vbCrLf
            'end
        Loop
        textIn.Close()
        'For display purpose
        MessageBox.Show(namestackstring, "Stack")
        'end


        eventName = txtEvent_Name.Text
        eventDate = dtpEvent_Date.Value
        eventLocation = txtEvent_Location.Text
        regFee = txtEvent_Reg_Fee.Text
        eventDistance = cbxEvent_distance.SelectedItem

        If eventExists = False Then

            Dim fs As FileStream
            fs = New FileStream(Path, FileMode.Append, FileAccess.Write) 'filestream for writing

            Try

                Dim textOut As New StreamWriter(fs)

                'For Each product As Product In products
                textOut.Write(eventName & "|")
                textOut.Write(eventDate & "|")
                textOut.Write(regFee & "|")
                textOut.Write(eventLocation & "|")
                textOut.WriteLine(eventDistance)
                'Next
                textOut.Close()

            Catch ex As FileNotFoundException
                MessageBox.Show(Path & " not found.", "File Not Found")
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(Dir & " not found.", "Directory Not Found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IOException")
            Finally
                If fs IsNot Nothing Then
                    fs.Close()
                End If
            End Try

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEvent_Name.Text = ""
        dtpEvent_Date.Refresh()
        txtEvent_Reg_Fee.Text = ""
        txtEvent_Location.Clear()
        cbxEvent_distance.ResetText()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Update events
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))

        Dim namestackstring As String = ""
        Dim eventExists As Boolean
        Dim noofrecords As Integer = 0

        Do While textIn.Peek <> -1

            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            eventName = columns(0)

            'check the availability of event and update
            If eventName = txtEvent_Name.Text Then

                eventExists = True
                eventName = columns(0)

                eventDate = dtpEvent_Date.Value
                eventLocation = txtEvent_Location.Text
                regFee = txtEvent_Reg_Fee.Text
                eventDistance = cbxEvent_distance.SelectedItem

                nameStack.Push(eventName)
                dateStack.Push(eventDate)
                regfeeStack.Push(regFee)
                locationStack.Push(eventLocation)
                distanceStack.Push(eventDistance)
                noofrecords = noofrecords + 1
               
            Else

                eventName = columns(0)
                eventDate = columns(1)
                regFee = columns(2)
                eventLocation = columns(3)
                eventDistance = columns(4)

                nameStack.Push(eventName)
                dateStack.Push(eventDate)
                regfeeStack.Push(regFee)
                locationStack.Push(eventLocation)
                distanceStack.Push(eventDistance)
                noofrecords = noofrecords + 1
            End If

        Loop
        textIn.Close()

        'Recapture the records
        If eventExists = True Then
            'Recapturing of events
            Dim fs As FileStream
            fs = New FileStream(Path, FileMode.Create, FileAccess.Write) 'filestream for writing

            Try

                Dim textOut As New StreamWriter(fs)

                Dim count As Integer = 0

                'For Each product As Product In products
                Do While count < noofrecords

                    eventName = nameStack.Pop
                    eventDate = dateStack.Pop
                    regFee = regfeeStack.Pop
                    eventLocation = locationStack.Pop
                    eventDistance = distanceStack.Pop
                    ' & " " & vbCrLf

                    textOut.Write(eventName & "|")
                    textOut.Write(eventDate & "|")
                    textOut.Write(regFee & "|")
                    textOut.Write(eventLocation & "|")
                    textOut.WriteLine(eventDistance)

                    count = count + 1

                Loop

                'Next
                textOut.Close()

            Catch ex As FileNotFoundException
                MessageBox.Show(Path & " not found.", "File Not Found")
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(Dir & " not found.", "Directory Not Found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IOException")
            Finally
                If fs IsNot Nothing Then
                    fs.Close()
                End If
            End Try
            MessageBox.Show(txtEvent_Name.Text & " updated successfully")
        Else
            MessageBox.Show(txtEvent_Name.Text & " does not exist in the system")
        End If

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))

        Dim namestackstring As String = ""
        Dim eventExists As Boolean

        Dim noofrecords As Integer = 0
        Do While textIn.Peek <> -1

            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            eventName = columns(0)

            'check the availability of event
            If eventName = txtEvent_Name.Text Then

                eventExists = True
                eventName = columns(0)
                eventDate = columns(1)
                regFee = columns(2)
                eventLocation = columns(3)
                eventDistance = columns(4)

            Else

                eventName = columns(0)
                eventDate = columns(1)
                regFee = columns(2)
                eventLocation = columns(3)
                eventDistance = columns(4)

                nameStack.Push(eventName)
                dateStack.Push(eventDate)
                regfeeStack.Push(regFee)
                locationStack.Push(eventLocation)
                distanceStack.Push(eventDistance)
                noofrecords = noofrecords + 1
            End If

        Loop
        textIn.Close()

        'Recapture the records
        If eventExists = True Then
            'Recapturing of events
            Dim fs As FileStream
            fs = New FileStream(Path, FileMode.Create, FileAccess.Write) 'filestream for writing

            Try

                Dim textOut As New StreamWriter(fs)

                Dim count As Integer = 0

                'For Each product As Product In products
                Do While count < noofrecords

                    eventName = nameStack.Pop
                    eventDate = dateStack.Pop
                    regFee = regfeeStack.Pop
                    eventLocation = locationStack.Pop
                    eventDistance = distanceStack.Pop
                    ' & " " & vbCrLf

                    textOut.Write(eventName & "|")
                    textOut.Write(eventDate & "|")
                    textOut.Write(regFee & "|")
                    textOut.Write(eventLocation & "|")
                    textOut.WriteLine(eventDistance)

                    count = count + 1

                Loop

                'Next
                textOut.Close()

            Catch ex As FileNotFoundException
                MessageBox.Show(Path & " not found.", "File Not Found")
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(Dir & " not found.", "Directory Not Found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IOException")
            Finally
                If fs IsNot Nothing Then
                    fs.Close()
                End If
            End Try
            MessageBox.Show(txtEvent_Name.Text & " deleted successfully")
        Else
            MessageBox.Show(txtEvent_Name.Text & " does not exist in the system")
        End If
    End Sub

    Private Sub btnAddAthlete_Click(sender As Object, e As EventArgs) Handles btnAddAthlete.Click

        'Add Athlete

        'Check the validity of membership number
        Dim regYear As String = dtpRegistrationdate.Value.Year.ToString.Substring(2)
        Dim bYear As String = dtpDateofbirth.Value.Year.ToString.Substring(0)
        Dim bMonth As String = dtpDateofbirth.Value.Month.ToString.Substring(0)
        Dim bDay As String = dtpDateofbirth.Value.Day.ToString.Substring(0)

        'assigning of zerovalues
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
            MessageBox.Show(txtMNumber.Text.ToString.Length & " Membership is valid " & mNumb & " = " & mNum & " check digit :" & checkDigit)



            'Retriving and adding to files
            If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
                Directory.CreateDirectory(Dir)
            End If

            Dim AtextIn As New StreamReader(New FileStream(APath, FileMode.OpenOrCreate, FileAccess.Read))

            Dim namestackstring As String = ""
            Dim AthleteExists As Boolean

       


            Do While AtextIn.Peek <> -1

                Dim row As String = AtextIn.ReadLine
                Dim columns() As String = row.Split(CChar("|"))
                mNumber = columns(0)
                MessageBox.Show(mNumber)
                'For display purpose
                nSurname = columns(1)
                bDate = columns(2)
                Gender = columns(3)
                rDate = columns(4)
                omFee = columns(5)
                'racesCompleted = columns(6)
                'end

                If mNumber = txtMNumber.Text Then
                    AthleteExists = True
                    MessageBox.Show(mNumber & " athlete already exists, please recapture unique membership number!")

                End If

                'For display purpose
                mNumbeStack.Push(mNumber)
                nSurnameStack.Push(nSurname)
                bDateStack.Push(bDate)
                GenderStack.Push(Gender)
                rDateStack.Push(rDate)
                omFeeStack.Push(omFee)
                ' racesCompletedStack.Push(racesCompleted)

                'namestackstring &= nameStack.Pop & " " & dateStack.Pop & " " & regfeeStack.Pop & " " & locationStack.Pop & " " & distanceStack.Pop & " " & vbCrLf

                namestackstring &= mNumbeStack.Pop & " " & nSurnameStack.Pop & " " & bDateStack.Pop & " " & GenderStack.Pop & " " & rDateStack.Pop & " " & omFeeStack.Pop & vbCrLf
                'end
            Loop
            AtextIn.Close()
                'For display purpose
                MessageBox.Show(namestackstring, "Athletes")
                'lstviewRaces.Show(mNumbeStack.Pop)
                'end


                mNumber = txtMNumber.Text
                nSurname = txtName.Text
                bDate = dtpDateofbirth.Value

                If radMale.Checked = True Then
                    Gender = "Male"
                Else
                    Gender = "Female"
                End If

                rDate = dtpRegistrationdate.Value
                omFee = txtOMfee.Text
                'racesCompleted  = cbxEvent_distance.SelectedItem

                If athleteExists = False Then

                    Dim fs As FileStream
                    fs = New FileStream(APath, FileMode.Append, FileAccess.Write) 'filestream for writing

                    Try

                        Dim textOut As New StreamWriter(fs)

                        'For Each product As Product In products
                        textOut.Write(mNumber & "|")
                        textOut.Write(nSurname & "|")
                        textOut.Write(bDate & "|")
                        textOut.Write(Gender & "|")
                        textOut.Write(rDate & "|")
                        textOut.WriteLine(omFee)
                        'Next
                        textOut.Close()

                    Catch ex As FileNotFoundException
                        MessageBox.Show(Path & " not found.", "File Not Found")
                    Catch ex As DirectoryNotFoundException
                        MessageBox.Show(Dir & " not found.", "Directory Not Found")
                    Catch ex As IOException
                        MessageBox.Show(ex.Message, "IOException")
                    Finally
                        If fs IsNot Nothing Then
                            fs.Close()
                        End If
                    End Try
                    MessageBox.Show("Membership number: " & txtMNumber.Text & " added successfully:")
                End If


        End If

    End Sub

    Private Sub btnClearAthlete_Click(sender As Object, e As EventArgs) Handles btnClearAthlete.Click
        txtMNumber.Text = ""
        txtName.Text = ""
        dtpDateofbirth.Refresh()
        dtpRegistrationdate.Refresh()
        txtOMfee.Text = ""
        lstviewRaces.Clear()


    End Sub

    Private Sub btnUpdateAthlete_Click(sender As Object, e As EventArgs) Handles btnUpdateAthlete.Click

        'Update of athletes
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(APath, FileMode.OpenOrCreate, FileAccess.Read))

        Dim namestackstring As String = ""
        Dim AthleteExists As Boolean
        Dim noofrecords As Integer = 0
     
        Do While textIn.Peek <> -1

            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            mNumber = columns(0)

            'check the availability of event and update
            If mNumber = txtMNumber.Text Then

                AthleteExists = True
                mNumber = columns(0)

                nSurname = txtName.Text
                bDate = dtpDateofbirth.Value

                If radMale.Checked Then
                    Gender = "Male"
                Else
                    Gender = "Female"
                End If

                rDate = dtpRegistrationdate.Value
                omFee = txtOMfee.Text

                mNumbeStack.Push(mNumber)
                nSurnameStack.Push(nSurname)
                bDateStack.Push(bDate)
                GenderStack.Push(Gender)
                rDateStack.Push(rDate)
                omFeeStack.Push(omFee)
                'racesCompletedStack.Push(racesCompleted)

                noofrecords = noofrecords + 1

            Else

                mNumber = columns(0)
                nSurname = columns(1)
                bDate = columns(2)
                Gender = columns(3)
                rDate = columns(4)
                omFee = columns(5)

                mNumbeStack.Push(mNumber)
                nSurnameStack.Push(nSurname)
                bDateStack.Push(bDate)
                GenderStack.Push(Gender)
                rDateStack.Push(rDate)
                omFeeStack.Push(omFee)
                'racesCompletedStack.Push(racesCompleted)


                noofrecords = noofrecords + 1
            End If

        Loop
        textIn.Close()

        'Recapture the records
        If AthleteExists = True Then
            'Recapturing of events
            Dim fs As FileStream
            fs = New FileStream(APath, FileMode.Create, FileAccess.Write) 'filestream for writing

            Try

                Dim textOut As New StreamWriter(fs)

                Dim count As Integer = 0

                'For Each product As Product In products
                Do While count < noofrecords

                    mNumber = mNumbeStack.Pop
                    nSurname = nSurnameStack.Pop
                    bDate = bDateStack.Pop
                    Gender = GenderStack.Pop
                    rDate = rDateStack.Pop
                    omFee = omFeeStack.Pop

                    textOut.Write(mNumber & "|")
                    textOut.Write(nSurname & "|")
                    textOut.Write(bDate & "|")
                    textOut.Write(Gender & "|")
                    textOut.Write(rDate & "|")
                    textOut.WriteLine(omFee)

                    count = count + 1

                Loop

                'Next
                textOut.Close()

            Catch ex As FileNotFoundException
                MessageBox.Show(Path & " not found.", "File Not Found")
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(Dir & " not found.", "Directory Not Found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IOException")
            Finally
                If fs IsNot Nothing Then
                    fs.Close()
                End If
            End Try
            MessageBox.Show("Membership number " & txtMNumber.Text & " record updated successfully")
        Else
            MessageBox.Show("Membership number " & txtMNumber.Text & " does not exist in the system")
        End If


    End Sub

    Private Sub btnDeleteAthlete_Click(sender As Object, e As EventArgs) Handles btnDeleteAthlete.Click
        'Delete the Athlete
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(APath, FileMode.OpenOrCreate, FileAccess.Read))

        Dim namestackstring As String = ""
        Dim AthleteExists As Boolean
        Dim noofrecords As Integer = 0

        Do While textIn.Peek <> -1

            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            mNumber = columns(0)

            'check the availability of athlete and update
            If mNumber = txtMNumber.Text Then

                AthleteExists = True

            Else

                mNumber = columns(0)
                nSurname = columns(1)
                bDate = columns(2)
                Gender = columns(3)
                rDate = columns(4)
                omFee = columns(5)

                mNumbeStack.Push(mNumber)
                nSurnameStack.Push(nSurname)
                bDateStack.Push(bDate)
                GenderStack.Push(Gender)
                rDateStack.Push(rDate)
                omFeeStack.Push(omFee)
                'racesCompletedStack.Push(racesCompleted)


                noofrecords = noofrecords + 1
            End If

        Loop
        textIn.Close()

        'Recapture the records
        If AthleteExists = True Then
            'Recapturing of events
            Dim fs As FileStream
            fs = New FileStream(APath, FileMode.Create, FileAccess.Write) 'filestream for writing

            Try

                Dim textOut As New StreamWriter(fs)

                Dim count As Integer = 0

                'For Each product As Product In products
                Do While count < noofrecords

                    mNumber = mNumbeStack.Pop
                    nSurname = nSurnameStack.Pop
                    bDate = bDateStack.Pop
                    Gender = GenderStack.Pop
                    rDate = rDateStack.Pop
                    omFee = omFeeStack.Pop

                    textOut.Write(mNumber & "|")
                    textOut.Write(nSurname & "|")
                    textOut.Write(bDate & "|")
                    textOut.Write(Gender & "|")
                    textOut.Write(rDate & "|")
                    textOut.WriteLine(omFee)

                    count = count + 1

                Loop

                'Next
                textOut.Close()

            Catch ex As FileNotFoundException
                MessageBox.Show(Path & " not found.", "File Not Found")
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(Dir & " not found.", "Directory Not Found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IOException")
            Finally
                If fs IsNot Nothing Then
                    fs.Close()
                End If
            End Try
            MessageBox.Show("Membership number " & txtMNumber.Text & " record deleted successfully")
        Else
            MessageBox.Show("Membership number " & txtMNumber.Text & " does not exist in the system")
        End If

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        
    End Sub

    Private Sub btnrAdd_Click(sender As Object, e As EventArgs) Handles btnrAdd.Click

   'For display purpose
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim RAtextIn As New StreamReader(New FileStream(RPath, FileMode.OpenOrCreate, FileAccess.Read))
        Dim rmNumber As String
        Dim namestackstring As String = ""
        Dim resultsExists As Boolean
        Do While RAtextIn.Peek <> -1
            Dim row As String = RAtextIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            rmNumber = columns(0)

            'For display purpose
            eventName = columns(1)
            results = columns(2)
            'end

            If eventName = cmbEName.SelectedItem Then
                resultsExists = True
                MessageBox.Show(rmNumber & " event " & eventName & " results already added, please add other results!")

            End If
            'For display purpose
            mNumbeStack.Push(rmNumber)
            nameStack.Push(eventName)
            resultsStack.Push(results)

            namestackstring &= mNumbeStack.Pop & " " & nameStack.Pop & " " & resultsStack.Pop & vbCrLf
            'end
        Loop
        RAtextIn.Close()
        'For display purpose
        MessageBox.Show(namestackstring, "Results")
        'end

        mNumber = cmbmNumber.SelectedItem
        eventName = cmbEName.SelectedItem
        ' MessageBox.Show(mNumber & "Results added successfully")
        results = numHours.Value & " : " & numMinutes.Value & " : " & numSeconds.Value

     
        If resultsExists = False Then

            Dim fs As FileStream
            fs = New FileStream(RPath, FileMode.Append, FileAccess.Write) 'filestream for writing

            Try

                Dim textOut As New StreamWriter(fs)

                'For Each product As Product In products
                textOut.Write(mNumber & "|")
                textOut.Write(eventName & "|")
                textOut.WriteLine(results)
                'Next
                textOut.Close()

            Catch ex As FileNotFoundException
                MessageBox.Show(RPath & " not found.", "File Not Found")
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(Dir & " not found.", "Directory Not Found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IOException")
            Finally
                If fs IsNot Nothing Then
                    fs.Close()
                End If
            End Try
            MessageBox.Show("Results added successfully")
        End If
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get the events saved
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))
        Dim rttextIn As New StreamReader(New FileStream(RPath, FileMode.OpenOrCreate, FileAccess.Read))
        Dim rtmNumber As String = ""
        Dim namestackstring As String = ""
        Dim rnamestackstring As String = ""
        ' Dim eventExists As Boolean
        Do While rttextIn.Peek <> -1
            Dim row As String = rttextIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            rtmNumber = columns(0)
            eventName = columns(1)
            results = columns(2)
            ' lstviewRaces.Items.Clear()
            lstviewRaces.Items.Add(rtmNumber & " " & eventName & " " & results & vbCrLf)
           
        Loop
        rttextIn.Close()

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            eventName = columns(0)

            cmbEName.Items.Add(eventName)

        Loop
        textIn.Close()

        'Load membership numbers
        Dim atextIn As New StreamReader(New FileStream(APath, FileMode.OpenOrCreate, FileAccess.Read))

        ' Dim namestackstring As String = ""
        ' Dim eventExists As Boolean

        Do While atextIn.Peek <> -1
            Dim row As String = atextIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            mNumber = columns(0)

            cmbmNumber.Items.Add(mNumber)
            'MessageBox.Show(mNumber & " event already exists, please recapture unique event title!")

            If txtMNumber.Text <> "" And txtMNumber.Text = mNumber Then

            End If
            'For display purpose
            ' eventDate = columns(1)
            'regFee = columns(2)
            'eventLocation = columns(3)
            'eventDistance = columns(4)
            'end

            ' If eventName = txtEvent_Name.Text Then
            'eventExists = True
            ' 
            ' End If
            'For display purpose
            'nameStack.Push(eventName)
            'dateStack.Push(eventDate)
            'regfeeStack.Push(regFee)
            'locationStack.Push(eventLocation)
            'distanceStack.Push(eventDistance)

            'namestackstring &= nameStack.Pop & " " & dateStack.Pop & " " & regfeeStack.Pop & " " & locationStack.Pop & " " & distanceStack.Pop & " " & vbCrLf
            'end
        Loop
        atextIn.Close()

    End Sub

    Private Sub btnrUpdate_Click(sender As Object, e As EventArgs) Handles btnrUpdate.Click

        'Update results
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(RPath, FileMode.OpenOrCreate, FileAccess.Read))

        Dim namestackstring As String = ""
        Dim resultsExists As Boolean
        Dim noofrecords As Integer = 0
         Do While textIn.Peek <> -1

            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            mNumber = columns(0)

            'check the availability of event and update
            If mNumber = cmbmNumber.SelectedItem Then

                resultsExists = True
                mNumber = columns(0)

                eventName = cmbEName.SelectedItem
                results = numHours.Value & " : " & numMinutes.Value & " : " & numSeconds.Value

                results = results

                mNumbeStack.Push(mNumber)
                nameStack.Push(eventName)
                resultsStack.Push(results)
               
                noofrecords = noofrecords + 1

            Else
                mNumber = columns(0)
                eventName = columns(1)
                results = columns(2)

                mNumbeStack.Push(mNumber)
                nameStack.Push(eventName)
                resultsStack.Push(results)

                noofrecords = noofrecords + 1
            End If

        Loop
        textIn.Close()

        'Recapture the records
        If resultsExists = True Then
            'Recapturing of events
            Dim fs As FileStream
            fs = New FileStream(RPath, FileMode.Create, FileAccess.Write) 'filestream for writing

            Try

                Dim textOut As New StreamWriter(fs)

                Dim count As Integer = 0

                'For Each product As Product In products
                Do While count < noofrecords
                    mNumber = mNumbeStack.Pop
                    eventName = nameStack.Pop
                    results = resultsStack.Pop
                  
                    textOut.Write(mNumber & "|")
                    textOut.Write(eventName & "|")
                    textOut.WriteLine(results)

                    count = count + 1

                Loop

                'Next
                textOut.Close()

            Catch ex As FileNotFoundException
                MessageBox.Show(RPath & " not found.", "File Not Found")
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(Dir & " not found.", "Directory Not Found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IOException")
            Finally
                If fs IsNot Nothing Then
                    fs.Close()
                End If
            End Try
            MessageBox.Show(cmbmNumber.SelectedItem & " results updated successfully")
        End If

    End Sub

    Private Sub btnrDelete_Click(sender As Object, e As EventArgs) Handles btnrDelete.Click
        'Update delete 
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(RPath, FileMode.OpenOrCreate, FileAccess.Read))

        Dim namestackstring As String = ""
        Dim resultsExists As Boolean
        Dim noofrecords As Integer = 0
        Do While textIn.Peek <> -1

            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            mNumber = columns(0)
            eventName = columns(1)

            'check the availability of event and update
            If mNumber = cmbmNumber.SelectedItem And eventName = cmbEName.SelectedItem Then

                resultsExists = True
                mNumber = columns(0)

                '
                'results = numHours.Value & " : " & numMinutes.Value & " : " & numSeconds.Value

                'results = results

                ' mNumbeStack.Push(mNumber)
                'nameStack.Push(eventName)
                ' resultsStack.Push(results)

                ' noofrecords = noofrecords + 1

            Else
                mNumber = columns(0)
                eventName = columns(1)
                results = columns(2)

                mNumbeStack.Push(mNumber)
                nameStack.Push(eventName)
                resultsStack.Push(results)

                noofrecords = noofrecords + 1
            End If

        Loop
        textIn.Close()

        'Recapture the records
        If resultsExists = True Then
            'Recapturing of events
            Dim fs As FileStream
            fs = New FileStream(RPath, FileMode.Create, FileAccess.Write) 'filestream for writing

            Try

                Dim textOut As New StreamWriter(fs)

                Dim count As Integer = 0

                'For Each product As Product In products
                Do While count < noofrecords
                    mNumber = mNumbeStack.Pop
                    eventName = nameStack.Pop
                    results = resultsStack.Pop

                    textOut.Write(mNumber & "|")
                    textOut.Write(eventName & "|")
                    textOut.WriteLine(results)

                    count = count + 1

                Loop

                'Next
                textOut.Close()

            Catch ex As FileNotFoundException
                MessageBox.Show(RPath & " not found.", "File Not Found")
            Catch ex As DirectoryNotFoundException
                MessageBox.Show(Dir & " not found.", "Directory Not Found")
            Catch ex As IOException
                MessageBox.Show(ex.Message, "IOException")
            Finally
                If fs IsNot Nothing Then
                    fs.Close()
                End If
            End Try
            MessageBox.Show(cmbmNumber.SelectedItem & " results deleted successfully")
        End If

    End Sub
End Class
