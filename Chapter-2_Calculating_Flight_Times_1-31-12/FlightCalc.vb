


Public Class FlightCalc

    Private departAirportIndex As Integer
    Private arriveAirportIndex As Integer
    Private departingDate As DateTime
    Private deptartingTime As DateTime
    Private arrivalDateAndTIme As DateTime
    Private currentTravelTime As Double
    ' airport array holds airport identification codes
    Private airportsCollection As String() = {"MIA", "JFK", "HNL", "LAX", "DFW"}
    ' utc array holds the UTC offsets corrisponding to the airports
    Private utcOffsetsCollection As Integer() = {-4, -4, -10, -7, -5}
    ' travel time array holds the estimated travel time in hours, between 2 airports
    Private travelTimesCollection As Double(,) = {{0, 3, 12, 8, 2.5},
                                                 {3, 0, 14, 8.5, 3.5},
                                                 {12, 14, 0, 4.5, 8.5},
                                                 {8, 8.5, 4.5, 0, 3.5},
                                                 {2.5, 3.5, 8.5, 3.5, 0}}


    ' property to read the contents of the Airport Array for the comboboxes on form 1
    Public ReadOnly Property airPorts() As Array
        Get
            Return airportsCollection
        End Get
    End Property

    ' property to read the travel time for the main form1
    Public ReadOnly Property flightTravelTime() As Double
        Get
            Return currentTravelTime
        End Get
    End Property

    ' property to read the Arrival Date and Time for the main form1
    Public ReadOnly Property arrivingDateTime() As DateTime
        Get
            Return arrivalDateAndTIme
        End Get
    End Property




    Public Sub CalculateFlight(ByVal departingDateAndTime As DateTime,
                               ByVal departAirportIndex As Integer,
                               ByVal arriveAirportIndex As Integer)

        Dim departUtcOffSet As Integer = utcOffsetsCollection(departAirportIndex)
        Dim arrivUtcOffSet As Integer = utcOffsetsCollection(arriveAirportIndex)
        Dim travTime As Double = travelTimesCollection(departAirportIndex, arriveAirportIndex)
        Dim utcConvertedDepart As DateTime
        Dim tempArrivalTime As DateTime
        Dim utcConvertedArrive As DateTime

        ' convert the departure time to the UTC time
        utcConvertedDepart = departingDateAndTime.Subtract(New TimeSpan(0, departUtcOffSet, 0, 0))
        ' Set the temp arrival time
        'tempArrivalTime = departingDateAndTime.AddHours(travTime)
        tempArrivalTime = utcConvertedDepart.AddHours(travTime)
        ' Convert the arrival time
        utcConvertedArrive = tempArrivalTime.Add(New TimeSpan(0, arrivUtcOffSet, 0, 0))
        arrivalDateAndTIme = utcConvertedArrive
        currentTravelTime = travTime


    End Sub

End Class
