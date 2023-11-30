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
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.CoolingSetPointTextBox = New System.Windows.Forms.TextBox()
        Me.HeatingSetPointTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UPCoolingButtion = New System.Windows.Forms.Button()
        Me.UPHeatButton = New System.Windows.Forms.Button()
        Me.DownCoolingButton = New System.Windows.Forms.Button()
        Me.DownHeatButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialPortToolStripMenuItem, Me.SaveSettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShowShortcutKeys = False
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SerialPortToolStripMenuItem
        '
        Me.SerialPortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaudRateToolStripMenuItem, Me.ComPortToolStripMenuItem})
        Me.SerialPortToolStripMenuItem.Name = "SerialPortToolStripMenuItem"
        Me.SerialPortToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
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
        Me.BaudRateToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.ComPortToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ComPortToolStripComboBox.Name = "ComPortToolStripComboBox"
        Me.ComPortToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'SaveSettingsToolStripMenuItem
        '
        Me.SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
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
        'SerialPort1
        '
        '
        'CoolingSetPointTextBox
        '
        Me.CoolingSetPointTextBox.Location = New System.Drawing.Point(673, 55)
        Me.CoolingSetPointTextBox.Name = "CoolingSetPointTextBox"
        Me.CoolingSetPointTextBox.Size = New System.Drawing.Size(56, 22)
        Me.CoolingSetPointTextBox.TabIndex = 5
        '
        'HeatingSetPointTextBox
        '
        Me.HeatingSetPointTextBox.Location = New System.Drawing.Point(673, 157)
        Me.HeatingSetPointTextBox.Name = "HeatingSetPointTextBox"
        Me.HeatingSetPointTextBox.Size = New System.Drawing.Size(56, 22)
        Me.HeatingSetPointTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(559, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Clooling Setpoint"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(559, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Heating Setpoint"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(135, 79)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(135, 157)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(282, 109)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(73, 57)
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(427, 55)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(38, 16)
        Me.TimeLabel.TabIndex = 13
        Me.TimeLabel.Text = "Time"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'UPCoolingButtion
        '
        Me.UPCoolingButtion.Location = New System.Drawing.Point(735, 31)
        Me.UPCoolingButtion.Name = "UPCoolingButtion"
        Me.UPCoolingButtion.Size = New System.Drawing.Size(53, 24)
        Me.UPCoolingButtion.TabIndex = 14
        Me.UPCoolingButtion.Text = "UP"
        Me.UPCoolingButtion.UseVisualStyleBackColor = True
        '
        'UPHeatButton
        '
        Me.UPHeatButton.Location = New System.Drawing.Point(735, 142)
        Me.UPHeatButton.Name = "UPHeatButton"
        Me.UPHeatButton.Size = New System.Drawing.Size(53, 24)
        Me.UPHeatButton.TabIndex = 15
        Me.UPHeatButton.Text = "UP"
        Me.UPHeatButton.UseVisualStyleBackColor = True
        '
        'DownCoolingButton
        '
        Me.DownCoolingButton.Location = New System.Drawing.Point(735, 70)
        Me.DownCoolingButton.Name = "DownCoolingButton"
        Me.DownCoolingButton.Size = New System.Drawing.Size(53, 24)
        Me.DownCoolingButton.TabIndex = 16
        Me.DownCoolingButton.Text = "Down"
        Me.DownCoolingButton.UseVisualStyleBackColor = True
        '
        'DownHeatButton
        '
        Me.DownHeatButton.Location = New System.Drawing.Point(735, 172)
        Me.DownHeatButton.Name = "DownHeatButton"
        Me.DownHeatButton.Size = New System.Drawing.Size(53, 24)
        Me.DownHeatButton.TabIndex = 17
        Me.DownHeatButton.Text = "Down"
        Me.DownHeatButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DownHeatButton)
        Me.Controls.Add(Me.DownCoolingButton)
        Me.Controls.Add(Me.UPHeatButton)
        Me.Controls.Add(Me.UPCoolingButtion)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HeatingSetPointTextBox)
        Me.Controls.Add(Me.CoolingSetPointTextBox)
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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CoolingSetPointTextBox As TextBox
    Friend WithEvents HeatingSetPointTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPCoolingButtion As Button
    Friend WithEvents UPHeatButton As Button
    Friend WithEvents DownCoolingButton As Button
    Friend WithEvents DownHeatButton As Button
End Class
