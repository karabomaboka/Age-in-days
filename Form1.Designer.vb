<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAge
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
    Me.lblDayOfBirth = New System.Windows.Forms.Label()
    Me.mtDayOfBirth = New System.Windows.Forms.MaskedTextBox()
    Me.btnComputeOfBirth = New System.Windows.Forms.Button()
    Me.lblFullDateOfBirth = New System.Windows.Forms.Label()
    Me.lblToday = New System.Windows.Forms.Label()
    Me.lblAgeInDays = New System.Windows.Forms.Label()
    Me.txtFullDateOfBirth = New System.Windows.Forms.TextBox()
    Me.txtToday = New System.Windows.Forms.TextBox()
    Me.txtAgeInDays = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblDayOfBirth
    '
    Me.lblDayOfBirth.AutoSize = True
    Me.lblDayOfBirth.Location = New System.Drawing.Point(194, 80)
    Me.lblDayOfBirth.Name = "lblDayOfBirth"
    Me.lblDayOfBirth.Size = New System.Drawing.Size(91, 17)
    Me.lblDayOfBirth.TabIndex = 0
    Me.lblDayOfBirth.Text = "Date of Birth:"
    '
    'mtDayOfBirth
    '
    Me.mtDayOfBirth.Location = New System.Drawing.Point(313, 77)
    Me.mtDayOfBirth.Mask = "00/00/0000"
    Me.mtDayOfBirth.Name = "mtDayOfBirth"
    Me.mtDayOfBirth.Size = New System.Drawing.Size(214, 22)
    Me.mtDayOfBirth.TabIndex = 1
    '
    'btnComputeOfBirth
    '
    Me.btnComputeOfBirth.Location = New System.Drawing.Point(239, 123)
    Me.btnComputeOfBirth.Name = "btnComputeOfBirth"
    Me.btnComputeOfBirth.Size = New System.Drawing.Size(234, 37)
    Me.btnComputeOfBirth.TabIndex = 2
    Me.btnComputeOfBirth.Text = "Compute Data"
    Me.btnComputeOfBirth.UseVisualStyleBackColor = True
    '
    'lblFullDateOfBirth
    '
    Me.lblFullDateOfBirth.AutoSize = True
    Me.lblFullDateOfBirth.Location = New System.Drawing.Point(194, 166)
    Me.lblFullDateOfBirth.Name = "lblFullDateOfBirth"
    Me.lblFullDateOfBirth.Size = New System.Drawing.Size(98, 17)
    Me.lblFullDateOfBirth.TabIndex = 3
    Me.lblFullDateOfBirth.Text = "Full birth date:"
    '
    'lblToday
    '
    Me.lblToday.AutoSize = True
    Me.lblToday.Location = New System.Drawing.Point(194, 216)
    Me.lblToday.Name = "lblToday"
    Me.lblToday.Size = New System.Drawing.Size(90, 17)
    Me.lblToday.TabIndex = 4
    Me.lblToday.Text = "Today's date"
    '
    'lblAgeInDays
    '
    Me.lblAgeInDays.AutoSize = True
    Me.lblAgeInDays.Location = New System.Drawing.Point(194, 260)
    Me.lblAgeInDays.Name = "lblAgeInDays"
    Me.lblAgeInDays.Size = New System.Drawing.Size(82, 17)
    Me.lblAgeInDays.TabIndex = 5
    Me.lblAgeInDays.Text = "Age in days"
    '
    'txtFullDateOfBirth
    '
    Me.txtFullDateOfBirth.Location = New System.Drawing.Point(313, 166)
    Me.txtFullDateOfBirth.Name = "txtFullDateOfBirth"
    Me.txtFullDateOfBirth.ReadOnly = True
    Me.txtFullDateOfBirth.Size = New System.Drawing.Size(214, 22)
    Me.txtFullDateOfBirth.TabIndex = 6
    '
    'txtToday
    '
    Me.txtToday.Location = New System.Drawing.Point(313, 211)
    Me.txtToday.Name = "txtToday"
    Me.txtToday.ReadOnly = True
    Me.txtToday.Size = New System.Drawing.Size(214, 22)
    Me.txtToday.TabIndex = 7
    '
    'txtAgeInDays
    '
    Me.txtAgeInDays.Location = New System.Drawing.Point(313, 255)
    Me.txtAgeInDays.Name = "txtAgeInDays"
    Me.txtAgeInDays.ReadOnly = True
    Me.txtAgeInDays.Size = New System.Drawing.Size(214, 22)
    Me.txtAgeInDays.TabIndex = 8
    '
    'frmAge
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.txtAgeInDays)
    Me.Controls.Add(Me.txtToday)
    Me.Controls.Add(Me.txtFullDateOfBirth)
    Me.Controls.Add(Me.lblAgeInDays)
    Me.Controls.Add(Me.lblToday)
    Me.Controls.Add(Me.lblFullDateOfBirth)
    Me.Controls.Add(Me.btnComputeOfBirth)
    Me.Controls.Add(Me.mtDayOfBirth)
    Me.Controls.Add(Me.lblDayOfBirth)
    Me.Name = "frmAge"
    Me.Text = "Age in Days"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lblDayOfBirth As Label
  Friend WithEvents mtDayOfBirth As MaskedTextBox
  Friend WithEvents btnComputeOfBirth As Button
  Friend WithEvents lblFullDateOfBirth As Label
  Friend WithEvents lblToday As Label
  Friend WithEvents lblAgeInDays As Label
  Friend WithEvents txtFullDateOfBirth As TextBox
  Friend WithEvents txtToday As TextBox
  Friend WithEvents txtAgeInDays As TextBox
End Class
