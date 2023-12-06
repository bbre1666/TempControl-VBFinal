Imports System.Configuration
Imports System.IO
Imports System.IO.Ports
Public Class Form1
    Public DateTemp, DrivePath, fileName, ComPortName, Baudrate, ComPortName1, Baudrate1, HighSetPoint, LowSetPoint As String
    Public PortState, ReadDigital, Interlock, InterlockLog, Heating, HeatingStart, HeatingStop, Cooling, CoolingStart, CoolingStop, Fan, FanError As Boolean
    Public ReceveByte(18) As Byte
    Public Comand As Byte
    Public AnalogData1, AnalogData2, AnalogData3, AnalogData4, DigitalData, ADCValue1, ADCValue2, Total, SendCount, RoomTemp, SystemTemp As Integer

    Private Sub DelayTimer_Tick(sender As Object, e As EventArgs) Handles DelayTimer.Tick

    End Sub

    Private Sub TXTimer_Tick(sender As Object, e As EventArgs) Handles TXTimer.Tick
        TimeLabel.Text = TimeOfDay
        Dim Intermidete() As Byte
        Dim Intermidete1() As Byte

        If PortState = True Then  'if serial port is open send read analog in comand 
            SendCount += 1
            If SendCount = 1 Then
                Intermidete = {&H51} 'load comand to byte array
            ElseIf SendCount = 2 Then
                Intermidete = {&H52} 'load comand to byte array
            ElseIf SendCount = 3 Then
                Intermidete = {&H30} 'load comand to byte array
                ReadDigital = True
                SendCount = 0
            End If

            'Intermidete = {&H53, &H30, Comand} 'load comand to byte array
            Try

                SerialPort1.Write(Intermidete, 0, Intermidete.Length)     'output comand
            Catch ex As Exception

            End Try

            If PictureBox1.Visible = True Then
                If InterlockLog = True Then
                    InterlockLog = False
                    Interlock = True
                    LogError()
                End If
                Intermidete1 = {&H20, &H1}
            Else
                InterlockLog = True
                Intermidete1 = {&H20, &H0}
            End If

            Try

                SerialPort1.Write(Intermidete1, 0, Intermidete1.Length)
            Catch ex As Exception

            End Try

            If RoomTemp < (LowSetPoint + 2) Then
                Heating = True
            ElseIf RoomTemp > (HighSetPoint + 2) Then
                Heating = False
            End If

            If RoomTemp > (HighSetPoint + 2) Then
                Cooling = True
            ElseIf RoomTemp < (LowSetPoint + 2) Then
                Cooling = False
            End If

            If PictureBox2.Visible = True Then
                If Heating = True Then
                    If HeatingStart = True Then
                        HeatingStart = False
                        RunFan()
                        PreshureSence()
                    End If
                    Try
                        Dim Intermidete2() As Byte
                        Intermidete2 = {&H20, &HA}
                        SerialPort1.Write(Intermidete2, 0, Intermidete2.Length)
                        HeatingStop = True
                    Catch ex As Exception

                    End Try
                ElseIf Heating = False Then
                    HeatingStart = True
                    If HeatingStop = True Then
                        HeatingStop = False
                        RunFan()
                    End If
                End If
            Else
                HeatingStart = True
                If HeatingStop = True Then
                    HeatingStop = False
                    RunFan()
                End If
            End If

            If PictureBox3.Visible = True Then
                Try

                    Dim Intermidete3() As Byte
                    Intermidete3 = {&H20, &H8}
                    SerialPort1.Write(Intermidete3, 0, Intermidete3.Length)
                Catch ex As Exception

                End Try

            End If

            If PictureBox4.Visible = True Then
                If Cooling = True Then

                    If CoolingStart = True Then
                        CoolingStart = False
                        RunFan()
                        PreshureSence()
                    End If
                    Try
                        Dim Intermidete2() As Byte
                        Intermidete2 = {&H20, &HC}
                        SerialPort1.Write(Intermidete2, 0, Intermidete2.Length)
                        CoolingStop = True

                    Catch ex As Exception

                    End Try
                ElseIf Cooling = False Then
                    CoolingStart = True
                    If CoolingStop = True Then
                        CoolingStop = False
                        RunFan()
                    End If
                End If
            Else
                CoolingStart = True
                If CoolingStop = True Then
                    CoolingStop = False
                    RunFan()
                End If
            End If
        End If


        AdcValue1Label.Text = ADCValue1
        RoomTemp = ((ADCValue1 * 3.226) / 6.6)
        RoomTempLabel.Text = RoomTemp
        ADCValue2Label.Text = ADCValue2
        SystemTemp = ((ADCValue2 * 3.226) / 6.6)
        SystemTempLabel.Text = SystemTemp
        DigitalLabel.Text = DigitalData
        Total = DigitalData
        DecodeDigital()

    End Sub
    Public Sub LogError()
        DrivePath = CurDir()



        Dim DateTime As String = TimeOfDay & " " & Date.Today

        fileName = DrivePath & "\" & "HVACSystemLog" & ".txt" 'set the file name 

        Try

            FileOpen(2, fileName, OpenMode.Append)  'open the file
        Catch ex As Exception
            MsgBox("Faiiled to open the SystemLog file, Please goto the setup menu")
            Exit Sub
        End Try

        If Interlock = True Then
            WriteLine(2, "Interlock" & " " & DateTime)
            Interlock = False
        ElseIf FanError = True Then
            FanError = False
            WriteLine(2, "FanError" & " " & DateTime)
        End If

        FileClose(2)
        ShutDown()
    End Sub

    Public Sub ShutDown()
        TXTimer.Enabled = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False

        Dim Intermidete3() As Byte
        Intermidete3 = {&H20, &H1}
        SerialPort1.Write(Intermidete3, 0, Intermidete3.Length)
        SerialPort1.Close()

        MsgBox("A System Error Occured Check The HVACSystemLog System is Shutting down")



        Me.Close()
        Threading.Thread.Sleep(1000)
    End Sub

    Public Sub RunFan()
        Dim Intermidete2() As Byte
        Intermidete2 = {&H20, &H8}
        SerialPort1.Write(Intermidete2, 0, Intermidete2.Length)
        Threading.Thread.Sleep(5000)

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
        ElseIf ConnectButton.Text = "Disconnect" Then

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
        TXTimer.Enabled = True
        HeatingSetPointTextBox.Text = 65
        CoolingSetPointTextBox.Text = 70
    End Sub
    Public Sub PreshureSence()
        DecodeDigital()
        If PreshurePictureBox.Visible = True Then
            Exit Sub
        ElseIf PreshurePictureBox.Visible = False Then
            FanError = True
            LogError()
        End If
    End Sub
    Public Sub DecodeDigital()
        PictureBox4.Visible = True
        PictureBox3.Visible = True
        PictureBox2.Visible = True
        PictureBox1.Visible = True
        PreshurePictureBox.Visible = True


        Fan = True

        'subtract the waight of each bit and turn them on as nessary
        If Total >= 128 Then

            Total = Total - 128
        End If
        If Total >= 64 Then

            Total = Total - 64
        End If
        If Total >= 32 Then

            Total = Total - 32
        End If
        If Total >= 16 Then
            PictureBox4.Visible = False 'indacator for cooling
            Total = Total - 16
        End If
        If Total >= 8 Then
            PreshurePictureBox.Visible = False
            Total = Total - 8
        End If
        If Total >= 4 Then
            PictureBox3.Visible = False 'indicator for fan
            Fan = False
            Total = Total - 4
        End If
        If Total >= 2 Then
            PictureBox2.Visible = False 'indicator For heating

            Total = Total - 2
        End If
        If Total >= 1 Then

            PictureBox1.Visible = False 'indacator for interlock
            Total = Total - 1
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim RaadSize = SerialPort1.BytesToRead

        SerialPort1.Read(ReceveByte, 0, 4)
        AnalogData1 = ReceveByte(0)         'store data for analog to the analog data vribles
        AnalogData2 = ReceveByte(1)

        If SendCount = 1 Then
            ADCValue1 = (AnalogData1 * 4) + (AnalogData2 / 64)
        ElseIf SendCount = 2 Then
            ADCValue2 = (AnalogData1 * 4) + (AnalogData2 / 64)
        ElseIf ReadDigital = True Then
            DigitalData = AnalogData1
            ReadDigital = False
        End If

    End Sub
End Class
