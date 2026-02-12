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
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Button1.Location = New Point(110, 86)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 48)
        Button1.TabIndex = 0
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Button2.Location = New Point(529, 86)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 48)
        Button2.TabIndex = 1
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(112, 197)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(561, 66)
        ProgressBar1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(109, 291)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 29)
        Label1.TabIndex = 3
        Label1.Text = "Label1"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterParent
        Text = "Progressbar Application"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer

End Class
