Public Class Form11

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
        Me.TableAdapterManager.UpdateAll(Me.OMMI_2007DataSet7)
        
    End Sub

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMMI_2007DataSet7.PPC_JOBCARD' table. You can move, or remove it, as needed.
        Me.PPC_JOBCARDTableAdapter.Fill(Me.OMMI_2007DataSet7.PPC_JOBCARD)

    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Plan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Plan.Click
        Form10.Show()
    End Sub

    Private Sub Weight_Per_PeiceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Weight_Per_PeiceTextBox.TextChanged
        If Balance_To_PlanTextBox.Text <> "" And Weight_Per_PeiceTextBox.Text <> "" Then
            Balance_tonnageTextBox.Text = Balance_To_PlanTextBox.Text * Weight_Per_PeiceTextBox.Text
        End If
    End Sub
    Private Sub BalenceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalenceTextBox.TextChanged
        If BalenceTextBox.Text <> "" And Weight_Per_PeiceTextBox.Text <> "" Then
            TonnageTextBox.Text = BalenceTextBox.Text * Weight_Per_PeiceTextBox.Text
        End If
    End Sub
    Private Sub Balance_To_PlanTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Balance_To_PlanTextBox.TextChanged
        If Balance_To_PlanTextBox.Text <> "" And Weight_Per_PeiceTextBox.Text <> "" Then
            Balance_tonnageTextBox.Text = Balance_To_PlanTextBox.Text * Weight_Per_PeiceTextBox.Text
        End If
        

    End Sub
End Class