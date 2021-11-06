Public Class StudentBookSale
    Inherits BookSale
    ' Inherits statements brings in
    ' ALL public properties
    ' ALL public methods, EXCEPT the constructor
    ' Does NOT bring in anything PRIVATE
    ' ALL protected properties/methods are brought over

    Const DISCOUNT_RATE_DECIMAL As Decimal = 0.15D

    ' Constructors
    Public Sub New(TitleString As String,
                   QuantityInteger As Integer,
                   PriceDecimal As Decimal)
        ' When we have to recreate a constructor from the base class
        ' We have to call the constructor from the base class
        ' Must be the FIRST thing we do
        ' I have access to anyhting marked as public in the base class
        MyBase.New(TitleString, QuantityInteger, PriceDecimal)


    End Sub

    ' Properties
    Public Shared Property DiscountTotal As Decimal

    ' Methods

    Protected Overrides Sub CalculateExtendedPrice()
        Dim DiscountDecimal As Decimal

        DiscountDecimal = Quantity * Price * DISCOUNT_RATE_DECIMAL
        ExtendedPrice = (Quantity * Price) - DiscountDecimal
        ' Increment the totals
        DiscountTotal += DiscountDecimal

    End Sub
End Class
