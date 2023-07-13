Imports System.IO

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click

        Try

            If FileUpload.HasFile Then

                Dim reader As StreamReader = New StreamReader(FileUpload.FileContent)
                Dim start As String = reader.ReadToEnd
                txtResult.Text = viewCCXml.decode(start)

            Else
                txtResult.Text = "please select a file for upload"

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class