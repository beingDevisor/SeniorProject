Public Class Font_Selection
    Private Sub btnGeorgia_Click(sender As Object, e As EventArgs) Handles btnGeorgia.Click
        MainForm.lbOutput.Font = New Font(MainForm.lbOutput.Font.FontFamily, 8)
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class