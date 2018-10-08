Public Class login
    Public SQL As New Sqlcon
    Public idshow As String
    Public empname As String

    Private Function EMPLog() As Boolean
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()
        End If
        If Len(TextBox1.Text) <> 0! Or Len(TextBox2.Text) <> 0! Then
            SQL.ExecQuery("SELECT Count(EID) As userCount FROM Employee WHERE EID=" & TextBox1.Text &
            " AND PASSWORDS='" & TextBox2.Text & "'")
            If SQL.DBDS.Tables(0).Rows(0).Item("userCount") = 1 Then
                '
                Return True
            End If
            MsgBox("Invalid id or password", MsgBoxStyle.Critical, "Failed!")
            Return False
        End If
        MsgBox("you entered nothing")
        Return False
    End Function

    Private Sub EMPLOGIN_Click(sender As Object, e As EventArgs) Handles EMPLOGIN.Click
        If SQL.HasConnection = True Then
            If EMPLog() = True Then
                SQL.ExecQuery("SELECT name FROM Employee WHERE EID=" & TextBox1.Text)
                'empname = SQL.DBDS
                MsgBox("Login as successful!")
                Action_CTRL.Show()
                Me.Hide()
                idshow = TextBox1.Text
                Action_CTRL.Label2.Text = "Manager:" & TextBox1.Text
            End If
        End If
    End Sub

    'USE [CMPT395]
    'GO

    '/****** Object:  Table [dbo].[Employee]    Script Date: 2018/10/7 22:12:19 ******/
    'Set ANSI_NULLS On
    'GO

    'Set QUOTED_IDENTIFIER On
    'GO

    'CREATE TABLE [dbo].[Employee](
    '	[EID] [nchar](10) NULL,
    '	[PASSWORDS] [nchar](10) NULL,
    '	[NAME] [nchar](10) NULL
    ') ON [PRIMARY]

    'GO



End Class
