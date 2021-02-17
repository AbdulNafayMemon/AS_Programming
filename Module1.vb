Module Module1
    Dim MemID, Menu As Integer
    Dim Name, Telephone As String
    Dim Search As String
    Dim IsFound As Integer
    Dim Start As Date



    Sub Main()
        Console.WriteLine("MENU:")
        Console.WriteLine("1. CREATE A NEW FILE")
        Console.WriteLine("2. OUTPUT ALL RESULTS")
        Console.WriteLine("3. SEARCH FOR A RECORD")
        Console.WriteLine("4. ADD NEW RECORDS")
        Console.WriteLine("5. ADD NEW FIELDS")
        Console.WriteLine("0. EXIT")

        Menu = 1
        While Menu = 1 Or Menu = 2 Or Menu = 3 Or Menu = 4 Or Menu = 5
            Do
                Console.Write("Enter Your Choice: ")
                Menu = Console.ReadLine
                If Menu < 0 Or Menu > 6 Then
                    Console.WriteLine("INVALID CHOICE")
                End If
            Loop Until Menu > -1 And Menu < 6




            If Menu > 0 And Menu < 6 Then
                If Menu = 1 Then Call Task1()
                If Menu = 2 Then Call Task2()
                If Menu = 3 Then Call Task3()
                If Menu = 4 Then Call Task4()
                If Menu = 5 Then Call Task5()
            End If
        End While

    End Sub

    Sub Task1()

        'TASK 1.1 (INPUT)

        FileOpen(1, "D:\STUDY MATERIAL\SportsClub.txt", OpenMode.Output)

        Do
            Console.Write("Enter Name (Enter empty to Exit) : ")
            Name = Console.ReadLine
            If Name = "" Then

            Else
                Console.Write("Enter Membership ID: ")
                MemID = Console.ReadLine

                WriteLine(1, Name)

                WriteLine(1, MemID)

            End If

        Loop Until Name = ""

        FileClose(1)

        Console.WriteLine("Press Enter to Continue")
        Console.ReadKey()

    End Sub
    Sub Task2()




        'TASK 1.2 (OUTPUT)

        FileOpen(1, "D:\STUDY MATERIAL\SportsClub.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, Name)
            Input(1, MemID)

            Console.WriteLine("Name: " & Name)
            Console.WriteLine("Membership ID: " & MemID)

        End While

        FileClose(1)

        Console.WriteLine("Press Enter to Continue")

        Console.ReadKey()

    End Sub
    Sub Task3()

        'TASK 1.3 (SEARCH)

        IsFound = False

        Console.Write("Search for :")
        Search = Console.ReadLine


        FileOpen(1, "D:\STUDY MATERIAL\SportsClub.txt", OpenMode.Input)

        Do
            Input(1, Name)
            Input(1, MemID)
            If UCase(Search) = UCase(Name) Then
                IsFound = True
                Console.WriteLine("Corresponding ID Number: " & MemID)
            End If
        Loop Until EOF(1) = True

        If IsFound = False Then
            Console.WriteLine("Record not Found")
        End If

        Console.WriteLine("Press Enter to Continue")
        Console.ReadKey()

        FileClose(1)

    End Sub


    Sub Task4()

        'TASK 1.4 (APPEND)

        FileOpen(1, "D:\STUDY MATERIAL\SportsClub.txt", OpenMode.Append)

        Do
            Console.Write("Enter Name (Enter empty to Exit) : ")
            Name = Console.ReadLine
            If Name = "" Then

            Else
                Console.Write("Enter Membership ID: ")
                MemID = Console.ReadLine

                WriteLine(1, Name)

                WriteLine(1, MemID)

            End If

        Loop Until Name = ""

        FileClose(1)

        Console.WriteLine("Press Enter to Continue")
        Console.ReadKey()

    End Sub

    Sub Task5()

        'Task 1.5 (ADD NEW FEILDS)

        FileOpen(2, "D:\STUDY MATERIAL\Temp.txt", OpenMode.Output)
        FileOpen(1, "D:\STUDY MATERIAL\SportsClub.txt", OpenMode.Input)

            While Not EOF(1)
                Input(1, Name)
                Input(1, MemID)

                Console.WriteLine("Name: " & Name)
                Console.WriteLine("Membership ID: " & MemID)


                Console.Write("Enter Telephone Number: ")
                Telephone = Console.ReadLine

                Console.Write("Enter Membership Start Date: ")
                Start = Console.ReadLine

                WriteLine(2, Name)
                WriteLine(2, MemID)
                WriteLine(2, Name)
                WriteLine(2, MemID)

            End While

        My.Computer.FileSystem.DeleteFile("D:\STUDY MATERIAL\SportsClub.txt")
        My.Computer.FileSystem.RenameFile("D:\STUDY MATERIAL\Temp.txt", "Sportsclub.txt")


        FileClose(1)
        FileClose(2)

            Console.WriteLine("Press Enter to Continue")
            Console.ReadKey()




    End Sub





End Module
