<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cognative
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.LblDisplay = New System.Windows.Forms.Label()
        Me.ImgBox = New System.Windows.Forms.PictureBox()
        Me.btnAns10 = New System.Windows.Forms.Button()
        Me.btnAns5 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnAns9 = New System.Windows.Forms.Button()
        Me.btnAns8 = New System.Windows.Forms.Button()
        Me.btnAns7 = New System.Windows.Forms.Button()
        Me.btnAns6 = New System.Windows.Forms.Button()
        Me.btnAns4 = New System.Windows.Forms.Button()
        Me.btnAns3 = New System.Windows.Forms.Button()
        Me.btnAns2 = New System.Windows.Forms.Button()
        Me.btnAns1 = New System.Windows.Forms.Button()
        Me.Thicc = New System.Windows.Forms.Timer(Me.components)
        Me.PhraseBoxEnglish = New System.Windows.Forms.ListBox()
        Me.PhraseBoxItalian = New System.Windows.Forms.ListBox()
        Me.PhraseBoxPolish = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ImgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PhraseBoxPolish)
        Me.Panel1.Controls.Add(Me.PhraseBoxItalian)
        Me.Panel1.Controls.Add(Me.PhraseBoxEnglish)
        Me.Panel1.Controls.Add(Me.LblTimer)
        Me.Panel1.Controls.Add(Me.LblDisplay)
        Me.Panel1.Controls.Add(Me.ImgBox)
        Me.Panel1.Controls.Add(Me.btnAns10)
        Me.Panel1.Controls.Add(Me.btnAns5)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.btnAns9)
        Me.Panel1.Controls.Add(Me.btnAns8)
        Me.Panel1.Controls.Add(Me.btnAns7)
        Me.Panel1.Controls.Add(Me.btnAns6)
        Me.Panel1.Controls.Add(Me.btnAns4)
        Me.Panel1.Controls.Add(Me.btnAns3)
        Me.Panel1.Controls.Add(Me.btnAns2)
        Me.Panel1.Controls.Add(Me.btnAns1)
        Me.Panel1.Location = New System.Drawing.Point(0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1286, 713)
        Me.Panel1.TabIndex = 0
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.Location = New System.Drawing.Point(594, 231)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(98, 108)
        Me.LblTimer.TabIndex = 14
        Me.LblTimer.Text = "3"
        Me.LblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblDisplay
        '
        Me.LblDisplay.AutoSize = True
        Me.LblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisplay.Location = New System.Drawing.Point(443, 62)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.Size = New System.Drawing.Size(401, 108)
        Me.LblDisplay.TabIndex = 13
        Me.LblDisplay.Text = "Ready?!"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ImgBox
        '
        Me.ImgBox.Location = New System.Drawing.Point(3, 0)
        Me.ImgBox.Name = "ImgBox"
        Me.ImgBox.Size = New System.Drawing.Size(1283, 420)
        Me.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgBox.TabIndex = 12
        Me.ImgBox.TabStop = False
        '
        'btnAns10
        '
        Me.btnAns10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns10.Location = New System.Drawing.Point(1033, 595)
        Me.btnAns10.Name = "btnAns10"
        Me.btnAns10.Size = New System.Drawing.Size(250, 111)
        Me.btnAns10.TabIndex = 11
        Me.btnAns10.Text = "Button 10"
        Me.btnAns10.UseVisualStyleBackColor = True
        '
        'btnAns5
        '
        Me.btnAns5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns5.Location = New System.Drawing.Point(1033, 484)
        Me.btnAns5.Name = "btnAns5"
        Me.btnAns5.Size = New System.Drawing.Size(250, 111)
        Me.btnAns5.TabIndex = 10
        Me.btnAns5.Text = "Button5"
        Me.btnAns5.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(33, 426)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(1250, 52)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 9
        '
        'btnAns9
        '
        Me.btnAns9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns9.Location = New System.Drawing.Point(783, 595)
        Me.btnAns9.Name = "btnAns9"
        Me.btnAns9.Size = New System.Drawing.Size(250, 111)
        Me.btnAns9.TabIndex = 8
        Me.btnAns9.Text = "Button9"
        Me.btnAns9.UseVisualStyleBackColor = True
        '
        'btnAns8
        '
        Me.btnAns8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns8.Location = New System.Drawing.Point(533, 595)
        Me.btnAns8.Name = "btnAns8"
        Me.btnAns8.Size = New System.Drawing.Size(250, 111)
        Me.btnAns8.TabIndex = 7
        Me.btnAns8.Text = "Button8"
        Me.btnAns8.UseVisualStyleBackColor = True
        '
        'btnAns7
        '
        Me.btnAns7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns7.Location = New System.Drawing.Point(283, 595)
        Me.btnAns7.Name = "btnAns7"
        Me.btnAns7.Size = New System.Drawing.Size(250, 111)
        Me.btnAns7.TabIndex = 6
        Me.btnAns7.Text = "Button7"
        Me.btnAns7.UseVisualStyleBackColor = True
        '
        'btnAns6
        '
        Me.btnAns6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns6.Location = New System.Drawing.Point(33, 595)
        Me.btnAns6.Name = "btnAns6"
        Me.btnAns6.Size = New System.Drawing.Size(250, 111)
        Me.btnAns6.TabIndex = 5
        Me.btnAns6.Text = "Button6"
        Me.btnAns6.UseVisualStyleBackColor = True
        '
        'btnAns4
        '
        Me.btnAns4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns4.Location = New System.Drawing.Point(783, 484)
        Me.btnAns4.Name = "btnAns4"
        Me.btnAns4.Size = New System.Drawing.Size(250, 111)
        Me.btnAns4.TabIndex = 4
        Me.btnAns4.Text = "Button4"
        Me.btnAns4.UseVisualStyleBackColor = True
        '
        'btnAns3
        '
        Me.btnAns3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns3.Location = New System.Drawing.Point(533, 484)
        Me.btnAns3.Name = "btnAns3"
        Me.btnAns3.Size = New System.Drawing.Size(250, 111)
        Me.btnAns3.TabIndex = 3
        Me.btnAns3.Text = "Button3"
        Me.btnAns3.UseVisualStyleBackColor = True
        '
        'btnAns2
        '
        Me.btnAns2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns2.Location = New System.Drawing.Point(283, 484)
        Me.btnAns2.Name = "btnAns2"
        Me.btnAns2.Size = New System.Drawing.Size(250, 111)
        Me.btnAns2.TabIndex = 2
        Me.btnAns2.Text = "Button2"
        Me.btnAns2.UseVisualStyleBackColor = True
        '
        'btnAns1
        '
        Me.btnAns1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAns1.Location = New System.Drawing.Point(33, 484)
        Me.btnAns1.Name = "btnAns1"
        Me.btnAns1.Size = New System.Drawing.Size(250, 111)
        Me.btnAns1.TabIndex = 1
        Me.btnAns1.Text = "Button1"
        Me.btnAns1.UseVisualStyleBackColor = True
        '
        'Thicc
        '
        '
        'PhraseBoxEnglish
        '
        Me.PhraseBoxEnglish.FormattingEnabled = True
        Me.PhraseBoxEnglish.Items.AddRange(New Object() {"Mineral Water", "A Black Coffee", "Tea with lemon", "Sugar", "Milk", "Pepper", "A table for two, please", "Here is the menu", "Do you want to order?"})
        Me.PhraseBoxEnglish.Location = New System.Drawing.Point(70, 268)
        Me.PhraseBoxEnglish.Name = "PhraseBoxEnglish"
        Me.PhraseBoxEnglish.Size = New System.Drawing.Size(120, 95)
        Me.PhraseBoxEnglish.TabIndex = 15
        Me.PhraseBoxEnglish.Visible = False
        '
        'PhraseBoxItalian
        '
        Me.PhraseBoxItalian.FormattingEnabled = True
        Me.PhraseBoxItalian.Items.AddRange(New Object() {"acqua minerale", "un caffé nero", "té con limone", "Zucchero", "Latte", "Sale", "Pepe", "Un tavolo per due, per favour", "Ecco il menu", "Volete ordinare?"})
        Me.PhraseBoxItalian.Location = New System.Drawing.Point(196, 268)
        Me.PhraseBoxItalian.Name = "PhraseBoxItalian"
        Me.PhraseBoxItalian.Size = New System.Drawing.Size(120, 95)
        Me.PhraseBoxItalian.TabIndex = 16
        Me.PhraseBoxItalian.Visible = False
        '
        'PhraseBoxPolish
        '
        Me.PhraseBoxPolish.FormattingEnabled = True
        Me.PhraseBoxPolish.Items.AddRange(New Object() {"woda mineralna", "czarna kawa", "Herbata z cytryna", "Cukier", "sól", "Pieprz", "Stolik dla dwojga prosze", "oto menu", "chcesz zamówic?"})
        Me.PhraseBoxPolish.Location = New System.Drawing.Point(322, 268)
        Me.PhraseBoxPolish.Name = "PhraseBoxPolish"
        Me.PhraseBoxPolish.Size = New System.Drawing.Size(120, 95)
        Me.PhraseBoxPolish.TabIndex = 17
        Me.PhraseBoxPolish.Visible = False
        '
        'Cognative
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1298, 728)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cognative"
        Me.Text = "Cognative"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Thicc As Timer
    Friend WithEvents btnAns6 As Button
    Friend WithEvents btnAns4 As Button
    Friend WithEvents btnAns3 As Button
    Friend WithEvents btnAns2 As Button
    Friend WithEvents btnAns1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnAns10 As Button
    Friend WithEvents btnAns5 As Button
    Friend WithEvents btnAns9 As Button
    Friend WithEvents btnAns8 As Button
    Friend WithEvents btnAns7 As Button
    Friend WithEvents LblDisplay As Label
    Friend WithEvents ImgBox As PictureBox
    Friend WithEvents LblTimer As Label
    Friend WithEvents PhraseBoxEnglish As ListBox
    Friend WithEvents PhraseBoxPolish As ListBox
    Friend WithEvents PhraseBoxItalian As ListBox
End Class
