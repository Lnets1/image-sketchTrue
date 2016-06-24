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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnBrowser = New System.Windows.Forms.Button()
        Me.BtnBrightness = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NudPencerahan = New System.Windows.Forms.NumericUpDown()
        Me.BtnBW = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudPencerahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(301, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(274, 216)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BtnBrowser
        '
        Me.BtnBrowser.Location = New System.Drawing.Point(12, 234)
        Me.BtnBrowser.Name = "BtnBrowser"
        Me.BtnBrowser.Size = New System.Drawing.Size(111, 23)
        Me.BtnBrowser.TabIndex = 2
        Me.BtnBrowser.Text = "Browse Gambar"
        Me.BtnBrowser.UseVisualStyleBackColor = True
        '
        'BtnBrightness
        '
        Me.BtnBrightness.Location = New System.Drawing.Point(327, 234)
        Me.BtnBrightness.Name = "BtnBrightness"
        Me.BtnBrightness.Size = New System.Drawing.Size(77, 23)
        Me.BtnBrightness.TabIndex = 3
        Me.BtnBrightness.Text = "Brightness"
        Me.BtnBrightness.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(484, 234)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(74, 23)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Atur Pencerahan"
        '
        'NudPencerahan
        '
        Me.NudPencerahan.Location = New System.Drawing.Point(373, 271)
        Me.NudPencerahan.Name = "NudPencerahan"
        Me.NudPencerahan.Size = New System.Drawing.Size(57, 20)
        Me.NudPencerahan.TabIndex = 6
        '
        'BtnBW
        '
        Me.BtnBW.Location = New System.Drawing.Point(410, 234)
        Me.BtnBW.Name = "BtnBW"
        Me.BtnBW.Size = New System.Drawing.Size(68, 23)
        Me.BtnBW.TabIndex = 7
        Me.BtnBW.Text = "Black&white"
        Me.BtnBW.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 303)
        Me.Controls.Add(Me.BtnBW)
        Me.Controls.Add(Me.NudPencerahan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBrightness)
        Me.Controls.Add(Me.BtnBrowser)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "App Image Sketch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudPencerahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBrowser As System.Windows.Forms.Button
    Friend WithEvents BtnBrightness As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NudPencerahan As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnBW As System.Windows.Forms.Button

End Class
