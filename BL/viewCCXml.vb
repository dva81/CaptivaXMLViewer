Imports Emc.InputAccel.Core
Imports System.IO

Module viewCCXml


    Public Function decode(filetext As String) As String

        Dim decodedContent As String = String.Empty
        Try

            If Not String.IsNullOrEmpty(filetext) Then

                Dim rawContent As String = filetext
                Debug.WriteLine(rawContent)

                ' config files have this goofy prefix and suffix
                If (rawContent.StartsWith(">>>>*") And rawContent.EndsWith("*>>>>")) Then
                    rawContent = rawContent.Replace(">>>>*", "")
                    rawContent = rawContent.Replace("*>>>>", "")
                End If

                ' here is the secret decoder call
                decodedContent = SystemHelper.DecodeData(rawContent)

                Debug.WriteLine("**********************************************************")
                Debug.WriteLine(decodedContent)

                Return decodedContent

                Debug.WriteLine("")


            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return ex.Message
        End Try
        Return decodedContent
    End Function
End Module
