Public Class Form2

    Private Sub Form2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Dim durum As Integer

    Private Sub aktar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aktar.Tick
        If ListBox1.Items.Count = Form1.listbox1.Items.Count - 1 Then
            durum = 1
        Else
            Form1.ListBox1.SelectedIndex += 1
            ListBox1.Items.Add(Form1.ListBox1.SelectedItem)
        End If

        If durum = 1 Then
            aktar.Stop()
            ListBox1.SelectedIndex = 0
            Form1.ListBox1.SelectedIndex = 0
            izle.Start()
        End If
    End Sub

    Private Sub izle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles izle.Tick
        If ListBox1.SelectedIndex = Form1.ListBox1.Items.Count - 2 Then
            izle.Stop()
            MsgBox("Kayıt Bitti")
            Me.Close()
        Else
            Dim x As Integer
            Dim y As Integer
            Dim text As New TextBox

            ListBox1.SelectedIndex += 1
            text.Text = ListBox1.SelectedItem

            x = text.Text.Split(","c).First()
            y = text.Text.Split(","c)(text.Text.Split(","c).Length - 1)

            PictureBox1.Location = New Point(x, y)
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        aktar.Start()
    End Sub
End Class