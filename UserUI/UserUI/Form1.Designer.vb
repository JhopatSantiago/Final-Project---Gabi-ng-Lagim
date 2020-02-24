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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Role = New System.Windows.Forms.Label()
        Me.RoleDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LynchP1 = New System.Windows.Forms.Button()
        Me.LynchP2 = New System.Windows.Forms.Button()
        Me.LynchP3 = New System.Windows.Forms.Button()
        Me.LynchP4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabelBox = New System.Windows.Forms.TextBox()
        Me.TimerStart = New System.Windows.Forms.Button()
        Me.KillP4 = New System.Windows.Forms.Button()
        Me.KillP3 = New System.Windows.Forms.Button()
        Me.KillP2 = New System.Windows.Forms.Button()
        Me.KillP1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(207, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Role
        '
        Me.Role.AutoSize = True
        Me.Role.Font = New System.Drawing.Font("Paintdrips", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role.ForeColor = System.Drawing.Color.White
        Me.Role.Location = New System.Drawing.Point(242, 201)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(159, 25)
        Me.Role.TabIndex = 2
        Me.Role.Text = "Mananggal"
        '
        'RoleDesc
        '
        Me.RoleDesc.BackColor = System.Drawing.Color.Black
        Me.RoleDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RoleDesc.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleDesc.ForeColor = System.Drawing.Color.White
        Me.RoleDesc.Location = New System.Drawing.Point(21, 229)
        Me.RoleDesc.Multiline = True
        Me.RoleDesc.Name = "RoleDesc"
        Me.RoleDesc.Size = New System.Drawing.Size(593, 58)
        Me.RoleDesc.TabIndex = 3
        Me.RoleDesc.Text = "Ang manananggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Paintdrips", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pumatay :"
        '
        'LynchP1
        '
        Me.LynchP1.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LynchP1.ForeColor = System.Drawing.Color.Black
        Me.LynchP1.Location = New System.Drawing.Point(123, 347)
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
        Me.LynchP2.Location = New System.Drawing.Point(247, 347)
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
        Me.LynchP3.Location = New System.Drawing.Point(372, 347)
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
        Me.LynchP4.Location = New System.Drawing.Point(494, 347)
        Me.LynchP4.Name = "LynchP4"
        Me.LynchP4.Size = New System.Drawing.Size(107, 26)
        Me.LynchP4.TabIndex = 25
        Me.LynchP4.Text = "Player 4"
        Me.LynchP4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Paintdrips", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Lynch :"
        '
        'Timer1
        '
        '
        'TimeLabelBox
        '
        Me.TimeLabelBox.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabelBox.Location = New System.Drawing.Point(497, 45)
        Me.TimeLabelBox.Name = "TimeLabelBox"
        Me.TimeLabelBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeLabelBox.Size = New System.Drawing.Size(100, 23)
        Me.TimeLabelBox.TabIndex = 27
        Me.TimeLabelBox.Text = "0"
        '
        'TimerStart
        '
        Me.TimerStart.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerStart.ForeColor = System.Drawing.Color.Black
        Me.TimerStart.Location = New System.Drawing.Point(494, 126)
        Me.TimerStart.Name = "TimerStart"
        Me.TimerStart.Size = New System.Drawing.Size(107, 26)
        Me.TimerStart.TabIndex = 28
        Me.TimerStart.Text = "Start"
        Me.TimerStart.UseVisualStyleBackColor = True
        '
        'KillP4
        '
        Me.KillP4.Font = New System.Drawing.Font("Gill Sans MT Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KillP4.ForeColor = System.Drawing.Color.Black
        Me.KillP4.Location = New System.Drawing.Point(494, 304)
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
        Me.KillP3.Location = New System.Drawing.Point(372, 304)
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
        Me.KillP2.Location = New System.Drawing.Point(247, 304)
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
        Me.KillP1.Location = New System.Drawing.Point(123, 304)
        Me.KillP1.Name = "KillP1"
        Me.KillP1.Size = New System.Drawing.Size(107, 26)
        Me.KillP1.TabIndex = 18
        Me.KillP1.Text = "Player 1"
        Me.KillP1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(641, 401)
        Me.Controls.Add(Me.TimerStart)
        Me.Controls.Add(Me.TimeLabelBox)
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
        Me.Controls.Add(Me.RoleDesc)
        Me.Controls.Add(Me.Role)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Player"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Role As Label
    Friend WithEvents RoleDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LynchP1 As Button
    Friend WithEvents LynchP2 As Button
    Friend WithEvents LynchP3 As Button
    Friend WithEvents LynchP4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeLabelBox As TextBox
    Friend WithEvents TimerStart As Button
    Friend WithEvents KillP4 As Button
    Friend WithEvents KillP3 As Button
    Friend WithEvents KillP2 As Button
    Friend WithEvents KillP1 As Button
End Class
