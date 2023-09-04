Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Management

Public Class frmFindCustomer
    Private strUser As String = "Admin"
    Private strPassword As String = "P@ssword123"
    Private strTitle As String = "SOLD RETAIL - "
    Public strLocation As String
    Public strConn = "Data Source=SQLServer\SQLExpress;Connection Timeout=400;Persist Security Info=True;User ID=" & strUser & ";Password=" & strPassword & ";"

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
                                           ByVal keyData As System.Windows.Forms.Keys) _
                                           As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")

            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Form_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")

            e.Handled = True
        End If
    End Sub

    Private Sub findResults()
        Dim Conn As New SqlConnection(strConn)
        Dim cmd As New SqlCommand()
        Dim cmd2 As New SqlCommand()
        Dim nFound As String = ""
        Dim skuSearch, strFormFactor As String

        On Error GoTo err_Handler

        If txtSearchFor.Text = "" Then Exit Sub

        Dim intCount As Int16

        '        lstResults.Clear()

        If lstResults.Items.Count > 0 Then
            For intCount = lstResults.Items.Count - 1 To 0 Step -1
                lstResults.Items.RemoveAt(intCount)
            Next intCount
        End If

        If Val(txtSearchFor.Text) > 0 And Len(txtSearchFor.Text) > 2 Then
            skuSearch = "SELECT * FROM [Incoming_Audit].[dbo].[Customers] WHERE [Company ID] Like '" + txtSearchFor.Text + "%' order by 'Company Name';"
        ElseIf Len(txtSearchFor.Text) > 3 Then
            skuSearch = "SELECT * FROM [Incoming_Audit].[dbo].[Customers] WHERE [Company Name] Like '%" + txtSearchFor.Text + "%' order by 'Company Name';"
        Else
            Exit Sub
        End If

        Conn.Open()

        cmd = New SqlCommand(skuSearch, Conn)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim lst As ListViewItem

        Dim strResults(4) As String

        Do While reader.Read()
            strResults(0) = reader("Company ID").ToString
            strResults(1) = reader("Company Name").ToString
            strResults(2) = reader("Company Address").ToString
            strResults(3) = reader("Last Name").ToString & ", " & reader("First Name").ToString
            strResults(4) = reader("Phone #").ToString

            lst = New ListViewItem(strResults)

            lstResults.Items.Add(lst)
        Loop

        Conn.Close()

        Exit Sub
err_Handler:
        If Err.Number = 5 Then
            'MsgBox("Invalid STS Serial #...please verify number!", vbOKOnly, strTitle)

            'txtInternalSerial.SelectAll()
            'txtInternalSerial.Focus()

            Conn.Close()

            Exit Sub
        End If

        MsgBox("Error with " & strTitle & " & getManufacturer:" & vbCrLf & vbCrLf & Err.Description)

        Resume Next
    End Sub

    Private Sub txtSearchFor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchFor.KeyUp
        findResults()
    End Sub

    Private Sub frmFindCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstResults.View = View.Details
        lstResults.FullRowSelect = True

        lstResults.Columns.Add("ID", 60)
        lstResults.Columns.Add("Name", 150)
        lstResults.Columns.Add("Address", 150)
        lstResults.Columns.Add("Contact", 130)
        lstResults.Columns.Add("Contact #", 110)
    End Sub

    Private Sub txtSearchFor_TextChanged(sender As Object, e As EventArgs) Handles txtSearchFor.TextChanged

    End Sub
End Class
