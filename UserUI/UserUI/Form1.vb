Imports System.IO
Imports System.Net.Sockets

Public Class Form1

    Dim client As TcpClient
        Dim sWriter As StreamWriter
    Dim NIckFrefix As String = "Player 1"
    Sub xLoad() Handles Me.Load
        Me.Text &= " " & NIckFrefix
    End Sub
    Delegate Sub _xUpdate(ByVal str As String)
        Sub xUpdate(ByVal str As String)
            If InvokeRequired Then
                Invoke(New _xUpdate(AddressOf xUpdate), str)
            Else
                TextBox3.AppendText(str & vbNewLine)
            End If
        End Sub

        Sub read(ByVal ar As IAsyncResult)
            Try
                xUpdate(New StreamReader(client.GetStream).ReadLine)
                client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)

            Catch ex As Exception
                xUpdate("You have disconnecting from server")
                Exit Sub
            End Try
        End Sub
        Private Sub send(ByVal str As String)
            Try
                sWriter = New StreamWriter(client.GetStream)
                sWriter.WriteLine(str)
                sWriter.Flush()
            Catch ex As Exception
                xUpdate("You're not server")
            End Try
        End Sub
    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        If Connect.Text = "Connect" Then
            Try
                client = New TcpClient(TextBox1.Text, CInt(TextBox2.Text))
                client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
                Connect.Text = "Disconnect"
            Catch ex As Exception
                xUpdate("Can't connect to the server!")
            End Try
        Else
            client.Client.Close()
            client = Nothing
            Connect.Text = "Connect"
        End If
    End Sub
    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
            send(NIckFrefix & ": " & TextBox4.Text)
            TextBox4.Clear()
            End If
        End Sub
        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        send(NIckFrefix & ": " & TextBox4.Text)
        TextBox4.Clear()
        End Sub


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

    Public Sub Kill()
        KillP1.Enabled = True
        KillP2.Enabled = True
        KillP3.Enabled = True
        KillP4.Enabled = True
    End Sub

    Private Sub LynchP1_Click(sender As Object, e As EventArgs) Handles LynchP1.Click
        MessageBox.Show("Pinili mong matanggal si Player 1")

        Lynchx()

    End Sub

    Public Sub Killx()
        KillP1.Enabled = False
        KillP1.BackColor = Color.Gray
        KillP2.Enabled = False
        KillP2.BackColor = Color.Gray
        KillP3.Enabled = False
        KillP3.BackColor = Color.Gray
        KillP4.Enabled = False
        KillP4.BackColor = Color.Gray
    End Sub

    Private Sub LynchP3_Click(sender As Object, e As EventArgs) Handles LynchP3.Click
        MessageBox.Show("Pinili mong matanggal si Player 3")
        Lynchx()
    End Sub

    Private Sub LynchP4_Click(sender As Object, e As EventArgs) Handles LynchP4.Click
        MessageBox.Show("Pinili mong matanggal si Player 4")
        Lynchx()

    End Sub

    Public Sub Lynch()
        Killx()
        LynchP1.Enabled = True
        LynchP2.Enabled = True
        LynchP3.Enabled = True
        LynchP4.Enabled = True

    End Sub

    Public Sub Lynchx()
        LynchP1.Enabled = False
        LynchP1.BackColor = Color.Gray
        LynchP2.Enabled = False
        LynchP2.BackColor = Color.Gray
        LynchP3.Enabled = False
        LynchP3.BackColor = Color.Gray
        LynchP4.Enabled = False
        LynchP4.BackColor = Color.Gray
    End Sub

    Private Sub LynchP2_Click(sender As Object, e As EventArgs) Handles LynchP2.Click
        MessageBox.Show("Pinili mong matanggal si Player 2")
        Lynchx()
    End Sub

    Private Sub TimerStart_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 1000
        Lynch()

    End Sub

    Dim time As Integer = 15
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


