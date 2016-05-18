


Imports System.Data.SqlClient
Imports System.Data


Public Class VideoRentalDataBaseManager







    Dim SqlConn As New SqlConnection("Data Source = shar;Initial Catalog=Gerry_2016;Integrated Security=True")

    Dim SqlStr As New SqlCommand
    Dim SqlReader As SqlDataReader
    Dim SqlStmt As String



    Public Sub AddMovie(Rating As String, Title As String, YearOfRelease As String, Rental_Cost As String, Copies As String, Plot As String, Genre As String)
        Try
            If Rating = "" Or Title = "" Or YearOfRelease = "" Or Copies = "" Or Genre = "" Then

                MsgBox("Please ensure the Rating, Title, Year Of Release, Number of Copies and Genre are Entered Correctly")

            Else
                'Check that movie is not already in the database
                'make use of search function
                'if so then msgbox("Movie already in Database") 'exit???
                'else 'continue

                If MsgBox("Are You Sure you wish to add: " & vbCrLf & vbCrLf & "Title: " & Title & vbCrLf & "Rating: " & Rating & vbCrLf & "Year of Release: " & YearOfRelease & vbCrLf & "Number of Copies: " & Copies & vbCrLf & "Genre: " & Genre, MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then



                    SqlStr.Connection = SqlConn
                    SqlStmt = "Insert into Movies(Rating, Title,Year,Copies,Genre) values(@Rating, @Title, @YearOfRelease, @Copies, @Genre)"
                    Using cmd = New SqlCommand(SqlStmt, SqlConn)
                        cmd.Parameters.AddWithValue("@Rating", Rating)
                        cmd.Parameters.AddWithValue("@Title", Title)
                        cmd.Parameters.AddWithValue("@YearOfRelease", YearOfRelease)
                        cmd.Parameters.AddWithValue("@Copies", Copies)
                        cmd.Parameters.AddWithValue("@Genre", Genre)
                        SqlConn.Open()
                        Dim affectedRecords = cmd.ExecuteNonQuery
                        If affectedRecords > 0 Then
                            MsgBox("Movie Added")
                        End If
                        SqlConn.Close()
                    End Using
                Else

                End If
            End If


        Catch ex As Exception
            SqlConn.Close()
            MsgBox("Error Occured: " & ex.Message)


        End Try




    End Sub









    Public Sub AddCustomer(FirstName As String, LastName As String, Address As String, Phone As String)
        Try
            If FirstName = "" Or LastName = "" Or Address = "" Or Phone = "" Then

                MsgBox("Please ensure the Customer's First Name, Last Name, Address and Phone Number are Entered Correctly")

            Else
                'Check that Customer is not already in the database
                'make use of search function
                'if so then msgbox("Customer already in Database") 'exit???
                'else 'continue



                If MsgBox("Are You Sure you wish to add: " & vbCrLf & vbCrLf & "Name: " & FirstName & "  " & LastName & vbCrLf & "Address: " & Address & vbCrLf & "Phone: " & Phone, MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

                    SqlStr.Connection = SqlConn
                    SqlStmt = "Insert into Customer(FirstName, LastName,Address,Phone) values(@FirstName, @LastName, @Address, @Phone)"
                    Using cmd = New SqlCommand(SqlStmt, SqlConn)
                        cmd.Parameters.AddWithValue("@FirstName", FirstName)
                        cmd.Parameters.AddWithValue("@LastName", LastName)
                        cmd.Parameters.AddWithValue("@Address", Address)
                        cmd.Parameters.AddWithValue("@Phone", Phone)
                        SqlConn.Open()
                        Dim affectedRecords = cmd.ExecuteNonQuery
                        If affectedRecords > 0 Then
                            MsgBox("Customer Added")
                        End If
                        SqlConn.Close()
                    End Using
                Else
                End If
            End If

        Catch ex As Exception
            SqlConn.Close()
            MsgBox("Error Occured: " & ex.Message)


        End Try




    End Sub


    Public Sub UpdateMovie(Rating As String, Title As String, YearOfRelease As Date, Copies As Integer, Genre As String, MovieID As Integer)
        Try


            If Rating = "" Or Title = "" Or YearOfRelease = "" Or Copies = vbNull Or Genre = "" Or MovieID = "" Then

                MsgBox("Please ensure the Rating, Title, YearOfRelease, Number of Copies and Genre are Entered Correctly")

            Else
                'Check that movie is not already in the database
                'make use of search function
                'if so then msgbox("Movie already in Database") 'exit???
                'else 'continue

                If MsgBox("Is this updated information correct? " & vbCrLf & vbCrLf & "Title: " & Title & vbCrLf & "Rating: " & Rating & vbCrLf & "Year of Release: " & YearOfRelease & vbCrLf & "Number of Copies: " & Copies & vbCrLf & "Genre: " & Genre, MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then





                    SqlStr.Connection = SqlConn
                    SqlStmt = "Update Movies Set Rating = @Rating, Title = @Title, YearOfRelease = @YearOfRelease, Copies = @Copies, Genre = @Genre, where MovieID = @MovieID"
                    Using cmd = New SqlCommand(SqlStmt, SqlConn)
                        cmd.Parameters.AddWithValue("@Rating", Rating)
                        cmd.Parameters.AddWithValue("@Title", Title)
                        cmd.Parameters.AddWithValue("@YearOfRelease", YearOfRelease)
                        cmd.Parameters.AddWithValue("@Copies", Copies)
                        cmd.Parameters.AddWithValue("@Genre", Genre)
                        cmd.Parameters.AddWithValue("@MovieID", MovieID)
                        SqlConn.Open()
                        Dim affectedRecords = cmd.ExecuteNonQuery()
                        If affectedRecords > 0 Then
                            MsgBox("Movie details for: " & vbCrLf & Title & vbCrLf & "Updated")

                        End If

                        SqlConn.Close()
                    End Using
                Else
                End If
            End If
        Catch ex As Exception
            SqlConn.Close()
            MsgBox("Error Occured: " & ex.Message)
        End Try
    End Sub







    Public Sub UpdateCustomer(FirstName As String, LastName As String, Address As String, Phone As String, CustID As Integer)
        Try


            If FirstName = "" Or LastName = "" Or Address = "" Or Phone = "" Or CustID = "" Then

                MsgBox("Please ensure the Customer's First Name, Last Name, Address and Phone Number are Entered Correctly")

            Else
                'Check that Customer is not already in the database
                'make use of search function
                'if so then msgbox("Customer already in Database") 'exit???
                'else 'continue



                If MsgBox("Is this updated information correct?" & vbCrLf & vbCrLf & "Name: " & FirstName & "  " & LastName & vbCrLf & "Address: " & Address & vbCrLf & "Phone: " & Phone, MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then




                    SqlStr.Connection = SqlConn
                    SqlStmt = "Update Movies Set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone, where CustID = @CustID"
                    Using cmd = New SqlCommand(SqlStmt, SqlConn)
                        cmd.Parameters.AddWithValue("@FirstName", FirstName)
                        cmd.Parameters.AddWithValue("@LastName", LastName)
                        cmd.Parameters.AddWithValue("@Address", Address)
                        cmd.Parameters.AddWithValue("@Phone", Phone)
                        SqlConn.Open()
                        Dim affectedRecords = cmd.ExecuteNonQuery()
                        If affectedRecords > 0 Then
                            MsgBox("Customer details for: " & vbCrLf & FirstName & "  " & LastName & vbCrLf & "Updated")

                        End If

                        SqlConn.Close()
                    End Using
                Else
                End If
            End If
        Catch ex As Exception
            SqlConn.Close()
            MsgBox("Error Occured: " & ex.Message)
        End Try
    End Sub







    Public Sub DeleteMovie(Title As String, MovieID As Integer)

        'if movie rented out then 
        'MsgBox("Cannot delete Movie." & vbCrLf & "Movie is currently on Loan to RENTEDMOVIES.CUSTID WHERE MOVIEID = MOVIEID")
        'else
        Dim Deleted_Movie As String = Title

        If MsgBox("Are you sure you wish to delete " & vbCrLf & Title & vbCrLf & MovieID & vbCrLf & "from Database?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

            Try
                SqlStr.Connection = SqlConn
                SqlStmt = "Delete from Movies where MovieID = @MovieID"
                Using cmd = New SqlCommand(SqlStmt, SqlConn)
                    cmd.Parameters.AddWithValue("@MovieID", MovieID)
                    SqlConn.Open()
                    Dim affectedRecords = cmd.ExecuteNonQuery()
                    If affectedRecords > 0 Then
                        MsgBox(Deleted_Movie & vbCrLf & " Deleted from Database")
                    End If
                    SqlConn.Close()
                End Using


            Catch ex As Exception
                SqlConn.Close()
                MsgBox("Error Occured: " & ex.Message)
            End Try
        Else
        End If
    End Sub




    Public Sub DeleteCustomer(FirstName As String, LastName As String, CustID As Integer)

        'if renting a movie  then 
        'MsgBox("Cannot delete " & vbCrLf & FirstName &"  " & LastName & vbcrlf & "RENTEDMOVIES.MOVIEID WHERE CUSTID = CUSTID  currently on Loan to " & FirstName &"  " & LastName)
        'else

        Dim Deleted_Customer As String = FirstName & "   " & LastName



        If MsgBox("Are you sure you wish to delete " & vbCrLf & FirstName & "  " & LastName & "from Database?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then



            Try
                SqlStr.Connection = SqlConn
                SqlStmt = "Delete from Customer where CustID = @CustID"
                Using cmd = New SqlCommand(SqlStmt, SqlConn)
                    cmd.Parameters.AddWithValue("@CustID", CustID)
                    SqlConn.Open()
                    Dim affectedRecords = cmd.ExecuteNonQuery()
                    If affectedRecords > 0 Then
                        MsgBox(Deleted_Customer & vbCrLf & " Deleted from Database")
                    End If
                    SqlConn.Close()
                End Using


            Catch ex As Exception
                SqlConn.Close()
                MsgBox("Error Occured: " & ex.Message)
            End Try
        Else
        End If
    End Sub

















    Sub getitdone()
        Dim Title As String = "what?"
        Dim Rating As String = "you shouldn't watch this"
        Dim YearOfRelease As Date = Date.Now
        Dim Copies As Integer = 2
        Dim Genre As String = "Comedy"
        If MsgBox("Are You Sure you wish to add: " & vbCrLf & vbCrLf & "Title: " & Title & vbCrLf & "Rating: " & Rating & vbCrLf & "Year of Release: " & YearOfRelease & vbCrLf & "Number of Copies: " & Copies & vbCrLf & "Genre: " & Genre, MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            MsgBox("Movie Added" & vbCrLf & "etc.")
        End If
    End Sub





    ''''Public Sub ClearCustomerTxtBoxes()
    ''''    MainWindow.txtCustomerFirstName.Text = ""
    ''''    MainWindow.txtCustomerLastName.Text = ""
    ''''    MainWindow.txtAddress.Text = ""
    ''''    MainWindow.txtPhone.Text = ""
    ''''    MainWindow.txtCustomerID.Text = ""
    ''''    MainWindow.btnAddCustomer.Visibility = False
    ''''    MainWindow.btnDeleteCustomer.Visibility = False
    ''''    MainWindow.btnUpdateCustomer.Visibility = False
    ''''    MainWindow.btnIssueMovie.Visibility = False
    ''''    MainWindow.btnReturnMovie.Visibility = False

    ''''End Sub
    ''''Public Sub ClearMovieTxtBoxes()
    ''''    MainWindow.txtTitle.Text = ""
    ''''    MainWindow.txtRating.Text = ""
    ''''    MainWindow.txtRelease.Text = ""
    ''''    MainWindow.txtCost.Text = ""
    ''''    MainWindow.txtCopies.Text = ""
    ''''    MainWindow.txtGenre.Text = ""
    ''''    MainWindow.btnAddMovie.Visibility = False
    ''''    MainWindow.btnDeleteMovie.Visibility = False
    ''''    MainWindow.btnUpdateMovie.Visibility = False
    ''''    MainWindow.btnIssueMovie.Visibility = False
    ''''    MainWindow.btnReturnMovie.Visibility = False
    ''''    MainWindow.btnPlot.Visibility = False

    ''''End Sub





    Public Sub IssueMovie(Title As String, FirstName As String, LastName As String, MovieID As Integer, CustID As Integer)

        Try




            If MovieID = "" Or CustID = "" Or FirstName = "" Or LastName = "" Or Title = "" Then

                MsgBox("Please ensure both a Customer and a Movie are selected")

            Else
                'if Customer is  currently renting 2 movies then MsgBox("Customer already has maximum number of movies on loan") EXIT
                'else
                'if MovieID is RENTEDMOVIES.DATERETURNED IS NULL THEN MsgBox("Movie is unavailable." & vbCrLf & "Due back on EXPECTED RETURN DATE")
                'make use of search function
                'if so then msgbox("Customer already in Database") 'exit???
                'else 'continue



                If MsgBox("Issue:" & vbCrLf & vbCrLf & Title & vbCrLf & "to " & FirstName & "  " & LastName & vbCrLf, MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then







                    SqlStr.Connection = SqlConn
                    'fix the date insert to now below
                    SqlStmt = "Insert into RentedMovies(MovieID,CustID,DateRented) values(@MovieID, @CustID, ******Date(now)****** )"
                    'can the below be of help?
                    '"Update RentedMovies set Available= 'No', Borrower = @Borrower where MovieID = @MovieID"


                    Using cmd = New SqlCommand(SqlStmt, SqlConn)
                        cmd.Parameters.AddWithValue("@CustID", CustID)
                        cmd.Parameters.AddWithValue("@MovieID", MovieID)
                        SqlStr.CommandText = SqlStmt
                        SqlConn.Open()
                        Dim affectedRecords As Int32 = cmd.ExecuteNonQuery
                        If affectedRecords > 0 Then
                            MsgBox("Movie Issued")
                        End If
                        SqlConn.Close()
                    End Using
                Else
                End If
            End If

        Catch ex As Exception
            SqlConn.Close()
            MsgBox("Error Occured: " & ex.Message)
        End Try

    End Sub


    'the below function needs work

    Public Sub ReturnMovie(MovieID As String)
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Update RentedMovies set DateReturned = '****DateNow***' where BookID = @BookID"
            Using cmd = New SqlCommand(SqlStmt, SqlConn)
                cmd.Parameters.AddWithValue("@MovieID", MovieID)
                SqlStr.CommandText = SqlStmt
                SqlConn.Open()
                Dim affectedRecords As Int32 = cmd.ExecuteNonQuery
                If affectedRecords > 0 Then
                    MsgBox("Movie Returned")
                End If
                SqlConn.Close()
            End Using
        Catch ex As Exception
            SqlConn.Close()
            MsgBox("Error Occured: " & ex.Message)

        End Try
    End Sub






    Public Function SearchMovies(Rating As String, Title As String, YearOfRelease As String, Rental_Cost As String, Copies As String, Plot As String, Genre As String) As DataTable
        Dim dt As New DataTable
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Select Title, Rating, Year, Copies, Genre from Movies where Rating like  @Rating + '%' AND Title like  @Title + '%' AND Year like  @YearOfRelease + '%' AND Copies like  @Copies + '%' AND Genre like   @Genre + '%'"
            Using cmd = New SqlCommand(SqlStmt, SqlConn)
                cmd.Parameters.AddWithValue("@Rating", Rating)
                cmd.Parameters.AddWithValue("@Title", Title)
                cmd.Parameters.AddWithValue("@YearOfRelease", YearOfRelease)
                cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost)
                cmd.Parameters.AddWithValue("@Copies", Copies)
                cmd.Parameters.AddWithValue("@Genre", Genre)
                SqlConn.Open()
                SqlReader = cmd.ExecuteReader
                If SqlReader.HasRows Then
                    dt.Load(SqlReader)
                End If
                SqlConn.Close()
            End Using
        Catch ex As Exception
            SqlConn.Close()
            MsgBox("Error Occured: " & ex.Message)
        End Try
        Return dt
    End Function





    Public Function SearchCustomers(FirstName As String, LastName As String, Address As String, Phone As String) As DataTable
        Dim dt As New DataTable
        Try



            'If FirstName = "" Then
            '    FirstName = "*"
            'End If


            'If LastName = "" Then
            '    LastName = "*"
            'End If


            'If Address = "" Then
            '    Address = "*"
            'End If


            'If Phone = "" Then
            '    Phone = "*"
            'End If



            'Check that Customer is not already in the database
            'make use of search function
            'if so then msgbox("Customer already in Database") 'exit???
            'else 'continue
            '



            'initial for sql stmt below works!!!
            '''"Select * from Customer where FirstName like '%' + @FirstName + '%' AND LastName like '%' + @LastName + '%' AND Address like '%' + @Address + '%' AND Phone like '%' + @Phone + '%'"




            SqlStr.Connection = SqlConn
            SqlStmt = "Select * from Customer where FirstName like  @FirstName + '%' AND LastName like  @LastName + '%' AND Address like  @Address + '%' AND Phone like  @Phone + '%'"
            Using cmd = New SqlCommand(SqlStmt, SqlConn)
                cmd.Parameters.AddWithValue("@FirstName", FirstName)
                cmd.Parameters.AddWithValue("@LastName", LastName)
                cmd.Parameters.AddWithValue("@Address", Address)
                cmd.Parameters.AddWithValue("@Phone", Phone)

                SqlConn.Open()
                SqlReader = cmd.ExecuteReader
                If SqlReader.HasRows Then
                    dt.Load(SqlReader)
                End If
                SqlConn.Close()
            End Using
        Catch ex As Exception
            SqlConn.Close()
            MsgBox("Error Occured: " & ex.Message)
        End Try
        Return dt
    End Function






End Class





































