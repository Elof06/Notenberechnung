Option Strict On
Public Class Form5
    Inherits System.Windows.Forms.Form
    Dim Total As Integer
    Dim NumberOfMarks As Integer
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim iQuit As DialogResult

        iQuit = MessageBox.Show("Wollen Sie wirklich das Programm schließen?", "Zensurenberechnung", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If iQuit = vbYes Then
            Application.Exit()

        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbResult.Checked = False
        rbResult.Enabled = False
        NumberOfMarks = 0
        Total = 0
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim Number As Integer
        Number = CInt(txtMark.Text)
        lstMark.Items.Add(Number)
        Total = Total + Number
        NumberOfMarks = NumberOfMarks + 1
        btnShowAverage.Enabled = True
        txtMark.Clear()
        txtMark.Focus()

        Dim count As Integer = lstMark.Items.Count
        If count = 9 Then
            txtMark.Enabled = False
            btnOk.Enabled = False
            rbResult.Checked = True
        End If
    End Sub

    Private Sub btnShowAverage_Click(sender As Object, e As EventArgs) Handles btnShowAverage.Click
        Dim Average As Double

        Average = Total / NumberOfMarks
        txtMean.Text = Convert.ToString(Average)
        txtMean.Visible = True
        txtMark.Enabled = False
        btnOk.Enabled = False
        btnReset.Enabled = True
        txtMean.Text = FormatNumber(txtMean.Text, 2)

    End Sub

    Private Sub txtMark_TextChanged(sender As Object, e As EventArgs) Handles txtMark.TextChanged
        btnOk.Enabled = True
    End Sub

    Private Sub txtMark_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMark.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) < 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtMark.Text = ""
        txtMean.Clear()
        txtMark.Enabled = True
        btnOk.Enabled = False
        txtMean.Visible = False
        btnShowAverage.Enabled = False
        lstMark.Items.Clear()
        btnReset.Enabled = False

    End Sub

    Private Sub lstMark_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMark.SelectedIndexChanged

    End Sub
End Class