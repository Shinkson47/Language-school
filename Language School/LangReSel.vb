Public Class LangReSel
    Private Sub languageSelectChange1_Click(sender As Object, e As EventArgs) Handles languageSelectChange1.Click
        Me.Hide()
    End Sub

    Private Sub languageSelectChange2_Click(sender As Object, e As EventArgs) Handles languageSelectChange2.Click
        If frmSplash.flop = True Then
            frmSplash.flop = False
        Else
            frmSplash.flop = True
        End If
        Me.Hide()
    End Sub
End Class