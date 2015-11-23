Imports System.Text.RegularExpressions



Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click



        'this will calculate my index depending on my numeric up down
        TBStartValue.Text = (NumericUpDown1.Value - 1) * 100



        'this is the number of results i want google to show i put 100 because is the maximum
        TBNumValue.Text = 100






        'this will create a position for google to show how many results it will show and the index
        Dim position As String = "&start=" & TBStartValue.Text & "&num=" & TBNumValue.Text & "" '



        'this will check what kind of email i want to get
        If RBGmail.Checked = True Then



            Dim keyword As String = TBSearchKeyword.Text & "+""gmail.com"" "



            WebBrowser1.Navigate("https://www.google.ca/search?q=" & keyword & position & "")



        End If




        If RBYahoo.Checked = True Then



            Dim keyword As String = TBSearchKeyword.Text & "+" & Chr(34) & EmailDomain.Text & Chr(34)



            WebBrowser1.Navigate("https://www.google.ca/search?q=" & keyword & position & "")



        End If




        If RBHotmail.Checked = True Then



            Dim keyword As String = TBSearchKeyword.Text & "+""hotmail.com"" "



            WebBrowser1.Navigate("https://www.google.ca/search?q=" & keyword & position & "")




        End If



        'this section will allow me to everytime seach for a new page by changing the index page
        NumericUpDown1.Value = NumericUpDown1.Value + 1



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNExtractHTML.Click



        ' Copy the source code of the webbrowser into a textbox
        TBHtmlSourceCode.Text = WebBrowser1.DocumentText



        ' This will extract the emails from a textbox and will add it to a listbox
        ExtractEmailAddressesFromString(TBHtmlSourceCode, ListBox1)



        'remove duplicated items into a textbox
        Scraping.RemoveDuplicatedListbox(ListBox1)

        ' Count how many emails have been scrapped
        LBEmails.Text = ListBox1.Items.Count



    End Sub






    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        'This will save the items of the listbox into a text file
        Scraping.SaveListboxToTextFile(SaveFileDialog1, ListBox1)



    End Sub


    Private Sub ExtractEmailAddressesFromString(source As TextBox, listbox1 As ListBox)



        Dim mc As MatchCollection
        Dim i As Integer

        Dim rgx As New Regex("<[^>]*>")

        Dim htmlsourcecode As String = rgx.Replace(source.Text, "")


        If CheckBox1.Checked = True Then

            ' In this section i can change the patter of my regular expressions. whatever the match is, it will be added to a listbox
            mc = Regex.Matches(htmlsourcecode, "^[A-Z0-9._%+-]+@uwaterloo.ca$")


        Else

            ' In this section i can change the patter of my regular expressions. whatever the match is, it will be added to a listbox
            mc = Regex.Matches(htmlsourcecode, "(?i)([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})")


        End If




        Dim results(mc.Count - 1) As String
        For i = 0 To results.Length - 1
            results(i) = mc(i).Value
            listbox1.Items.Add(mc(i).Value)



        Next



        ' Return results
    End Sub

End Class