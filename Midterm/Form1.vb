
'MIS 322
'Damanbir Singh
'Midterm
'10/25/2022

Option Explicit On
Option Strict On

Public Class Form1

    Private positionSequence As Integer
    Private min As Integer
    Private max As Integer
    Private numberSpot As Integer

    Private Sub midterm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set backcolor and disable analyze button

        BackColor = Color.Red
        analyzeButton.Enabled = False
    End Sub

    Private Sub positionButton_Click(sender As Object, e As EventArgs) Handles positionButton.Click
        'input the position of the line

        Dim input As Integer
        Dim message As String

        input = Convert.ToInt32(InputBox("Enter position in sequence", "Enter number", "0"))
        If input > 0 Then
            positionText.Text = input.ToString
        Else
            message = "Input must be a positive integer"
            MessageBox.Show(message, "Invalid entry")
            Exit Sub
        End If
        positionSequence = input
        analyzeButton.Enabled = True
        resultText.Clear()


    End Sub

    Private Sub analyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click
        'analyze and make the proper calculations to show result in textbox

        Dim message As String

        resultText.Clear()
        Try
            min = Convert.ToInt32(minimumText.Text)
            max = Convert.ToInt32(maximumText.Text)
            If max <= min Then
                message = "Max must be greater than min"
                MessageBox.Show(message, "Error")
            End If
        Catch fe As FormatException
            message = "Numbers are not valid"
            MessageBox.Show(message, "Invalid numbers")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try


        resultText.Text = min.ToString
        min += 1

        Do While min <= max
            resultText.Text = resultText.Text & ", " & min.ToString
            min += 1
        Loop

        positionSequence = Convert.ToInt32(maximumText.Text) - Convert.ToInt32(minimumText.Text) + 1

        resultText.Text = resultText.Text & vbNewLine & vbNewLine & "Count: " & positionSequence.ToString & " numbers in sequence"

        numberSpot = Convert.ToInt32(minimumText.Text) + Convert.ToInt32(positionText.Text) - 1

        If numberSpot <= Convert.ToInt32(maximumText.Text) Then
            resultText.Text = resultText.Text & vbNewLine & "Number in spot " & positionText.Text &
                    ":" & numberSpot
        ElseIf numberSpot > Convert.ToInt32(maximumText.Text) Then
            resultText.Text = resultText.Text & vbNewLine & "Number in spot " & positionText.Text &
                    " not contained in sequence."
        End If



    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        'reset the form

        minimumText.Clear()
        maximumText.Clear()
        positionText.Clear()
        resultText.Clear()
        minimumText.Select()
        analyzeButton.Enabled = False
    End Sub
End Class
