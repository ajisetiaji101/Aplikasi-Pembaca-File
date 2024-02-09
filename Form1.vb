Imports System.IO

Public Class Form1

    Private filePath As String

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog.FileName
            DisplayFileContent(filePath)
        End If
    End Sub

    Private Sub btnBrowse2_Click(sender As Object, e As EventArgs) Handles btnBrowse2.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog.FileName
            ReadFile(filePath)
        End If
    End Sub

    Private Sub DisplayFileContent(filePath As String)
        Try
            Dim fileContent As String = File.ReadAllText(filePath)
            MessageBox.Show("Isi File:" & vbCrLf & fileContent)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub ReadFile(filePath As String)
        Try
            Using reader As New StreamReader(filePath)
                Dim line As String
                Do
                    line = reader.ReadLine()
                    If Not line Is Nothing Then
                        ' Proses setiap baris sesuai kebutuhan
                        ProcessLine(line)
                    End If
                Loop Until line Is Nothing
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ProcessLine(line As String)
        MessageBox.Show("Line contains : " & line)
    End Sub


End Class
