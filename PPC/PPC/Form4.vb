Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "1234") Then
            Form11.Job_Card_NoTextBox.ReadOnly = True
            Form11.Schedule_QuantityTextBox.ReadOnly = True
            Form11.Weight_Per_PeiceTextBox.ReadOnly = True
            Form11.Part_NumberTextBox.ReadOnly = True
            Form11.CustomerTextBox.ReadOnly = True
            Form11.Grade_1TextBox.ReadOnly = True
            Form11.DiscriptionTextBox.ReadOnly = True
            Form11.BalenceTextBox.ReadOnly = True
            Form11.Die_NumberTextBox.ReadOnly = True
            Form11.RateTextBox.ReadOnly = True
            Form11.Year_JCTextBox.ReadOnly = True
            Form11.Month_JCTextBox.ReadOnly = True
            Form11.Current_StockTextBox.ReadOnly = True
            Form11.TonnageTextBox.ReadOnly = True
            Form11.Balance_tonnageTextBox.ReadOnly = True
            Form11.SectionTextBox.ReadOnly = True
            Form11.Balance_To_PlanTextBox.ReadOnly = True
            Form11.Left_To_ProduceTextBox.ReadOnly = True
            Form11.HammerTextBox.ReadOnly = True
            Form11.Scheduled_DateDateTimePicker.Enabled = False
            Form11.MdiParent = Form1
            Form11.Show()
        ElseIf (TextBox1.Text = "5678") Then
            Form11.MdiParent = Form1
            Form11.Show()



        End If
    End Sub
End Class