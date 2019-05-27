Public Class Cognative




    Dim increment
    Private Sub Thicc_Tick(sender As Object, e As EventArgs) Handles Thicc.Tick
        increment = increment - 1
        If increment < ProgressBar1.Minimum Then
            increment = ProgressBar1.Minimum
        End If
        ProgressBar1.Value = increment
    End Sub

    Private Sub Cognative_Load(sender As Object, e As EventArgs) Handles Me.Load
        ProgressBar1.Value = 100
        increment = ProgressBar1.Value
        Thicc.Enabled = True

        LblTimer.Text = "3"
        LblTimer.Show()
        LblDisplay.Show()
        Threading.Thread.Sleep(1000)
        LblTimer.Text = "2"
        Threading.Thread.Sleep(1000)
        LblTimer.Text = "1"
        Threading.Thread.Sleep(1000)
        LblTimer.Text = "GO!"
        Threading.Thread.Sleep(1000)
        LblTimer.Hide()
        LblDisplay.Hide()
        gamestart()
    End Sub

    Private Sub gamestart()
        Dim index = Math.Round((Rnd() * 10), 0)
        roundStart()
    End Sub

    Public Function phraseSel()
        PhraseBoxEnglish.SelectedIndex.Equals(Math.Round(Rnd() * 10, 0))
        Dim phrase = PhraseBoxEnglish.SelectedItem
        Return (phrase)
    End Function

    Private Sub roundStart()
        btnAns1.Text = phraseSel()
        btnAns2.Text = phraseSel()
        btnAns3.Text = phraseSel()
        btnAns4.Text = phraseSel()
        btnAns5.Text = phraseSel()
        btnAns6.Text = phraseSel()
        btnAns7.Text = phraseSel()
        btnAns8.Text = phraseSel()
        btnAns9.Text = phraseSel()
        btnAns10.Text = phraseSel()
        Dim SelectedPhrase = phraseSel()
        Select Case Math.Round(Rnd() * 10, 0)
            Case 1
                btnAns1.Text = SelectedPhrase
            Case 2
                btnAns1.Text = SelectedPhrase
            Case 3
                btnAns1.Text = SelectedPhrase
            Case 4
                btnAns1.Text = SelectedPhrase
            Case 5
                btnAns1.Text = SelectedPhrase
            Case 6
                btnAns1.Text = SelectedPhrase
            Case 7
                btnAns1.Text = SelectedPhrase
            Case 8
                btnAns1.Text = SelectedPhrase
            Case 9
                btnAns1.Text = SelectedPhrase
            Case 10
        End Select
        'XXX Set Image Box

    End Sub


End Class