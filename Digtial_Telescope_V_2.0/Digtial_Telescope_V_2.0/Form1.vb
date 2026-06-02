Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization


Public Class Form1

    Dim SelectedPlanet As String = ""
    Dim SelectedPlanetName As String = ""
    Dim SelectedAltitude As String = ""
    Dim SelectedAzimuth As String = ""
    Dim AboveHorizon As String = ""

    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Try
            ' URL to fetch the JSON from
            Dim apiUrl As String = "https://api.visibleplanets.dev/v3?latitude=" & TextBox1.Text & "&longitude=" & TextBox2.Text & " &aboveHorizon=false" ' Replace with your desired API endpoint

            ' Fetch the JSON response
            Dim jsonResponse As String = FetchJson(apiUrl)


            Dim s As String = jsonResponse
            Dim SS() As String
            Dim SSS() As String
            Dim Token As String

            Dim CurrentPlanetName As String = ""


            s = s.Replace("{", "")
            s = s.Replace("}", "")
            s = s.Replace("[", "NA,")
            s = s.Replace("]", "")
            s = s.Replace("""", "")

            SS = s.Split(",")

            For Each Token In SS
                SSS = Token.Split(":")

                'lstTags.Items.Add(SSS(0) & ":" & SSS(1))

                If SSS(0) = "name" Then CurrentPlanetName = SSS(1) : UpdatePlanetInfo(CurrentPlanetName, "Name", SSS(1))
                If SSS(0) = "constellation" Then UpdatePlanetInfo(CurrentPlanetName, "Zodiac", SSS(1))
                If SSS(0) = "altitude" Then UpdatePlanetInfo(CurrentPlanetName, "Altitude", String.Format("{0:####}", CDbl(SSS(1))))
                If SSS(0) = "azimuth" Then UpdatePlanetInfo(CurrentPlanetName, "Azimuth", String.Format("{0:####}", CDbl(SSS(1))))
                If SSS(0) = "aboveHorizon" Then UpdatePlanetInfo(CurrentPlanetName, "Horizon Position", If(SSS(1) = "true", "Above", "Below"))



                'If SSS(0) = "name" Then PlanetInfo(PlanetCounterCol, PlanetCounterRow) = SSS(1) : PlanetCounterCol += 1 : PlanetCounterRow += 1
                'If SSS(0) = "constellation" Then PlanetInfo(PlanetCounterCol, PlanetCounterRow) = SSS(1) : PlanetCounterRow += 1

            Next

            Panel1.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub UpdatePlanetInfo(Planet As String, Infotype As String, Info As String)

        If Infotype = "Name" Then
            Select Case Planet
                Case "Mars"
                    lbl_Mars.Text = Infotype & " : " & Info & vbCrLf
                Case "Moon"
                    lbl_Moon.Text = Infotype & " : " & Info & vbCrLf
                Case "Neptune"
                    lbl_Neptune.Text = Infotype & " : " & Info & vbCrLf
                Case "Venus"
                    lbl_Venus.Text = Infotype & " : " & Info & vbCrLf
                Case "Mercury"
                    lbl_Mercury.Text = Infotype & " : " & Info & vbCrLf
                Case "Uranus"
                    lbl_Uranus.Text = Infotype & " : " & Info & vbCrLf
                Case "Saturn"
                    lbl_Saturn.Text = Infotype & " : " & Info & vbCrLf
                Case "Jupiter"
                    lbl_Jupiter.Text = Infotype & " : " & Info & vbCrLf
                Case "Pluto"
                    lbl_Pluto.Text = Infotype & " : " & Info & vbCrLf
            End Select
        Else
            Select Case Planet
                Case "Mars"
                    lbl_Mars.Text &= Infotype & " : " & Info & vbCrLf
                Case "Moon"
                    lbl_Moon.Text &= Infotype & " : " & Info & vbCrLf
                Case "Neptune"
                    lbl_Neptune.Text &= Infotype & " : " & Info & vbCrLf
                Case "Venus"
                    lbl_Venus.Text &= Infotype & " : " & Info & vbCrLf
                Case "Mercury"
                    lbl_Mercury.Text &= Infotype & " : " & Info & vbCrLf
                Case "Uranus"
                    lbl_Uranus.Text &= Infotype & " : " & Info & vbCrLf
                Case "Saturn"
                    lbl_Saturn.Text &= Infotype & " : " & Info & vbCrLf
                Case "Jupiter"
                    lbl_Jupiter.Text &= Infotype & " : " & Info & vbCrLf
                Case "Pluto"
                    lbl_Pluto.Text &= Infotype & " : " & Info & vbCrLf
            End Select
        End If


    End Sub

    ' Function to fetch JSON from a URL
    Private Function FetchJson(url As String) As String
        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "GET"
        Dim response As WebResponse = request.GetResponse()

        Using responseStream As Stream = response.GetResponseStream()
            Using reader As New StreamReader(responseStream)
                Return reader.ReadToEnd()
            End Using
        End Using
    End Function

    Public Sub ClearLabel()
        For Each lbl As Label In Panel1.Controls.OfType(Of Label)()
            lbl.BackColor = Color.White
        Next

        For Each pic As PictureBox In Panel1.Controls.OfType(Of PictureBox)()
            pic.BorderStyle = BorderStyle.FixedSingle
        Next
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ClearLabel()
        lbl_Mars.BackColor = Color.Orange
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Mars.Text
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ClearLabel()
        lbl_Jupiter.BackColor = Color.Orange
        PictureBox4.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Jupiter.Text
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ClearLabel()
        lbl_Mercury.BackColor = Color.Orange
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Mercury.Text
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ClearLabel()
        lbl_Neptune.BackColor = Color.Orange
        PictureBox6.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Neptune.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClearLabel()
        lbl_Moon.BackColor = Color.Orange
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Moon.Text
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        ClearLabel()
        lbl_Pluto.BackColor = Color.Orange
        PictureBox10.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Pluto.Text
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ClearLabel()
        lbl_Saturn.BackColor = Color.Orange
        PictureBox5.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Saturn.Text
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ClearLabel()
        lbl_Uranus.BackColor = Color.Orange
        PictureBox8.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Uranus.Text
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        ClearLabel()
        lbl_Venus.BackColor = Color.Orange
        PictureBox7.BorderStyle = BorderStyle.Fixed3D
        SelectedPlanet = lbl_Venus.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If SelectedPlanet = "" Then MsgBox("Please select the planet to view", MsgBoxStyle.Information, "Find My Planet") : Exit Sub

        Dim s() As String = SelectedPlanet.Split(vbCrLf)
        SelectedPlanetName = Trim(s(0).Split(":")(1))
        SelectedAltitude = Trim(s(2).Split(":")(1))
        SelectedAzimuth = Trim(s(3).Split(":")(1))
        AboveHorizon = Trim(s(4).Split(":")(1))

        If Trim(AboveHorizon) = "Below" Then MsgBox("Sorry at this time, selected planet is not visible", MsgBoxStyle.Information, "Find My Planet") : Exit Sub


        If MsgBox("You are looking for " & SelectedPlanetName & vbCrLf & vbCrLf & "Make sure telescope at home position..?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Find My Planet") = MsgBoxResult.Yes Then

            If MsgBox("Are you sure..?" & vbCrLf & vbCrLf & "Sending control signal to telescope...", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Find My Planet") = MsgBoxResult.Ok Then

                If SerialPort1.IsOpen Then
                    SerialPort1.WriteLine(SelectedAzimuth & "," & SelectedAltitude)
                Else
                    MsgBox("Please connect the telescope to PC" & vbCrLf & vbCrLf & "Then Retry...", MsgBoxStyle.Information, "Find My Planet") : Exit Sub
                End If


            End If

        End If
    End Sub

    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click
        SerialPort1.PortName = "COM" & txtPort.Text
        SerialPort1.Open()

        If SerialPort1.IsOpen Then
            MsgBox("Telescope connected successfully", MsgBoxStyle.Information, "Find My Planet")

            Button1.Enabled = True
        End If
    End Sub

    Private Sub btn_DisConnect_Click(sender As Object, e As EventArgs) Handles btn_DisConnect.Click
        Button1.Enabled = False

        SerialPort1.Close()
    End Sub





    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim PlanetName As String = ListBox1.SelectedItem.ToString

    '    ListBox2.Items.Clear()

    '    Dim PlanetFound As String = "No"

    '    For Each item In lstTags.Items
    '        Dim PlanettoSearch As String = item.ToString.Split(":")(1)

    '        If PlanetName = PlanettoSearch Then PlanetFound = "Yes"

    '        If PlanetFound = "Yes" Then
    '            ListBox2.Items.Add(item.ToString.Split(":")(0) & " --> " & item.ToString.Split(":")(1))

    '            If item.ToString.Split(":")(0) = "nakedEyeObject" Then PlanetFound = "No"
    '        End If
    '    Next
    'End Sub

End Class
