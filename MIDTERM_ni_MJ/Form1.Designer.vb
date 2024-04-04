<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        txtmonthinc = New TextBox()
        Label2 = New Label()
        label3 = New Label()
        txttranspo = New TextBox()
        txtgroc = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtenter = New TextBox()
        Label6 = New Label()
        txttotalexp = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        txtremain = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(215, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 0
        Label1.Text = "Monthly  Income"
        ' 
        ' txtmonthinc
        ' 
        txtmonthinc.Location = New Point(213, 27)
        txtmonthinc.Name = "txtmonthinc"
        txtmonthinc.Size = New Size(100, 23)
        txtmonthinc.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(504, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 2
        Label2.Text = "Expenses:"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(504, 35)
        label3.Name = "label3"
        label3.Size = New Size(83, 15)
        label3.TabIndex = 3
        label3.Text = "Transportation"
        ' 
        ' txttranspo
        ' 
        txttranspo.Location = New Point(504, 53)
        txttranspo.Name = "txttranspo"
        txttranspo.Size = New Size(100, 23)
        txttranspo.TabIndex = 4
        ' 
        ' txtgroc
        ' 
        txtgroc.Location = New Point(504, 97)
        txtgroc.Name = "txtgroc"
        txtgroc.Size = New Size(100, 23)
        txtgroc.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(504, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 3
        Label4.Text = "Groceries"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(504, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 15)
        Label5.TabIndex = 3
        Label5.Text = "Entertainment"
        ' 
        ' txtenter
        ' 
        txtenter.Location = New Point(504, 141)
        txtenter.Name = "txtenter"
        txtenter.Size = New Size(100, 23)
        txtenter.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(504, 167)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 15)
        Label6.TabIndex = 3
        Label6.Text = "Total  expenses:"
        ' 
        ' txttotalexp
        ' 
        txttotalexp.Location = New Point(504, 185)
        txttotalexp.Name = "txttotalexp"
        txttotalexp.Size = New Size(100, 23)
        txttotalexp.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(373, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Total"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(215, 167)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 15)
        Label7.TabIndex = 0
        Label7.Text = "Remaining Balace"
        ' 
        ' txtremain
        ' 
        txtremain.Location = New Point(215, 185)
        txtremain.Name = "txtremain"
        txtremain.Size = New Size(100, 23)
        txtremain.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(373, 152)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 6
        Button2.Text = "Clear All"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txttotalexp)
        Controls.Add(txtenter)
        Controls.Add(txtgroc)
        Controls.Add(txttranspo)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(label3)
        Controls.Add(Label2)
        Controls.Add(txtremain)
        Controls.Add(txtmonthinc)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtmonthinc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents txttranspo As TextBox
    Friend WithEvents txtgroc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtenter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttotalexp As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtremain As TextBox
    Friend WithEvents Button2 As Button
End Class
