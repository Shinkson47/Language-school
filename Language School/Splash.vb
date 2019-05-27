Public Class frmSplash
    '================Global Level===============
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        centersplash(Panel3)
        centersplash(Panel4)
        Timer1.Enabled = True
    End Sub

    Public Sub centersplash(sender As Object)
        Dim r As Rectangle
        If Parent IsNot Nothing Then
            r = Parent.RectangleToScreen(Parent.ClientRectangle)
        Else
            r = Screen.FromPoint(Me.Location).WorkingArea
        End If
        Dim x = r.Left + (r.Width - SplashTransition.Width) \ 2
        Dim y = r.Top + (r.Height - SplashTransition.Height) \ 2
        SplashTransition.Top = y
        SplashTransition.Left = x
        x = r.Left + (r.Width - sender.Width) \ 2
        y = r.Top + (r.Height - sender.Height) \ 2
        sender.Top = y
        sender.Left = x
    End Sub
    'Timer to stop gif from repeating
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Panel3.Visible = True

    End Sub

    'Responsive backing text In text boxes, avoids labels - minimalism!
    Private Sub NameField_GotFocus(sender As Object, e As EventArgs) Handles NameField.GotFocus
        If NameField.Text = "ID" Then
            NameField.ResetText()
        End If
    End Sub
    Private Sub Passfield_GotFocus(sender As Object, e As EventArgs) Handles Passfield.GotFocus
        Passfield.ResetText()
        Passfield.PasswordChar = "•"
    End Sub
    Private Sub NameField_LostFocus(sender As Object, e As EventArgs) Handles NameField.LostFocus
        If NameField.Text = "" Then
            NameField.Text = "ID"
        End If
    End Sub
    Private Sub Passfield_LostFocus(sender As Object, e As EventArgs) Handles Passfield.LostFocus
        If Passfield.Text = "" Then
            Passfield.PasswordChar = ""
            Passfield.Text = "Password"
        End If
    End Sub
    Private Sub frmLogIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            btnContinue_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub Passfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Passfield.KeyPress
        If e.KeyChar = Chr(13) Then
            btnContinue_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub NameField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameField.KeyPress
        If e.KeyChar = Chr(13) Then
            btnContinue_Click(Me, EventArgs.Empty)
        End If
    End Sub

    '===========Active level========
    Private Sub LangConf_Click(sender As Object, e As EventArgs) Handles LangConf.Click
        If LangSelectPoland.BorderStyle = BorderStyle.None And LangSelectItaly.BorderStyle = BorderStyle.None Then
            FailTimer.Enabled = True
            failcount = 1
            Exit Sub
        ElseIf LangSelectPoland.BorderStyle = BorderStyle.Fixed3D Then
            flop = False
        Else
            flop = True
        End If

        Me.Hide()
        frmMenu.Show()

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs)
        LogAttempt()
    End Sub

    Private Sub LogAttempt()
        NameField.Enabled = False
        Passfield.Enabled = False
        Select Case NameField.Text
            Case "GRA17217882"
                If Passfield.Text = "1234" Then
                    LogInSuc()
                Else
                    LogInFail()
                End If
            Case Else
                LogInFail()
        End Select
    End Sub
    Public Sub LogInFail()
        Passfield.Text = "Password"
        Passfield.PasswordChar = "•"
        failcount = 0
        FailTimer.Enabled = True
        centersplash(Panel3)

    End Sub

    Public Sub LogInSuc() 'Open Main menu, treat login as verified.
        Panel3.Hide()
        Panel4.Show()
        Panel4.BringToFront()
    End Sub

    Public flip As Boolean
    Public failcount
    Private Sub FailTimer_Tick(sender As Object, e As EventArgs) Handles FailTimer.Tick
        If failcount >= 6 Then
            FailTimer.Enabled = False
            NameField.BackColor = Color.FromArgb(32, 30, 30)
            Passfield.BackColor = Color.FromArgb(32, 30, 30)
            Panel4.BackColor = Color.FromArgb(32, 30, 30)
            Exit Sub
        End If
        If flip = True Then
            NameField.BackColor = Color.Red
            Passfield.BackColor = Color.Red
            Panel4.BackColor = Color.Red
            flip = False
        Else
            NameField.BackColor = Color.FromArgb(32, 30, 30)
            Passfield.BackColor = Color.FromArgb(32, 30, 30)
            flip = True
        End If
        failcount = failcount + 1
        NameField.Enabled = True
        Passfield.Enabled = True
    End Sub

    Public flop As Boolean
    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles LangSelectPoland.Click
        flop = False
        LangSelectPoland.BorderStyle = BorderStyle.Fixed3D
        LangSelectItaly.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles LangSelectItaly.Click
        flop = True
        LangSelectItaly.BorderStyle = BorderStyle.Fixed3D
        LangSelectPoland.BorderStyle = BorderStyle.None
    End Sub

End Class