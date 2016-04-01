Imports System.Data.OleDb

Public Class AtlhetesAddRow

    Function AddAtlhetes(mNumber As String, nSurname As String, bDate As Date, rDate As Date, Gender As String, omFee As Double)

        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb"
        Dim connection As New OleDbConnection(connetionString)

        Dim query As String = "INSERT INTO tblAthletes" & "(MemberNum,NameAndSurname,BirthDate,DateJoined,Gender,AmountDue)" & "VALUES(@mNumber, @nSurname, @bDate,@rDate,@Gender,@omFee)"

        Dim myCommand As New OleDbCommand(query, connection)

        myCommand.Parameters.AddWithValue("@mNumber", mNumber)
        myCommand.Parameters.AddWithValue("@nSurname", nSurname)
        myCommand.Parameters.AddWithValue("@bDate", bDate)
        myCommand.Parameters.AddWithValue("@rDate", rDate)
        myCommand.Parameters.AddWithValue("@Gender", Gender)
        myCommand.Parameters.AddWithValue("@omFee", omFee)

        Try
            connection.Open()
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Entry successful")



        Catch ex As Exception
            MessageBox.Show("error  " & ex.Message & ex.GetType.ToString)

        Finally
            connection.Close()

        End Try


    End Function

End Class
