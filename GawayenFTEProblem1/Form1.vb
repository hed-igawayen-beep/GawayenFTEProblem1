Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Private artwork As New Dictionary(Of String, String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbArtworkCategory.Items.AddRange(New String() {"Painting", "Sculpture", "Digital Art", "Photography", "Crafts"})
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ArtworkTitle As String = txtArtworkTitle.Text.Trim()
        Dim ArtistName As String = txtArtistName.Text.Trim()
        Dim Price As String = txtArtworkPrice.Text.Trim()
        Dim category As String = ""
        If String.IsNullOrEmpty(ArtworkTitle) Then
            MessageBox.Show("Please enter the artwork title.", "Input Error")
            Return
        End If
        If String.IsNullOrEmpty(ArtistName) Then
            MessageBox.Show("Please enter the artist name.", "Input Error")
            Return
        End If
        If String.IsNullOrEmpty(Price) OrElse Not Integer.TryParse(Price, Nothing) Then
            MessageBox.Show("Invalid format")
            Return
        End If
        If cmbArtworkCategory.SelectedItem Is Nothing Then
            MessageBox.Show("Input Error")
            Return
        Else
            category = cmbArtworkCategory.SelectedItem.ToString()
        End If

        Dim details As String = $"Title: {ArtworkTitle}, Artist: {ArtistName}, Price: {Price}, Category: {category}"
        Output.Items.Add(details)

        txtArtworkTitle.Clear()
        txtArtistName.Clear()
        txtArtworkPrice.Clear()
        cmbArtworkCategory.SelectedIndex = -1
    End Sub
End Class
