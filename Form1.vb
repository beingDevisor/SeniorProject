Public Class MainForm
    Dim rs As New Resizer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub



    'Global Variables
    Dim strInput As String ' Text the user enters. Goes to lowercase after placed in listbox
    Dim strFavoriteWebsites() As String
    Dim intNumOfFavWebsites As Integer = 0
    Dim blnAddedFavBefore As Boolean = False 'Prevents null exception when calling array
    Dim intTimer As Integer


    Private scriptControl1 As Object

    Public Sub tbxInput_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxInput.KeyDown 'Input
        If e.KeyCode = Keys.Enter Then
            e.Handled = True 'These things make it so the form doesn't "ding" when you hit enter
            e.SuppressKeyPress = True
            strInput = tbxInput.Text
            If strInput = "" Then 'Checks if text box is empty
                MessageBox.Show("Please input a command.")
            Else
                tbxInput.Text = ""
                lbOutput.Items.Add("> " & strInput)

                strInput = strInput.ToLower ' Begin input checks 

                If strInput = "help" Then 'Help input
                    lbOutput.Items.Add("* HELP *")
                    lbOutput.Items.Add("-+-+-+-+-+-+-+-")
                    lbOutput.Items.Add("Google <arg> ; Performs a Google search of the arguments")
                    lbOutput.Items.Add("Youtube <arg> ; Performs a search in Youtube of the arguments")
                    lbOutput.Items.Add("<Number argument> <operator +, -, /, or *> <Number Argument> ; Performs a basic mathematical function. Rounds down.")
                    lbOutput.Items.Add("Favorite <arg> ; Adds a website to the Favorite Websites list")
                    lbOutput.Items.Add("OpenFavs ; Launchs all favorite websites")
                    lbOutput.Items.Add("Launch <arg> ; Launches the argument application if available")
                    lbOutput.Items.Add("Clear ; Clears the console output")
                    lbOutput.Items.Add("Exit ; Quits the application")
                    lbOutput.Items.Add("-+-+-+-+-+-+-+-")
                End If

                If Microsoft.VisualBasic.Strings.Left(strInput, 6) = "google" Then ' If the first word is google
                    If strInput = "google" Or strInput = "google " Then
                        lbOutput.Items.Add("Please add an argument")
                    Else
                        Dim strTempString As String = Microsoft.VisualBasic.Strings.Right(strInput, strInput.Length - 7) ' grab everything after Google
                        lbOutput.Items.Add("Launching...")
                        'Process.Start("iexplore", "http://www.google.com/search?hl=en&q=" + strTempString + "&aq=f&oq=") for internet explorer
                        Process.Start("http://www.google.com/search?hl=en&q=" + strTempString + "&aq=f&oq=") 'Launches default browser and searches for the arguments
                    End If
                End If
                If Microsoft.VisualBasic.Strings.Left(strInput, 7) = "youtube" Then ' If the first word is youtube
                    If strInput = "youtube" Or strInput = "youtube " Then
                        lbOutput.Items.Add("Please add an argument")
                    Else
                        Dim strTempString As String = Microsoft.VisualBasic.Strings.Right(strInput, strInput.Length - 8) ' grab everything after Youtube
                        lbOutput.Items.Add("Launching...")
                        Process.Start("https://www.youtube.com/results?search_query=" + strTempString.Replace(" ", "+")) 'Launches default browser and searches for the arguments in Youtube
                    End If
                End If

                If strInput.Chars(0) = "1" Or strInput.Chars(0) = "2" Or strInput.Chars(0) = "3" Or strInput.Chars(0) = "4" Or strInput.Chars(0) = "5" Or strInput.Chars(0) = "6" Or strInput.Chars(0) = "7" Or strInput.Chars(0) = "8" Or strInput.Chars(0) = "9" Or strInput.Chars(0) = "0" Then ' Mathematical function
                    Dim intResult As Integer = 0
                    Dim strNum As String = ""
                    Dim strSign As String = ""
                    Dim blnQuit As Boolean = False
                    'Dim blnParse As Boolean
                    Try
                        For Each c As Char In strInput
                            If blnQuit = False Then
                                If c = "1" Or c = "2" Or c = "3" Or c = "4" Or c = "5" Or c = "6" Or c = "7" Or c = "8" Or c = "9" Or c = "0" Then
                                    strNum = strNum + c
                                    If c = "0" Then
                                        If strSign = "/" Then
                                            If strNum = "0" Then
                                                lbOutput.Items.Add("Divide by zero error.")
                                                blnQuit = True
                                            End If
                                        End If
                                    End If
                                End If
                                If blnQuit = False Then
                                    If c = "+" Then
                                        If strSign = "" Then
                                            intResult = Convert.ToInt32(strNum)
                                        Else
                                            If strSign = "+" Then
                                                intResult = intResult + Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "-" Then
                                                intResult = intResult - Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "/" Then
                                                intResult = intResult / Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "*" Then
                                                intResult = intResult * Convert.ToInt32(strNum)
                                            End If
                                        End If
                                        strSign = c
                                        strNum = ""
                                    End If
                                    If c = "-" Then
                                        If strSign = "" Then
                                            intResult = Convert.ToInt32(strNum)
                                        Else
                                            If strSign = "+" Then
                                                intResult = intResult + Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "-" Then
                                                intResult = intResult - Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "/" Then
                                                intResult = intResult / Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "*" Then
                                                intResult = intResult * Convert.ToInt32(strNum)
                                            End If
                                        End If
                                        strSign = c
                                        strNum = ""
                                    End If
                                    If c = "/" Then
                                        If strSign = "" Then
                                            intResult = Convert.ToInt32(strNum)
                                        Else
                                            If strSign = "+" Then
                                                intResult = intResult + Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "-" Then
                                                intResult = intResult - Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "/" Then
                                                intResult = intResult / Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "*" Then
                                                intResult = intResult * Convert.ToInt32(strNum)
                                            End If
                                        End If
                                        strSign = c
                                        strNum = ""
                                    End If
                                    If c = "*" Then
                                        If strSign = "" Then
                                            intResult = Convert.ToInt32(strNum)
                                        Else
                                            If strSign = "+" Then
                                                intResult = intResult + Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "-" Then
                                                intResult = intResult - Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "/" Then
                                                intResult = intResult / Convert.ToInt32(strNum)
                                            End If
                                            If strSign = "*" Then
                                                intResult = intResult * Convert.ToInt32(strNum)
                                            End If
                                        End If
                                        strNum = ""
                                        strSign = "*"
                                    End If
                                End If
                            End If
                        Next
                        If strSign = "+" Then
                            intResult = intResult + Convert.ToInt32(strNum)
                        End If
                        If strSign = "-" Then
                            intResult = intResult - Convert.ToInt32(strNum)
                        End If
                        If strSign = "/" Then
                            If blnQuit = False Then
                                intResult = intResult / Convert.ToInt32(strNum)
                            End If
                        End If
                        If strSign = "*" Then
                            intResult = intResult * Convert.ToInt32(strNum)
                        End If
                        If blnQuit = False Then
                            lbOutput.Items.Add(intResult)
                        End If
                    Catch ex As Exception
                        lbOutput.Items.Add("An error occurred. Ensure there is no overflow error or format error.")
                    End Try
                End If

                If Microsoft.VisualBasic.Strings.Left(strInput, 8) = "favorite" Then 'Begins with "favorite" ; add to favorite array
                    If strInput.Length > 9 Then
                        Dim strTempString As String = Microsoft.VisualBasic.Strings.Right(strInput, strInput.Length - 9) 'Grabs all characters except favorite and a space
                        intNumOfFavWebsites = intNumOfFavWebsites + 1
                        blnAddedFavBefore = True
                        ReDim Preserve strFavoriteWebsites(intNumOfFavWebsites - 1)
                        strFavoriteWebsites(UBound(strFavoriteWebsites)) = strTempString
                        lbOutput.Items.Add("Added!")
                        lbOutput.Items.Add("Current list of favorites:")
                        lbOutput.Items.Add("-+-+-+-+-+-+-+-")
                        For Each i In strFavoriteWebsites
                            lbOutput.Items.Add(i)
                        Next
                    Else
                        lbOutput.Items.Add("Please add an argument.")
                    End If
                End If
                If strInput = "gotofavs" Or strInput = "gotofavorites" Or strInput = "openfavs" Or strInput = "openfavorites" Then
                    If blnAddedFavBefore = True Then
                        For Each i In strFavoriteWebsites
                            Try
                                Process.Start(i)
                            Catch ex As Exception
                                lbOutput.Items.Add("Unable to launch website '" + i + "'. Check the URL format (www.abc.com)")
                            End Try
                        Next
                        lbOutput.Items.Add("Launching favorite websites...")
                    Else
                        lbOutput.Items.Add("Please add a website using the 'Favorite' command.")
                    End If
                End If
                If strInput = "clearfavs" Or strInput = "clearfavorites" Or strInput = "clear favorites" Then
                    intNumOfFavWebsites = 0
                    blnAddedFavBefore = False
                    ReDim strFavoriteWebsites(0)
                    lbOutput.Items.Add("Favorite Website list cleared successfully.")
                End If

                If Microsoft.VisualBasic.Strings.Left(strInput, 6) = "launch" Then ' Begins with launch, launching application
                    If strInput.Length > 7 Then
                        Try
                            Process.Start(Microsoft.VisualBasic.Strings.Right(strInput, strInput.Length - 7))
                        Catch ex As Exception
                            lbOutput.Items.Add("Could not find the specified application.")
                        End Try
                    Else
                        lbOutput.Items.Add("Please add an argument.")
                    End If
                End If

                If Microsoft.VisualBasic.Strings.Left(strInput, 5) = "timer" Then
                    If strInput = "timer" Or strInput = "timer " Then
                        lbOutput.Items.Add("Please add an argument.")
                    Else
                        If Microsoft.VisualBasic.Strings.Right(strInput, 7) = "minutes" Then

                        End If

                        Try
                                Dim strTempString As String
                                strTempString = Microsoft.VisualBasic.Strings.Right(strInput, strInput.Length - 6)
                                intTimer = Convert.ToInt32(strTempString)
                            Catch ex As Exception
                                lbOutput.Items.Add("Invalid argument. Please input ")
                            End Try


                        End If
                    End If





                'Basic Commands
                If strInput = "hello" Then
                    lbOutput.Items.Add("Hello there!")
                End If
                If strInput = "exit" Or strInput = "stop" Or strInput = "quit" Or strInput = "close" Then
                    lbOutput.Items.Add("Goodbye!")
                    Me.Close()
                End If
                If strInput = "clear" Then
                    lbOutput.Items.Clear()
                End If


                'Item count check
                If lbOutput.Items.Count > 42 Then ' Auto scrolling list. Change the number to the max items + 1
                    Do Until lbOutput.Items.Count < 43
                        lbOutput.Items.RemoveAt(0)
                    Loop
                End If

                lbOutput.TopIndex = lbOutput.Items.Count - 1 'Scrolls the listbox down
                End If
            End If
    End Sub











    'Complex Toolstrips


    Private Sub LaunchFavoriteWebsitesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchFavoriteWebsitesToolStripMenuItem.Click
        If blnAddedFavBefore = True Then
            For Each i In strFavoriteWebsites
                Process.Start(i)
            Next
            lbOutput.Items.Add("Launching favorite websites...")
        Else
            lbOutput.Items.Add("Please add a website using the 'Favorite' command.")
        End If
    End Sub


    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        lbOutput.Items.Add("* HELP *")
        lbOutput.Items.Add("-+-+-+-+-+-+-+-")
        lbOutput.Items.Add("Google <arg> ; Performs a Google search of the arguments")
        lbOutput.Items.Add("Youtube <arg> ; Performs a search in Youtube of the arguments")
        lbOutput.Items.Add("<Number argument> <operator +, -, /, or *> <Number Argument> ; Performs a basic mathematical function")
        lbOutput.Items.Add("Favorite <arg> ; Adds a website to the Favorite Websites list")
        lbOutput.Items.Add("OpenFavs ; Launchs all favorite websites")
        lbOutput.Items.Add("Launch <arg> ; Launches the argument application if available")
        lbOutput.Items.Add("Clear ; Clears the console output")
        lbOutput.Items.Add("Exit ; Quits the application")
        lbOutput.Items.Add("-+-+-+-+-+-+-+-")
    End Sub










    'Toolstrips

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        'Font_Selection.Show()
        FontDialog1.ShowDialog()
        lbOutput.Font = FontDialog1.Font ' Displays the font selection dialog box
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        MessageBox.Show("Aida" & vbCrLf & "Artificial Intelligence Digital Assistant" & vbCrLf & "Developed and programmed by <redacted>" & vbCrLf & "" & vbCrLf & "Contact" & vbCrLf & "<redacted>")
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click
        tbxInput.Text = "Google "
        tbxInput.Select(tbxInput.Text.Length, 0) ' Puts the textbox cursor at the end
    End Sub
    Private Sub YoutubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YoutubeToolStripMenuItem.Click
        tbxInput.Text = "YouTube "
        tbxInput.Select(tbxInput.Text.Length, 0) ' same as above
    End Sub

    Private Sub BasicCommandsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasicCommandsToolStripMenuItem.Click

    End Sub
    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        lbOutput.ForeColor = Color.Red
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        lbOutput.ForeColor = Color.SkyBlue
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        lbOutput.ForeColor = Color.Purple
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        lbOutput.ForeColor = Color.Green
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        lbOutput.ForeColor = Color.Black
    End Sub

    Private Sub WhiteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem1.Click
        lbOutput.ForeColor = Color.White
    End Sub

    Private Sub BlueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem1.Click
        lbOutput.BackColor = Color.Red
    End Sub

    Private Sub RedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem1.Click
        lbOutput.BackColor = Color.SkyBlue
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        lbOutput.BackColor = Color.Purple
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem1.Click
        lbOutput.BackColor = Color.Green
    End Sub

    Private Sub BlackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem1.Click
        lbOutput.BackColor = Color.Black
    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click
        lbOutput.BackColor = Color.Gray
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        lbOutput.BackColor = Color.White
    End Sub

    Private Sub RedToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem2.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub BlueToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem2.Click
        Me.BackColor = Color.SkyBlue
    End Sub

    Private Sub PurpleToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem2.Click
        Me.BackColor = Color.Purple
    End Sub

    Private Sub GreenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem2.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub BlackToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem2.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub GrayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem1.Click
        Me.BackColor = Color.Gray
    End Sub

    Private Sub WhiteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem2.Click
        Me.BackColor = Color.White
    End Sub








    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
