<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LynchP1 = New System.Windows.Forms.Button()
        Me.LynchP2 = New System.Windows.Forms.Button()
        Me.LynchP3 = New System.Windows.Forms.Button()
        Me.LynchP4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.KillP4 = New System.Windows.Forms.Button()
        Me.KillP3 = New System.Windows.Forms.Button()
        Me.KillP2 = New System.Windows.Forms.Button()
        Me.KillP1 = New System.Windows.Forms.Button()
        Me.RoleDesc = New System.Windows.Forms.Label()
        Me.Connect = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(236, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleLabel.ForeColor = System.Drawing.Color.White
        Me.RoleLabel.Location = New System.Drawing.Point(273, 209)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(143, 25)
        Me.RoleLabel.TabIndex = 2
        Me.RoleLabel.Text = "Manananggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pumatay :"
        '
        'LynchP1
        '
        Me.LynchP1.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LynchP1.ForeColor = System.Drawing.Color.Black
        Me.LynchP1.Location = New System.Drawing.Point(124, 335)
        Me.LynchP1.Name = "LynchP1"
        Me.LynchP1.Size = New System.Drawing.Size(107, 26)
        Me.LynchP1.TabIndex = 22
        Me.LynchP1.Text = "Player 1"
        Me.LynchP1.UseVisualStyleBackColor = True
        '
        'LynchP2
        '
        Me.LynchP2.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LynchP2.ForeColor = System.Drawing.Color.Black
        Me.LynchP2.Location = New System.Drawing.Point(248, 335)
        Me.LynchP2.Name = "LynchP2"
        Me.LynchP2.Size = New System.Drawing.Size(107, 26)
        Me.LynchP2.TabIndex = 23
        Me.LynchP2.Text = "Player 2"
        Me.LynchP2.UseVisualStyleBackColor = True
        '
        'LynchP3
        '
        Me.LynchP3.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LynchP3.ForeColor = System.Drawing.Color.Black
        Me.LynchP3.Location = New System.Drawing.Point(373, 335)
        Me.LynchP3.Name = "LynchP3"
        Me.LynchP3.Size = New System.Drawing.Size(107, 26)
        Me.LynchP3.TabIndex = 24
        Me.LynchP3.Text = "Player 3"
        Me.LynchP3.UseVisualStyleBackColor = True
        '
        'LynchP4
        '
        Me.LynchP4.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LynchP4.ForeColor = System.Drawing.Color.Black
        Me.LynchP4.Location = New System.Drawing.Point(495, 335)
        Me.LynchP4.Name = "LynchP4"
        Me.LynchP4.Size = New System.Drawing.Size(107, 26)
        Me.LynchP4.TabIndex = 25
        Me.LynchP4.Text = "Player 4"
        Me.LynchP4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Lynch :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'KillP4
        '
        Me.KillP4.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KillP4.ForeColor = System.Drawing.Color.Black
        Me.KillP4.Location = New System.Drawing.Point(495, 292)
        Me.KillP4.Name = "KillP4"
        Me.KillP4.Size = New System.Drawing.Size(107, 26)
        Me.KillP4.TabIndex = 21
        Me.KillP4.Text = "Player 4"
        Me.KillP4.UseVisualStyleBackColor = True
        '
        'KillP3
        '
        Me.KillP3.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KillP3.ForeColor = System.Drawing.Color.Black
        Me.KillP3.Location = New System.Drawing.Point(373, 292)
        Me.KillP3.Name = "KillP3"
        Me.KillP3.Size = New System.Drawing.Size(107, 26)
        Me.KillP3.TabIndex = 20
        Me.KillP3.Text = "Player 3"
        Me.KillP3.UseVisualStyleBackColor = True
        '
        'KillP2
        '
        Me.KillP2.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KillP2.ForeColor = System.Drawing.Color.Black
        Me.KillP2.Location = New System.Drawing.Point(248, 292)
        Me.KillP2.Name = "KillP2"
        Me.KillP2.Size = New System.Drawing.Size(107, 26)
        Me.KillP2.TabIndex = 19
        Me.KillP2.Text = "Player 2"
        Me.KillP2.UseVisualStyleBackColor = True
        '
        'KillP1
        '
        Me.KillP1.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KillP1.ForeColor = System.Drawing.Color.Black
        Me.KillP1.Location = New System.Drawing.Point(124, 292)
        Me.KillP1.Name = "KillP1"
        Me.KillP1.Size = New System.Drawing.Size(107, 26)
        Me.KillP1.TabIndex = 18
        Me.KillP1.Text = "Player 1"
        Me.KillP1.UseVisualStyleBackColor = True
        '
        'RoleDesc
        '
        Me.RoleDesc.AutoSize = True
        Me.RoleDesc.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleDesc.ForeColor = System.Drawing.Color.White
        Me.RoleDesc.Location = New System.Drawing.Point(28, 236)
        Me.RoleDesc.Name = "RoleDesc"
        Me.RoleDesc.Size = New System.Drawing.Size(153, 23)
        Me.RoleDesc.TabIndex = 29
        Me.RoleDesc.Text = "Ang mga Manananggal"
        '
        'Connect
        '
        Me.Connect.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Connect.ForeColor = System.Drawing.Color.Black
        Me.Connect.Location = New System.Drawing.Point(12, 83)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(169, 26)
        Me.Connect.TabIndex = 30
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Server:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Port:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(477, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 108)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "15"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(492, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "SEGUNDONG NATITIRA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(653, 385)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Connect)
        Me.Controls.Add(Me.RoleDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LynchP4)
        Me.Controls.Add(Me.LynchP3)
        Me.Controls.Add(Me.LynchP2)
        Me.Controls.Add(Me.LynchP1)
        Me.Controls.Add(Me.KillP4)
        Me.Controls.Add(Me.KillP3)
        Me.Controls.Add(Me.KillP2)
        Me.Controls.Add(Me.KillP1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RoleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Player 1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LynchP1 As Button
    Friend WithEvents LynchP2 As Button
    Friend WithEvents LynchP3 As Button
    Friend WithEvents LynchP4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents KillP4 As Button
    Friend WithEvents KillP3 As Button
    Friend WithEvents KillP2 As Button
    Friend WithEvents KillP1 As Button
    Friend WithEvents RoleDesc As Label
    Friend WithEvents Connect As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
