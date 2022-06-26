<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.lstMark = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ShowAverage = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(692, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(12, 49)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(100, 23)
        Me.txtMark.TabIndex = 2
        '
        'lstMark
        '
        Me.lstMark.FormattingEnabled = True
        Me.lstMark.ItemHeight = 15
        Me.lstMark.Location = New System.Drawing.Point(12, 78)
        Me.lstMark.Name = "lstMark"
        Me.lstMark.Size = New System.Drawing.Size(100, 349)
        Me.lstMark.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(688, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(688, 78)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(100, 349)
        Me.ListBox2.TabIndex = 5
        '
        'ShowAverage
        '
        Me.ShowAverage.Location = New System.Drawing.Point(118, 78)
        Me.ShowAverage.Name = "ShowAverage"
        Me.ShowAverage.Size = New System.Drawing.Size(100, 44)
        Me.ShowAverage.TabIndex = 6
        Me.ShowAverage.Text = "Los!"
        Me.ShowAverage.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 44)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Schließen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShowAverage)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lstMark)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMark As TextBox
    Friend WithEvents lstMark As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ShowAverage As Button
    Friend WithEvents Button2 As Button

    Private Sub txtMark_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShowAverage_Click(sender As Object, e As EventArgs)

    End Sub
End Class
