Imports System.Data.SqlClient 'Import SQL Capabilities

Partial Class VB_Code_index
    Inherits System.Web.UI.Page
    Private strConn As String = "Data Source=LAPTOP-MI-SEESA;Initial Catalog=TEST;Integrated Security=True"
    Private sqlCon As SqlConnection

    Private Sub showMsgBox(msgText As String)
        ClientScript.RegisterClientScriptBlock(Me.GetType(), "ClientScript", "alert(""" + msgText + """)", True)
    End Sub

    Private Sub CreateTable()
        sqlCon = New SqlConnection(strConn)
        Using (sqlCon)
            Dim sqlComm As New SqlCommand

            Try
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "CreateAppTable"
                sqlComm.CommandType = Data.CommandType.StoredProcedure
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                showMsgBox(ex.Message)
            Finally
                sqlCon.Close()
            End Try
        End Using
    End Sub

    Protected Sub Write_Click(sender As Object, e As EventArgs) Handles Write.Click
        If Name.Text.Length = 0 Then
            showMsgBox("please enter a name")
            Return
        End If

        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)
            Dim sqlComm As New SqlCommand()
            Try
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "InsertAppDataIntoTable"
                sqlComm.CommandType = Data.CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("Name", Name.Text)

                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                showMsgBox(ex.Message)
            Finally
                sqlCon.Close()
            End Try
        End Using
    End Sub

    Protected Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        CreateTable()
    End Sub
End Class
