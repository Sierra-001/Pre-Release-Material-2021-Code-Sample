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
        Dim TotalDownSeats(3), OccupiedDownSeat(3), DownTrainMoney(3), MaxPassengerTrain(3) As Integer
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
                Console.WriteLine("Train Number " & "Departure" & " Seat's Avaliable" & " Occupied Seat's" & " Money Collected")
                Console.WriteLine("------------ " & "---------" & " " & "----------------" & " " & "---------------" & " " & "---------------")
            End If
            If (Len(TotalUpSeats(0) <= 3)) Then
                Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count) & "  " & Right(Space, 13) & UpTrainMoney(Count))
            Else
                If (Len(TotalUpSeats(0) <= 2)) Then
                Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count) & " " & Right(Space, 13) & UpTrainMoney(Count))
            Else
                Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count) & Right(Space, 13) & UpTrainMoney(Count))
            End If
            End If
        Next Count

        Console.WriteLine()
        For Count = 0 To 3
            If (Count = 0) Then
                Console.WriteLine("Train Number " & "Arrival " & "Seat's Avaliable" & " Occupied Seat's" & " Money Collected")
                Console.WriteLine("------------ " & "------- " & "----------------" & " " & "---------------" & " " & "---------------")
            End If
            Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeDown(Count) & Right(Space, 3) & TotalDownSeats(Count) & Right(Space, 14) & Format(OccupiedDownSeat(Count), "0  ") & Right(Space, 13) & Format(DownTrainMoney(Count), "0    "))
        Next Count

        'Task2
        Console.Write("Do You want to buy Ticket's [yes/no]? ")
        Choice = UCase(Console.ReadLine())
        Console.WriteLine()

        While Choice = "YES"
            Console.Write("Enter Number of passenger's : ")
            NumOfPassenger = Console.ReadLine()
            Console.WriteLine()
            TotalPassengers = TotalPassengers + NumOfPassenger

            Console.Write("Enter Trian Number [1 - 4]? :")
            UpTrip = (Console.ReadLine() - 1)
            Console.WriteLine()
            OccupiedUpSeat(UpTrip) = OccupiedUpSeat(UpTrip) + NumOfPassenger
            TotalUpSeats(UpTrip) = TotalUpSeats(UpTrip) - NumOfPassenger

            Console.Write("Enter Train Number For Return [1 - 4]? ")
            DownTrip = (Console.ReadLine() - 1)
            Console.WriteLine()
            OccupiedDownSeat(DownTrip) = OccupiedDownSeat(DownTrip) + NumOfPassenger
            TotalDownSeats(DownTrip) = TotalDownSeats(DownTrip) - NumOfPassenger

            Cost = NumOfPassenger * OneWayTicket

            Discount = Cost - (OneWayTicket * (NumOfPassenger \ 10))
            'integer division for discount of every 10th passengers

            TwoWayTickets = Discount * 2
            'you have to buy ticket for Uptrip and Downtrip

            UpTrainMoney(UpTrip) = UpTrainMoney(UpTrip) + Discount
            DownTrainMoney(DownTrip) = DownTrainMoney(DownTrip) + Discount
            TotalAmount = TotalAmount + UpTrainMoney(UpTrip) + DownTrainMoney(DownTrip)

            'For Task3
            Console.Clear()

            For Count = 0 To 3
                If (Count = 0) Then
                    Console.WriteLine("Train Number " & "Departure" & " Seat's Avaliable" & " Occupied Seat's" & " Money Collected")
                    Console.WriteLine("------------ " & "---------" & " " & "----------------" & " " & "---------------" & " " & "---------------")
                End If
                If Not (TotalUpSeats(Count) <> 0) Then
                    Avaliability = "Train is Full"
                Else
                    Avaliability = "Seat's Avaliable"
                End If
                If (OccupiedUpSeat(Count) < 10) Then
                    Console.WriteLine(Left(Space, 5) & 1 & Left(Space, 7) & TrainTimeUP(Count) & Left(Space, 5) & TotalUpSeats(Count) & Left(Space, 14) & OccupiedUpSeat(Count) & Left(Space, 15) & UpTrainMoney(Count) & Avaliability)
                Else
                    If (OccupiedUpSeat(Count) >= 10 And OccupiedUpSeat(Count) < 100) Then
                        Console.WriteLine(Left(Space, 5) & 1 & Left(Space, 7) & TrainTimeUP(Count) & Left(Space, 5) & TotalUpSeats(Count) & Left(Space, 14) & OccupiedUpSeat(Count) & Left(Space, 14) & UpTrainMoney(Count) & Avaliability)
                    Else
                        Console.WriteLine(Left(Space, 5) & 1 & Left(Space, 7) & TrainTimeUP(Count) & Left(Space, 5) & TotalUpSeats(Count) & Left(Space, 14) & OccupiedUpSeat(Count) & Left(Space, 13) & UpTrainMoney(Count) & Avaliability)
                    End If
                End If

                'If (Len(TotalUpSeats(Count) = 3)) Then
                '    Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count) & Left(Space, 13) & Format(UpTrainMoney(Count), "0    "))
                'Else
                '    If (Len(TotalUpSeats(Count) = 2)) Then
                '        Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count) & Left(Space, 14) & Format(UpTrainMoney(Count), "0    "))
                '    Else
                '        Console.WriteLine(Right(Space, 5) & Count + 1 & Right(Space, 7) & TrainTimeUP(Count) & Right(Space, 5) & TotalUpSeats(Count) & Right(Space, 14) & OccupiedUpSeat(Count) & Left(Space, 15) & Format(UpTrainMoney(Count), "0    "))
                '    End If
                'End If
            Next Count

            Console.WriteLine()
            For Count = 0 To 3
                If (Count = 0) Then
                    Console.WriteLine("Train Number " & "Arrival " & "Seat's Avaliable" & " Occupied Seat's" & " Money Collected")
                    Console.WriteLine("------------ " & "------- " & "----------------" & " " & "---------------" & " " & "---------------")
                End If
                If Not (TotalUpSeats(Count) <> 0) Then
                    Avaliability = "Train is Full"
                Else
                    Avaliability = "Seat's Avaliable"
                End If
                If (OccupiedDownSeat(Count) < 10) Then
                    Console.WriteLine(Left(Space, 5) & 1 & Left(Space, 7) & TrainTimeDown(Count) & Right(Space, 3) & TotalDownSeats(Count) & Right(Space, 14) & OccupiedDownSeat(Count) & Left(Space, 15) & DownTrainMoney(Count) & Avaliability)
                Else
                    If (OccupiedDownSeat(Count) >= 10 And OccupiedDownSeat(Count) < 100) Then
                        Console.WriteLine(Left(Space, 5) & 1 & Left(Space, 7) & TrainTimeDown(Count) & Right(Space, 3) & TotalDownSeats(Count) & Right(Space, 14) & OccupiedDownSeat(Count) & Left(Space, 14) & DownTrainMoney(Count) & Avaliability)
                    Else
                        Console.WriteLine(Left(Space, 5) & 1 & Left(Space, 7) & TrainTimeDown(Count) & Right(Space, 3) & TotalDownSeats(Count) & Right(Space, 14) & OccupiedDownSeat(Count) & Left(Space, 13) & DownTrainMoney(Count) & Avaliability)
                    End If
                End If
            Next Count

            'For Count = 0 To 3
            'Console.WriteLine("Train Num: " & Count & "Train Time Up: " & TrainTimeUP(Count) & "Total Seats Up: " & TotalUpSeats(Count) & "Occupied Seats: " & OccupiedUpSeat(Count))
            'Console.WriteLine("Train Num: " & Count & "Train Time Down: " & TrainTimeDown(Count) & "total Seats Down: " & TotalDownSeats(Count) & "Occupied Seats: " & OccupiedDownSeat(Count))
            'Console.WriteLine("DownTrain Money = " & DownTrainMoney(Count))

            'If TotalUpSeats(Count) = 0 Then
            '    Console.WriteLine(TrainTimeUP(Count) & " : Train is FULL : booking CLOSED")
            'Else
            '    Console.WriteLine(TrainTimeUP(Count) & " : Seats Available : booking OPEN")
            'End If
            'Console.WriteLine("----------------------------------------")

            'If TotalDownSeats(Count) = 0 Then
            '    Console.WriteLine(TrainTimeDown(Count) & " : Train is FULL : booking CLOSED")
            'Else
            '    Console.WriteLine(TrainTimeDown(Count) & " : Seats Available : booking OPEN")
            'End If
            'Console.WriteLine("----------------------------------------")
            'Next
            Console.WriteLine("Do you want to buy more tickets? True for yes and False for no")
            Choice = UCase(Console.ReadLine())
        End While

        'task 3
        Dim MaxTrainUp As String
        Dim MaxTrainDown As String
        Console.Clear()
        Console.WriteLine("------ END OF THE DAY ----------")
        For Count = 0 To 3
            If OccupiedUpSeat(Count) > MaxPassengerTrain(Count) Then
                MaxPassengerTrain(Count) = MaxPassengerTrain(Count) + OccupiedUpSeat(Count)
                MaxTrainUp = TrainTimeUP(Count)
            End If

            Console.WriteLine("----------------------------------------")
            Console.WriteLine("Train Num: " & Count & " Train Time Up: " & TrainTimeUP(Count) & " total seats down: " & TotalUpSeats(Count) & " occupied seats: " & OccupiedUpSeat(Count))
            Console.WriteLine("UPtrain Money = " & UpTrainMoney(Count))
            Console.WriteLine("Train Num: " & Count & " train time up: " & TrainTimeDown(Count) & " total seats down: " & TotalDownSeats(Count) & " occupied seats: " & OccupiedDownSeat(Count))
            Console.WriteLine("DownTrain Money = " & DownTrainMoney(Count))
            Console.WriteLine("----------------------------------------")
        Next
        Console.WriteLine("Total Money Earned Today: " & TotalAmount)
        Console.WriteLine("Total Passengers Travalled TODAY: " & TotalPassengers)
        Console.WriteLine("Maxtrain Passengers Train Upwards: " & MaxTrainUp)
        Console.WriteLine("Maxtrain Passengers Train Downwards: " & MaxTrainDown)
        Console.ReadKey()

    End Sub
End Module
