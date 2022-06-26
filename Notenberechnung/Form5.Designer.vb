<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnShowAverage = New System.Windows.Forms.Button()
        Me.lstMark2 = New System.Windows.Forms.ListBox()
        Me.txtMark2 = New System.Windows.Forms.TextBox()
        Me.lstMark = New System.Windows.Forms.ListBox()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnOk2 = New System.Windows.Forms.Button()
        Me.rbResult = New System.Windows.Forms.RadioButton()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.txtMean2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(582, 85)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(100, 44)
        Me.btnQuit.TabIndex = 15
        Me.btnQuit.Text = "Schließen"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnShowAverage
        '
        Me.btnShowAverage.Location = New System.Drawing.Point(118, 85)
        Me.btnShowAverage.Name = "btnShowAverage"
        Me.btnShowAverage.Size = New System.Drawing.Size(100, 44)
        Me.btnShowAverage.TabIndex = 14
        Me.btnShowAverage.Text = "Los!"
        Me.btnShowAverage.UseVisualStyleBackColor = True
        '
        'lstMark2
        '
        Me.lstMark2.FormattingEnabled = True
        Me.lstMark2.ItemHeight = 15
        Me.lstMark2.Location = New System.Drawing.Point(688, 85)
        Me.lstMark2.Name = "lstMark2"
        Me.lstMark2.Size = New System.Drawing.Size(100, 349)
        Me.lstMark2.TabIndex = 13
        '
        'txtMark2
        '
        Me.txtMark2.Location = New System.Drawing.Point(688, 56)
        Me.txtMark2.Name = "txtMark2"
        Me.txtMark2.Size = New System.Drawing.Size(100, 23)
        Me.txtMark2.TabIndex = 12
        '
        'lstMark
        '
        Me.lstMark.FormattingEnabled = True
        Me.lstMark.ItemHeight = 15
        Me.lstMark.Location = New System.Drawing.Point(12, 85)
        Me.lstMark.Name = "lstMark"
        Me.lstMark.Size = New System.Drawing.Size(100, 349)
        Me.lstMark.TabIndex = 11
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(12, 56)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(100, 23)
        Me.txtMark.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(692, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(343, 85)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 44)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(118, 56)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 23)
        Me.btnOk.TabIndex = 17
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnOk2
        '
        Me.btnOk2.Location = New System.Drawing.Point(582, 56)
        Me.btnOk2.Name = "btnOk2"
        Me.btnOk2.Size = New System.Drawing.Size(100, 23)
        Me.btnOk2.TabIndex = 18
        Me.btnOk2.Text = "Ok"
        Me.btnOk2.UseVisualStyleBackColor = True
        '
        'rbResult
        '
        Me.rbResult.AutoSize = True
        Me.rbResult.Location = New System.Drawing.Point(141, 253)
        Me.rbResult.Name = "rbResult"
        Me.rbResult.Size = New System.Drawing.Size(97, 19)
        Me.rbResult.TabIndex = 19
        Me.rbResult.TabStop = True
        Me.rbResult.Text = "RadioButton1"
        Me.rbResult.UseVisualStyleBackColor = True
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(118, 411)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.Size = New System.Drawing.Size(100, 23)
        Me.txtMean.TabIndex = 20
        '
        'txtMean2
        '
        Me.txtMean2.Location = New System.Drawing.Point(582, 411)
        Me.txtMean2.Name = "txtMean2"
        Me.txtMean2.Size = New System.Drawing.Size(100, 23)
        Me.txtMean2.TabIndex = 21
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMean2)
        Me.Controls.Add(Me.txtMean)
        Me.Controls.Add(Me.rbResult)
        Me.Controls.Add(Me.btnOk2)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnShowAverage)
        Me.Controls.Add(Me.lstMark2)
        Me.Controls.Add(Me.txtMark2)
        Me.Controls.Add(Me.lstMark)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents btnShowAverage As Button
    Friend WithEvents lstMark2 As ListBox
    Friend WithEvents txtMark2 As TextBox
    Friend WithEvents lstMark As ListBox
    Friend WithEvents txtMark As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnOk2 As Button
    Friend WithEvents rbResult As RadioButton
    Friend WithEvents txtMean As TextBox
    Friend WithEvents txtMean2 As TextBox
End Class
