<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModUI))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Player1Box = New System.Windows.Forms.ComboBox()
        Me.Player2Box = New System.Windows.Forms.ComboBox()
        Me.Player3Box = New System.Windows.Forms.ComboBox()
        Me.Player4Box = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimeBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(531, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Paintdrips", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Player 1 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Paintdrips", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player 2 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Paintdrips", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Player 3 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Paintdrips", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(56, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Player 4 :"
        '
        'Player1Box
        '
        Me.Player1Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1Box.FormattingEnabled = True
        Me.Player1Box.Items.AddRange(New Object() {"Mananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player1Box.Location = New System.Drawing.Point(185, 258)
        Me.Player1Box.Name = "Player1Box"
        Me.Player1Box.Size = New System.Drawing.Size(313, 26)
        Me.Player1Box.TabIndex = 5
        '
        'Player2Box
        '
        Me.Player2Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2Box.FormattingEnabled = True
        Me.Player2Box.Items.AddRange(New Object() {"Mananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player2Box.Location = New System.Drawing.Point(185, 292)
        Me.Player2Box.Name = "Player2Box"
        Me.Player2Box.Size = New System.Drawing.Size(313, 26)
        Me.Player2Box.TabIndex = 6
        '
        'Player3Box
        '
        Me.Player3Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player3Box.FormattingEnabled = True
        Me.Player3Box.Items.AddRange(New Object() {"Mananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player3Box.Location = New System.Drawing.Point(185, 326)
        Me.Player3Box.Name = "Player3Box"
        Me.Player3Box.Size = New System.Drawing.Size(313, 26)
        Me.Player3Box.TabIndex = 7
        '
        'Player4Box
        '
        Me.Player4Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player4Box.FormattingEnabled = True
        Me.Player4Box.Items.AddRange(New Object() {"Mananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player4Box.Location = New System.Drawing.Point(185, 361)
        Me.Player4Box.Name = "Player4Box"
        Me.Player4Box.Size = New System.Drawing.Size(313, 26)
        Me.Player4Box.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Paintdrips", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(251, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Oras : "
        '
        'TimeBox
        '
        Me.TimeBox.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBox.FormattingEnabled = True
        Me.TimeBox.Items.AddRange(New Object() {"60", "45", "30"})
        Me.TimeBox.Location = New System.Drawing.Point(334, 220)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.Size = New System.Drawing.Size(71, 26)
        Me.TimeBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Paintdrips", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(425, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 25)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Ipatupad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Paintdrips", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(411, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Seconds"
        '
        'ModUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(554, 445)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TimeBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Player4Box)
        Me.Controls.Add(Me.Player3Box)
        Me.Controls.Add(Me.Player2Box)
        Me.Controls.Add(Me.Player1Box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "ModUI"
        Me.Text = "Moderator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Player1Box As ComboBox
    Friend WithEvents Player2Box As ComboBox
    Friend WithEvents Player3Box As ComboBox
    Friend WithEvents Player4Box As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TimeBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
End Class
