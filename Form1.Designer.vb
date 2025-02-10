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
        components = New ComponentModel.Container()
        lblusernm = New Label()
        lblpass = New Label()
        txtusernm = New TextBox()
        txtpass = New TextBox()
        btnlogin = New Button()
        btncancel = New Button()
        LinkLabel1 = New LinkLabel()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        chbpass = New CheckBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblusernm
        ' 
        lblusernm.AutoSize = True
        lblusernm.Location = New Point(184, 144)
        lblusernm.Name = "lblusernm"
        lblusernm.Size = New Size(79, 20)
        lblusernm.TabIndex = 0
        lblusernm.Text = "User name"
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.Location = New Point(184, 221)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(70, 20)
        lblpass.TabIndex = 1
        lblpass.Text = "Password"
        ' 
        ' txtusernm
        ' 
        txtusernm.Location = New Point(327, 144)
        txtusernm.Name = "txtusernm"
        txtusernm.Size = New Size(304, 27)
        txtusernm.TabIndex = 2
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(327, 214)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(304, 27)
        txtpass.TabIndex = 3
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(327, 307)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(94, 29)
        btnlogin.TabIndex = 4
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' btncancel
        ' 
        btncancel.Location = New Point(508, 307)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(94, 29)
        btncancel.TabIndex = 5
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(369, 367)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(79, 20)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "LinkLabel1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' chbpass
        ' 
        chbpass.AutoSize = True
        chbpass.Location = New Point(374, 256)
        chbpass.Name = "chbpass"
        chbpass.Size = New Size(132, 24)
        chbpass.TabIndex = 7
        chbpass.Text = "Show Password"
        chbpass.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(chbpass)
        Controls.Add(LinkLabel1)
        Controls.Add(btncancel)
        Controls.Add(btnlogin)
        Controls.Add(txtpass)
        Controls.Add(txtusernm)
        Controls.Add(lblpass)
        Controls.Add(lblusernm)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblusernm As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents txtusernm As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents chbpass As CheckBox
End Class
