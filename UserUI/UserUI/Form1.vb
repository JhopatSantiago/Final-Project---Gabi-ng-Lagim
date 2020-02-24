Public Class Form1
    Dim time As Integer = 60
    Dim Player1Role, Player2Role, Player3Role, Player4Role As String
    Dim VotingP1, VotingP2, VotingP3, VotingP4 As Integer

    Public Sub Mananggal()
        Role.Text = "Mananggal"
        RoleDesc.Text = "Ang mananaggal ay umaatake sa gabi. Bawat gabi ay inaatake nya ang mga bahay na naisin nya."
        PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\GitHub\Final-Project---Gabi-ng-Lagim\Pictures\Mananggal.png")
    End Sub

    Public Sub Pulis()
        Role.Text = "Pulis"
        RoleDesc.Text = "Ang mga pulis"
        PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\GitHub\Final-Project---Gabi-ng-Lagim\Pictures\Police.png")
    End Sub

    Public Sub Manghuhula()
        Role.Text = "Manghuhula"
        RoleDesc.Text = "Ang mga manghuhula"
        PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\GitHub\Final-Project---Gabi-ng-Lagim\Pictures\Manghuhula.png")
    End Sub

    Public Sub Magbubukid()
        Role.Text = "Magbubukid"
        RoleDesc.Text = "Ang mga magbubukid"
        PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\GitHub\Final-Project---Gabi-ng-Lagim\Pictures\Villager.png")
    End Sub

    Public Sub Lynch()
        LynchP1.Enabled = True
        LynchP2.Enabled = True
        LynchP3.Enabled = True
        LynchP4.Enabled = True


    End Sub

    Public Sub NotLynch()
        LynchP1.Enabled = False
        LynchP1.BackColor = Color.Gray
        LynchP2.Enabled = False
        LynchP2.BackColor = Color.Gray
        LynchP3.Enabled = False
        LynchP3.BackColor = Color.Gray
        LynchP4.Enabled = False
        LynchP4.BackColor = Color.Gray
    End Sub


    Private Sub TimerStart_Click(sender As Object, e As EventArgs) Handles TimerStart.Click
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If time = 0 Then
            Timer1.Stop()
        Else
            time = time - 1
            TimeLabelBox.Text = time
        End If
    End Sub

    Private Sub TimerBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
