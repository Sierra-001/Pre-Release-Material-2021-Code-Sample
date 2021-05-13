Imports System
Module Program
    Sub Main(args As String())
        'task 1

        Console.WriteLine("PRE-RELEASE MJ2021 SOLUTION IN VB")
        Dim OneWayTicket = 25

        Dim TrainTimeUP(3), TotalUpSeats(3) As String
        Dim OccupiedUpSeat(3), UpTrainMoney(3) As Integer

        TrainTimeUP(0) = "09:00"
        TrainTimeUP(1) = "11:00"
        TrainTimeUP(2) = "13:00"
        TrainTimeUP(3) = "15:00"

        TotalUpSeats(0) = 480
        TotalUpSeats(1) = 480
        TotalUpSeats(2) = 480
        TotalUpSeats(3) = 480

        OccupiedUpSeat(0) = 0
        OccupiedUpSeat(1) = 0
        OccupiedUpSeat(2) = 0
        OccupiedUpSeat(3) = 0

        UpTrainMoney(0) = 0
        UpTrainMoney(1) = 0
        UpTrainMoney(2) = 0
        UpTrainMoney(3) = 0

        Dim TrainTimeDown(3) As String
        Dim TotalDownSeats(3), OccupiedDownSeat(3), DownTrainMoney(3), MaxPassengerTrain(3), ArSpace(1) As Integer
        Dim Choice, Avaliability, Space As String
        Dim NumOfPassenger, UpTrip, DownTrip, Cost, Discount, TwoWayTickets As Integer

        TrainTimeDown(0) = "10:00"
        TrainTimeDown(1) = "12:00"
        TrainTimeDown(2) = "14:00"
        TrainTimeDown(3) = "16:00"

        TotalDownSeats(0) = 480
        TotalDownSeats(1) = 480
        TotalDownSeats(2) = 480
        TotalDownSeats(3) = 640

        OccupiedDownSeat(0) = 0
        OccupiedDownSeat(1) = 0
        OccupiedDownSeat(2) = 0
        OccupiedDownSeat(3) = 0

        DownTrainMoney(0) = 0
        DownTrainMoney(1) = 0
        DownTrainMoney(2) = 0
        DownTrainMoney(3) = 0

        MaxPassengerTrain(0) = 0
        MaxPassengerTrain(1) = 0
        MaxPassengerTrain(2) = 0
        MaxPassengerTrain(3) = 0

        Dim TotalPassengers, TotalAmount As Integer 'For Task3

        Space = ("                                                                                        ")
        'Console.WriteLine(Len("------------ --------- ---------------- --------------- ---------------"))

        Console.WriteLine("Welcome to TRAIN JOURNEY Display Screen")
        For Count = 0 To 3
            If (Count = 0) Then
                Console.WriteLine("Train Number " & "Departure" & " Seat's Avaliable" & " Occupied Seat's")
                Console.WriteLine("------------ " & "---------" & " " & "----------------" & " " & "---------------")
            End If
            If (Len(TotalUpSeats(0) <= 3)) Then
                Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count))
            Else
                If (Len(TotalUpSeats(0) <= 2)) Then
                    Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count))
                Else
                    Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count))
                End If
            End If
        Next Count

        Console.WriteLine()
        For Count = 0 To 3
            If (Count = 0) Then
                Console.WriteLine("Train Number " & "Arrival " & "Seat's Avaliable" & " Occupied Seat's")
                Console.WriteLine("------------ " & "------- " & "----------------" & " " & "---------------")
            End If
            Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeDown(Count) & Right(Space, 3) & TotalDownSeats(Count) & Right(Space, 14) & OccupiedDownSeat(Count))
        Next Count

        'Task2
        Console.Write("Do You want to buy Ticket's [yes/no]? ")
        Choice = UCase(Console.ReadLine())
        Console.WriteLine()

        While Choice = "YES"
            Console.Write("Enter Number of passenger's : ")
            NumOfPassenger = Console.ReadLine()
            Console.WriteLine()
            TotalPassengers = (TotalPassengers + NumOfPassenger)

            Console.Write("Enter Trian Number [1 - 4]? :")
            UpTrip = (Console.ReadLine() - 1)
            Console.WriteLine()
            OccupiedUpSeat(UpTrip) = (OccupiedUpSeat(UpTrip) + NumOfPassenger)
            TotalUpSeats(UpTrip) = (TotalUpSeats(UpTrip) - NumOfPassenger)

            Console.Write("Enter Train Number For Return [1 - 4]? ")
            DownTrip = (Console.ReadLine() - 1)
            Console.WriteLine()
            OccupiedDownSeat(DownTrip) = (OccupiedDownSeat(DownTrip) + NumOfPassenger)
            TotalDownSeats(DownTrip) = (TotalDownSeats(DownTrip) - NumOfPassenger)

            Cost = (NumOfPassenger * OneWayTicket)

            Discount = (Cost - (OneWayTicket * (NumOfPassenger \ 10)))
            'integer division for discount of every 10th passengers

            TwoWayTickets = (Discount * 2)
            'you have to buy ticket for Uptrip and Downtrip

            UpTrainMoney(UpTrip) = (UpTrainMoney(UpTrip) + Discount)
            DownTrainMoney(DownTrip) = (DownTrainMoney(DownTrip) + Discount)
            TotalAmount = (TotalAmount + UpTrainMoney(UpTrip) + DownTrainMoney(DownTrip))

            'For Task3
            Console.Clear()

            For Count = 0 To 3
                If (Count = 0) Then
                    Console.WriteLine("Train Number " & "Departure" & " Seat's Avaliable" & " Occupied Seat's" & " Status")
                    Console.WriteLine("------------ " & "---------" & " " & "----------------" & " " & "---------------" & " " & "----------------")
                End If
                If Not (TotalUpSeats(Count) <> 0) Then
                    Avaliability = "Train is Full"
                Else
                    Avaliability = "Seat's Avaliable"
                End If
                If (TotalUpSeats(Count) > 99) Then
                    ArSpace(0) = 14
                Else
                    If (TotalUpSeats(Count) > 9 And TotalUpSeats(Count) < 100) Then
                        ArSpace(0) = 15
                    Else
                        ArSpace(0) = 16
                    End If
                End If
                If (OccupiedUpSeat(Count) <= 9) Then
                    ArSpace(1) = 15
                Else
                    If (OccupiedUpSeat(Count) > 9 And OccupiedUpSeat(Count) <= 99) Then
                        ArSpace(1) = 14
                    Else
                        ArSpace(1) = 13
                    End If
                End If
                If (OccupiedUpSeat(Count) < 10) Then
                    Console.WriteLine(Left(Space, 5) & Count + 1 & Left(Space, 7) & TrainTimeUP(Count) & Left(Space, 5) & TotalUpSeats(Count) & Left(Space, ArSpace(0)) & OccupiedUpSeat(Count) & Left(Space, ArSpace(1)) & Avaliability)
                Else
                    If (OccupiedUpSeat(Count) >= 10 And OccupiedUpSeat(Count) < 100) Then
                        Console.WriteLine(Left(Space, 5) & Count + 1 & Left(Space, 7) & TrainTimeUP(Count) & Left(Space, 5) & TotalUpSeats(Count) & Left(Space, ArSpace(0)) & OccupiedUpSeat(Count) & Left(Space, ArSpace(1)) & Avaliability)
                    Else
                        Console.WriteLine(Left(Space, 5) & Count + 1 & Left(Space, 7) & TrainTimeUP(Count) & Left(Space, 5) & TotalUpSeats(Count) & Left(Space, ArSpace(0)) & OccupiedUpSeat(Count) & Left(Space, ArSpace(1)) & Avaliability)
                    End If
                End If
            Next Count

            Console.WriteLine()
            For Count = 0 To 3
                If (Count = 0) Then
                    Console.WriteLine("Train Number " & "Arrival " & "Seat's Avaliable" & " Occupied Seat's" & " Status")
                    Console.WriteLine("------------ " & "------- " & "----------------" & " " & "---------------" & " " & "----------------")
                End If
                If Not (TotalUpSeats(Count) <> 0) Then
                    Avaliability = "Train is Full"
                Else
                    Avaliability = "Seat's Avaliable"
                End If
                If (TotalDownSeats(Count) > 99) Then
                    ArSpace(0) = 14
                Else
                    If (TotalDownSeats(Count) > 9 And TotalDownSeats(Count) < 100) Then
                        ArSpace(0) = 15
                    Else
                        ArSpace(0) = 16
                    End If
                End If
                If (OccupiedDownSeat(Count) <= 9) Then
                    ArSpace(1) = 15
                Else
                    If (OccupiedDownSeat(Count) > 9 And OccupiedDownSeat(Count) <= 99) Then
                        ArSpace(1) = 14
                    Else
                        ArSpace(1) = 13
                    End If
                End If
                If (OccupiedDownSeat(Count) < 10) Then
                    Console.WriteLine(Left(Space, 5) & Count + 1 & Left(Space, 7) & TrainTimeDown(Count) & Right(Space, 3) & TotalDownSeats(Count) & Right(Space, ArSpace(0)) & OccupiedDownSeat(Count) & Left(Space, ArSpace(1)) & Avaliability)
                Else
                    If (OccupiedDownSeat(Count) >= 10 And OccupiedDownSeat(Count) < 100) Then
                        Console.WriteLine(Left(Space, 5) & Count + 1 & Left(Space, 7) & TrainTimeDown(Count) & Right(Space, 3) & TotalDownSeats(Count) & Right(Space, ArSpace(0)) & OccupiedDownSeat(Count) & Left(Space, ArSpace(1)) & Avaliability)
                    Else
                        Console.WriteLine(Left(Space, 5) & Count + 1 & Left(Space, 7) & TrainTimeDown(Count) & Right(Space, 3) & TotalDownSeats(Count) & Right(Space, ArSpace(0)) & OccupiedDownSeat(Count) & Left(Space, ArSpace(1)) & Avaliability)
                    End If
                End If
            Next Count

            Console.WriteLine("Do You want to buy Ticket's [yes/no]? ")
            Choice = UCase(Console.ReadLine())
        End While

        'task 3
        Dim MaxTrainUp, MaxTrainDown As Integer
        Console.Clear()

        Console.WriteLine("------ END OF THE DAY ----------")
        For count = 0 To 3
            If count = 0 Then
                Console.WriteLine("Train Number " & "Departure" & " Seat's Avaliable" & " Occupied Seat's" & " Money Collected")
                Console.WriteLine("------------ " & "---------" & " " & "----------------" & " " & "---------------" & " " & "---------------")
            End If
            If (TotalUpSeats(count) > 99) Then
                ArSpace(0) = 14
            Else
                If (TotalUpSeats(count) > 9 And TotalUpSeats(count) < 100) Then
                    ArSpace(0) = 15
                Else
                    ArSpace(0) = 16
                End If
            End If

            If (OccupiedUpSeat(count) < 10) Then
                Console.WriteLine(Left(Space, 5) & count + 1 & Left(Space, 7) & TrainTimeUP(count) & Left(Space, 5) & TotalUpSeats(count) & Left(Space, ArSpace(0)) & OccupiedUpSeat(count) & Left(Space, 15) & UpTrainMoney(count))
            Else
                If (OccupiedUpSeat(count) >= 10 And OccupiedUpSeat(count) < 100) Then
                    Console.WriteLine(Left(Space, 5) & count + 1 & Left(Space, 7) & TrainTimeUP(count) & Left(Space, 5) & TotalUpSeats(count) & Left(Space, ArSpace(0)) & OccupiedUpSeat(count) & Left(Space, 14) & UpTrainMoney(count))
                Else
                    Console.WriteLine(Left(Space, 5) & count + 1 & Left(Space, 7) & TrainTimeUP(count) & Left(Space, 5) & TotalUpSeats(count) & Left(Space, ArSpace(0)) & OccupiedUpSeat(count) & Left(Space, 13) & UpTrainMoney(count))
                End If
            End If
        Next
        For count = 0 To 3
            If count = 0 Then
                Console.WriteLine("Train Number " & "Arrival " & "Seat's Avaliable" & " Occupied Seat's" & " Money Collected")
                Console.WriteLine("------------ " & "------- " & "----------------" & " " & "---------------" & " " & "---------------")
            End If
            If (TotalDownSeats(count) > 99) Then
                ArSpace(0) = 14
            Else
                If (TotalDownSeats(count) > 9 And TotalDownSeats(count) < 100) Then
                    ArSpace(0) = 15
                Else
                    ArSpace(0) = 16
                End If
            End If

            If (OccupiedDownSeat(count) < 10) Then
                Console.WriteLine(Left(Space, 5) & count + 1 & Left(Space, 7) & TrainTimeDown(count) & Right(Space, 3) & TotalDownSeats(count) & Right(Space, ArSpace(0)) & OccupiedDownSeat(count) & Left(Space, 15) & DownTrainMoney(count))
            Else
                If (OccupiedDownSeat(count) >= 10 And OccupiedDownSeat(count) < 100) Then
                    Console.WriteLine(Left(Space, 5) & count + 1 & Left(Space, 7) & TrainTimeDown(count) & Right(Space, 3) & TotalDownSeats(count) & Right(Space, ArSpace(0)) & OccupiedDownSeat(count) & Left(Space, 14) & DownTrainMoney(count))
                Else
                    Console.WriteLine(Left(Space, 5) & count + 1 & Left(Space, 7) & TrainTimeDown(count) & Right(Space, 3) & TotalDownSeats(count) & Right(Space, ArSpace(0)) & OccupiedDownSeat(count) & Left(Space, 13) & DownTrainMoney(count))
                End If
            End If
        Next

        For Count = 0 To 3
            If OccupiedUpSeat(Count) > MaxPassengerTrain(Count) Then
                MaxPassengerTrain(Count) = (MaxPassengerTrain(Count) + OccupiedUpSeat(Count))
                MaxTrainUp = MaxTrainUp + OccupiedUpSeat(Count)
                MaxTrainDown = MaxTrainDown + OccupiedDownSeat(Count)
            End If
        Next
        Console.WriteLine("Total Money Earned Today: " & TotalAmount)
        Console.WriteLine("Total Passengers Travalled TODAY: " & (TotalPassengers * 2))
        Console.WriteLine("Maxtrain Passengers Train Upwards: " & MaxTrainUp)
        Console.WriteLine("Maxtrain Passengers Train Downwards: " & MaxTrainDown)
        Console.ReadKey()

    End Sub
End Module
