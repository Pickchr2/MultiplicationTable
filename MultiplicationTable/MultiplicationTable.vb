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
                        userInput = ""
                    End Try
            End Select

            If userQuits = False And userInput <> "" Then
                Console.WriteLine("")
                Console.WriteLine($"Here is the multiplication table for {userNumber}.")
                Console.WriteLine("")
                For i As Integer = 1 To userNumber
                    For x As Integer = 1 To userNumber
                        Console.Write(String.Format("{0,5}", i * x))
                    Next
                    Console.WriteLine("")
                Next
                Console.WriteLine("")
            End If
        Loop
    End Sub
End Module
