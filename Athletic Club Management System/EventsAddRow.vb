Imports System.Data.OleDb

Public Class EventsAddRow

    Function AddEvent(eventname As String, eventDate As Date, eventLoc As String, eventDist As String, regFee As Double)

        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb"
        Dim connection As New OleDbConnection(connetionString)

        Dim query As String = "INSERT INTO tblEvents" & "(EventTitle,EventDate,EventLocation,EventDistance,RegistrationFee)" & "VALUES(@eventname, @eventDate, @eventLoc,@eventDist,@regFee)"

        Dim myCommand As New OleDbCommand(query, connection)

        myCommand.Parameters.AddWithValue("@eventname", eventname)
        myCommand.Parameters.AddWithValue("@eventDate", eventDate)
        myCommand.Parameters.AddWithValue("@eventLoc", eventLoc)
        myCommand.Parameters.AddWithValue("@eventDist", eventDist)
        myCommand.Parameters.AddWithValue("@regFee", regFee)

        Try
            connection.Open()
            Dim count As String = myCommand.ExecuteNonQuery
            MessageBox.Show("Entry successful")



        Catch ex As Exception
            MessageBox.Show("error" & ex.Message & ex.GetType.ToString)

        Finally
            connection.Close()

        End Try
    End Function

End Class
