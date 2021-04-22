Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kayit.Start()
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kayit.Stop()
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.SelectedIndex = 0
        Form2.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Button1.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Dim eski As Point
    Dim yeni As Point
    Dim rich As New RichTextBox

    Private Sub kayit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kayit.Tick
        yeni = New Point(MousePosition.X, MousePosition.Y)
        If yeni = eski Then
        Else
            'Otomatik kayıt içi aşağıdaki 2 kodu kullanabilirsiniz.
            'rich.Text &= vbNewLine & MousePosition.X & "," & MousePosition.Y
            'rich.SaveFile(Application.StartupPath & "\img\mouse.txt", RichTextBoxStreamType.PlainText)
            ListBox1.Items.Add(MousePosition.X & "," & MousePosition.Y)
        End If
        eski = New Point(MousePosition.X, MousePosition.Y)
    End Sub
End Class
