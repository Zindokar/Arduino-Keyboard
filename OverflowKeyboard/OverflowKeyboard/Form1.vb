Imports System.Threading
Public Class Form1
    Private thread As Thread
    Private com1 As IO.Ports.SerialPort = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thread = New Thread(AddressOf readCom)
        thread.IsBackground = True
        For Each ports As String In My.Computer.Ports.SerialPortNames
            comPortList.Items.Add(ports)
        Next

    End Sub

    Private Sub comPortList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPortList.SelectedIndexChanged
        comPortList.Enabled = False
        c01.Enabled = False
        c02.Enabled = False
        c03.Enabled = False
        c04.Enabled = False
        b01.Enabled = False
        b02.Enabled = False
        b03.Enabled = False
        b04.Enabled = False
        com1 = My.Computer.Ports.OpenSerialPort(comPortList.SelectedItem, 9600)
        msg.Text = "Conectado."
        msg.ForeColor = Color.Green
        thread.Start()
    End Sub

    Private Sub readCom()
        Do
            Dim input As String = com1.ReadLine()
            If input.IndexOf("c1") <> -1 Then
                SendKeys.SendWait(c01.Text)
            ElseIf input.IndexOf("c2") <> -1 Then
                SendKeys.SendWait(c02.Text)
            ElseIf input.IndexOf("c3") <> -1 Then
                SendKeys.SendWait(c03.Text)
            ElseIf input.IndexOf("c4") <> -1 Then
                SendKeys.SendWait(c04.Text)
            ElseIf input.IndexOf("b1") <> -1 Then
                SendKeys.SendWait(b01.Text)
            ElseIf input.IndexOf("b2") <> -1 Then
                SendKeys.SendWait(b02.Text)
            ElseIf input.IndexOf("b3") <> -1 Then
                SendKeys.SendWait(b03.Text)
            ElseIf input.IndexOf("b4") <> -1 Then
                SendKeys.SendWait(b04.Text)
            End If
        Loop
    End Sub
End Class
