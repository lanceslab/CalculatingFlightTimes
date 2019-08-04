' Lance Taylor
'
' 2-4-12
' 
' Chapter 2.5
'
' Calculating Flight Times

Public Class Form1

    Dim currentFlight As New FlightCalc
    Dim depDate As New DateTime
    Dim depTime As DateTime

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' for loop to add airports to the Depart from combobox
        For index = 0 To currentFlight.airPorts.Length - 1
            ComboBoxDepartFrom.Items.Add(currentFlight.airPorts(index).ToString)
        Next
        ' for loop to add airports to the Arrive at combobox
        For index = 0 To currentFlight.airPorts.Length - 1
            ComboBoxArriveAt.Items.Add(currentFlight.airPorts(index).ToString)
        Next


    End Sub

    Private Sub buttonContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonContinue.Click

        If ComboBoxDepartFrom.Text = "" Then
            errProvider.SetError(ComboBoxDepartFrom, "You must select a Departing Airport")
        End If

        If ComboBoxArriveAt.Text = "" Then
            errProvider.SetError(ComboBoxArriveAt, "You must select an Arriving Airport")
        End If

        If ComboBoxDepartFrom.SelectedItem IsNot Nothing Then
            If ComboBoxArriveAt.SelectedItem IsNot Nothing Then

                Dim deptDate As DateTime
                deptDate = DateTimePickerDepartDate.Value.Date()

                Dim convertedInfo As Date = Convert.ToDateTime(deptDate & " " & txtDepartTime.Text)

                Dim departAirportindex As Integer
                Dim arriveAirportindex As Integer
                departAirportindex = ComboBoxDepartFrom.SelectedIndex
                arriveAirportindex = ComboBoxArriveAt.SelectedIndex

                ' information to pass to "FlightCalc" 
                currentFlight.CalculateFlight(convertedInfo, departAirportindex, arriveAirportindex)

                ' add the Arrival information to the listbox
                ListBoxArrivalInformation.Items.Add(currentFlight.arrivingDateTime)
                ListBoxArrivalInformation.Items.Add("Travel time is " & currentFlight.flightTravelTime & " hours")
            End If
        End If
    End Sub

End Class
