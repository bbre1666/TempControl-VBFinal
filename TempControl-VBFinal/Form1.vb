Imports System.IO
Imports System.IO.Ports
Public Class Form1
    Public DateTemp, DrivePath, fileName, ComPortName, Baudrate, ComPortName1, Baudrate1, HighSetPoint, LowSetPoint As String
    Public PortState As Boolean
    Public ReceveByte(18) As Byte
    Public AnalogData1, AnalogData2, AnalogData3, AnalogData4, DigitalData As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = TimeOfDay


        If PortState = True Then        'if serial port is open send read analog in comand 
            Dim Intermidete() As Byte = {&H53} 'load comand to byte array
            SerialPort1.Write(Intermidete, 0, Intermidete.Length)     'output comand 

            Dim Intermidete1() As Byte = {&H30} 'load comand to byte array
            SerialPort1.Write(Intermidete1, 0, Intermidete1.Length)     'output comand 
        End If

    End Sub

    Private Sub BaudRateToolStripComboBox_Click(sender As Object, e As EventArgs) Handles BaudRateToolStripComboBox.Click
        BaudRateToolStripComboBox.Items.Clear()        'Display Baud rate Options
        BaudRateToolStripComboBox.Items.Add(1200)
        BaudRateToolStripComboBox.Items.Add(2400)
        BaudRateToolStripComboBox.Items.Add(4800)
        BaudRateToolStripComboBox.Items.Add(9600)
        BaudRateToolStripComboBox.Items.Add(19200)
        BaudRateToolStripComboBox.Items.Add(38400)
        BaudRateToolStripComboBox.Items.Add(57600)
        BaudRateToolStripComboBox.Items.Add(115200)
        BaudRateToolStripComboBox.Items.Add(230400)
        BaudRateToolStripComboBox.Items.Add(460800)
        BaudRateToolStripComboBox.Items.Add(921600)
    End Sub

    Private Sub UPCoolingButtion_Click(sender As Object, e As EventArgs) Handles UPCoolingButtion.Click
        CoolingSetPointTextBox.Text += 0.5
    End Sub

    Private Sub DownCoolingButton_Click(sender As Object, e As EventArgs) Handles DownCoolingButton.Click
        CoolingSetPointTextBox.Text -= 0.5
    End Sub

    Private Sub UPHeatButton_Click(sender As Object, e As EventArgs) Handles UPHeatButton.Click
        HeatingSetPointTextBox.Text += 0.5
    End Sub

    Private Sub DownHeatButton_Click(sender As Object, e As EventArgs) Handles DownHeatButton.Click
        HeatingSetPointTextBox.Text -= 0.5
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSettingsToolStripMenuItem.Click
        DrivePath = CurDir()

        fileName = DrivePath & "\" & "HVACSettings" & ".txt" 'set the file name 

        Try
            System.IO.File.Delete(fileName)
            FileOpen(1, fileName, OpenMode.Append)  'open the file
        Catch ex As Exception
            MsgBox("Faiiled to open the settings file, Please goto the setup menu")
            Exit Sub
        End Try

        WriteLine(1, Baudrate)      'Write baud rate to file 
        WriteLine(1, ComPortName)   'Write comport to file 
        WriteLine(1, CoolingSetPointTextBox.Text)
        WriteLine(1, HeatingSetPointTextBox.Text)

        FileClose(1)
    End Sub

    Private Sub ComPortToolStripComboBox_Click(sender As Object, e As EventArgs) Handles ComPortToolStripComboBox.Click
        'Find and display all available com ports
        ComPortToolStripComboBox.Items.Clear() 'Clear current list
        For Each sp As String In My.Computer.Ports.SerialPortNames  'check to see serial dvice serial ports
            ComPortToolStripComboBox.Items.Add(sp) 'add discovered port to listboxs
        Next
    End Sub

    Private Sub Form1_UnLoad()
        Try
            SerialPort1.Close() 'make shure the form doea not close with the serial port open
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        DateTemp = DateString   'set DateTemp to the date 
        DrivePath = CurDir()

        fileName = DrivePath & "\" & "HVACSettings" & ".txt" 'set the file name 

        Try
            FileOpen(1, fileName, OpenMode.Input)  'open the file
        Catch ex As Exception
            MsgBox("Faiiled to open the settings file, Please goto the setup menu")
            Exit Sub
        End Try
        Input(1, Baudrate1)      'pull baud rate from file 
        Input(1, ComPortName1)   'pull comport from file 
        Input(1, HighSetPoint)
        Input(1, LowSetPoint)


        Try
            SerialPort1.Close() 'try to close the port to make shure that the port is closed 

        Catch ex As Exception

        End Try
        ConnectButton.Text = "Connect"    'set the button text back to connect 
        PortState = False   'set the port state indicator to indicat the port is closed
        SerialPort1.BaudRate = Baudrate1    'set the baud to the selected item in the list 
        SerialPort1.PortName = ComPortName1   'set the selected port name 



        If ConnectButton.Text = "Connect" Then 'conect to serial port 
            Try
                SerialPort1.Open() 'open the port 
                ConnectButton.Text = "Disconnect"    'set the button text to disconnect 
                PortState = True    'set the port state indicator to indicat the port is open
            Catch ex As Exception
                MsgBox("Port Already Open Or Port Unavailable")     'if there is problems with pening the port display msg box
                ConnectButton.Text = "Connect"   'set the button text back to connect 
                PortState = False   'set the port state indicator to indicat the port is closed 
            End Try
        Else
            Try
                SerialPort1.Close() 'if button does not read connect close the prt 
            Catch ex As Exception

            End Try
            PortState = False   'set the port state indicator to indicat the port is closed 
            ConnectButton.Text = "Connect"   'set the button text back to connect 
        End If
        FileClose(1)    'close file
    End Sub
    Private Sub BaudRateToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BaudRateToolStripComboBox.SelectedIndexChanged
        Baudrate = CInt(BaudRateToolStripComboBox.SelectedItem)
    End Sub

    Private Sub ComPortToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortToolStripComboBox.SelectedIndexChanged
        ComPortName = ComPortToolStripComboBox.SelectedItem
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        HeatingSetPointTextBox.Text = 65
        CoolingSetPointTextBox.Text = 70

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim RaadSize = SerialPort1.BytesToRead

        SerialPort1.Read(ReceveByte, 0, 4)
        AnalogData1 = ReceveByte(0)         'store data for analog to the analog data vribles
        AnalogData2 = ReceveByte(1)
        AnalogData3 = ReceveByte(2)
        AnalogData4 = ReceveByte(3)
        DigitalData = ReceveByte(4)

    End Sub
End Class
