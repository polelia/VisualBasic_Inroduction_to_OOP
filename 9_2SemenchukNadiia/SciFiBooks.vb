
'Project: 9_2
'Description: Program loads a CSV file that contains a list of top 25 sci-fi books 
'             (based on crowd-rated list on bestsciencefictionbooks.com) and populates combobox
'             with their titles in descending order. If title is selected in the combo box, text boxes are
'             authomatically populated with more specific info about selected book. 
'             User can add, delete and modify data. 
'Author: Nadiia Semenchuk
'Date: November 19, 2014

'I promise that I created this code and I did not copy from someone else or the internet.


Imports System.IO

Public Class frmSciFiBooks

    Dim library() As String = File.ReadAllLines("Books.txt")

    Private Sub frmSciFiBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Searched for titles in the file and displays them in the combobox.
        Dim QueryList = From line In library
                        Let data = line.Split(","c)
                        Let title = data(0)
                        Select title

        'populates combobox with query results
        cboBooks.DataSource = QueryList.ToList
        cboBooks.SelectedIndex = -1

        'sub procedure which displays default image
        DefaultImage()
    End Sub

    Private Sub cboBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBooks.SelectedIndexChanged

        'Displays user selections

        'Clearing procedure
        txtTitle.Clear()
        txtWriter.Clear()
        TxtYear.Clear()
        DefaultImage()

        If cboBooks.SelectedIndex > -1 Then

            txtTitle.Text = cboBooks.Text 'displays book's title in the txtbox

            ' Searches for coresponding author
            Dim QuerySearch = From elem In library
                              Let data = elem.Split(","c)(0)
                              Let author = elem.Split(","c)(1)
                              Where data = cboBooks.Text
                              Select author
            'Displays search result
            txtWriter.Text = QuerySearch.First

            'Looks for a corresponding year
            Dim YearSearch = From line In library
                             Let d = line.Split(","c)(0)
                             Let year = line.Split(","c)(2)
                             Where d = cboBooks.Text
                             Select year

            TxtYear.Text = YearSearch.First

            'Displays cover of the selected book
            picBox.ImageLocation = txtTitle.Text & ".jpg"
            picBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        'Allows user to modify data in the file
        Dim bookTitle As String = txtTitle.Text
        Dim bookAuthor As String = txtWriter.Text
        Dim bookYear As String = TxtYear.Text
        Dim modifiedLine As String = bookTitle & "," & bookAuthor & "," & bookYear

        'Data validation
        If bookTitle <> "" And bookAuthor <> "" And (bookYear <> "" And IsNumeric(bookYear)) Then


            If File.Exists("Books.txt") Then  'Checks if file exists

                'Rewrites file and deletes line that user wants to modify
                Dim sr As StreamReader = File.OpenText("Books.txt")
                Dim sw As StreamWriter = File.CreateText("Temporary.txt")
                Dim line As String
                Dim data() As String
                Dim name As String
                Do Until sr.EndOfStream
                    line = sr.ReadLine
                    data = line.Split(","c)
                    name = data(0)
                    If name <> cboBooks.Text Then 'searches through file using text from the combobox
                        sw.WriteLine(line)        'that unlike one from txt boxes can't be modified directly by user
                    End If
                Loop
                sr.Close()
                sw.Close()
                File.Delete("Books.txt")
                File.Move("Temporary.txt", "Books.txt")

                If InFile(bookTitle) Then 'one more check if line was really deleted from the file
                    MessageBox.Show(bookTitle & " is already in the file.", "Error")
                Else
                    Dim sw1 As StreamWriter = File.AppendText("Books.txt")
                    sw1.WriteLine(modifiedLine) 'adds a new line that represents user's modifications
                    sw1.Close()
                    MessageBox.Show("Updates were successfully saved to the file.", "Update")
                    txtTitle.Clear()
                    txtWriter.Clear()
                    TxtYear.Clear()

                    'refreshes combobox to display all updates
                    BoxReload()
                    DefaultImage()

                End If
            Else
                MessageBox.Show("Please enter data in all boxes.", "Error")
            End If
        Else
            MessageBox.Show(bookTitle & "isn't in the file.", "Not Found")
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        'Handles "delete" operation
        Dim bookTitle As String = txtTitle.Text
        Dim bookAuthor As String = txtWriter.Text
        Dim bookYear As String = TxtYear.Text
        Dim delLine As String = bookTitle & "," & bookAuthor & "," & bookYear
        Dim data As String

        'input validation for delete procedure
        If bookTitle <> "" And bookAuthor <> "" And bookYear <> "" Then
            If InFile(bookTitle) Then
                Dim sr As StreamReader = File.OpenText("Books.txt")
                Dim sw As StreamWriter = File.CreateText("Temporary.txt")
                Do Until sr.EndOfStream 'rewrites all data except for the one that needs to be deleted
                    data = sr.ReadLine
                    If data <> delLine Then
                        sw.WriteLine(data)
                    End If
                Loop
                sr.Close()
                sw.Close()
                File.Delete("Books.txt")
                File.Move("Temporary.txt", "Books.txt")
                MessageBox.Show(bookTitle & " was deleted from the file.", "Removed")
                BoxReload()
                DefaultImage()

            Else
                MessageBox.Show(bookTitle & "isn't in the file.", "Not Found")
            End If
        Else
            MessageBox.Show("You must enter all information.", "Error")
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        'Adds new line to the txt file
        Dim bookTitle As String = txtTitle.Text
        Dim bookAuthor As String = txtWriter.Text
        Dim bookYear As String = TxtYear.Text
        Dim addedLine As String = bookTitle & "," & bookAuthor & "," & bookYear

        'Input validation for add procedure
        If bookTitle <> "" And bookAuthor <> "" And (bookYear <> "" And IsNumeric(bookYear)) Then
            If InFile(bookTitle) Then
                MessageBox.Show(bookTitle & " is already in the file.", "Error")
            Else
                Dim sw As StreamWriter = File.AppendText("Books.txt")
                sw.WriteLine(addedLine) 'Adds line to the file
                sw.Close()
                MessageBox.Show(bookTitle & " is added to the file.", "New Book")
                txtTitle.Clear()
                txtWriter.Clear()
                TxtYear.Clear()

                BoxReload()
                DefaultImage()

            End If
        Else
            MessageBox.Show("Please enter data in all boxes.", "Error")
        End If

    End Sub

    Function InFile(bkTitle As String) As Boolean
        'checks if selected data is in our file. Returns boolean values.
        If File.Exists("Books.txt") Then
            Dim sr As StreamReader = File.OpenText("Books.txt")
            Dim line As String
            Dim data() As String
            Dim name As String
            Do Until sr.EndOfStream
                line = sr.ReadLine
                data = line.Split(","c)
                name = data(0)
                If name = bkTitle Then 'if text in the title txt box corresponds with any line from file
                    sr.Close()         'function returns true
                    Return True
                End If
            Loop
            sr.Close()
        End If
        Return False
    End Function

    Sub DefaultImage()
        'Sets default image for the form
        picBox.ImageLocation = ("AbstractSciFi.jpg")
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Sub BoxReload()
        'repopulates combobox after any changes made by the user
        library = File.ReadAllLines("Books.txt")
        Dim QueryList = From line In library
               Let data = line.Split(","c)
               Let title = data(0)
               Order By title Ascending
               Select title

        cboBooks.DataSource = QueryList.ToList
        cboBooks.SelectedIndex = -1

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes form
        Me.Close()
    End Sub
   
End Class
