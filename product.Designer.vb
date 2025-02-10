<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product
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
        lblpid = New Label()
        lblpnm = New Label()
        lblpprice = New Label()
        txtpid = New TextBox()
        txtpnm = New TextBox()
        txtpprice = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' lblpid
        ' 
        lblpid.AutoSize = True
        lblpid.Location = New Point(12, 71)
        lblpid.Name = "lblpid"
        lblpid.Size = New Size(78, 20)
        lblpid.TabIndex = 0
        lblpid.Text = "product id"
        ' 
        ' lblpnm
        ' 
        lblpnm.AutoSize = True
        lblpnm.Location = New Point(12, 125)
        lblpnm.Name = "lblpnm"
        lblpnm.RightToLeft = RightToLeft.No
        lblpnm.Size = New Size(102, 20)
        lblpnm.TabIndex = 1
        lblpnm.Text = "product name"
        ' 
        ' lblpprice
        ' 
        lblpprice.AutoSize = True
        lblpprice.Location = New Point(12, 173)
        lblpprice.Name = "lblpprice"
        lblpprice.Size = New Size(98, 20)
        lblpprice.TabIndex = 2
        lblpprice.Text = "product price"
        ' 
        ' txtpid
        ' 
        txtpid.Location = New Point(119, 71)
        txtpid.Name = "txtpid"
        txtpid.Size = New Size(125, 27)
        txtpid.TabIndex = 3
        ' 
        ' txtpnm
        ' 
        txtpnm.Location = New Point(120, 125)
        txtpnm.Name = "txtpnm"
        txtpnm.Size = New Size(125, 27)
        txtpnm.TabIndex = 4
        ' 
        ' txtpprice
        ' 
        txtpprice.Location = New Point(119, 170)
        txtpprice.Name = "txtpprice"
        txtpprice.Size = New Size(125, 27)
        txtpprice.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 230)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 6
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(119, 223)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(119, 269)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 9
        ' 
        ' product
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtpprice)
        Controls.Add(txtpnm)
        Controls.Add(txtpid)
        Controls.Add(lblpprice)
        Controls.Add(lblpnm)
        Controls.Add(lblpid)
        Name = "product"
        Text = "product"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblpid As Label
    Friend WithEvents lblpnm As Label
    Friend WithEvents lblpprice As Label
    Friend WithEvents txtpid As TextBox
    Friend WithEvents txtpnm As TextBox
    Friend WithEvents txtpprice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
