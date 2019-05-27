<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LangReSel
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
        Me.lblLan2 = New System.Windows.Forms.Label()
        Me.lblLan1 = New System.Windows.Forms.Label()
        Me.languageSelectChange1 = New System.Windows.Forms.PictureBox()
        Me.languageSelectChange2 = New System.Windows.Forms.PictureBox()
        CType(Me.languageSelectChange1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.languageSelectChange2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLan2
        '
        Me.lblLan2.AutoSize = True
        Me.lblLan2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLan2.ForeColor = System.Drawing.Color.White
        Me.lblLan2.Location = New System.Drawing.Point(76, 65)
        Me.lblLan2.Name = "lblLan2"
        Me.lblLan2.Size = New System.Drawing.Size(97, 23)
        Me.lblLan2.TabIndex = 21
        Me.lblLan2.Text = "Language 2"
        '
        'lblLan1
        '
        Me.lblLan1.AutoSize = True
        Me.lblLan1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLan1.ForeColor = System.Drawing.Color.White
        Me.lblLan1.Location = New System.Drawing.Point(76, 18)
        Me.lblLan1.Name = "lblLan1"
        Me.lblLan1.Size = New System.Drawing.Size(97, 23)
        Me.lblLan1.TabIndex = 20
        Me.lblLan1.Text = "Language 1"
        '
        'languageSelectChange1
        '
        Me.languageSelectChange1.Location = New System.Drawing.Point(12, 12)
        Me.languageSelectChange1.Name = "languageSelectChange1"
        Me.languageSelectChange1.Size = New System.Drawing.Size(58, 36)
        Me.languageSelectChange1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.languageSelectChange1.TabIndex = 19
        Me.languageSelectChange1.TabStop = False
        '
        'languageSelectChange2
        '
        Me.languageSelectChange2.Location = New System.Drawing.Point(12, 58)
        Me.languageSelectChange2.Name = "languageSelectChange2"
        Me.languageSelectChange2.Size = New System.Drawing.Size(58, 36)
        Me.languageSelectChange2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.languageSelectChange2.TabIndex = 18
        Me.languageSelectChange2.TabStop = False
        '
        'LangReSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(194, 109)
        Me.Controls.Add(Me.lblLan2)
        Me.Controls.Add(Me.lblLan1)
        Me.Controls.Add(Me.languageSelectChange1)
        Me.Controls.Add(Me.languageSelectChange2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LangReSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LangReSel"
        Me.TopMost = True
        CType(Me.languageSelectChange1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.languageSelectChange2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLan2 As Label
    Friend WithEvents lblLan1 As Label
    Friend WithEvents languageSelectChange1 As PictureBox
    Friend WithEvents languageSelectChange2 As PictureBox
End Class
