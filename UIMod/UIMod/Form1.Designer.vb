<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Player1Box = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Player2Box = New System.Windows.Forms.ComboBox()
        Me.Player3Box = New System.Windows.Forms.ComboBox()
        Me.Player4Box = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TimeBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(539, 205)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Paintdrips", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Player 1 :"
        '
        'Player1Box
        '
        Me.Player1Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1Box.FormattingEnabled = True
        Me.Player1Box.Items.AddRange(New Object() {"Manananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player1Box.Location = New System.Drawing.Point(178, 252)
        Me.Player1Box.Name = "Player1Box"
        Me.Player1Box.Size = New System.Drawing.Size(367, 26)
        Me.Player1Box.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Paintdrips", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Player 2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Paintdrips", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Player 3 :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Paintdrips", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(46, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Player 4 :"
        '
        'Player2Box
        '
        Me.Player2Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2Box.FormattingEnabled = True
        Me.Player2Box.Items.AddRange(New Object() {"Manananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player2Box.Location = New System.Drawing.Point(178, 292)
        Me.Player2Box.Name = "Player2Box"
        Me.Player2Box.Size = New System.Drawing.Size(367, 26)
        Me.Player2Box.TabIndex = 11
        '
        'Player3Box
        '
        Me.Player3Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player3Box.FormattingEnabled = True
        Me.Player3Box.Items.AddRange(New Object() {"Manananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player3Box.Location = New System.Drawing.Point(178, 333)
        Me.Player3Box.Name = "Player3Box"
        Me.Player3Box.Size = New System.Drawing.Size(367, 26)
        Me.Player3Box.TabIndex = 12
        '
        'Player4Box
        '
        Me.Player4Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player4Box.FormattingEnabled = True
        Me.Player4Box.Items.AddRange(New Object() {"Manananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player4Box.Location = New System.Drawing.Point(178, 377)
        Me.Player4Box.Name = "Player4Box"
        Me.Player4Box.Size = New System.Drawing.Size(367, 26)
        Me.Player4Box.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Paintdrips", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(276, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Oras : "
        '
        'TimeBox
        '
        Me.TimeBox.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBox.FormattingEnabled = True
        Me.TimeBox.Items.AddRange(New Object() {"60", "45", "30"})
        Me.TimeBox.Location = New System.Drawing.Point(353, 214)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.Size = New System.Drawing.Size(101, 26)
        Me.TimeBox.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Paintdrips", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(460, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Seconds"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Paintdrips", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(461, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Ipatupad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(599, 459)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TimeBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Player4Box)
        Me.Controls.Add(Me.Player3Box)
        Me.Controls.Add(Me.Player2Box)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Player1Box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Moderator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Player1Box As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Player2Box As ComboBox
    Friend WithEvents Player3Box As ComboBox
    Friend WithEvents Player4Box As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TimeBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
End Class
