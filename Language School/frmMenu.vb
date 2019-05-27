Public Class frmMenu

    Public openLan As Boolean = True

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserDiplay.Text = "Hello " & frmSplash.NameField.Text & ", Welcome back!"
        centerMenu(Panel1)
        If frmSplash.flop = False Then
            languageDisplay.Image = My.Resources.Italy
        Else
            languageDisplay.Image = My.Resources.Poland
        End If
        LangReSel.Hide()
    End Sub

    Public Sub centerMenu(sender As Object)
        Dim r As Rectangle
        If Parent IsNot Nothing Then
            r = Parent.RectangleToScreen(Parent.ClientRectangle)
        Else
            r = Screen.FromPoint(Me.Location).WorkingArea
        End If
        Dim x = r.Left + (r.Width - sender.Width) \ 2
        Dim y = r.Top + (r.Height - sender.Height) \ 2
        sender.Top = y
        sender.Left = x
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        Me.Cursor = Cursors.Hand
        btnExit.BackgroundImage = My.Resources.Button_Clicked

    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        Me.Cursor = Cursors.Arrow
        btnExit.BackgroundImage = My.Resources.Button
    End Sub

    Private Sub btnGame1_MouseHover(sender As Object, e As EventArgs) Handles btnGame1.MouseHover
        Me.Cursor = Cursors.Hand
        btnGame1.BackgroundImage = My.Resources.Button_Clicked
    End Sub

    Private Sub btnGame1_MouseLeave(sender As Object, e As EventArgs) Handles btnGame1.MouseLeave
        Me.Cursor = Cursors.Arrow
        btnGame1.BackgroundImage = My.Resources.Button
    End Sub

    Private Sub btnGame2_MouseHover(sender As Object, e As EventArgs) Handles btnGame2.MouseHover
        Me.Cursor = Cursors.Hand
        btnGame2.BackgroundImage = My.Resources.Button_Clicked
    End Sub

    Private Sub btnGame2_MouseLeave(sender As Object, e As EventArgs) Handles btnGame2.MouseLeave
        Me.Cursor = Cursors.Arrow
        btnGame2.BackgroundImage = My.Resources.Button
    End Sub

    Private Sub btnGame3_MouseHover(sender As Object, e As EventArgs) Handles btnGame3.MouseHover
        Me.Cursor = Cursors.Hand
        btnGame3.BackgroundImage = My.Resources.Button_Clicked
    End Sub

    Private Sub btnGme3_MouseLeave(sender As Object, e As EventArgs) Handles btnGame3.MouseLeave
        Me.Cursor = Cursors.Arrow
        btnGame3.BackgroundImage = My.Resources.Button
    End Sub

    Private Sub languageDisplay_Click(sender As Object, e As EventArgs) Handles languageDisplay.Click
        LangReSel.ShowDialog()
        LangReSel.Select()
        LangReSel.languageSelectChange1.BringToFront()
        LangReSel.languageSelectChange2.BringToFront()
        If frmSplash.flop = False Then
            LangReSel.languageSelectChange1.Image = My.Resources.Italy
            LangReSel.languageSelectChange2.Image = My.Resources.Poland
            LangReSel.lblLan1.Text = "Italian"
            LangReSel.lblLan2.Text = "Polish"
        Else
            LangReSel.languageSelectChange1.Image = My.Resources.Poland
            LangReSel.languageSelectChange2.Image = My.Resources.Italy
            LangReSel.lblLan1.Text = "Polish"
            LangReSel.lblLan2.Text = "Italian"
        End If
    End Sub

    Private Sub languageDisplay_MouseHover(sender As Object, e As EventArgs) Handles languageDisplay.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub languageDisplay_MouseLeave(sender As Object, e As EventArgs) Handles languageDisplay.MouseLeave
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub languageSelectChanged_MouseHover(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub languageSelectChanged_MouseLeave(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnGame1_Click(sender As Object, e As EventArgs) Handles btnGame1.Click
        Cognative.Show()
        Me.Hide()
    End Sub
End Class
