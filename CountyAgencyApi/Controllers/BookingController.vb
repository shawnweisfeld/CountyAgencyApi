Imports System.Net
Imports System.Web.Http

Public Class BookingController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues(county As String, agency As String) As IEnumerable(Of String)
        Return New String() {county, agency}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(county As String, agency As String, ByVal id As Integer) As String
        Return String.Format("{0} {1} {2}", county, agency, id)
    End Function

    ' POST api/<controller>
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
