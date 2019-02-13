<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdAbweisend = New System.Windows.Forms.Button()
        Me.cmdNichtAbweisend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAbweisend
        '
        Me.cmdAbweisend.Location = New System.Drawing.Point(129, 109)
        Me.cmdAbweisend.Name = "cmdAbweisend"
        Me.cmdAbweisend.Size = New System.Drawing.Size(75, 51)
        Me.cmdAbweisend.TabIndex = 0
        Me.cmdAbweisend.Text = "Abweisend"
        Me.cmdAbweisend.UseVisualStyleBackColor = True
        '
        'cmdNichtAbweisend
        '
        Me.cmdNichtAbweisend.Location = New System.Drawing.Point(129, 191)
        Me.cmdNichtAbweisend.Name = "cmdNichtAbweisend"
        Me.cmdNichtAbweisend.Size = New System.Drawing.Size(75, 59)
        Me.cmdNichtAbweisend.TabIndex = 1
        Me.cmdNichtAbweisend.Text = "NichtAbweisend"
        Me.cmdNichtAbweisend.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdNichtAbweisend)
        Me.Controls.Add(Me.cmdAbweisend)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdAbweisend As Button
    Friend WithEvents cmdNichtAbweisend As Button
End Class
