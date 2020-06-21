Public Class PA

    Private Sub PPC_JOBCARDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPC_JOBCARDBindingNavigatorSaveItem.Click
        If Grade_1TextBox.ReadOnly = True Then
            If H1.Checked = True Then
                PPC_JOBCARDBindingSource.Current("Hammer") = "H1"
            ElseIf H2.Checked = True Then
                PPC_JOBCARDBindingSource.Current("Hammer") = "H2"
            ElseIf H3.Checked = True Then
                PPC_JOBCARDBindingSource.Current("Hammer") = "H3"
            ElseIf H4.Checked = True Then
                PPC_JOBCARDBindingSource.Current("Hammer") = "H4"
            ElseIf H5.Checked = True Then
                PPC_JOBCARDBindingSource.Current("Hammer") = "H5"
            End If

        End If
        Me.Validate()
        Me.PPC_JOBCARDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMMI_2007DataSet1)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMMI_2007DataSet1.PPC_JOBCARD' table. You can move, or remove it, as needed.
        HammerTextBox.Hide()
        Me.PPC_JOBCARDTableAdapter.Fill(Me.OMMI_2007DataSet1.PPC_JOBCARD)
        'PPC_JOBCARDBindingNavigatorSaveItem.Visible = False



    End Sub

    Private Sub Weight_Per_PeiceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Weight_Per_PeiceTextBox.TextChanged
        'TonnageTextBox.Text = Weight_Per_PeiceTextBox.Text * BalenceTextBox.Text
        'a = Convert.ToDouble(BalenceTextBox.Text)
        'b = Convert.ToDouble(Weight_Per_PeiceTextBox.Text)
        'TonnageTextBox.Text = BalenceTextBox.Text * Weight_Per_PeiceTextBox.Text
        'Balance_tonnageTextBox.Text = Balance_To_PlanTextBox.Text * Weight_Per_PeiceTextBox.Text

    End Sub

    Private Sub BalenceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalenceTextBox.TextChanged
        TonnageTextBox.Text = BalenceTextBox.Text * Weight_Per_PeiceTextBox.Text



    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Balance_To_PlanTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Balance_To_PlanTextBox.TextChanged
        Balance_tonnageTextBox.Text = Balance_To_PlanTextBox.Text * Weight_Per_PeiceTextBox.Text

    End Sub

    Private Sub H1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H1.CheckedChanged

    End Sub

    Private Sub HammerLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Plan.Click
        Form10.Show()
    End Sub

    Private Sub Month_JCTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Month_JCTextBox.TextChanged

    End Sub

    Private Sub Year_JCTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Year_JCTextBox.TextChanged

    End Sub

    Private Sub Year_JCLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Job_Card_NoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Job_Card_NoTextBox.TextChanged

    End Sub

    Private Sub HammerTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HammerTextBox.TextChanged

    End Sub

    Private Sub TonnageTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TonnageTextBox.TextChanged

    End Sub

    Private Sub H3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3.CheckedChanged

    End Sub
End Class