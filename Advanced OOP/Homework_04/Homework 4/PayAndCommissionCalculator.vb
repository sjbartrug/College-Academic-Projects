'Program:		Homework_04
'Programmer:	Sam Bartrug
'Date:			11/11/20
'Description:	Calculate pay and commission using PayAndCommissionCalculator Class
'				Instantiate Calculator as a new object of the PayAndCommissionCalculator class.
Public Class PayAndCommissionCalculator
    Private NameString As String
    Private WeeklySalesDecimal, CommissionDecimal, PayDecimal As Decimal
    Private Shared TotalSalesDecimal, TotalCommissionDecimal, TotalPayDecimal As Decimal
    Const COMMISSION_RATE_DECIMAL As Decimal = 0.15
    Const BASE_PAY_DECIMAL As Decimal = 250
    ' Constructor
    Public Sub New(inName As String, inWeeklySales As Decimal)
        ' Input values into class
        Name = inName
        WeeklySales = inWeeklySales
        ' Calculates pay and adds to the totals
        FindPay()
        AddTotals()
    End Sub

    ' Properties
    Property Name() As String
        Get
            Return NameString
        End Get
        Set(ByVal Value As String)
            If Value.Length = 0 Then
                Throw New ArgumentOutOfRangeException("You must enter a name")
            End If
            NameString = Value
        End Set
    End Property

    Property WeeklySales() As Decimal
        Get
            Return WeeklySalesDecimal
        End Get
        Set(ByVal Value As Decimal)
            If Value < 0 Then
                Throw New ArgumentOutOfRangeException("You must enter a positive sales amount.")
            End If
            WeeklySalesDecimal = Value
        End Set
    End Property

    ReadOnly Property Commission As Decimal
        Get
            Return CommissionDecimal
        End Get
    End Property

    ReadOnly Property Pay As Decimal
        Get
            Return PayDecimal
        End Get
    End Property

    Shared ReadOnly Property TotalSales As Decimal
        Get
            Return TotalSalesDecimal
        End Get
    End Property

    Shared ReadOnly Property TotalCommission As Decimal
        Get
            Return TotalCommissionDecimal
        End Get
    End Property

    Shared ReadOnly Property TotalPay As Decimal
        Get
            Return TotalPayDecimal
        End Get
    End Property

    ' Methods
    Private Sub FindPay()
        ' If over the quota of 300 then a commission is applied otherwise a 0 is used and no commission is given
        If WeeklySales > 300 Then
            CommissionDecimal = CalculateCommission(WeeklySales)
        Else
            CommissionDecimal = CalculateCommission(0)
        End If
        ' Calculates the pay with the base pay and the calculated commission
        PayDecimal = BASE_PAY_DECIMAL + Commission
    End Sub

    Private Sub AddTotals()
        ' Adds each sales information onto the totals for the summary form
        TotalPayDecimal += Pay
        TotalCommissionDecimal += Commission
        TotalSalesDecimal += WeeklySales
    End Sub

    Private Function CalculateCommission(SalesDecimal) As Decimal
        ' Calculates the commission with the amount of sales * the commission rate
        Return (SalesDecimal * COMMISSION_RATE_DECIMAL)
    End Function
End Class
