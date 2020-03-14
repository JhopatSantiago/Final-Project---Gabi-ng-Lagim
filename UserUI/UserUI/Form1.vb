Imports System.IO
Imports System.Net.Sockets

Public Class Form1
    Dim time = 15
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
            Dim PlayerRole = str(0)

            If PlayerRole = "0" Then
                Manananggal()
            ElseIf PlayerRole = "1" Then
                Pulis()
            ElseIf PlayerRole = "2" Then
                Manghuhula()
            ElseIf PlayerRole = "3" Then
                Magbubukid()
            End If
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


    Public Sub Manananggal()
        RoleLabel.Text = "Mananggal"
        RoleDesc.Text = "Ang mananaggal ay umaatake sa gabi. Bawat gabi ay inaatake nya ang mga bahay na naisin nya."
        PictureBox1.Image = Image.FromFile("D:\Documents\School Stuff\Fifth Year\2nd Sem\Final Project - Gabi ng Lagim\Pictures\Manananggal.png")
    End Sub
    Public Sub Pulis()
        RoleLabel.Text = "Pulis"
        RoleDesc.Text = "Ang mga pulis"
        PictureBox1.Image = Image.FromFile("D:\Documents\School Stuff\Fifth Year\2nd Sem\Final Project - Gabi ng Lagim\Pictures\Police.png")
    End Sub

    Public Sub Manghuhula()
        RoleLabel.Text = "Manghuhula"
        RoleDesc.Text = "Ang mga manghuhula"
        PictureBox1.Image = Image.FromFile("D:\Documents\School Stuff\Fifth Year\2nd Sem\Final Project - Gabi ng Lagim\Pictures\Manghuhula.png")
    End Sub

    Public Sub Magbubukid()
        RoleLabel.Text = "Magbubukid"
        RoleDesc.Text = "Ang mga magbubukid"
        PictureBox1.Image = Image.FromFile("D:\Documents\School Stuff\Fifth Year\2nd Sem\Final Project - Gabi ng Lagim\Pictures\Villager.png")
    End Sub






    Private Sub TimerStart_Click(sender As Object, e As EventArgs)
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


End Class


