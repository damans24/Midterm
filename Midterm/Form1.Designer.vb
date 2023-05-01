<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.minimumLabel = New System.Windows.Forms.Label()
        Me.positionLabel = New System.Windows.Forms.Label()
        Me.maximumLabel = New System.Windows.Forms.Label()
        Me.minimumText = New System.Windows.Forms.TextBox()
        Me.maximumText = New System.Windows.Forms.TextBox()
        Me.positionText = New System.Windows.Forms.TextBox()
        Me.positionButton = New System.Windows.Forms.Button()
        Me.analyzeButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.analysisLabel = New System.Windows.Forms.Label()
        Me.resultText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'minimumLabel
        '
        Me.minimumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimumLabel.Location = New System.Drawing.Point(128, 57)
        Me.minimumLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.minimumLabel.Name = "minimumLabel"
        Me.minimumLabel.Size = New System.Drawing.Size(226, 42)
        Me.minimumLabel.TabIndex = 0
        Me.minimumLabel.Text = "Minimum Number:"
        '
        'positionLabel
        '
        Me.positionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionLabel.Location = New System.Drawing.Point(128, 159)
        Me.positionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.positionLabel.Name = "positionLabel"
        Me.positionLabel.Size = New System.Drawing.Size(251, 42)
        Me.positionLabel.TabIndex = 1
        Me.positionLabel.Text = "Position in Sequence:"
        '
        'maximumLabel
        '
        Me.maximumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximumLabel.Location = New System.Drawing.Point(128, 108)
        Me.maximumLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.maximumLabel.Name = "maximumLabel"
        Me.maximumLabel.Size = New System.Drawing.Size(226, 42)
        Me.maximumLabel.TabIndex = 2
        Me.maximumLabel.Text = "Maximum Number:"
        '
        'minimumText
        '
        Me.minimumText.Location = New System.Drawing.Point(396, 57)
        Me.minimumText.Multiline = True
        Me.minimumText.Name = "minimumText"
        Me.minimumText.Size = New System.Drawing.Size(203, 42)
        Me.minimumText.TabIndex = 3
        '
        'maximumText
        '
        Me.maximumText.Location = New System.Drawing.Point(396, 108)
        Me.maximumText.Multiline = True
        Me.maximumText.Name = "maximumText"
        Me.maximumText.Size = New System.Drawing.Size(203, 42)
        Me.maximumText.TabIndex = 4
        '
        'positionText
        '
        Me.positionText.Location = New System.Drawing.Point(396, 159)
        Me.positionText.Multiline = True
        Me.positionText.Name = "positionText"
        Me.positionText.ReadOnly = True
        Me.positionText.Size = New System.Drawing.Size(203, 42)
        Me.positionText.TabIndex = 5
        '
        'positionButton
        '
        Me.positionButton.Location = New System.Drawing.Point(133, 246)
        Me.positionButton.Name = "positionButton"
        Me.positionButton.Size = New System.Drawing.Size(205, 61)
        Me.positionButton.TabIndex = 6
        Me.positionButton.Text = "Position"
        Me.positionButton.UseVisualStyleBackColor = True
        '
        'analyzeButton
        '
        Me.analyzeButton.Location = New System.Drawing.Point(396, 246)
        Me.analyzeButton.Name = "analyzeButton"
        Me.analyzeButton.Size = New System.Drawing.Size(203, 61)
        Me.analyzeButton.TabIndex = 7
        Me.analyzeButton.Text = "Analyze"
        Me.analyzeButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(666, 246)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(203, 61)
        Me.resetButton.TabIndex = 8
        Me.resetButton.Text = "Reset Form"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'analysisLabel
        '
        Me.analysisLabel.AutoSize = True
        Me.analysisLabel.Location = New System.Drawing.Point(133, 340)
        Me.analysisLabel.Name = "analysisLabel"
        Me.analysisLabel.Size = New System.Drawing.Size(107, 29)
        Me.analysisLabel.TabIndex = 9
        Me.analysisLabel.Text = "Analysis:"
        '
        'resultText
        '
        Me.resultText.Location = New System.Drawing.Point(133, 372)
        Me.resultText.Multiline = True
        Me.resultText.Name = "resultText"
        Me.resultText.ReadOnly = True
        Me.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.resultText.Size = New System.Drawing.Size(731, 267)
        Me.resultText.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 662)
        Me.Controls.Add(Me.resultText)
        Me.Controls.Add(Me.analysisLabel)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.analyzeButton)
        Me.Controls.Add(Me.positionButton)
        Me.Controls.Add(Me.positionText)
        Me.Controls.Add(Me.maximumText)
        Me.Controls.Add(Me.minimumText)
        Me.Controls.Add(Me.maximumLabel)
        Me.Controls.Add(Me.positionLabel)
        Me.Controls.Add(Me.minimumLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Midterm - Pattern Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimumLabel As Label
    Friend WithEvents positionLabel As Label
    Friend WithEvents maximumLabel As Label
    Friend WithEvents minimumText As TextBox
    Friend WithEvents maximumText As TextBox
    Friend WithEvents positionText As TextBox
    Friend WithEvents positionButton As Button
    Friend WithEvents analyzeButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents analysisLabel As Label
    Friend WithEvents resultText As TextBox
End Class
