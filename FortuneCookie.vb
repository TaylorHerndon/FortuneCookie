﻿Option Strict On
Option Explicit On

Imports System.Threading
Imports System.IO

'Taylor Herndon
'RCET0265
'Spring 2021
'FortuneCookie
'

Module FortuneCookie

    Sub Main()

        Randomize()

        Dim RandomNumber As Integer = Nothing
        Dim Fortunes As New StreamReader("Fortunes.txt")
        Dim FortunesArray(358) As String
        Dim ArrayIndex As Integer = 0
        Dim Proceed As Boolean = False

        AsciiArt.Cookie()
        Thread.Sleep(4000)
        Console.Clear()

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

        Do Until Fortunes.Peek = -1

            FortunesArray(ArrayIndex) = Fortunes.ReadLine()
            ArrayIndex = ArrayIndex + 1

        Loop

        RandomNumber = Convert.ToInt32(VBMath.Rnd * 357 + 1)
        Console.WriteLine(FortunesArray(RandomNumber))
        Thread.Sleep(2500)
        Console.WriteLine("[Press any key to continue...]")
        Console.ReadKey()

        Do Until Proceed = True

            Console.Clear()
            Console.WriteLine("Do you want another cookie?")
            Console.WriteLine("Y - N")

            Select Case Console.ReadKey.Key

                Case ConsoleKey.Y

                    Console.Clear()
                    Console.WriteLine("Crunch!")
                    Thread.Sleep(1000)
                    RandomNumber = Convert.ToInt32(VBMath.Rnd * 357 + 1)
                    Console.WriteLine(FortunesArray(RandomNumber))
                    Thread.Sleep(2000)
                    Console.WriteLine(vbNewLine & "[Press any key to continue...]")
                    Console.ReadKey()
                    Proceed = False

                Case ConsoleKey.N

                    Proceed = True

                Case Else

                    Proceed = False

            End Select

        Loop

        Console.Clear()
        Console.WriteLine("Goodbye! :)")
        Thread.Sleep(2000)

    End Sub

End Module
