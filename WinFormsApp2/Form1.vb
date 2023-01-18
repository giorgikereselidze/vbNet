Imports System.Drawing.Drawing2D
Imports excel = Microsoft.office.interop.excel


Public Class Form1

    Dim cxrili As New DataTable
    Sub tanabari()
        Dim k, i As Int16
        Dim weli, sab, lik, vada As Integer
        Dim amor, narch As Single
        Call atanabari()
        weli = Vweli.Text : sab = Vsab.Text : lik = Vlik.Text : vada = Vvada.Text
        amor = (sab - lik) / vada
        For i = weli To Year(Today)
            weli = weli + 1
            k = k + 1
            amor = (sab - lik) / vada
            narch = sab - amor * k
            cxrili.Rows.Add(New String() {i, Vsab.Text, Vlik.Text, Vvada.Text, amor, narch})
        Next

        DGsia.DataSource = cxrili
        Dim ex As New excel.application
        Call shedegi()

    End Sub

    Sub shedegi()
        Dim ex = New excel.application
        Dim gverdi As excel.worksheet
        ex.workbooks.add()
        Dim k As Integer
        gverdi = ex.worksheets.add
        gverdi.name = "ოქმი"
        With cxrili
            For t = 0 To cxrili.Columns.Count - 1
                gverdi.cells(1, t + 1) = cxrili.Columns(t).Caption
            Next
            k = 2
            For i = 0 To cxrili.Rows.Count - 1
                For t = 0 To .Columns.Count - 1
                    gverdi.cells(k, t + 1) = cxrili(i)(t)
                Next
                k = k + 1
            Next
            gverdi.range(gverdi.cells(1, 1), gverdi.cells(.Rows.Count + 1, .Columns.Count)).columnwidth = 10
            gverdi.range(gverdi.cells(1, 1), gverdi.cells(.Rows.Count + 1, .Columns.Count)).font.bold = True
            gverdi.range(gverdi.cells(1, 1), gverdi.cells(.Rows.Count + 1, .Columns.Count)).wraptext = True
            gverdi.range(gverdi.cells(1, 1), gverdi.cells(.Rows.Count + 1, .Columns.Count)).borderAround2()
            gverdi.range(gverdi.cells(1, 1), gverdi.cells(.Rows.Count + 1, .Columns.Count)).borders.linestyle = 1
            gverdi.range(gverdi.cells(1, 1), gverdi.cells(.Rows.Count + 1, .Columns.Count)).borders.weight = 1
            ex.visible = True
        End With
    End Sub



    Sub atanabari()
        cxrili.Clear() : cxrili.Columns.Clear()
        With cxrili
            .Columns.Add("წელი")
            .Columns.Add("საბალანსო ღირებულება")
            .Columns.Add("სალიკვიდაციო ღირებულება")
            .Columns.Add("ექსპლუატაციის ვადა")
            .Columns.Add("ამორტიზაცია")
            .Columns.Add("ნარჩენი ღირებულება")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call tanabari()
    End Sub

    Private Sub Lweli_Click(sender As Object, e As EventArgs) Handles Lweli.Click

    End Sub
End Class
