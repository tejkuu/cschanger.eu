﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prepare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prepare))
        Me.GenesisForm1 = New Wild_Games.GenesisForm()
        Me.GenesisGroupBox1 = New Wild_Games.GenesisGroupBox()
        Me.GenesisButton3 = New Wild_Games.GenesisButton()
        Me.GenesisButton1 = New Wild_Games.GenesisButton()
        Me.GenesisSimpleLabel2 = New Wild_Games.GenesisSimpleLabel()
        Me.GenesisSimpleLabel1 = New Wild_Games.GenesisSimpleLabel()
        Me.GenesisHeaderLabel1 = New Wild_Games.GenesisHeaderLabel()
        Me.GenesisButton2 = New Wild_Games.GenesisButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GenesisForm1.SuspendLayout()
        Me.GenesisGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenesisForm1
        '
        Me.GenesisForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.GenesisForm1.Controls.Add(Me.GenesisGroupBox1)
        Me.GenesisForm1.Controls.Add(Me.PictureBox1)
        Me.GenesisForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GenesisForm1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GenesisForm1.Location = New System.Drawing.Point(0, 0)
        Me.GenesisForm1.Name = "GenesisForm1"
        Me.GenesisForm1.Size = New System.Drawing.Size(501, 160)
        Me.GenesisForm1.TabIndex = 0
        Me.GenesisForm1.Text = "CSCHANGER.EU :: PREPARING TO UPDATE!"
        '
        'GenesisGroupBox1
        '
        Me.GenesisGroupBox1.Controls.Add(Me.GenesisButton3)
        Me.GenesisGroupBox1.Controls.Add(Me.GenesisButton1)
        Me.GenesisGroupBox1.Controls.Add(Me.GenesisSimpleLabel2)
        Me.GenesisGroupBox1.Controls.Add(Me.GenesisSimpleLabel1)
        Me.GenesisGroupBox1.Controls.Add(Me.GenesisHeaderLabel1)
        Me.GenesisGroupBox1.Controls.Add(Me.GenesisButton2)
        Me.GenesisGroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GenesisGroupBox1.Name = "GenesisGroupBox1"
        Me.GenesisGroupBox1.Size = New System.Drawing.Size(501, 132)
        Me.GenesisGroupBox1.TabIndex = 5
        Me.GenesisGroupBox1.TabStop = False
        Me.GenesisGroupBox1.Text = "GenesisGroupBox1"
        '
        'GenesisButton3
        '
        Me.GenesisButton3.Location = New System.Drawing.Point(198, 90)
        Me.GenesisButton3.Name = "GenesisButton3"
        Me.GenesisButton3.Size = New System.Drawing.Size(168, 30)
        Me.GenesisButton3.TabIndex = 7
        Me.GenesisButton3.Text = "JOIN OUR DISCORD"
        Me.GenesisButton3.UseVisualStyleBackColor = True
        '
        'GenesisButton1
        '
        Me.GenesisButton1.Location = New System.Drawing.Point(9, 90)
        Me.GenesisButton1.Name = "GenesisButton1"
        Me.GenesisButton1.Size = New System.Drawing.Size(183, 30)
        Me.GenesisButton1.TabIndex = 6
        Me.GenesisButton1.Text = "CHECK OUR WEBSITE"
        Me.GenesisButton1.UseVisualStyleBackColor = True
        '
        'GenesisSimpleLabel2
        '
        Me.GenesisSimpleLabel2.AutoSize = True
        Me.GenesisSimpleLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GenesisSimpleLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GenesisSimpleLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GenesisSimpleLabel2.Location = New System.Drawing.Point(204, 52)
        Me.GenesisSimpleLabel2.Name = "GenesisSimpleLabel2"
        Me.GenesisSimpleLabel2.Size = New System.Drawing.Size(88, 15)
        Me.GenesisSimpleLabel2.TabIndex = 5
        Me.GenesisSimpleLabel2.Text = "5d 10h 22m 12s"
        '
        'GenesisSimpleLabel1
        '
        Me.GenesisSimpleLabel1.AutoSize = True
        Me.GenesisSimpleLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GenesisSimpleLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GenesisSimpleLabel1.Location = New System.Drawing.Point(23, 52)
        Me.GenesisSimpleLabel1.Name = "GenesisSimpleLabel1"
        Me.GenesisSimpleLabel1.Size = New System.Drawing.Size(184, 15)
        Me.GenesisSimpleLabel1.TabIndex = 4
        Me.GenesisSimpleLabel1.Text = "The next update will be published"
        '
        'GenesisHeaderLabel1
        '
        Me.GenesisHeaderLabel1.AutoSize = True
        Me.GenesisHeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GenesisHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.GenesisHeaderLabel1.Location = New System.Drawing.Point(11, 16)
        Me.GenesisHeaderLabel1.Name = "GenesisHeaderLabel1"
        Me.GenesisHeaderLabel1.Size = New System.Drawing.Size(467, 19)
        Me.GenesisHeaderLabel1.TabIndex = 3
        Me.GenesisHeaderLabel1.Text = "We are preparing for a new update, more specifically to the 1.02.02 version"
        '
        'GenesisButton2
        '
        Me.GenesisButton2.Location = New System.Drawing.Point(417, 90)
        Me.GenesisButton2.Name = "GenesisButton2"
        Me.GenesisButton2.Size = New System.Drawing.Size(72, 30)
        Me.GenesisButton2.TabIndex = 2
        Me.GenesisButton2.Text = "CLOSE"
        Me.GenesisButton2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'prepare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 160)
        Me.Controls.Add(Me.GenesisForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "prepare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSCHANGER.EU :: PREPARING TO UPDATE"
        Me.GenesisForm1.ResumeLayout(False)
        Me.GenesisGroupBox1.ResumeLayout(False)
        Me.GenesisGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GenesisForm1 As GenesisForm
    Friend WithEvents GenesisGroupBox1 As GenesisGroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GenesisSimpleLabel2 As GenesisSimpleLabel
    Friend WithEvents GenesisSimpleLabel1 As GenesisSimpleLabel
    Friend WithEvents GenesisHeaderLabel1 As GenesisHeaderLabel
    Friend WithEvents GenesisButton2 As GenesisButton
    Friend WithEvents GenesisButton3 As GenesisButton
    Friend WithEvents GenesisButton1 As GenesisButton
End Class
