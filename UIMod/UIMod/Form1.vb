Public Class Form1
    Dim time As Integer
    Dim Player1Role, Player2Role, Player3Role, Player4Role As String

    Private Sub TimeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimeBox.SelectedIndexChanged
        time = TimeBox.Text
    End Sub

    Private Sub Player2Box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Player2Box.SelectedIndexChanged
        Player2Role = Player2Box.Text
    End Sub

    Private Sub Player3Box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Player3Box.SelectedIndexChanged
        Player3Role = Player3Box.Text
    End Sub

    Private Sub Player4Box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Player4Box.SelectedIndexChanged
        Player4Role = Player4Box.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TimeBox.Text <> "" And Player1Box.Text <> "" And Player2Box.Text <> "" And Player3Box.Text <> "" And Player4Box.Text <> "" Then
            MsgBox("Let the game begin!", MsgBoxStyle.Information, "Gabi ng Lagim")
        Else
            MsgBox("Please complete the requirements", MsgBoxStyle.Critical, "Input data")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Player1Box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Player1Box.SelectedIndexChanged
        Player1Role = Player1Box.Text
    End Sub
End Class
