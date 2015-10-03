
'Project: 8.3.26
'Description: Program loads a XML file that contains a list of top 25 sci-fi books 
'             (based on crowd-rated list on bestsciencefictionbooks.com) and displays 
'             results of user selections. Also it converts the XML file to CSV format. 
'Author: Nadiia Semenchuk
'Date: November 9, 2014

'I promise that I created this code and I did not copy from someone else or the internet.

Public Class frmSciFiBooks

    'Loads XML file
    Dim booksData As XElement = XElement.Load("SFBooks.xml")

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'declares a "sort" variable and assigns to it index of selected item in a listbox
        Dim sort As Integer
        sort = lstOptions.SelectedIndex

        'Runs and displays queries based on user's selections
        Select Case sort

            Case -1 'when nothing is selected
                MessageBox.Show("Please select display option", "Error")

            Case 0  'highest upvotes query
                Dim query = From i In booksData.Descendants("book")
                             Let title = i.<title>.Value
                             Let author = i.<author>.Value
                             Let votes1 = CInt(i.<upvotes>.Value)
                             Let votes2 = CInt(i.<downvotes>.Value)
                             Order By votes1 Descending
                             Select title, author, votes1, votes2
                dgvBooks.DataSource = query.ToList
                DataDisplay()

            Case 1  'lowest downvotes search
                Dim query = From i In booksData.Descendants("book")
                             Let title = i.<title>.Value
                             Let author = i.<author>.Value
                             Let votes1 = CInt(i.<upvotes>.Value)
                             Let votes2 = CInt(i.<downvotes>.Value)
                             Order By votes2 Ascending
                             Select title, author, votes1, votes2
                dgvBooks.DataSource = query.ToList
                DataDisplay()

            Case 2  'sorts list by title in descending order
                Dim query = From i In booksData.Descendants("book")
                             Let title = i.<title>.Value
                             Let author = i.<author>.Value
                             Let votes1 = i.<upvotes>.Value
                             Let votes2 = i.<downvotes>.Value
                             Order By title Descending
                             Select title, author, votes1, votes2
                dgvBooks.DataSource = query.ToList
                DataDisplay()

            Case 3  'list is sorted by authors in alphabetical order
                Dim query = From i In booksData.Descendants("book")
                             Let title = i.<title>.Value
                             Let author = i.<author>.Value
                             Let votes1 = i.<upvotes>.Value
                             Let votes2 = i.<downvotes>.Value
                             Order By author Ascending
                             Select title, author, votes1, votes2
                dgvBooks.DataSource = query.ToList
                DataDisplay()

        End Select
    End Sub


    Sub DataDisplay()

        'Sets up datagreedview control headers
        dgvBooks.CurrentCell = Nothing
        dgvBooks.Columns("title").HeaderText = "Title"
        dgvBooks.Columns("author").HeaderText = "Author"
        dgvBooks.Columns("votes1").HeaderText = "Upvotes"
        dgvBooks.Columns("votes2").HeaderText = "Downvotes"

    End Sub

   
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        'Converts XML file to CSV using LINQ
        Dim query = From i In booksData.Descendants("book")
                             Let title = i.<title>.Value
                             Let author = i.<author>.Value
                             Let votes1 = i.<upvotes>.Value
                             Let votes2 = i.<downvotes>.Value
                             Let newLine = title & "," & author & "," & votes1 & "," & votes2
                             Select newLine
       
        'Writes all lines from the search into txt file
        IO.File.WriteAllLines("SFBooks.txt", query)

        MessageBox.Show("XML file was succesfully converted to CSV format", "Congratulations")

    End Sub

    
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes form
        Me.Close()
    End Sub
End Class
