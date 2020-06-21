Public Class Form1

    Private Sub JobCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobCardToolStripMenuItem.Click
        Form11.H1.Hide()
        Form11.H2.Hide()
        Form11.H3.Hide()
        Form11.H4.Hide()
        Form11.H5.Hide()
        Form11.Plan.Hide()
        Form11.MdiParent = Me
        Form11.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PlanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanToolStripMenuItem.Click
        Form4.MdiParent = Me
        Form4.Show()
    End Sub

    Private Sub NewPlanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' working code with data set 6

        Form9.Show()
    End Sub

    Private Sub PlanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form10.Show()
    End Sub
End Class


