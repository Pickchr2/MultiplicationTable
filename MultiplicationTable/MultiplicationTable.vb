'Christopher Pickens
'RCET0265
'Spring 2023
'Multiplication Table
'https://github.com/Pickchr2/MultiplicationTable.git

Option Explicit On
Option Strict On
Option Compare Text

Imports System

Module MultiplicationTable
    Sub Main(args As String())
        Dim userInput As String = ""
        Dim userNumber As Integer
        Dim userQuits As Boolean = False
        Dim product As Integer
        Dim displayTable As String

        Do Until userQuits = True
            Console.WriteLine("Please enter a whole number to see its entire multiplication table. Press " & Chr(34) & "Q" & Chr(34) & " at anytime to quit.")
            userInput = (Console.ReadLine())
            Select Case userInput
                Case "Q"
                    userQuits = True
                Case Else
                    Try
                        userNumber = CInt(userInput)
                    Catch ex As Exception
                        Console.WriteLine($"Sorry {userInput} isn't a valid whole number")
                    End Try
            End Select

            If userQuits = False Then
                For i As Integer = 1 To userNumber
                    For x As Integer = 1 To userNumber
                        Console.Write(i * x & " ")
                    Next
                    Console.WriteLine("")
                Next
            End If
        Loop
    End Sub
End Module
