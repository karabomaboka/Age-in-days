Public Class frmAge
  Private Sub btnComputeOfBirth_Click(sender As Object, e As EventArgs) Handles btnComputeOfBirth.Click
    Dim dob As Date = CDate(mtDayOfBirth.Text)
    txtFullDateOfBirth.Text = dob.ToString("D")
    txtToday.Text = Today.ToString("D")
    txtAgeInDays.Text = DateDiff(DateInterval.Day, dob, Today).ToString("NO")
  End Sub
End Class
