<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_loading))
        Me.pic_loading = New System.Windows.Forms.PictureBox()
        Me.tmr_loading = New System.Windows.Forms.Timer(Me.components)
        Me.prg_loading = New System.Windows.Forms.ProgressBar()
        CType(Me.pic_loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_loading
        '
        Me.pic_loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_loading.Image = CType(resources.GetObject("pic_loading.Image"), System.Drawing.Image)
        Me.pic_loading.Location = New System.Drawing.Point(469, 264)
        Me.pic_loading.Name = "pic_loading"
        Me.pic_loading.Size = New System.Drawing.Size(50, 50)
        Me.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_loading.TabIndex = 0
        Me.pic_loading.TabStop = False
        '
        'tmr_loading
        '
        Me.tmr_loading.Interval = 50
        '
        'prg_loading
        '
        Me.prg_loading.Location = New System.Drawing.Point(351, 329)
        Me.prg_loading.Maximum = 1000
        Me.prg_loading.Name = "prg_loading"
        Me.prg_loading.Size = New System.Drawing.Size(287, 10)
        Me.prg_loading.TabIndex = 1
        Me.prg_loading.UseWaitCursor = True
        Me.prg_loading.Visible = False
        '
        'frm_loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 613)
        Me.Controls.Add(Me.prg_loading)
        Me.Controls.Add(Me.pic_loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_loading"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_loading"
        CType(Me.pic_loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_loading As PictureBox
    Friend WithEvents tmr_loading As Timer
    Friend WithEvents prg_loading As ProgressBar
End Class
