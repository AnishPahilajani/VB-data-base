Public Class Form9

    Private Sub PPC_JOBCARDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPC_JOBCARDBindingNavigatorSaveItem.Click
        Dim Month1 = Me.ComboBox1.SelectedText
        PPC_JOBCARDBindingSource.MoveFirst()
        For i = 1 To PPC_JOBCARDBindingSource.Count
            Select Case Month1
                Case "January"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 1
                Case "February"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 2
                Case "March"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 3
            End Select
            PPC_JOBCARDBindingSource.MoveNext()
        Next
        Me.Validate()
        Me.PPC_JOBCARDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMMI_2007DataSet6)

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMMI_2007DataSet6.PPC_JOBCARD_Complete' table. You can move, or remove it, as needed.
        Me.PPC_JOBCARD_CompleteTableAdapter.Fill(Me.OMMI_2007DataSet6.PPC_JOBCARD_Complete)
        'TODO: This line of code loads data into the 'OMMI_2007DataSet6.PPC_JOBCARD' table. You can move, or remove it, as needed.
        Me.PPC_JOBCARDTableAdapter.Fill(Me.OMMI_2007DataSet6.PPC_JOBCARD)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For r = 1 To PPC_JOBCARDBindingSource.Count
            If PPC_JOBCARDBindingSource.Current("Balance To Plan") > 0 Then
                PPC_JOBCARD_CompleteBindingSource.AddNew()
                For c = 0 To 2
                    PPC_JOBCARD_CompleteBindingSource.Current(c) = PPC_JOBCARDBindingSource.Current(c)
                Next
                PPC_JOBCARDBindingSource.MoveNext()
                PPC_JOBCARD_CompleteBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.OMMI_2007DataSet6)
                'Table1_CopyBindingSource.
            End If
        Next
    End Sub

    Private Sub PPC_JOBCARDBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPC_JOBCARDBindingNavigator.RefreshItems

    End Sub
End Class