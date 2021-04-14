Option Strict On
Option Explicit On

Imports System.Threading
Imports System.IO

'Taylor Herndon
'RCET0265
'Spring 2021
'FortuneCookie
'https://github.com/TaylorHerndon/FortuneCookie

Module FortuneCookie

    Sub Main()

        Randomize()

        Dim randomNumber As Integer = Nothing
        Dim fortunes As New StreamReader("Fortunes.txt")
        Dim fortunesArray(358) As String
        Dim arrayIndex As Integer = 0
        Dim proceed As Boolean = False

        'Throw up some ASCII art of a fortune cookie because it's cool
        AsciiArt.Cookie()
        Thread.Sleep(4000)
        Console.Clear()

        'Intro to the program
        Console.WriteLine("Hello friend!")
        Thread.Sleep(1000)
        Console.WriteLine("Here, take a cookie!")
        Thread.Sleep(1500)
        Console.WriteLine("[Press any key to take the fortune cookie.]")
        Console.ReadKey()

        Console.Clear()
        Console.WriteLine("Crunch!")
        Thread.Sleep(1000)
        Console.WriteLine("What's your fortune?")
        Thread.Sleep(1000)
        Console.WriteLine("[Press any key to read your fortune.]")
        Console.ReadKey()
        Console.Clear()

        'Fortunes were taken from https://joshmadison.com/2008/04/20/fortune-cookie-fortunes/
        'Total fortunes: 358

        'Take all of the fortines from the Fortunes.txt file and index them into an array for easy access
        Do Until fortunes.Peek = -1

            fortunesArray(arrayIndex) = fortunes.ReadLine()
            arrayIndex = arrayIndex + 1

        Loop

        'Get a random number and use it as the index for the fortune array.
        randomNumber = Convert.ToInt32(VBMath.Rnd * 357 + 1)
        Console.WriteLine(FortunesArray(RandomNumber))
        Thread.Sleep(2500)
        Console.WriteLine("[Press any key to continue...]")
        Console.ReadKey()

        'Allow the user to get a new fortune if they want
        Do Until proceed = True

            Console.Clear()
            Console.WriteLine("Do you want another cookie?")
            Console.WriteLine("Y - N")

            Select Case Console.ReadKey.Key

                Case ConsoleKey.Y

                    'Same as earlier, get a random number and use it as the index for the fortune array
                    Console.Clear()
                    Console.WriteLine("Crunch!")
                    Thread.Sleep(1000)
                    randomNumber = Convert.ToInt32(VBMath.Rnd * 357 + 1)
                    Console.WriteLine(fortunesArray(randomNumber))
                    Thread.Sleep(2000)
                    Console.WriteLine(vbNewLine & "[Press any key to continue...]")
                    Console.ReadKey()
                    proceed = False

                Case ConsoleKey.N

                    proceed = True

                Case Else

                    proceed = False

            End Select

        Loop

        Console.Clear()
        Console.WriteLine("Goodbye! :)")
        Thread.Sleep(2000)

    End Sub

End Module
