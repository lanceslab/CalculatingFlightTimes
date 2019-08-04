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
        Me.components = New System.ComponentModel.Container()
        Me.labelDepart = New System.Windows.Forms.Label()
        Me.labelArrive = New System.Windows.Forms.Label()
        Me.labelDepatDate = New System.Windows.Forms.Label()
        Me.labelDepartTime = New System.Windows.Forms.Label()
        Me.labelArrivDatTim = New System.Windows.Forms.Label()
        Me.ComboBoxDepartFrom = New System.Windows.Forms.ComboBox()
        Me.ComboBoxArriveAt = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDepartDate = New System.Windows.Forms.DateTimePicker()
        Me.ListBoxArrivalInformation = New System.Windows.Forms.ListBox()
        Me.buttonContinue = New System.Windows.Forms.Button()
        Me.txtDepartTime = New System.Windows.Forms.TextBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelDepart
        '
        Me.labelDepart.AutoSize = True
        Me.labelDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDepart.Location = New System.Drawing.Point(73, 43)
        Me.labelDepart.Name = "labelDepart"
        Me.labelDepart.Size = New System.Drawing.Size(75, 15)
        Me.labelDepart.TabIndex = 0
        Me.labelDepart.Text = "Depart from:"
        '
        'labelArrive
        '
        Me.labelArrive.AutoSize = True
        Me.labelArrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelArrive.Location = New System.Drawing.Point(331, 43)
        Me.labelArrive.Name = "labelArrive"
        Me.labelArrive.Size = New System.Drawing.Size(53, 15)
        Me.labelArrive.TabIndex = 1
        Me.labelArrive.Text = "Arrive at:"
        '
        'labelDepatDate
        '
        Me.labelDepatDate.AutoSize = True
        Me.labelDepatDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDepatDate.Location = New System.Drawing.Point(73, 118)
        Me.labelDepatDate.Name = "labelDepatDate"
        Me.labelDepatDate.Size = New System.Drawing.Size(94, 15)
        Me.labelDepatDate.TabIndex = 2
        Me.labelDepatDate.Text = "Departure Date:"
        '
        'labelDepartTime
        '
        Me.labelDepartTime.AutoSize = True
        Me.labelDepartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDepartTime.Location = New System.Drawing.Point(73, 188)
        Me.labelDepartTime.Name = "labelDepartTime"
        Me.labelDepartTime.Size = New System.Drawing.Size(96, 15)
        Me.labelDepartTime.TabIndex = 3
        Me.labelDepartTime.Text = "Departure Time:"
        '
        'labelArrivDatTim
        '
        Me.labelArrivDatTim.AutoSize = True
        Me.labelArrivDatTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelArrivDatTim.Location = New System.Drawing.Point(334, 127)
        Me.labelArrivDatTim.Name = "labelArrivDatTim"
        Me.labelArrivDatTim.Size = New System.Drawing.Size(103, 15)
        Me.labelArrivDatTim.TabIndex = 4
        Me.labelArrivDatTim.Text = "Arrival Date/Time:"
        '
        'ComboBoxDepartFrom
        '
        Me.ComboBoxDepartFrom.FormattingEnabled = True
        Me.ComboBoxDepartFrom.Location = New System.Drawing.Point(76, 61)
        Me.ComboBoxDepartFrom.Name = "ComboBoxDepartFrom"
        Me.ComboBoxDepartFrom.Size = New System.Drawing.Size(107, 21)
        Me.ComboBoxDepartFrom.TabIndex = 5
        '
        'ComboBoxArriveAt
        '
        Me.ComboBoxArriveAt.FormattingEnabled = True
        Me.ComboBoxArriveAt.Location = New System.Drawing.Point(334, 61)
        Me.ComboBoxArriveAt.Name = "ComboBoxArriveAt"
        Me.ComboBoxArriveAt.Size = New System.Drawing.Size(103, 21)
        Me.ComboBoxArriveAt.TabIndex = 8
        '
        'DateTimePickerDepartDate
        '
        Me.DateTimePickerDepartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDepartDate.Location = New System.Drawing.Point(76, 136)
        Me.DateTimePickerDepartDate.Name = "DateTimePickerDepartDate"
        Me.DateTimePickerDepartDate.Size = New System.Drawing.Size(107, 20)
        Me.DateTimePickerDepartDate.TabIndex = 9
        '
        'ListBoxArrivalInformation
        '
        Me.ListBoxArrivalInformation.BackColor = System.Drawing.SystemColors.Control
        Me.ListBoxArrivalInformation.FormattingEnabled = True
        Me.ListBoxArrivalInformation.Location = New System.Drawing.Point(334, 145)
        Me.ListBoxArrivalInformation.Name = "ListBoxArrivalInformation"
        Me.ListBoxArrivalInformation.Size = New System.Drawing.Size(154, 82)
        Me.ListBoxArrivalInformation.TabIndex = 10
        '
        'buttonContinue
        '
        Me.buttonContinue.Location = New System.Drawing.Point(232, 246)
        Me.buttonContinue.Name = "buttonContinue"
        Me.buttonContinue.Size = New System.Drawing.Size(75, 23)
        Me.buttonContinue.TabIndex = 11
        Me.buttonContinue.Text = "Continue"
        Me.buttonContinue.UseVisualStyleBackColor = True
        '
        'txtDepartTime
        '
        Me.txtDepartTime.Location = New System.Drawing.Point(76, 207)
        Me.txtDepartTime.Name = "txtDepartTime"
        Me.txtDepartTime.Size = New System.Drawing.Size(72, 20)
        Me.txtDepartTime.TabIndex = 12
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'Form1
        '
        Me.AcceptButton = Me.buttonContinue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 290)
        Me.Controls.Add(Me.txtDepartTime)
        Me.Controls.Add(Me.buttonContinue)
        Me.Controls.Add(Me.ListBoxArrivalInformation)
        Me.Controls.Add(Me.DateTimePickerDepartDate)
        Me.Controls.Add(Me.ComboBoxArriveAt)
        Me.Controls.Add(Me.ComboBoxDepartFrom)
        Me.Controls.Add(Me.labelArrivDatTim)
        Me.Controls.Add(Me.labelDepartTime)
        Me.Controls.Add(Me.labelDepatDate)
        Me.Controls.Add(Me.labelArrive)
        Me.Controls.Add(Me.labelDepart)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule a Flight"
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelDepart As System.Windows.Forms.Label
    Friend WithEvents labelArrive As System.Windows.Forms.Label
    Friend WithEvents labelDepatDate As System.Windows.Forms.Label
    Friend WithEvents labelDepartTime As System.Windows.Forms.Label
    Friend WithEvents labelArrivDatTim As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDepartFrom As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxArriveAt As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerDepartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBoxArrivalInformation As System.Windows.Forms.ListBox
    Friend WithEvents buttonContinue As System.Windows.Forms.Button
    Friend WithEvents txtDepartTime As System.Windows.Forms.TextBox
    Friend WithEvents errProvider As System.Windows.Forms.ErrorProvider

End Class
