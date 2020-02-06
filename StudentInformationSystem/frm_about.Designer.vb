<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_about))
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.lbl_about = New System.Windows.Forms.Label()
        Me.lbl_systemname = New System.Windows.Forms.Label()
        Me.lbl_systemversion = New System.Windows.Forms.Label()
        Me.lbl_copyright = New System.Windows.Forms.Label()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(923, 1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(25, 25)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 3
        Me.btn_close.TabStop = False
        '
        'lbl_about
        '
        Me.lbl_about.AutoSize = True
        Me.lbl_about.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_about.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_about.Location = New System.Drawing.Point(388, 153)
        Me.lbl_about.Name = "lbl_about"
        Me.lbl_about.Size = New System.Drawing.Size(154, 39)
        Me.lbl_about.TabIndex = 0
        Me.lbl_about.Text = "About Us"
        '
        'lbl_systemname
        '
        Me.lbl_systemname.AutoSize = True
        Me.lbl_systemname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_systemname.Location = New System.Drawing.Point(402, 230)
        Me.lbl_systemname.Name = "lbl_systemname"
        Me.lbl_systemname.Size = New System.Drawing.Size(260, 22)
        Me.lbl_systemname.TabIndex = 1
        Me.lbl_systemname.Text = "Student Information System"
        '
        'lbl_systemversion
        '
        Me.lbl_systemversion.AutoSize = True
        Me.lbl_systemversion.Location = New System.Drawing.Point(402, 269)
        Me.lbl_systemversion.Name = "lbl_systemversion"
        Me.lbl_systemversion.Size = New System.Drawing.Size(123, 21)
        Me.lbl_systemversion.TabIndex = 2
        Me.lbl_systemversion.Text = "System Version"
        '
        'lbl_copyright
        '
        Me.lbl_copyright.AutoSize = True
        Me.lbl_copyright.Location = New System.Drawing.Point(402, 308)
        Me.lbl_copyright.Name = "lbl_copyright"
        Me.lbl_copyright.Size = New System.Drawing.Size(146, 21)
        Me.lbl_copyright.TabIndex = 4
        Me.lbl_copyright.Text = "System Copyright"
        '
        'frm_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 613)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_copyright)
        Me.Controls.Add(Me.lbl_systemversion)
        Me.Controls.Add(Me.lbl_systemname)
        Me.Controls.Add(Me.lbl_about)
        Me.Controls.Add(Me.btn_close)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_about"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_close As PictureBox
    Friend WithEvents lbl_about As Label
    Friend WithEvents lbl_systemname As Label
    Friend WithEvents lbl_systemversion As Label
    Friend WithEvents lbl_copyright As Label
End Class
