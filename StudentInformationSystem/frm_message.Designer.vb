<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_message
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_message = New System.Windows.Forms.Label()
        Me.prg_loading = New System.Windows.Forms.ProgressBar()
        Me.tmr_loading = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = True
        Me.lbl_message.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_message.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_message.Location = New System.Drawing.Point(359, 269)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(101, 24)
        Me.lbl_message.TabIndex = 0
        Me.lbl_message.Text = "Message"
        '
        'prg_loading
        '
        Me.prg_loading.Location = New System.Drawing.Point(347, 371)
        Me.prg_loading.Maximum = 1000
        Me.prg_loading.Name = "prg_loading"
        Me.prg_loading.Size = New System.Drawing.Size(287, 10)
        Me.prg_loading.TabIndex = 2
        Me.prg_loading.UseWaitCursor = True
        Me.prg_loading.Visible = False
        '
        'tmr_loading
        '
        Me.tmr_loading.Interval = 50
        '
        'frm_message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 613)
        Me.Controls.Add(Me.prg_loading)
        Me.Controls.Add(Me.lbl_message)
        Me.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frm_message"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_message As Label
    Friend WithEvents prg_loading As ProgressBar
    Friend WithEvents tmr_loading As Timer
End Class
