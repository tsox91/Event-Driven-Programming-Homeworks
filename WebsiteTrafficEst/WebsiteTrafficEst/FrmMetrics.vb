' Program Name: Website Traffic Metric
' Author:       Tori Sox
' Date:         March 24, 2019
' Purpose:      The Website Traffic Metric program determines 
'               how much time is being spent on the opening 
'               page by computing the average.
'               The average website metric is then displayed in seconds

Option Strict On

Public Class FrmMetrics
    Private Sub btnAnalytics_Click(sender As Object, e As EventArgs) Handles btnAnalytics.Click

        ' The  btnAnalytics_Click event accepts and displays up to 12 time values 
        ' and then calculates and displays the average seconds spent on the opening page

        ' Declare and initialize variables: 
        Dim strTimeSpent As String
        Dim decTimeSpent As Decimal
        Dim decAverageTime As Decimal
        Dim decTotalTimeSpent As Decimal = 0D
        Dim strInputMessage As String = "Enter the number of seconds for visitor #"
        Dim strInputHeading As String = "Visitor Analytics"
        Dim strNormalMessage As String = "Enter the number of seconds for visitor #"
        Dim strNonNumericError As String = "Error - Enter a number for the number of seconds for visitor #"
        Dim strNegativeError As String = "Error - Enter a positive number for the number of seconds for visitor #"

        ' Declare and initialize loop variables:
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the seconds of up to 12 visitors.
        ' The loop terminates when the user has entered 12 values or the user 
        ' taps or clicks the Cancel button or the Close button in the InputBox


        ' *** Creates the initial input box for the first entry
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        strTimeSpent = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '*** In this declaration, you see strInputMessage -> this is changed in order to alert the user of errors
        'See below

        ' *** Continues in a loop until either the # of entries is larger than max, or the user cancels the input
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strTimeSpent = strCancelClicked

            ' *** Only continues if the entry is a numeric value
            If IsNumeric(strTimeSpent) Then
                decTimeSpent = Convert.ToDecimal(strTimeSpent)    ' *** Converts the value to a decimal value (float-like)
                '***Adds only if number if positive
                If decTimeSpent > 0 Then

                    '*** adds entry to ListBox item
                    '''''''''''''''''''''''''''''''''''''''''''
                    lstSeconds.Items.Add(decTimeSpent)
                    '''''''''''''''''''''''''''''''''''''''''''

                    decTotalTimeSpent += decTimeSpent '*** adds the decimal entry to the total sum of current entries
                    intNumberOfEntries += 1             '*** Increments the number of entries given
                    strInputMessage = strNormalMessage
                    ' *** Does not add if negative
                Else
                    strInputMessage = strNegativeError
                End If
                '*** Entry is not numeric
            Else
                strInputMessage = strNonNumericError
            End If

            If intNumberOfEntries <= intMaxNumberOfEntries Then

                '*** Creates another input box as long as the number of entries is less than the number of max entries
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                strTimeSpent = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            End If

        Loop


        'Calculates and displays average total time spent
        If intNumberOfEntries > 1 Then
            lblAverageTime.Visible = True
            decAverageTime = decTotalTimeSpent / (intNumberOfEntries - 1)
            lblAverageTime.Text = "Average Time Spent: " &
            decAverageTime.ToString("F2") & " Seconds"
        Else
            MsgBox("No time value entered")
        End If

        ' Disables the Visitor Analytics button
        btnAnalytics.Enabled = False



    End Sub


End Class
