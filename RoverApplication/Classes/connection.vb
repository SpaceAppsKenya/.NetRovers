Imports System.Web
Imports System.IO
Imports System.Net

Public Class connection

    ''' <summary>
    ''' Executes an authenticated HTTP GET command, sending userName/password as a NetworkCredential.
    ''' </summary>
    ''' <param name="uri">The URI to perform the GET operation</param>
    ''' <param name="username">The username to use with the request</param>
    ''' <param name="password">The password to use with the request</param>
    ''' <returns>The response of the request, null if exception thrown.</returns>
    Public Function HttpGet(ByVal uri As String, Optional ByVal username As String = "", Optional ByVal password As String = "") As String
        Dim stream As Stream
        Dim reader As StreamReader
        Dim response As [String] = Nothing
        Dim webClient As New WebClient()

        Using webClient
            ' Check our auth details
            If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
                webClient.Credentials = New NetworkCredential(username, password)
            End If

            Try
                ' open and read from the supplied URI
                stream = webClient.OpenRead(uri)
                reader = New StreamReader(stream)
                response = reader.ReadToEnd()
            Catch ex As WebException
                If TypeOf ex.Response Is HttpWebResponse Then
                    ' Add you own error handling as required
                    Select Case DirectCast(ex.Response, HttpWebResponse).StatusCode
                        Case HttpStatusCode.NotFound, HttpStatusCode.Unauthorized
                            response = Nothing
                            Exit Select
                        Case Else

                            Throw ex
                    End Select
                End If
            End Try
        End Using

        Return response
    End Function

End Class


