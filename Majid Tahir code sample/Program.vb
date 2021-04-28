Imports System

Module Program
    Sub Main(args As String())
        'task 1

        Console.WriteLine("PRE-RELEASE MJ2021 SOLUTION IN VB")
        Const OneWayTicket = 25

        Dim TrainTimeUP() As String = {"9:00", "11:00", "13:00", "15:00"}
        Dim totalupseats() = {480, 480, 480, 480}
        Dim occupiedUpseat() = {0, 0, 0, 0}
        Dim UPtrainmoney() = {0, 0, 0, 0}

        Dim TrainTimeDown() As String = {"10:00", "12:00", "14:00", "16:00"}
        Dim totaldownseats() = {480, 480, 480, 640}
        Dim occupiedDownseat() = {0, 0, 0, 0}
        Dim DOWNtrainmoney() = {0, 0, 0, 0}
        Dim MaxPassengerTrain() = {0, 0, 0, 0}
        Dim choice As Boolean
        Dim numofopassenger, Uptrip, Downtrip, cost, discountedcost As Integer
        Dim TwoWayTickets As Integer

        Dim totalpassengers, totalamount As Integer 'For Task3

        Console.WriteLine("Welcome to TRAIN JOURNEY Display Screen")
        For count = 0 To 3
            Console.WriteLine("Train Num: " & count & "Train Time up: " & TrainTimeUP(count) & "Total seats Up: " & totalupseats(count) & "Occupied Seats: " & occupiedUpseat(count))
            Console.WriteLine("UpTrain Money = " & UPtrainmoney(count))
            Console.WriteLine("Train Num: " & count & "Train Time down: " & TrainTimeDown(count) & "Total Seats Down: " & totaldownseats(count) & "Occupied Seats: " & occupiedDownseat(count))
            Console.WriteLine("DownTrain Money = " & DOWNtrainmoney(count))
            Console.WriteLine("----------------------------------------")
        Next

        'Task2
        Console.WriteLine("Do You want to buy Tickets? True for yes and False for no")
        choice = Console.ReadLine()

        While choice <> False
            Console.WriteLine("Enter Number of passengers for trip")
            numofopassenger = Console.ReadLine()

            totalpassengers = totalpassengers + numofopassenger

            Console.WriteLine("Enter Trian to Journey Up [0,,1,2,3] ")
            Uptrip = Console.ReadLine()
            occupiedUpseat(Uptrip) = occupiedUpseat(Uptrip) + numofopassenger
            totalupseats(Uptrip) = totalupseats(Uptrip) - numofopassenger

            Console.WriteLine("Enter Train Number to journey DOWN [0,,1,2,3")
            Downtrip = Console.ReadLine()
            occupiedDownseat(Downtrip) = occupiedDownseat(Downtrip) + numofopassenger
            totaldownseats(Downtrip) = totaldownseats(Downtrip) - numofopassenger

            cost = numofopassenger * OneWayTicket

            discountedcost = cost - (OneWayTicket * (numofopassenger \ 10))
            'integer division for discount of every 10th passengers
            TwoWayTickets = discountedcost * 2
            'you have to buy ticket for Uptrip and Downtrip
            UPtrainmoney(Uptrip) = UPtrainmoney(Uptrip) + discountedcost
            DOWNtrainmoney(Downtrip) = DOWNtrainmoney(Downtrip) + discountedcost
            totalamount = totalamount + UPtrainmoney(Uptrip) + DOWNtrainmoney(Downtrip)

            'For Task3
            Console.Clear()
            For count = 0 To 3
                Console.WriteLine("Train Num: " & count & "Train Time Up: " & TrainTimeUP(count) & "Total Seats Up: " & totalupseats(count) & "Occupied Seats: " & TrainTimeUP(count))
                Console.WriteLine("Train Num: " & count & "Train Time Down: " & TrainTimeDown(count) & "total Seats Down: " & totaldownseats(count) & "Occupied Seats: " & occupiedDownseat(count))
                Console.WriteLine("DownTrain Money = " & DOWNtrainmoney(count))

                If totalupseats(count) = 0 Then
                    Console.WriteLine(TrainTimeUP(count) & " : Train is FULL : booking CLOSED")
                Else
                    Console.WriteLine(TrainTimeUP(count) & " : Seats Available : booking OPEN")
                End If
                Console.WriteLine("----------------------------------------")

                If totaldownseats(count) = 0 Then
                    Console.WriteLine(TrainTimeDown(count) & " : Train is FULL : booking CLOSED")
                Else
                    Console.WriteLine(TrainTimeDown(count) & " : Seats Available : booking OPEN")
                End If
                Console.WriteLine("----------------------------------------")
            Next
            Console.WriteLine("Do you want to buy more tickets? True for yes and False for no")
            choice = Console.ReadLine()
        End While

        'task 3
        Dim Maxtrainup As String
        Dim Maxtriandown As String
        Console.Clear()
        Console.WriteLine("------ END OF THE DAY ----------")
        For count = 0 To 3
            If occupiedUpseat(count) > MaxPassengerTrain(count) Then
                MaxPassengerTrain(count) = MaxPassengerTrain(count) + occupiedUpseat(count)
                Maxtrainup = TrainTimeUP(count)
            End If

            Console.WriteLine("----------------------------------------")
            Console.WriteLine("Train Num: " & count & " Train Time Up: " & TrainTimeUP(count) & " total seats down: " & totalupseats(count) & " occupied seats: " & occupiedUpseat(count))
            Console.WriteLine("UPtrain Money = " & UPtrainmoney(count))
            Console.WriteLine("Train Num: " & count & " train time up: " & TrainTimeDown(count) & " total seats down: " & totaldownseats(count) & " occupied seats: " & occupiedDownseat(count))
            Console.WriteLine("DownTrain Money = " & DOWNtrainmoney(count))
            Console.WriteLine("----------------------------------------")
        Next
        Console.WriteLine("Total Money Earned Today: " & totalamount)
        Console.WriteLine("Total Passengers Travalled TODAY: " & totalpassengers)
        Console.WriteLine("Maxtrain Passengers Train Upwards: " & Maxtrainup)
        Console.WriteLine("Maxtrain Passengers Train Downwards: " & Maxtriandown)
        Console.ReadKey()

    End Sub
End Module
