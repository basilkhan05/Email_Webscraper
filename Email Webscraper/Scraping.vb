
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Mail
Imports System.Threading




Public Class Scraping







    Public Shared Sub SAVETXTFROMTEXTBOX(DIRECTORYTOSAVE As String, FILENAME As String, EXTENCION As String, TEXTBOXTOSAVE As TextBox)



        Try



            If Not Directory.Exists(DIRECTORYTOSAVE) Then
                Directory.CreateDirectory(DIRECTORYTOSAVE)
            End If



            My.Computer.FileSystem.WriteAllText(DIRECTORYTOSAVE & "\" & FILENAME & "." & EXTENCION, TEXTBOXTOSAVE.Text, False)



        Catch ex As Exception



        End Try
    End Sub









    Public Shared Sub COLORDATAGRID(DTGRV As DataGridView, Column As String, Cell As String, Color As Color)
        Try



            For i = 0 To DTGRV.RowCount - 2
                If DTGRV.Rows(i).Cells(Column).Value = Cell Then
                    DTGRV.Rows(i).DefaultCellStyle.BackColor = Color
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub










    Public Shared Sub RESETCOMBOBOX(COMBOBOXTORESE As ComboBox)



        COMBOBOXTORESE.Text = ""
        COMBOBOXTORESE.Items.Clear()



    End Sub






    Public Shared Sub REMOVEDUPLICATEDCOMBOBOX(COMBOBOXWITHDUPLICATEDVALUE As ComboBox)




        For i As Int16 = 0 To COMBOBOXWITHDUPLICATEDVALUE.Items.Count - 2
            For j As Int16 = COMBOBOXWITHDUPLICATEDVALUE.Items.Count - 1 To i + 1 Step -1
                If COMBOBOXWITHDUPLICATEDVALUE.Items(i).ToString = COMBOBOXWITHDUPLICATEDVALUE.Items(j).ToString Then
                    COMBOBOXWITHDUPLICATEDVALUE.Items.RemoveAt(j)
                End If
            Next
        Next




    End Sub




    Public Shared Sub SELECTEDDATAGRIDVIEWTOLABEL(DATAGRIDVIEW As DataGridView, LABEL As Label, COLUMNNUMBER As Integer)




        For Each RW As DataGridViewRow In DATAGRIDVIEW.SelectedRows
            LABEL.Text = RW.Cells(COLUMNNUMBER).Value.ToString
        Next



    End Sub






    Public Shared Sub SELECTEDDATAGRIDVIEWTOTEXTBOX(DATAGRIDVIEW As DataGridView, TEXTBOX As TextBox, COLUMNNUMBER As Integer)




        For Each RW As DataGridViewRow In DATAGRIDVIEW.SelectedRows
            TEXTBOX.Text = RW.Cells(COLUMNNUMBER).Value.ToString
        Next



    End Sub




    Public Shared Sub SELECTEDDATAGRIDVIEWTOCOMBOBOX(DATAGRIDVIEW As DataGridView, COMBOBOX As ComboBox, COLUMNNUMBER As Integer)




        For Each RW As DataGridViewRow In DATAGRIDVIEW.SelectedRows
            COMBOBOX.Text = RW.Cells(COLUMNNUMBER).Value.ToString
        Next



    End Sub



    Public Shared Sub REMOVESELECTED(DATAGRIDVIEW1 As DataGridView)




        If DATAGRIDVIEW1.SelectedRows.Count > 0 AndAlso
        Not DATAGRIDVIEW1.SelectedRows(0).Index =
        DATAGRIDVIEW1.Rows.Count - 1 Then




            DATAGRIDVIEW1.Rows.RemoveAt(
            DATAGRIDVIEW1.SelectedRows(0).Index)



        End If



    End Sub






    Shared Sub RemoveFirstCharacters(textboxname As TextBox, QytCharactersRemove As Integer)



        Dim str9 As String = textboxname.Text
        str9 = str9.Remove(0, QytCharactersRemove)
        textboxname.Text = str9




    End Sub




    Shared Sub RemoveLastCharacters(textboxname As TextBox, QytCharactersRemove As Integer)



        Dim s15 As String
        s15 = textboxname.Text
        textboxname.Text = textboxname.Text.Substring(0, s15.Length - QytCharactersRemove)






    End Sub





    ''' <summary>
    ''' This will download the html source from a website and will place it to a Textbox
    ''' </summary>
    ''' <param name="url">This is the Url that will be download into a textbox</param>
    ''' <param name="RichTextbox">This is the name of the textbox where you will save the html source code</param>
    ''' <remarks></remarks>



    Shared Sub DownloadHtmlPage(ByVal url As String, RichTextbox As TextBox)
        Try
            Dim result As String
            Dim objResponse As WebResponse
            Dim objRequest As WebRequest = System.Net.HttpWebRequest.Create(url)
            DirectCast(objRequest, System.Net.HttpWebRequest).UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:34.0) Gecko/20100101 Firefox/34.0"



            objResponse = objRequest.GetResponse()
            Using sr As New StreamReader(objResponse.GetResponseStream())
                result = sr.ReadToEnd()
                'Close and clean up the StreamReader
                sr.Close()
            End Using
            result = result.ToString



            RichTextbox.Text = result
            RichTextbox.Text = RichTextbox.Text.Replace("""", "#")




        Catch ex As Exception
            'lblStatus.Text = ex.Message
            RichTextbox.Text = ex.Message.ToString
            Exit Sub
        End Try
    End Sub




    ''' <summary>
    ''' 
    ''' This will clear the html code so there are no break lines and you can modify the html code
    ''' 
    ''' </summary>
    ''' <param name="HtmlCode"></param>
    ''' <remarks></remarks>



    Shared Sub ClearHtml(HtmlCode As RichTextBox)









        ' THIS WILL CLEAR THE EXTRA INFORMATION




        ' Remove new lines since they are not visible in HTML
        HtmlCode.Text = HtmlCode.Text.Replace("\n", " ")



        ' Remove tab spaces
        HtmlCode.Text = HtmlCode.Text.Replace("\t", " ")



        ' Remove multiple white spaces from HTML
        HtmlCode.Text = Regex.Replace(HtmlCode.Text, "\\s+", " ")



        ' Remove HEAD tag
        ' HtmlCode.Text = Regex.Replace(HtmlCode.Text, "<head.*?</head>", "" _
        ' , RegexOptions.IgnoreCase Or RegexOptions.Singleline)



        ' Remove any JavaScript
        HtmlCode.Text = Regex.Replace(HtmlCode.Text, "<script.*?</script>", "" _
        , RegexOptions.IgnoreCase Or RegexOptions.Singleline)






        HtmlCode.Text = HtmlCode.Text.Replace(vbCr, "").Replace(vbLf, "")
        HtmlCode.Text = HtmlCode.Text.Replace("\n", "").Replace("\r", "")
        HtmlCode.Text = HtmlCode.Text.Replace(Chr(10), "").Replace(Chr(13), "")






        HtmlCode.Text = HtmlCode.Text.Replace("""", "#")
        HtmlCode.Text = HtmlCode.Text.Replace("&", "")
        HtmlCode.Text = HtmlCode.Text.Replace("'", "")
        HtmlCode.Text = HtmlCode.Text.Replace(Environment.NewLine, "")






    End Sub



    Shared Sub ClearHtmlTB(HtmlCode As TextBox)












        ' THIS WILL CLEAR THE EXTRA INFORMATION







        ' Remove new lines since they are not visible in HTML
        HtmlCode.Text = HtmlCode.Text.Replace("\n", " ")






        ' Remove tab spaces
        HtmlCode.Text = HtmlCode.Text.Replace("\t", " ")






        ' Remove multiple white spaces from HTML
        HtmlCode.Text = Regex.Replace(HtmlCode.Text, "\\s+", " ")






        ' Remove HEAD tag
        ' HtmlCode.Text = Regex.Replace(HtmlCode.Text, "<head.*?</head>", "" _
        ' , RegexOptions.IgnoreCase Or RegexOptions.Singleline)






        ' Remove any JavaScript
        HtmlCode.Text = Regex.Replace(HtmlCode.Text, "<script.*?</script>", "" _
        , RegexOptions.IgnoreCase Or RegexOptions.Singleline)









        HtmlCode.Text = HtmlCode.Text.Replace(vbCr, "").Replace(vbLf, "")
        HtmlCode.Text = HtmlCode.Text.Replace("\n", "").Replace("\r", "")
        HtmlCode.Text = HtmlCode.Text.Replace(Chr(10), "").Replace(Chr(13), "")









        HtmlCode.Text = HtmlCode.Text.Replace("""", "#")
        HtmlCode.Text = HtmlCode.Text.Replace("&", "")
        HtmlCode.Text = HtmlCode.Text.Replace("'", "")
        HtmlCode.Text = HtmlCode.Text.Replace(Environment.NewLine, "")









    End Sub



    ' this will check for matches and will add them to a listbox
    Shared Sub AddMatchToListBox(HtmlCode As TextBox, StartTag1 As String, EndTag1 As String, listbox As ListBox)




        Dim contenido As String = HtmlCode.Text



        If contenido <> String.Empty Then
            With listbox



                ' limpiar el control listbox 
                .DataSource = Nothing
                ' Mostrar el resultado en el control ListBox 
                .DataSource = Obtener_Links(contenido.ToString, StartTag1, EndTag1)



                ' MsgBox("Cantidad de Links : " & .Items.Count.ToString, MsgBoxStyle.Information)
            End With
        End If




    End Sub






    Shared Function Obtener_Links(ByVal fuente As String, StartTag1 As String, EndTag1 As String) As ArrayList




        Dim temp_arrayList As New ArrayList
        ' expresión regular 
        Dim pattern As String = StartTag1 & "(.*?)" & EndTag1



        Try
            ' Colección para obtener los links 
            Dim Links As MatchCollection = Regex.Matches(fuente, pattern)



            ' añadirlos 
            For Each Link As Match In Links
                temp_arrayList.Add(Replace(Link.Value.ToString, Chr(34), String.Empty))
                ' TextBox6.Text = Link.Value.ToString



            Next
            ' retornar 
            Return temp_arrayList



            ' errores 
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally



        End Try
        Return Nothing
    End Function




    ' once you have the listbox this will separate for specific tags



    Shared Sub FindTextBetweenTags(TagStart As String, TagEnd As String, HtmlCode As String, Result As TextBox)



        'THIS PART WILL GET THE description



        Dim Tags5 As List(Of String) = Get_Description(TagStart, TagEnd, HtmlCode)



        Dim TagStartSize = TagStart.Length
        Dim TagEndSize = TagEnd.Length
        'You can loop through the list to view all of the results
        For Each Tag As String In Tags5



            Result.Text = Tag




            Dim str9 As String = Result.Text
            str9 = str9.Remove(0, TagStartSize)
            Result.Text = str9



            Dim s15 As String
            s15 = Result.Text
            Result.Text = Result.Text.Substring(0, s15.Length - TagEndSize)







        Next



    End Sub












    'You can give any TagName e.g. title, H1, div, head etc. etc.
    Shared Function Get_Description(ByVal TagStart As String, ByVal TagEnd As String, ByVal HTML As String) As List(Of String)
        Dim lMatch As New List(Of String) 'Get the results in a List of strings



        'RegexOptions.IgnoreCase allows case mismatch e.g. if TagName="title" results can include "title", "Title", "TITLE" etc.
        'RegexOptions.Singleline allows .* to see past CarriageReturn characters 
        Dim Tag As New Regex(TagStart & "(.*?)" & TagEnd, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
        For Each rMatch As Match In Tag.Matches(HTML)
            lMatch.Add(rMatch.Value)
        Next



        Return lMatch
    End Function






    Shared Sub RemoveDuplicatedListbox(listbox As ListBox)



        listbox.Sorted = True
        listbox.Refresh()



        Dim index As Integer
        Dim itemcount As Integer = listbox.Items.Count



        If itemcount > 1 Then
            Dim lastitem As String = listbox.Items(itemcount - 1)



            For index = itemcount - 2 To 0 Step -1
                If listbox.Items(index) = lastitem Then
                    listbox.Items.RemoveAt(index)
                Else
                    lastitem = listbox.Items(index)
                End If
            Next
        End If



    End Sub



    Shared Sub ExtractEmailAddressesFromString(source As TextBox, listbox1 As ListBox)



        Dim mc As MatchCollection
        Dim i As Integer

        Dim rgx As New Regex("<[^>]*>")

        Dim htmlsourcecode As String = rgx.Replace(source.Text, "")


        'If CheckBox1 = True Then

        ' In this section i can change the patter of my regular expressions. whatever the match is, it will be added to a listbox
        'mc = Regex.Matches(htmlsourcecode, "(?i)([a-zA-Z0-9_\-\.]+)@" & EmailDomain.Text)


        'Else

        ' In this section i can change the patter of my regular expressions. whatever the match is, it will be added to a listbox
        mc = Regex.Matches(htmlsourcecode, "(?i)([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})")


        'End If




        Dim results(mc.Count - 1) As String
        For i = 0 To results.Length - 1
            results(i) = mc(i).Value
            listbox1.Items.Add(mc(i).Value)



        Next



        ' Return results
    End Sub




    Shared Sub SaveListboxToTextFile(SaveFileDialog As SaveFileDialog, listbox As ListBox)



        SaveFileDialog.ShowDialog()




        Dim saveurl As String = SaveFileDialog.FileName



        Using SW As New IO.StreamWriter(saveurl & ".txt", True)
            For Each itm As String In listbox.Items
                SW.WriteLine(itm)
            Next
        End Using



    End Sub






    Public Shared Sub RemoveAllTagshtml(textbox As TextBox)



        ' this will remove the tags
        textbox.Text = Regex.Replace(textbox.Text, "<.*?>", String.Empty)






    End Sub






    Public Shared Sub RemoveEverythingBeforeSymbol(textbox As TextBox, symbol As String)



        'DELETE EVERYTHING BEFORE THE SYMBOL > 'this was added to remove the extra information
        Dim index As Integer = textbox.Text.IndexOf(symbol)
        Dim output As String = textbox.Text.Substring(index, textbox.Text.Length - index)
        textbox.Text = output
        Dim sizestring As Integer = symbol.Length
        Scraping.RemoveFirstCharacters(textbox, sizestring) ' this will remove the > simbol




    End Sub



End Class