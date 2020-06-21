Public Class Form10

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PPC_JOBCARDBindingSource.MoveFirst()

        'Dim Month3 = Month1.SelectedItem

        Dim Month3 = DateAndTime.Now.Month
        'MsgBox(Month2)

        Select Case Month3
            Case 2
                PPC_JOBCARDDataGridView.Columns(50).Visible = False
                PPC_JOBCARDDataGridView.Columns(81).Visible = False
                PPC_JOBCARDDataGridView.Columns(49).Visible = False
                PPC_JOBCARDDataGridView.Columns(80).Visible = False
                If DateAndTime.Now.Year = 2020 Then
                    PPC_JOBCARDDataGridView.Columns(48).Visible = False
                    PPC_JOBCARDDataGridView.Columns(79).Visible = False
                End If
            Case 4, 6, 9, 10
                PPC_JOBCARDDataGridView.Columns(50).Visible = False
                PPC_JOBCARDDataGridView.Columns(81).Visible = False
        End Select

        'Making first "purple" columns read only
        For i = 0 To 19
            PPC_JOBCARDDataGridView.Columns(i).ReadOnly = True
        Next
        PPC_JOBCARDDataGridView.Columns(8).HeaderText = "Balance"
        Dim tmonth = DateAndTime.Now.Month
        Month1.SelectedIndex = tmonth - 1
        Dim todayyear = DateAndTime.Now.Year
        Select Case todayyear
            Case 2017
                Year1.SelectedIndex = 0
            Case 2018
                Year1.SelectedIndex = 1
            Case 2019
                Year1.SelectedIndex = 2
            Case 2020
                Year1.SelectedIndex = 3
            Case 2021
                Year1.SelectedIndex = 4
            Case 2020
                Year1.SelectedIndex = 5
            Case 2021
                Year1.SelectedIndex = 6
            Case 2022
                Year1.SelectedIndex = 7
            Case 2023
                Year1.SelectedIndex = 8
            Case 2024
                Year1.SelectedIndex = 9
            Case 2025
                Year1.SelectedIndex = 10
        End Select

        'TODO: This line of code loads data into the 'OMMI_2007DataSet7.PPC_JOBCARD_Complete' table. You can move, or remove it, as needed.
        'PPC_JOBCARDDataGridView
        Me.PPC_JOBCARD_CompleteTableAdapter.Fill(Me.OMMI_2007DataSet7.PPC_JOBCARD_Complete)
        'TODO: This line of code loads data into the 'OMMI_2007DataSet7.PPC_JOBCARD' table. You can move, or remove it, as needed.
        Me.PPC_JOBCARDTableAdapter.Fill(Me.OMMI_2007DataSet7.PPC_JOBCARD)



    End Sub

    Private Sub PPC_JOBCARDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPC_JOBCARDBindingNavigatorSaveItem.Click
        PPC_JOBCARDBindingSource.MoveFirst()
        Dim Year2 = Year1.SelectedItem
        Dim Month2 = Month1.SelectedItem
        'MsgBox(Month2)
        For i = 1 To PPC_JOBCARDBindingSource.Count()
            Select Case Month2
                Case "January"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 1
                Case "February"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 2
                Case "March"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 3
                Case "April"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 4
                Case "May"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 5
                Case "June"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 6
                Case "July"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 7
                Case "August"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 8
                Case "September"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 9
                Case "October"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 10
                Case "November"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 11
                Case "December"
                    PPC_JOBCARDBindingSource.Current("Month_JC") = 12

            End Select
            Select Case Year2
                Case "2017"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2017
                Case "2018"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2018
                Case "2019"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2019
                Case "2020"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2020
                Case "2021"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2021
                Case "2022"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2022
                Case "2023"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2023
                Case "2024"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2024
                Case "2025"
                    PPC_JOBCARDBindingSource.Current("Year_JC") = 2025
            End Select
            PPC_JOBCARDBindingSource.MoveNext()


        Next







        Me.Validate()
        Me.PPC_JOBCARDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMMI_2007DataSet7)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        PPC_JOBCARDBindingSource.MoveFirst()
        For r = 1 To PPC_JOBCARDBindingSource.Count
            Dim A = PPC_JOBCARDBindingSource.Current("Balance To Plan")
            If A = 0 Then
                PPC_JOBCARD_CompleteBindingSource.AddNew()
                For c = 0 To 81
                    PPC_JOBCARD_CompleteBindingSource.Current(c) = PPC_JOBCARDBindingSource.Current(c)
                Next
                PPC_JOBCARDBindingSource.RemoveCurrent()
            End If
            PPC_JOBCARDBindingSource.MoveNext()
        Next
        Me.PPC_JOBCARD_CompleteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMMI_2007DataSet7)
        MsgBox("Data Saved")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Month1.SelectedIndexChanged
       

    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(DateAndTime.Now.Year)
        'Year1.SelectedText = DateAndTime.Now.Year
        

    End Sub

    Private Sub Year1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Year1.SelectedIndexChanged
        
    End Sub

    Private Sub cal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal.Click

        For j = 0 To PPC_JOBCARDBindingSource.Count
            Dim plannedsum = 0
            For i = 20 To 50
                If Not IsDBNull(PPC_JOBCARDBindingSource.Current(i)) Then
                    plannedsum = PPC_JOBCARDBindingSource.Current(i) + plannedsum
                End If
            Next
            PPC_JOBCARDBindingSource.Current("Balance To Plan") = PPC_JOBCARDBindingSource.Current("Balence") - plannedsum
            PPC_JOBCARDBindingSource.MoveNext()
        Next
    End Sub

    Private Sub tontotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tontotal.TextChanged

    End Sub

    Private Sub Calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate.Click
        Dim tontotal1 = 0
        Dim ratetotal = 0
        Dim PPC_count = PPC_JOBCARDBindingSource.Count
        PPC_JOBCARDBindingSource.MoveFirst()
        For r = 1 To PPC_count
            tontotal1 = PPC_JOBCARDBindingSource.Current("Tonnage") + tontotal1
            ratetotal = PPC_JOBCARDBindingSource.Current("Rate") + ratetotal
            PPC_JOBCARDBindingSource.MoveNext()
        Next

        np.Text = PPC_count
        Value.Text = ratetotal * PPC_count
        tontotal.Text = tontotal1




    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles np.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value.TextChanged

    End Sub

    Private Sub PPC_JOBCARDDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PPC_JOBCARDDataGridView.CellContentClick

    End Sub
End Class