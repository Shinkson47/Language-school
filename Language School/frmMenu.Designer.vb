<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserDisplay = New System.Windows.Forms.Label()
        Me.UserDiplay = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGame3 = New System.Windows.Forms.Button()
        Me.btnGame2 = New System.Windows.Forms.Button()
        Me.btnGame1 = New System.Windows.Forms.Button()
        Me.languageDisplay = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.languageDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 1
        '
        'UserDisplay
        '
        Me.UserDisplay.AutoSize = True
        Me.UserDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDisplay.ForeColor = System.Drawing.Color.White
        Me.UserDisplay.Location = New System.Drawing.Point(10, 9)
        Me.UserDisplay.Name = "UserDisplay"
        Me.UserDisplay.Size = New System.Drawing.Size(0, 16)
        Me.UserDisplay.TabIndex = 0
        '
        'UserDiplay
        '
        Me.UserDiplay.AutoSize = True
        Me.UserDiplay.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDiplay.ForeColor = System.Drawing.Color.White
        Me.UserDiplay.Location = New System.Drawing.Point(26, 23)
        Me.UserDiplay.Name = "UserDiplay"
        Me.UserDiplay.Size = New System.Drawing.Size(55, 23)
        Me.UserDiplay.TabIndex = 0
        Me.UserDiplay.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnGame3)
        Me.Panel1.Controls.Add(Me.btnGame2)
        Me.Panel1.Controls.Add(Me.btnGame1)
        Me.Panel1.Controls.Add(Me.languageDisplay)
        Me.Panel1.Controls.Add(Me.UserDiplay)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1268, 681)
        Me.Panel1.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(493, 424)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(300, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGame3
        '
        Me.btnGame3.BackgroundImage = CType(resources.GetObject("btnGame3.BackgroundImage"), System.Drawing.Image)
        Me.btnGame3.FlatAppearance.BorderSize = 0
        Me.btnGame3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnGame3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGame3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGame3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGame3.ForeColor = System.Drawing.Color.White
        Me.btnGame3.Location = New System.Drawing.Point(493, 356)
        Me.btnGame3.Name = "btnGame3"
        Me.btnGame3.Size = New System.Drawing.Size(300, 40)
        Me.btnGame3.TabIndex = 7
        Me.btnGame3.Text = " Speed Stomp"
        Me.btnGame3.UseVisualStyleBackColor = True
        '
        'btnGame2
        '
        Me.btnGame2.BackgroundImage = CType(resources.GetObject("btnGame2.BackgroundImage"), System.Drawing.Image)
        Me.btnGame2.FlatAppearance.BorderSize = 0
        Me.btnGame2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnGame2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGame2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGame2.ForeColor = System.Drawing.Color.White
        Me.btnGame2.Location = New System.Drawing.Point(493, 288)
        Me.btnGame2.Name = "btnGame2"
        Me.btnGame2.Size = New System.Drawing.Size(300, 40)
        Me.btnGame2.TabIndex = 6
        Me.btnGame2.Text = "Word Crash"
        Me.btnGame2.UseVisualStyleBackColor = True
        '
        'btnGame1
        '
        Me.btnGame1.BackgroundImage = CType(resources.GetObject("btnGame1.BackgroundImage"), System.Drawing.Image)
        Me.btnGame1.FlatAppearance.BorderSize = 0
        Me.btnGame1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnGame1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGame1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGame1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGame1.ForeColor = System.Drawing.Color.White
        Me.btnGame1.Location = New System.Drawing.Point(493, 220)
        Me.btnGame1.Name = "btnGame1"
        Me.btnGame1.Size = New System.Drawing.Size(300, 40)
        Me.btnGame1.TabIndex = 3
        Me.btnGame1.Text = "Memory Smash"
        Me.btnGame1.UseVisualStyleBackColor = True
        '
        'languageDisplay
        '
        Me.languageDisplay.Location = New System.Drawing.Point(30, 57)
        Me.languageDisplay.Name = "languageDisplay"
        Me.languageDisplay.Size = New System.Drawing.Size(58, 36)
        Me.languageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.languageDisplay.TabIndex = 1
        Me.languageDisplay.TabStop = False
        '
        'frmMenu
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.languageDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmMenu As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserDisplay As System.Windows.Forms.Label
    Friend WithEvents UserDiplay As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents languageDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents btnGame1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGame3 As System.Windows.Forms.Button
    Friend WithEvents btnGame2 As System.Windows.Forms.Button
End Class
