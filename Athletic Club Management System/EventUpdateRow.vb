Imports System.Data.OleDb

Public Class EventsUpdateRow
    Function UpdateEvent(eventname As String, eventDate As Date, eventLoc As String, eventDist As String, regFee As Double)

        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb"
        Dim connection As New OleDbConnection(connetionString)

        Dim query As String = "UPDATE tblEvents SET [EventDate]= '" & eventDate & "', [EventLocation]= '" & eventLoc & "',[EventDistance]= '" & eventDist & "', [RegistrationFee]= '" & regFee & "' WHERE [EventTitle] = '" & eventname & "'"

        Dim myCommand As New OleDbCommand(query, connection)


        Try
            connection.Open()
            Dim count As String = myCommand.ExecuteNonQuery
            MessageBox.Show("Update successful")



        Catch ex As Exception
            MessageBox.Show("error" & ex.Message & ex.GetType.ToString)

        Finally
            connection.Close()

        End Try


    End Function
End Class
