' Program Name: Computer Salary Application
' Author:       Tori Sox
' Date:         March 31, 2019
' Purpose:      User selects occupation from drop down menu, and the U.S. 
'               hourly mean wage And annual mean wage, And future pay increase Is calculated
Option Strict On


Public Class frmSalaries

    Private index As Integer = 0

    Private Sub cboOccupation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOccupation.SelectedIndexChanged

        Dim intJobChoice As Integer

        intJobChoice = cboOccupation.SelectedIndex
        Select Case intJobChoice
            Case 0
                index = 0
                'CompDev()
            Case 1
                index = 1
                'SysAnalyst()
            Case 2
                index = 2
                'CompAndInfo()
            Case 3
                index = 3
                'SoftwareEngineer()
        End Select

        btnFindPay.Visible = True
        btnClear.Visible = True

    End Sub

    Private Sub CompDev()
        Dim decHourly As Decimal = 48.04D
        Dim decYearly As Decimal = 104480D
        Dim dblHourlyIncrease As Double = decHourly * (1.04 * 1.04 * 1.04 * 1.04 * 1.04)
        Dim dblYearlyIncrease As Double = decYearly * (1.04 * 1.04 * 1.04 * 1.04 * 1.04)

        lblHourlyPay.Text = "Median Hourly: $" & decHourly.ToString()
        lblYearlyPay.Text = "Yearly: $" & decYearly.ToString()
        lblHourlyIncrease.Text = "Hourly 5-Year Estimate: $" & dblHourlyIncrease.ToString("F2")
        lblYearlyIncrease.Text = "Yearly 5-Year Estimate: $" & dblYearlyIncrease.ToString("F2")

    End Sub
    Private Sub SysAnalyst()
        Dim decHourly As Decimal = 42.66D
        Dim decYearly As Decimal = 93610D
        Dim dblHourlyIncrease As Double = decHourly * (1.04 * 1.04 * 1.04 * 1.04 * 1.04)
        Dim dblYearlyIncrease As Double = decYearly * (1.04 * 1.04 * 1.04 * 1.04 * 1.04)

        lblHourlyPay.Text = "Median Hourly: $" & decHourly.ToString()
        lblYearlyPay.Text = "Yearly: $" & decYearly.ToString()
        lblHourlyIncrease.Text = "Hourly 5-Year Estimate: $" & dblHourlyIncrease.ToString("F2")
        lblYearlyIncrease.Text = "Yearly 5-Year Estimate: $" & dblYearlyIncrease.ToString("F2")

    End Sub
    Private Sub CompAndInfo()
        Dim decHourly As Decimal = 68.53D
        Dim decYearly As Decimal = 152860D
        Dim dblHourlyIncrease As Double = decHourly * (1.04 * 1.04 * 1.04 * 1.04 * 1.04)
        Dim dblYearlyIncrease As Double = decYearly * (1.04 * 1.04 * 1.04 * 1.04 * 1.04)

        lblHourlyPay.Text = "Median Hourly: $" & decHourly.ToString()
        lblYearlyPay.Text = "Yearly: $" & decYearly.ToString()
        lblHourlyIncrease.Text = "Hourly 5-Year Estimate: $" & dblHourlyIncrease.ToString("F2")
        lblYearlyIncrease.Text = "Yearly 5-Year Estimate: $" & dblYearlyIncrease.ToString("F2")


    End Sub
    Private Sub SoftwareEngineer()
        Dim decHourly As Decimal = 49.82D
        Dim decYearly As Decimal = 108080D
        Dim dblHourlyIncrease As Double = decHourly * (1.04 * 1.04 * 1.04 * 1.04 * 1.04)
        Dim dblYearlyIncrease As Double = decYearly * (1.04 * 1.04 * 1.04 * 1.04 * 1.04)

        lblHourlyPay.Text = "Median Hourly: $" & decHourly.ToString()
        lblYearlyPay.Text = "Yearly: $" & decYearly.ToString()
        lblHourlyIncrease.Text = "Hourly 5-Year Estimate: $" & dblHourlyIncrease.ToString("F2")
        lblYearlyIncrease.Text = "Yearly 5-Year Estimate: $" & dblYearlyIncrease.ToString("F2")


    End Sub

    Private Sub btnFindPay_Click(sender As Object, e As EventArgs) Handles btnFindPay.Click
        Select Case index
            Case 0
                CompDev()
            Case 1
                SysAnalyst()
            Case 2
                CompAndInfo()
            Case 3
                SoftwareEngineer()
        End Select

        lblHourlyPay.Visible = True
        lblYearlyPay.Visible = True
        lblHourlyIncrease.Visible = True
        lblYearlyIncrease.Visible = True

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboOccupation.Text = "Select Occupation: "
        lblHourlyPay.Visible = False
        lblYearlyPay.Visible = False
        lblHourlyIncrease.Visible = False
        lblYearlyIncrease.Visible = False
        btnFindPay.Visible = False
        btnClear.Visible = False
    End Sub


End Class
