<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FailTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplashTransition = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Passfield = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameField = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LangSelectItaly = New System.Windows.Forms.PictureBox()
        Me.LangSelectPoland = New System.Windows.Forms.PictureBox()
        Me.LangConf = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.SplashTransition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.LangSelectItaly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LangSelectPoland, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(395, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 8)
        Me.Panel2.TabIndex = 2
        '
        'FailTimer
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 7000
        '
        'SplashTransition
        '
        Me.SplashTransition.Image = CType(resources.GetObject("SplashTransition.Image"), System.Drawing.Image)
        Me.SplashTransition.Location = New System.Drawing.Point(0, 0)
        Me.SplashTransition.Name = "SplashTransition"
        Me.SplashTransition.Size = New System.Drawing.Size(500, 500)
        Me.SplashTransition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SplashTransition.TabIndex = 0
        Me.SplashTransition.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnEnter)
        Me.Panel3.Controls.Add(Me.NameField)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Passfield)
        Me.Panel3.Location = New System.Drawing.Point(149, 149)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 188)
        Me.Panel3.TabIndex = 4
        Me.Panel3.Visible = False
        '
        'Passfield
        '
        Me.Passfield.BackColor = System.Drawing.Color.Black
        Me.Passfield.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passfield.ForeColor = System.Drawing.Color.White
        Me.Passfield.Location = New System.Drawing.Point(2, 108)
        Me.Passfield.Name = "Passfield"
        Me.Passfield.Size = New System.Drawing.Size(194, 40)
        Me.Passfield.TabIndex = 2
        Me.Passfield.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome, Students!"
        '
        'NameField
        '
        Me.NameField.BackColor = System.Drawing.Color.Black
        Me.NameField.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameField.ForeColor = System.Drawing.Color.White
        Me.NameField.Location = New System.Drawing.Point(0, 49)
        Me.NameField.Name = "NameField"
        Me.NameField.Size = New System.Drawing.Size(197, 40)
        Me.NameField.TabIndex = 1
        Me.NameField.Text = "ID"
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnEnter.FlatAppearance.BorderSize = 0
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(56, 154)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "→"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LangConf)
        Me.Panel4.Controls.Add(Me.LangSelectPoland)
        Me.Panel4.Controls.Add(Me.LangSelectItaly)
        Me.Panel4.Location = New System.Drawing.Point(489, 149)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(199, 188)
        Me.Panel4.TabIndex = 6
        Me.Panel4.Visible = False
        '
        'LangSelectItaly
        '
        Me.LangSelectItaly.Image = Global.Language_School.My.Resources.Resources.Italy
        Me.LangSelectItaly.Location = New System.Drawing.Point(55, 13)
        Me.LangSelectItaly.Name = "LangSelectItaly"
        Me.LangSelectItaly.Size = New System.Drawing.Size(91, 66)
        Me.LangSelectItaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LangSelectItaly.TabIndex = 4
        Me.LangSelectItaly.TabStop = False
        '
        'LangSelectPoland
        '
        Me.LangSelectPoland.Image = Global.Language_School.My.Resources.Resources.Poland
        Me.LangSelectPoland.Location = New System.Drawing.Point(55, 85)
        Me.LangSelectPoland.Name = "LangSelectPoland"
        Me.LangSelectPoland.Size = New System.Drawing.Size(91, 73)
        Me.LangSelectPoland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LangSelectPoland.TabIndex = 5
        Me.LangSelectPoland.TabStop = False
        '
        'LangConf
        '
        Me.LangConf.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LangConf.FlatAppearance.BorderSize = 0
        Me.LangConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LangConf.ForeColor = System.Drawing.Color.White
        Me.LangConf.Location = New System.Drawing.Point(55, 162)
        Me.LangConf.Name = "LangConf"
        Me.LangConf.Size = New System.Drawing.Size(90, 23)
        Me.LangConf.TabIndex = 7
        Me.LangConf.Text = "→"
        Me.LangConf.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.SplashTransition)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 642)
        Me.Panel1.TabIndex = 1
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 644)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Language School"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SplashTransition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.LangSelectItaly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LangSelectPoland, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FailTimer As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplashTransition As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEnter As Button
    Friend WithEvents NameField As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Passfield As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LangConf As Button
    Friend WithEvents LangSelectPoland As PictureBox
    Friend WithEvents LangSelectItaly As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
