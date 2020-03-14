Imports System.IO
Imports System.Net.Sockets

Public Class Form1
    Private Const V As Integer = 10
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
            Dim PlayerRole = str(3)

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
        If Timer1.Enabled = True Then
            Timer1.Start()

        Else
            Label1.Text = 20
            Timer1.Start()
        End If

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
        RoleLabel.Text = "Manananggal"
        RoleDesc.Text = "Ang mananaggal ay umaatake sa gabi. Bawat gabi ay inaatake nya ang mga bahay na naisin nya."
        PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\GitHub\Final-Project---Gabi-ng-Lagim\Pictures\Manananggal.png")
    End Sub
    Public Sub Pulis()
        RoleLabel.Text = "Pulis"
        RoleDesc.Text = "Ang mga pulis"
        PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\GitHub\Final-Project---Gabi-ng-Lagim\Pictures\Police.png")
    End Sub

    Public Sub Manghuhula()
        RoleLabel.Text = "Manghuhula"
        RoleDesc.Text = "Ang mga manghuhula"
        PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\GitHub\Final-Project---Gabi-ng-Lagim\Pictures\Manghuhula.png")
    End Sub

    Public Sub Magbubukid()
        RoleLabel.Text = "Magbubukid"
        RoleDesc.Text = "Ang mga magbubukid"
        PictureBox1.Image = Image.FromFile("C:\Users\user\Documents\GitHub\Final-Project---Gabi-ng-Lagim\Pictures\Villager.png")
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000

        If Label5.Text = 11 Then
            Label5.ForeColor = Color.Red
            Label5.Text = Val(Label5.Text) - 1

        ElseIf Label5.Text = 0 Then
            Me.Close()
        Else
            Label5.Text = Val(Label5.Text) - 1
        End If

        If Label5.Text = 1 Then
            Label6.Text = "TIME'S UP!"
        ElseIf Label5.Text >= 16 Then
            Label6.Text = "segundong natitira"
        Else Label6.Text = Label6.Text
        End If
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class


