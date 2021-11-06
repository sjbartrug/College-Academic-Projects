'Program:		Lab #7
'Programmer:	Sam Bartrug
'Date:			11/4/20
'Description:	To calculate a custom sale

Public Class BookSale

    ' Constructors
    ' ALWAYS a default constructor built for us
    Public Sub New(inTitle As String, inQuantity As Integer, inPrice As Decimal)
        ' Overloaded constructor
        ' Set our properties based on the arguments passed in
        Title = inTitle
        ' Setting the private variable directly, potentially bypasses business logic. BAD
        ' QuantityInteger = inQuantity ' Changing the private instance variable directly
        Quantity = inQuantity ' using the public property to change the instance variable
        Price = inPrice

        ' Computer our extended price
        CalculateExtendedPrice()
        ' Add to totals
        AddToTotals()

    End Sub

    ' Properties
    Private QuantityInteger As Integer
    Private PriceDecimal, ExtendedPriceDecimal As Decimal
    Private Shared SalesCountInteger As Integer
    Public Shared Property SalesTotal As Decimal ' Auto implemented shared property
    ' ALL properties are public by default
    Public Property Quantity As Integer
        Get
            ' Messagebox.show(obj.quantity)
            ' Retrieve the private instance variable value
            Return QuantityInteger
        End Get
        Set(value As Integer)
            ' obj.Quantity = 100
            ' Change the private instance variable
            If value <= 0 Then
                Throw New ArgumentOutOfRangeException("Quantity must be a positive integer.")
            End If
            QuantityInteger = value
        End Set
    End Property
    Public Property Title As String ' Auto implemented property
    ' Created private _Title as string , the GET and SET
    Property Price As Decimal
        Get
            ' msgbox(obj.price)
            Return PriceDecimal
        End Get
        Set(value As Decimal)
            ' obj.price = 100
            If value < 0 Then
                Throw New ArgumentOutOfRangeException("Your price must be greater than zero.")
            End If

            PriceDecimal = value
        End Set
    End Property
    Public ReadOnly Property ExtendedPrice As Decimal
        Get
            Return ExtendedPriceDecimal
        End Get
    End Property
    Shared Property SalesCount As Integer
        Get
            Return SalesCountInteger
        End Get
        Set(value As Integer)
            SalesCountInteger = value
        End Set
    End Property
    ' Methods

    Private Sub CalculateExtendedPrice()
        ' Calculate extended price
        ' Has access to all public and private variables and methods in this class
        ' ExtendedPrice = Quantity * Price ' Read only can't change
        ExtendedPriceDecimal = Quantity * Price
    End Sub

    Private Sub AddToTotals()
        ' Add to summary
        SalesCount += 1

        SalesTotal += ExtendedPrice
    End Sub

End Class
