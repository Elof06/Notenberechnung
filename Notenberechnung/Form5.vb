Option Strict On
Public Class Form5
    Inherits System.Windows.Forms.Form
    Dim Total As Integer
    Dim NumberOfMarks As Integer
    Dim Total2 As Integer
    Dim NumberOfMarks2 As Integer
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim iQuit As DialogResult

        iQuit = MessageBox.Show("Wollen Sie wirklich das Programm schließen?", "Zensurenberechnung", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If iQuit = vbYes Then
            Application.Exit()

        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If count = 100 Then
            txtMark.Enabled = False
            btnOk.Enabled = False
        End If
    End Sub

    Private Sub btnShowAverage_Click(sender As Object, e As EventArgs) Handles btnShowAverage.Click
        Dim Average As Double
        Dim Average2 As Double
        Dim Final As Double

        Dim FinalLK As Double
        Dim FinalKA As Double

        Average2 = Total2 / NumberOfMarks2
        Average = Total / NumberOfMarks
        txtMean.Text = Convert.ToString(Average)
        txtMean2.Text = Convert.ToString(Average2)
        txtMean.Visible = True
        txtMean2.Visible = True
        txtFinal.Visible = True
        txtMark.Enabled = False
        txtMark2.Enabled = False
        btnOk.Enabled = False
        btnOk2.Enabled = False
        ' btnReset.Enabled = True
        txtMean.Text = FormatNumber(txtMean.Text, 2)
        txtMean2.Text = FormatNumber(txtMean2.Text, 2)

        FinalKA = Average2 * 0.3
        FinalLK = Average * 0.7
        Final = FinalLK + FinalKA
        txtFinal.Text = Convert.ToString(Final)
        txtFinal.Text = FormatNumber(txtFinal.Text, 2)
    End Sub

    Private Sub txtMark_TextChanged(sender As Object, e As EventArgs) Handles txtMark.TextChanged
        btnOk.Enabled = True
    End Sub



    ' Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    '     lstMark.Items.Clear()
    '     lstMark2.Items.Clear()
    '     txtMark.Text = ""
    '     txtMark2.Text = ""
    '     txtFinal.Text = ""
    '     txtMean.Clear()
    '     txtMean2.Clear()
    '     txtFinal.Clear()
    '     txtMark.Enabled = True
    '     txtMark2.Enabled = True
    '     btnOk.Enabled = False
    '     btnOk2.Enabled = False
    '     txtMean.Visible = False
    '     txtMean2.Visible = False
    '     txtFinal.Visible = False
    '     btnShowAverage.Enabled = False


    '     lstMark.DataSource = Nothing
    '     lstMark2.DataSource = Nothing

    '     btnReset.Enabled = False

    ' End Sub

    Private Sub btnOk2_Click(sender As Object, e As EventArgs) Handles btnOk2.Click
        Dim Number2 As Integer
        Number2 = CInt(txtMark2.Text)
        lstMark2.Items.Add(Number2)
        Total2 = Total2 + Number2
        NumberOfMarks2 = NumberOfMarks2 + 1
        btnShowAverage.Enabled = True
        txtMark2.Clear()
        txtMark2.Focus()

        Dim count2 As Integer = lstMark.Items.Count
        If count2 = 100 Then
            txtMark2.Enabled = False
            btnOk2.Enabled = False
        End If
    End Sub

    Private Sub Final_TextChanged(sender As Object, e As EventArgs) Handles txtFinal.TextChanged

    End Sub

    Private Sub txtMark2_TextChanged(sender As Object, e As EventArgs) Handles txtMark2.TextChanged
        btnOk2.Enabled = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub
End Class