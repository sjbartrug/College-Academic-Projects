Imports Microsoft.VisualBasic
'Class Name: CalorieCalculator
'Programmer: Sam Bartrug
'Date: 12/2/20
'Description: Handle calorie counter information.
'Project: Homework 5

Public Class CalorieCalculator
    Private FatInteger As Integer
    Private CarbsInteger As Integer
    Private ProteinInteger As Integer
    Public Sub New(ByVal FatIn As Integer,
                   ByVal CarbsIn As Integer,
                   ByVal ProteinIn As Integer)
        ' Assign the property Values.
        Fat = FatIn
        Carbs = CarbsIn
        Protein = ProteinIn

    End Sub

    Property Fat() As Integer
        Get
            Return FatInteger
        End Get
        Set(ByVal Value As Integer)
            FatInteger = Value
        End Set
    End Property

    Property Carbs() As Integer
        Get
            Return CarbsInteger
        End Get
        Set(ByVal Value As Integer)
            CarbsInteger = Value
        End Set
    End Property

    Property Protein() As Integer
        Get
            Return ProteinInteger
        End Get
        Set(ByVal Value As Integer)
            ProteinInteger = Value
        End Set
    End Property

    Public Function CalculateCalories()
        ' Calculate the calories.

        Return (Fat * 9 + Carbs * 4 + Protein * 4)

    End Function
End Class
