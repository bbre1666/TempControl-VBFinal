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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaudRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaudRateToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ComPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComPortToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.HighSetPointTextBox = New System.Windows.Forms.TextBox()
        Me.LowSetPointTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveSettingsButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 61)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(12, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 61)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialPortToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShowShortcutKeys = False
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SerialPortToolStripMenuItem
        '
        Me.SerialPortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaudRateToolStripMenuItem, Me.ComPortToolStripMenuItem})
        Me.SerialPortToolStripMenuItem.Name = "SerialPortToolStripMenuItem"
        Me.SerialPortToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.SerialPortToolStripMenuItem.Text = "Serial Port"
        '
        'BaudRateToolStripMenuItem
        '
        Me.BaudRateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaudRateToolStripComboBox})
        Me.BaudRateToolStripMenuItem.Name = "BaudRateToolStripMenuItem"
        Me.BaudRateToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.BaudRateToolStripMenuItem.Text = "Baud Rate"
        '
        'BaudRateToolStripComboBox
        '
        Me.BaudRateToolStripComboBox.Name = "BaudRateToolStripComboBox"
        Me.BaudRateToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'ComPortToolStripMenuItem
        '
        Me.ComPortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComPortToolStripComboBox})
        Me.ComPortToolStripMenuItem.Name = "ComPortToolStripMenuItem"
        Me.ComPortToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.ComPortToolStripMenuItem.Text = "ComPort"
        '
        'ComPortToolStripComboBox
        '
        Me.ComPortToolStripComboBox.Name = "ComPortToolStripComboBox"
        Me.ComPortToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(687, 406)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(101, 32)
        Me.ConnectButton.TabIndex = 3
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 406)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(64, 32)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'HighSetPointTextBox
        '
        Me.HighSetPointTextBox.Location = New System.Drawing.Point(732, 55)
        Me.HighSetPointTextBox.Name = "HighSetPointTextBox"
        Me.HighSetPointTextBox.Size = New System.Drawing.Size(56, 22)
        Me.HighSetPointTextBox.TabIndex = 5
        '
        'LowSetPointTextBox
        '
        Me.LowSetPointTextBox.Location = New System.Drawing.Point(732, 83)
        Me.LowSetPointTextBox.Name = "LowSetPointTextBox"
        Me.LowSetPointTextBox.Size = New System.Drawing.Size(56, 22)
        Me.LowSetPointTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(629, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "High Setpoint"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(629, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Low Setpoint"
        '
        'SaveSettingsButton
        '
        Me.SaveSettingsButton.Location = New System.Drawing.Point(687, 368)
        Me.SaveSettingsButton.Name = "SaveSettingsButton"
        Me.SaveSettingsButton.Size = New System.Drawing.Size(101, 32)
        Me.SaveSettingsButton.TabIndex = 9
        Me.SaveSettingsButton.Text = "Save Settings"
        Me.SaveSettingsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SaveSettingsButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LowSetPointTextBox)
        Me.Controls.Add(Me.HighSetPointTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaudRateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComPortToolStripComboBox As ToolStripComboBox
    Friend WithEvents BaudRateToolStripComboBox As ToolStripComboBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ExitButton As Button
    Friend WithEvents HighSetPointTextBox As TextBox
    Friend WithEvents LowSetPointTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveSettingsButton As Button
End Class
