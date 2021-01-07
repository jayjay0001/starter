<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStopwatch
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblElapsed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(157, 222)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "&Start Timing"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(293, 222)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "&End Timing"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(402, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Elapsed Time:"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStart.Location = New System.Drawing.Point(366, 65)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(2, 15)
        Me.lblStart.TabIndex = 6
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEnd.Location = New System.Drawing.Point(366, 121)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(2, 15)
        Me.lblEnd.TabIndex = 7
        '
        'lblElapsed
        '
        Me.lblElapsed.AutoSize = True
        Me.lblElapsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblElapsed.Location = New System.Drawing.Point(366, 180)
        Me.lblElapsed.Name = "lblElapsed"
        Me.lblElapsed.Size = New System.Drawing.Size(2, 15)
        Me.lblElapsed.TabIndex = 8
        '
        'frmStopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblElapsed)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStopwatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stopwatch Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblElapsed As Label
End Class
