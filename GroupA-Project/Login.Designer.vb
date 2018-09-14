<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.fld_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fld_password = New System.Windows.Forms.TextBox()
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnl_login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fld_username
        '
        Me.fld_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_username.Location = New System.Drawing.Point(264, 245)
        Me.fld_username.Name = "fld_username"
        Me.fld_username.Size = New System.Drawing.Size(218, 26)
        Me.fld_username.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(122, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(122, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD"
        '
        'fld_password
        '
        Me.fld_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_password.Location = New System.Drawing.Point(264, 294)
        Me.fld_password.Name = "fld_password"
        Me.fld_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.fld_password.Size = New System.Drawing.Size(218, 26)
        Me.fld_password.TabIndex = 3
        '
        'pnl_login
        '
        Me.pnl_login.BackColor = System.Drawing.Color.White
        Me.pnl_login.Controls.Add(Me.btn_login)
        Me.pnl_login.Controls.Add(Me.PictureBox1)
        Me.pnl_login.Controls.Add(Me.fld_username)
        Me.pnl_login.Controls.Add(Me.fld_password)
        Me.pnl_login.Controls.Add(Me.Label1)
        Me.pnl_login.Controls.Add(Me.Label2)
        Me.pnl_login.Location = New System.Drawing.Point(128, 41)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(597, 391)
        Me.pnl_login.TabIndex = 4
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.Control
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_login.Location = New System.Drawing.Point(264, 338)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(218, 35)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GroupA_Project.My.Resources.Resource1.logo
        Me.PictureBox1.Location = New System.Drawing.Point(60, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(456, 195)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(888, 642)
        Me.Controls.Add(Me.pnl_login)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fld_username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fld_password As TextBox
    Friend WithEvents pnl_login As Panel
    Friend WithEvents btn_login As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
