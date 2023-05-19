<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceCallHistory
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
        Me.ExistingCallsGridView = New System.Windows.Forms.DataGridView()
        Me.ServiceCallReportLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.ExistingCallsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExistingCallsGridView
        '
        Me.ExistingCallsGridView.AllowUserToAddRows = False
        Me.ExistingCallsGridView.AllowUserToDeleteRows = False
        Me.ExistingCallsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ExistingCallsGridView.CausesValidation = False
        Me.ExistingCallsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExistingCallsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ExistingCallsGridView.Location = New System.Drawing.Point(12, 94)
        Me.ExistingCallsGridView.Name = "ExistingCallsGridView"
        Me.ExistingCallsGridView.ReadOnly = True
        Me.ExistingCallsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ExistingCallsGridView.Size = New System.Drawing.Size(1247, 625)
        Me.ExistingCallsGridView.TabIndex = 0
        '
        'ServiceCallReportLabel
        '
        Me.ServiceCallReportLabel.AutoSize = True
        Me.ServiceCallReportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceCallReportLabel.Location = New System.Drawing.Point(13, 38)
        Me.ServiceCallReportLabel.Name = "ServiceCallReportLabel"
        Me.ServiceCallReportLabel.Size = New System.Drawing.Size(154, 29)
        Me.ServiceCallReportLabel.TabIndex = 1
        Me.ServiceCallReportLabel.Text = "Service Calls"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(1139, 29)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(120, 59)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ServiceCallHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 731)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ServiceCallReportLabel)
        Me.Controls.Add(Me.ExistingCallsGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ServiceCallHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Call History"
        Me.TopMost = True
        CType(Me.ExistingCallsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExistingCallsGridView As DataGridView
    Friend WithEvents ServiceCallReportLabel As Label
    Friend WithEvents CloseButton As Button
End Class
