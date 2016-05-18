Public Class MainWindow

    Dim ObjDb As New VideoRentalDataBaseManager





    Private Sub txtCustomerFirstName_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCustomerFirstName.TextChanged


        DGCustomers.ItemsSource = Nothing



        Dim FirstName As String = txtCustomerFirstName.Text
        Dim LastName As String = txtCustomerLastName.Text
        Dim Address As String = txtAddress.Text
        Dim Phone As String = txtPhone.Text

        DGCustomers.ItemsSource = ObjDb.SearchCustomers(FirstName, LastName, Address, Phone).DefaultView

    End Sub

    Private Sub txtCustomerLastName_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCustomerLastName.TextChanged

        DGCustomers.ItemsSource = Nothing



        Dim FirstName As String = txtCustomerFirstName.Text
        Dim LastName As String = txtCustomerLastName.Text
        Dim Address As String = txtAddress.Text
        Dim Phone As String = txtPhone.Text

        DGCustomers.ItemsSource = ObjDb.SearchCustomers(FirstName, LastName, Address, Phone).DefaultView

    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtAddress.TextChanged

        DGCustomers.ItemsSource = Nothing



        Dim FirstName As String = txtCustomerFirstName.Text
        Dim LastName As String = txtCustomerLastName.Text
        Dim Address As String = txtAddress.Text
        Dim Phone As String = txtPhone.Text

        DGCustomers.ItemsSource = ObjDb.SearchCustomers(FirstName, LastName, Address, Phone).DefaultView

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtPhone.TextChanged

        DGCustomers.ItemsSource = Nothing



        Dim FirstName As String = txtCustomerFirstName.Text
        Dim LastName As String = txtCustomerLastName.Text
        Dim Address As String = txtAddress.Text
        Dim Phone As String = txtPhone.Text

        DGCustomers.ItemsSource = ObjDb.SearchCustomers(FirstName, LastName, Address, Phone).DefaultView

    End Sub



    Private Sub txtTitle_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtTitle.TextChanged


        DGCustomers.ItemsSource = Nothing

        Dim Rating As String = txtRating.Text
        Dim Title As String = txtTitle.Text
        Dim Rental_Cost As String = txtCost.Text
        Dim YearOfRelease As String = txtRelease.Text
        Dim Copies As String = txtCopies.Text
        Dim Genre As String = txtGenre.Text
        Dim Plot As String = "*"

        DGCustomers.ItemsSource = ObjDb.SearchMovies(Rating, Title, YearOfRelease, Rental_Cost, Copies, Plot, Genre).DefaultView







    End Sub

    Private Sub txtRating_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtRating.TextChanged


        DGCustomers.ItemsSource = Nothing

        Dim Rating As String = txtRating.Text
        Dim Title As String = txtTitle.Text
        Dim Rental_Cost As String = txtCost.Text
        Dim YearOfRelease As String = txtRelease.Text
        Dim Copies As String = txtCopies.Text
        Dim Genre As String = txtGenre.Text
        Dim Plot As String = "*"

        DGCustomers.ItemsSource = ObjDb.SearchMovies(Rating, Title, YearOfRelease, Rental_Cost, Copies, Plot, Genre).DefaultView



    End Sub

    Private Sub txtRelease_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtRelease.TextChanged


        DGCustomers.ItemsSource = Nothing

        Dim Rating As String = txtRating.Text
        Dim Title As String = txtTitle.Text
        Dim Rental_Cost As String = txtCost.Text
        Dim YearOfRelease As String = txtRelease.Text
        Dim Copies As String = txtCopies.Text
        Dim Genre As String = txtGenre.Text
        Dim Plot As String = "*"

        DGCustomers.ItemsSource = ObjDb.SearchMovies(Rating, Title, YearOfRelease, Rental_Cost, Copies, Plot, Genre).DefaultView


    End Sub

    Private Sub txtGenre_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtGenre.TextChanged

        DGCustomers.ItemsSource = Nothing

        Dim Rating As String = txtRating.Text
        Dim Title As String = txtTitle.Text
        Dim Rental_Cost As String = txtCost.Text
        Dim YearOfRelease As String = txtRelease.Text
        Dim Copies As String = txtCopies.Text
        Dim Genre As String = txtGenre.Text
        Dim Plot As String = "*"

        DGCustomers.ItemsSource = ObjDb.SearchMovies(Rating, Title, YearOfRelease, Rental_Cost, Copies, Plot, Genre).DefaultView



    End Sub

    Private Sub txtCopies_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCopies.TextChanged


        DGCustomers.ItemsSource = Nothing

        Dim Rating As String = txtRating.Text
        Dim Title As String = txtTitle.Text
        Dim Rental_Cost As String = txtCost.Text
        Dim YearOfRelease As String = txtRelease.Text
        Dim Copies As String = txtCopies.Text
        Dim Genre As String = txtGenre.Text
        Dim Plot As String = "*"

        DGCustomers.ItemsSource = ObjDb.SearchMovies(Rating, Title, YearOfRelease, Rental_Cost, Copies, Plot, Genre).DefaultView



    End Sub

    Private Sub btnAddMovie_Click(sender As Object, e As RoutedEventArgs) Handles btnAddMovie.Click


        If DGCustomers.Items.Count >= 1 Then
            'MsgBox("no of rows:    " & DGCustomers.Items.Count)
            MsgBox("Movie is already in Database!")
        Else
            Dim Rating As String = txtRating.Text
            Dim Title As String = txtTitle.Text
            Dim Rental_Cost As String = txtCost.Text
            Dim YearOfRelease As String = txtRelease.Text
            Dim Copies As String = txtCopies.Text
            Dim Genre As String = txtGenre.Text
            Dim Plot As String = "*"

            ObjDb.AddMovie(Rating, Title, YearOfRelease, Rental_Cost, Copies, Plot, Genre)
        End If


    End Sub



    Private Sub btnAddCustomer_Click(sender As Object, e As RoutedEventArgs) Handles btnAddCustomer.Click

        If DGCustomers.Items.Count >= 1 Then
            'MsgBox("no of rows:    " & DGCustomers.Items.Count)
            MsgBox("Customer is already in Database!")
        Else

            Dim FirstName As String = txtCustomerFirstName.Text
            Dim LastName As String = txtCustomerLastName.Text
            Dim Address As String = txtAddress.Text
            Dim Phone As String = txtPhone.Text

            ObjDb.AddCustomer(FirstName, LastName, Address, Phone)
        End If

    End Sub

    Private Sub btnDeleteMovie_Click(sender As Object, e As RoutedEventArgs) Handles btnDeleteMovie.Click
        Dim Title As String = txtTitle.Text
        Dim MovieID As Integer = txtMovieID.Text

        ObjDb.DeleteMovie(Title, MovieID)
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As RoutedEventArgs) Handles btnDeleteCustomer.Click
        Dim FirstName As String = txtCustomerFirstName.Text
        Dim LastName As String = txtCustomerLastName.Text
        Dim CustID As Integer = txtCustomerID.Text

        ObjDb.DeleteCustomer(FirstName, LastName, CustID)
    End Sub
End Class
