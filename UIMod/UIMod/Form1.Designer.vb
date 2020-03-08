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
        Me.Ipatupad = New System.Windows.Forms.Button()
        Me.RM1 = New System.Windows.Forms.Button()
        Me.RM2 = New System.Windows.Forms.Button()
        Me.RM3 = New System.Windows.Forms.Button()
        Me.RM4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(178, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 96)
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
        Me.Player1Box.Size = New System.Drawing.Size(276, 26)
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
        Me.Player2Box.Size = New System.Drawing.Size(276, 26)
        Me.Player2Box.TabIndex = 11
        '
        'Player3Box
        '
        Me.Player3Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player3Box.FormattingEnabled = True
        Me.Player3Box.Items.AddRange(New Object() {"Manananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player3Box.Location = New System.Drawing.Point(178, 333)
        Me.Player3Box.Name = "Player3Box"
        Me.Player3Box.Size = New System.Drawing.Size(276, 26)
        Me.Player3Box.TabIndex = 12
        '
        'Player4Box
        '
        Me.Player4Box.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player4Box.FormattingEnabled = True
        Me.Player4Box.Items.AddRange(New Object() {"Manananggal", "Pulis", "Manghuhula", "Magbubukid"})
        Me.Player4Box.Location = New System.Drawing.Point(178, 377)
        Me.Player4Box.Name = "Player4Box"
        Me.Player4Box.Size = New System.Drawing.Size(276, 26)
        Me.Player4Box.TabIndex = 13
        '
        'Ipatupad
        '
        Me.Ipatupad.Font = New System.Drawing.Font("Paintdrips", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipatupad.Location = New System.Drawing.Point(461, 424)
        Me.Ipatupad.Name = "Ipatupad"
        Me.Ipatupad.Size = New System.Drawing.Size(107, 23)
        Me.Ipatupad.TabIndex = 17
        Me.Ipatupad.Text = "Ipatupad"
        Me.Ipatupad.UseVisualStyleBackColor = True
        '
        'RM1
        '
        Me.RM1.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RM1.ForeColor = System.Drawing.Color.Black
        Me.RM1.Location = New System.Drawing.Point(464, 251)
        Me.RM1.Name = "RM1"
        Me.RM1.Size = New System.Drawing.Size(104, 26)
        Me.RM1.TabIndex = 21
        Me.RM1.Text = "Tanggalin"
        Me.RM1.UseVisualStyleBackColor = True
        '
        'RM2
        '
        Me.RM2.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RM2.ForeColor = System.Drawing.Color.Black
        Me.RM2.Location = New System.Drawing.Point(461, 292)
        Me.RM2.Name = "RM2"
        Me.RM2.Size = New System.Drawing.Size(107, 26)
        Me.RM2.TabIndex = 22
        Me.RM2.Text = "Tanggalin"
        Me.RM2.UseVisualStyleBackColor = True
        '
        'RM3
        '
        Me.RM3.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RM3.ForeColor = System.Drawing.Color.Black
        Me.RM3.Location = New System.Drawing.Point(461, 333)
        Me.RM3.Name = "RM3"
        Me.RM3.Size = New System.Drawing.Size(107, 26)
        Me.RM3.TabIndex = 23
        Me.RM3.Text = "Tanggalin"
        Me.RM3.UseVisualStyleBackColor = True
        '
        'RM4
        '
        Me.RM4.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RM4.ForeColor = System.Drawing.Color.Black
        Me.RM4.Location = New System.Drawing.Point(460, 376)
        Me.RM4.Name = "RM4"
        Me.RM4.Size = New System.Drawing.Size(107, 26)
        Me.RM4.TabIndex = 24
        Me.RM4.Text = "Tanggalin"
        Me.RM4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 112)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(560, 80)
        Me.TextBox1.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(19, 198)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(560, 18)
        Me.TextBox2.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(492, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(605, 459)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RM4)
        Me.Controls.Add(Me.RM3)
        Me.Controls.Add(Me.RM2)
        Me.Controls.Add(Me.RM1)
        Me.Controls.Add(Me.Ipatupad)
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
    Friend WithEvents Ipatupad As Button
    Friend WithEvents RM1 As Button
    Friend WithEvents RM2 As Button
    Friend WithEvents RM3 As Button
    Friend WithEvents RM4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
