Imports System.Math
Public Class Form1
    Dim ofd As New OpenFileDialog
    Dim sfd As New SaveFileDialog

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NudPencerahan.Maximum = 254
        NudPencerahan.Minimum = -254

    End Sub
    Private Sub BtnBrowser_Click(sender As Object, e As EventArgs) Handles BtnBrowser.Click
        With ofd
            .Filter = "jpg files|*.jpg|png files|*png|bmp files|*.bmp"
            .FilterIndex = 3
            .Title = "Buka File Gambar"
        End With
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub BtnBrightness_Click(sender As Object, e As EventArgs) Handles BtnBrightness.Click
         Dim R, G, B As Integer
        Dim bmp As New Bitmap(PictureBox1.Image)
        For i As Integer = 0 To bmp.Width - 1
            For j As Integer = 0 To bmp.Height - 1
                R = bmp.GetPixel(i, j).R
                G = bmp.GetPixel(i, j).G
                B = bmp.GetPixel(i, j).B

                R = R + NudPencerahan.Value
                G = G + NudPencerahan.Value
                B = B + NudPencerahan.Value

                If R > 255 Then R = 255
                If R < 0 Then R = 0
                If G > 255 Then G = 255
                If G < 0 Then G = 0
                If B > 255 Then B = 255
                If B < 0 Then B = 0

                'hasil = Math.Floor((R + G + B) / 3)
                bmp.SetPixel(i, j, Color.FromArgb(R, G, B))
                PictureBox2.Image = bmp
                Application.DoEvents()


            Next
        Next
    End Sub

    Private Sub BtnBW_Click(sender As Object, e As EventArgs) Handles BtnBW.Click
        Try
            Dim img As Bitmap = New Bitmap(PictureBox1.Image)
            Dim c As Color
            Dim i As Integer = 0
            Do While (i < img.Width)
                Dim j As Integer = 0
                Do While (j < img.Height)
                    c = img.GetPixel(i, j)
                    Dim r As Integer = 0
                    r = Convert.ToInt16(c.R)
                    Dim g As Integer = 0
                    g = Convert.ToInt16(c.G)
                    Dim b As Integer = 0
                    b = Convert.ToInt16(c.B)
                    Dim ans As Integer = ((r _
                                + (g + b)) _
                                / 3)
                    If (ans > 128) Then
                        r = 255
                        g = 255
                        b = 255
                    Else
                        r = 0
                        g = 0
                        b = 0
                    End If
                    c = Color.FromArgb(r, g, b)
                    img.SetPixel(i, j, c)
                    j = (j + 1)
                Loop
                i = (i + 1)
            Loop
            PictureBox2.Image = img
            MessageBox.Show("SUCESSFULLY DONE")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With sfd
            .Filter = "jpg files |*.jpg|png files|*png|bmp files|*.bmp"
            .FileName = 1
            .Title = "Simpan File Gambar"
        End With
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image.Save(sfd.FileName)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub



    Private Sub NudPencerahan_ValueChanged(sender As Object, e As EventArgs) Handles NudPencerahan.ValueChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BtnRotate_Click(sender As Object, e As EventArgs)

    End Sub
End Class
