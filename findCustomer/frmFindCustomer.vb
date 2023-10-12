Imports System.Net
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports System.IO
Imports System.Text
Imports System.Net.Http
Imports System.ServiceModel

Public Class frmFindCustomer
    Private strTitle As String = "SOLD RETAIL - "
    Public strLocation As String
    Public request As WebRequest
    Public strToken As String
    Public strSourceID As String
    Public strPhone As String
    Dim strAddress As String
    Dim strName As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
                                           ByVal keyData As System.Windows.Forms.Keys) _
                                           As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")

            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub getSugarToken()
        Try
            Dim data = Encoding.UTF8.GetBytes("{""grant_type"": ""password"", ""client_id"": ""sugar"", ""client_secret"": """", ""username"": ""TMorris"", ""password"": ""ktehT54321"", ""platform"": ""customer""}")
            Dim json = SendRequest(New Uri("https://stsrecycling.sugarondemand.com/rest/v10/oauth2/token"), data, "application/json", "POST")

            Dim serializer As New JavaScriptSerializer()
            Dim result As Object = serializer.DeserializeObject(json)

            strToken = result("access_token")
        Catch ex As Exception
            MsgBox(ex.InnerException.Message)
        End Try
    End Sub

    Private Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim response As String

        request = WebRequest.Create(uri)
        request.ContentLength = jsonDataBytes.Length
        request.ContentType = contentType
        request.Method = method

        Using requestStream = request.GetRequestStream
            requestStream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
            requestStream.Close()

            Using responseStream = request.GetResponse.GetResponseStream
                Using reader As New StreamReader(responseStream)
                    response = reader.ReadToEnd()
                End Using
            End Using
        End Using

        Return response
    End Function

    Private Sub Form_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")

            e.Handled = True
        End If
    End Sub

    Private Sub getCustomerInfo()
        Try
            getSugarToken()

            Dim SugarURI As Uri = New Uri("https://stsrecycling.sugarondemand.com/rest/v10/Accounts/" & strSourceID)

            request = WebRequest.Create(SugarURI)

            With request
                .ContentType = "application/json"
                .Method = "GET"
                .Headers.Add("Authorization", "Bearer " & strToken)
            End With

            Dim result = request.GetResponse()
            Dim responsedata As Stream = result.GetResponseStream
            Dim responsereader As StreamReader = New StreamReader(responsedata)
            Dim xResponse = responsereader.ReadToEnd

            Dim serializer As New JavaScriptSerializer()
            Dim jsonResult As Object = serializer.DeserializeObject(xResponse)

            With jsonResult
                strPhone = .item("phone_office")
                strAddress = .item("shipping_address_street")
                strName = .item("email1")
            End With
        Catch ex As Exception
            MsgBox(ex.InnerException.Message)
        End Try
    End Sub

    Private Sub findResults()
        Dim strSearchBy As String

        If txtSearchFor.Text = "" Or Len(txtSearchFor.Text) < 5 Then Exit Sub

        Dim intCount As Int16
        Dim strResults(4) As String

        Me.Cursor = Cursors.WaitCursor

        Try
            If lstResults.Items.Count > 0 Then
                For intCount = lstResults.Items.Count - 1 To 0 Step -1
                    lstResults.Items.RemoveAt(intCount)
                Next intCount
            End If
            '66781 85020
            If Val(txtSearchFor.Text) > 0 And Len(txtSearchFor.Text) > 2 Then
                strSearchBy = "https://api.corp.stsrecycle.com/business-development/customer-accounts?customerId=" + txtSearchFor.Text
            ElseIf Len(txtSearchFor.Text) > 3 Then
                strSearchBy = "https://api.corp.stsrecycle.com/business-development/customer-accounts?organizationName=" + txtSearchFor.Text
            Else
                Exit Sub
            End If

            Dim client As New WebClient()
            Dim json As String = client.DownloadString(strSearchBy)

            Dim serializer As New JavaScriptSerializer()
            Dim result As Object = serializer.DeserializeObject(json)

            For i = 0 To result.length - 1
                Dim data As Dictionary(Of String, Object) = CType(result(i), Dictionary(Of String, Object))

                strResults(0) = data.Item("customerId")

                Dim orgData As Dictionary(Of String, Object) = CType(data.Item("organization"), Dictionary(Of String, Object))

                strResults(1) = orgData.Item("name")

                data = data.Item("organization")

                strSourceID = data.Item("sourceId")

                getCustomerInfo()

                strResults(2) = strAddress
                strResults(3) = strName
                strResults(4) = strPhone

                Dim lst As ListViewItem

                lst = New ListViewItem(strResults)

                lstResults.Items.Add(lst)
            Next i

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Stop
            Me.Cursor = Cursors.Default
        End Try
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
        lstResults.Columns.Add("E-Mail", 130)
        lstResults.Columns.Add("Contact #", 110)
    End Sub
End Class
