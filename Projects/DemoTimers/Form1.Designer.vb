<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        LblInfo = New Label()
        Timer1 = New Timer(components)
        txtCounter = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Button1.Location = New Point(74, 152)
        Button1.Name = "Button1"
        Button1.Size = New Size(292, 87)
        Button1.TabIndex = 0
        Button1.Text = "Start Timer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Button2.Location = New Point(429, 152)
        Button2.Name = "Button2"
        Button2.Size = New Size(292, 87)
        Button2.TabIndex = 1
        Button2.Text = "Stop Timer"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LblInfo
        ' 
        LblInfo.AutoSize = True
        LblInfo.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblInfo.Location = New Point(74, 141)
        LblInfo.Name = "LblInfo"
        LblInfo.Size = New Size(0, 29)
        LblInfo.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' txtCounter
        ' 
        txtCounter.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCounter.Location = New Point(74, 50)
        txtCounter.Name = "txtCounter"
        txtCounter.Size = New Size(647, 37)
        txtCounter.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(774, 278)
        Controls.Add(txtCounter)
        Controls.Add(LblInfo)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LblInfo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtCounter As TextBox

End Class
