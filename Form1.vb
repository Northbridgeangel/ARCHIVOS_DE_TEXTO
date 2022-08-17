Imports System.IO 'IMPORTO LA CLASE SYSTEM.IO

Public Class Form1

    'Public oSW As New StreamWriter("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV", True) 'SIN "(,TRUE)" DESTRUYE EL ARCHIVO (YA QUE CREARÍA UNO NUEVO POR CADA NUEVO REGISTRO)
    'CON LA PROPIEDAD "(,TRUE)" AÑADIDA A STREAMWRITER, RENUEVA EL ARCHIVO QUE YA FUE CREADO


    Public MATRIX(1000, 4) As String
    Public D As Integer
    Public F As Integer
    Public CAPITALIZA, FECHABIEN As String


    Private Sub BTN_GRABAR_Click(sender As Object, e As EventArgs) Handles BTN_GRABAR.Click
        Dim oSW As New StreamWriter("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV", True)

        Call CAPITALIZAR(TextBox1.Text)
        TextBox1.Text = CAPITALIZA
        Call CAPITALIZAR(TextBox2.Text)
        TextBox2.Text = CAPITALIZA
        Call CAPITALIZAR(TextBox3.Text)
        TextBox3.Text = CAPITALIZA
        Call FECHAR(TextBox4.Text, 10)
        TextBox4.Text = FECHABIEN

        Dim LINEA As String = TextBox1.Text & ";" & TextBox2.Text & ";" & TextBox3.Text & ";" & TextBox4.Text 'VBNEWLINE, CREA NUEVA LÍNEA (mete linea en blanco)
        oSW.WriteLine(LINEA)
        oSW.Flush()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        oSW.Close()
    End Sub

    Private Sub BTN_LEER_FICHERO_Click(sender As Object, e As EventArgs) Handles BTN_LEER_FICHERO.Click
        ListBox1.Items.Clear()
        Dim oSR As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Dim LINEA As String
        Do
            LINEA = oSR.ReadLine()
            If Not LINEA Is Nothing Then ListBox1.Items.Add(LINEA)
        Loop Until LINEA Is Nothing
        oSR.Close()
    End Sub


    '****************************************************************************************
    'BOTÓN BUSCAR 
    '****************************************************************************************
    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        Dim BUSCA As String
        BUSCA = InputBox("¿QUE BUSCAMOS?", "BUSCAR EN FICHERO DE TEXTO")
        If BUSCA = "" Then Exit Sub
        CAPITALIZAR(BUSCA)
        BUSCA = CAPITALIZA
        Dim p1, p2, p3 As Integer
        Dim c As Integer
        Dim oSR As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Dim LINEA As String
        Do
            LINEA = oSR.ReadLine()
            If Not LINEA Is Nothing Then
                If InStr(LINEA, BUSCA) <> 0 Then
                    p1 = InStr(LINEA, ";")
                    p2 = InStr(p1 + 1, LINEA, ";")
                    p3 = InStr(p2 + 1, LINEA, ";")
                    TextBox1.Text = Mid(LINEA, 1, p1 - 1)
                    TextBox2.Text = Mid(LINEA, p1 + 1, p2 - (p1 + 1))
                    TextBox3.Text = Mid(LINEA, p2 + 1, p3 - (p2 + 1))
                    TextBox4.Text = Mid(LINEA, p3 + 1, Len(LINEA) - p3)
                End If
            End If
        Loop Until LINEA Is Nothing
        oSR.Close()
    End Sub




    Private Sub BTN_ORDEN_POR_APELLIDO_Click(sender As Object, e As EventArgs) Handles BTN_ORDEN_POR_APELLIDO.Click
        Dim p1, p2, p3 As Integer
        Dim c As Integer
        Dim oSR1 As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Dim LINEA As String
        'AVERIGUAR CUANTOS REGISTROS HAY
        Do
            LINEA = oSR1.ReadLine()
            If Not LINEA Is Nothing Then c = c + 1
        Loop Until LINEA Is Nothing

        '--------------------------------------------------------------------
        'COMO YA SE CUANTOS HAY CREO LA MATRIZ DE ESE TAMAÑO
        Dim MATRIZ(c, 4) As String
        c = 0
        oSR1.Close()

        '----------------------------------------------------------------------
        'LLENA LA MATRIZ CON LOS DATOS
        Dim oSR As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Do
            LINEA = oSR.ReadLine()
            If Not LINEA Is Nothing Then
                c = c + 1
                p1 = InStr(LINEA, ";")
                p2 = InStr(p1 + 1, LINEA, ";")
                p3 = InStr(p2 + 1, LINEA, ";")
                MATRIZ(c, 1) = Mid(LINEA, 1, p1 - 1)
                MATRIZ(c, 2) = Mid(LINEA, p1 + 1, p2 - (p1 + 1))
                MATRIZ(c, 3) = Mid(LINEA, p2 + 1, p3 - (p2 + 1))
                MATRIZ(c, 4) = Mid(LINEA, p3 + 1, Len(LINEA) - p3)
            End If
        Loop Until LINEA Is Nothing
        oSR.Close()


        '-----------------------------------------------------------------------------
        ' ORDENACION DE LA MATRIZ
        Dim ORDEN(c, 4) As String
        Dim POSI As Integer
        Dim MINIMO As String
        For I = 1 To c
            MINIMO = "ZZZZZZZZZ"
            POSI = 0
            For X = 1 To c
                If MATRIZ(X, 2) < MINIMO Then
                    MINIMO = MATRIZ(X, 2)
                    POSI = X
                End If

            Next

            ORDEN(I, 2) = MINIMO
            ORDEN(I, 1) = MATRIZ(POSI, 1)
            ORDEN(I, 3) = MATRIZ(POSI, 3)
            ORDEN(I, 4) = MATRIZ(POSI, 4)
            MATRIZ(POSI, 2) = "ZZZZZZZZZZZ"
        Next
        '-------------------------------------------------------------
        'CARGO ORDEN EN EL LISTBOX1
        ListBox1.Items.Clear()
        For I = 1 To c
            ListBox1.Items.Add(ORDEN(I, 1) & ";" & ORDEN(I, 2) & ";" & ORDEN(I, 3) & ";" & ORDEN(I, 4))
        Next

    End Sub
    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    '*******************************************************************************************************************
    'BTN_BORRAR
    '*******************************************************************************************************************
    ' 1ª FASE AVERIGUAR CUANTOS REGISTROS HAY 
    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        Dim oSR2 As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Dim Linea As String
        Dim c As Integer
        Dim D As Integer
        Dim P1, P2, P3 As Integer

        Do
            Linea = oSR2.ReadLine()
            If Not Linea Is Nothing Then c = c + 1
        Loop Until Linea Is Nothing
        '-------------------------------------------------------
        'COMO YA SE CUANTOS HAY CREO LA MATRIZ DE ESE TAMAÑO
        Dim MATRIZ(c, 4) As String
        oSR2.Close()
        D = c ' COMO LUEGO USO C PARA NO PERDER EL VALOR LO METO EN D
        c = 0

        '---------------------------------------------------------
        ' LLENA LA MATRIZ CON LOS DATOS
        Dim oSR3 As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Do
            Linea = oSR3.ReadLine()
            If Not Linea Is Nothing Then
                c = c + 1
                P1 = InStr(Linea, ";")
                P2 = InStr(P1 + 1, Linea, ";")
                P3 = InStr(P2 + 1, Linea, ";")
                MATRIZ(c, 1) = Mid(Linea, 1, P1 - 1)
                MATRIZ(c, 2) = Mid(Linea, P1 + 1, P2 - (P1 + 1))
                MATRIZ(c, 3) = Mid(Linea, P2 + 1, P3 - (P2 + 1))
                MATRIZ(c, 4) = Mid(Linea, P3 + 1, Len(Linea) - P3)
            End If
        Loop Until Linea Is Nothing
        oSR3.Close()
        '----------------------------------------------------------------------
        'BORRAR 2ª FASE 
        ' BUSCAR
        c = 0
        Dim BUSCA As String
        BUSCA = InputBox("¿Que Buscamos?", "BUSCAR EN FICHERO DE TEXTO")
        If BUSCA = "" Then Exit Sub
        CAPITALIZAR(BUSCA)
        BUSCA = CAPITALIZA

        Dim oSR As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Do
            Linea = oSR.ReadLine()
            If Not Linea Is Nothing Then
                c = c + 1
                If InStr(Linea, BUSCA) <> 0 Then
                    P1 = InStr(Linea, ";")
                    P2 = InStr(P1 + 1, Linea, ";")
                    P3 = InStr(P2 + 1, Linea, ";")
                    TextBox1.Text = Mid(Linea, 1, P1 - 1)
                    TextBox2.Text = Mid(Linea, P1 + 1, P2 - (P1 + 1))
                    TextBox3.Text = Mid(Linea, P2 + 1, P3 - (P2 + 1))
                    TextBox4.Text = Mid(Linea, P3 + 1, Len(Linea) - P3)
                    MATRIZ(c, 1) = ""
                    MATRIZ(c, 2) = ""
                    MATRIZ(c, 3) = ""
                    MATRIZ(c, 4) = ""
                End If
            End If
        Loop Until Linea Is Nothing
        oSR.Close()
        ' ULTIMA FASE GRABAR LA MATRIZ EN EL FICHERO (SIN EL QUE BORRAMOS)
        ' AQUI USO EL RECORDATORIO D PARA HACER EL BUCLE
        Dim oSR4 As New StreamWriter("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        For I = 1 To D
            If MATRIZ(I, 1) <> "" Then
                Dim Linea1 As String = MATRIZ(I, 1) & ";" & MATRIZ(I, 2) & ";" & MATRIZ(I, 3) & ";" & MATRIZ(I, 4)
                oSR4.WriteLine(Linea1)
            End If
        Next
        oSR4.Close()

    End Sub

    '*************************************************************************************************************
    'GUARDAR EDICION
    Private Sub BTN_GUARDAR_EDICION_Click(sender As Object, e As EventArgs) Handles BTN_GUARDAR_EDICION.Click
        Dim a, b, g As String
        a = TextBox1.Text
        CAPITALIZAR(a)
        b = TextBox2.Text
        CAPITALIZAR(b)
        g = TextBox4.Text
        FECHAR(g, 10)
        MATRIX(F, 1) = TextBox1.Text
        MATRIX(F, 2) = TextBox2.Text
        MATRIX(F, 3) = TextBox3.Text
        MATRIX(F, 4) = TextBox4.Text
        '-------------------
        ' ULTIMA FASE GRABAR LA MATRIZ EN EL FICHERO (SIN EL QUE BORRAMOS)
        ' AQUI USO EL RECORDATORIO D PARA HACER EL BUCLE
        Dim oSR3 As New StreamWriter("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        For I = 1 To D

            Dim Linea1 As String = MATRIX(I, 1) & ";" & MATRIX(I, 2) & ";" & MATRIX(I, 3) & ";" & MATRIX(I, 4)
            oSR3.WriteLine(Linea1)

        Next
        oSR3.Close()
        '----------------------
        BTN_EDITAR.Visible = True
        BTN_GUARDAR_EDICION.Visible = False
    End Sub

    '*************************************************************************************************************
    'EDITAR REGISTRO
    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        Dim F As Integer
        Dim D As Integer
        Dim MATRIX(F, 4) As String
        ' 1ª FASE AVERIGUAR CUANTOS REGISTROS HAY 
        Dim oSR1 As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Dim Linea As String
        Dim c As Integer

        Dim P1, P2, P3 As Integer
        Do
            Linea = oSR1.ReadLine()
            If Not Linea Is Nothing Then c = c + 1
        Loop Until Linea Is Nothing
        '-------------------------------------------------------
        'COMO YA SE CUANTOS HAY CREO LA MATRIZ DE ESE TAMAÑO
        ReDim MATRIX(c, 4)
        oSR1.Close()
        D = c ' COMO LUEGO USO C PARA NO PERDER EL VALOR LO METO EN D
        c = 0
        '---------------------------------------------------------
        ' LLENA LA MATRIZ CON LOS DATOS
        Dim oSR2 As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Do
            Linea = oSR2.ReadLine()
            If Not Linea Is Nothing Then
                c = c + 1
                P1 = InStr(Linea, ";")
                P2 = InStr(P1 + 1, Linea, ";")
                P3 = InStr(P2 + 1, Linea, ";")
                MATRIX(c, 1) = Mid(Linea, 1, P1 - 1)
                MATRIX(c, 2) = Mid(Linea, P1 + 1, P2 - (P1 + 1))
                MATRIX(c, 3) = Mid(Linea, P2 + 1, P3 - (P2 + 1))
                MATRIX(c, 4) = Mid(Linea, P3 + 1, Len(Linea) - P3)
            End If
        Loop Until Linea Is Nothing
        oSR2.Close()
        '----------------------------------------------------------------------
        'BORRAR 2ª FASE 
        ' BUSCAR
        c = 0
        Dim BUSCA As String
        BUSCA = InputBox("¿QUE BUSCAMOS?", "BUSCAR EN FICHERO DE TEXTO")

        CAPITALIZAR(BUSCA)
        BUSCA = CAPITALIZA

        Dim oSR As New StreamReader("C:\Cristina\A_BTN_REGISTROS\Archivo_REGISTROS.CSV")
        Do
            Linea = oSR.ReadLine()
            If Not Linea Is Nothing Then
                c = c + 1
                If InStr(Linea, BUSCA) <> 0 Then
                    P1 = InStr(Linea, ";")
                    P2 = InStr(P1 + 1, Linea, ";")
                    P3 = InStr(P2 + 1, Linea, ";")
                    TextBox1.Text = Mid(Linea, 1, P1 - 1)
                    TextBox2.Text = Mid(Linea, P1 + 1, P2 - (P1 + 1))
                    TextBox3.Text = Mid(Linea, P2 + 1, P3 - (P2 + 1))
                    TextBox4.Text = Mid(Linea, P3 + 1, Len(Linea) - P3)
                    MATRIX(c, 1) = ""
                    MATRIX(c, 2) = ""
                    MATRIX(c, 3) = ""
                    MATRIX(c, 4) = ""
                    F = c ' PAN Y TOMATE PA QUE NO TE ESCAPES
                End If
            End If
        Loop Until Linea Is Nothing
        oSR.Close()
        '-----------------------------------------------------
        BTN_EDITAR.Visible = False
        BTN_GUARDAR_EDICION.Visible = True
    End Sub






    '*********************************************************************************************************************
    'SUB CAPITALIZAR Y SUB FECHAR
    '*********************************************************************************************************************
    '*******************************************************************************************************************************************************************************************
    Sub CAPITALIZAR(DD As String)
        '*******************************************************************
        'PON EN MAYUSCULAS LA PRIMERA LETRA DEL TEXTO QUE LE ENVIEMOS A LA FUNCIÓN
        '****      Y LO DEVUELVE EN LA VARIABLE PUBLIC CAPITALIZA
        If IsNumeric(DD) Then
            CAPITALIZA = ""
            MsgBox("Datos Incorrectos",, "TONTERÍA INTRODUCIDA")
            Exit Sub
        End If

        DD = Trim(DD)
        Dim L As Char
        Dim MIDE As Integer
        'Dim RESULTADO As String
        Dim flag As Integer
        CAPITALIZA = ""

        'RUTINA PARA LOS ESPACIOS

        flag = 0

        MIDE = Len(DD)

        For I = 1 To MIDE
            L = Mid(DD, I, 1)

            If L = " " Then
                flag = 1
                GoTo SAL
            End If

            If I = 1 Or flag = 1 Then
                L = UCase(L)
                flag = 0
            Else
                L = LCase(L)
            End If

SAL:            'RESULTADO = RESULTADO & L
            CAPITALIZA = CAPITALIZA & L
        Next
        'TextBox2.Text = RESULTADO
    End Sub



    '19/02/2020


    Sub FECHAR(DD As String, NN As Integer)
        Dim barra1, barra2 As Integer
        Dim d, m, y As String
        Dim x As Integer
        Dim xx As String
        Dim VERSIFECHA As Date



        Try
            VERSIFECHA = CDate(DD)
            Exit Try
        Catch ex As Exception
            MsgBox("ESA MIERDA NO ES NI NUNCA SERÁ UNA FECHA")
        End Try


        If NN <> 10 And NN <> 8 Then
            MsgBox("Parametro Tipo de Fecha erroneo, por favor mete un 8 o un 10")
            Exit Sub
        End If

        ' donde estan las barras???
        barra1 = InStr(DD, "/")
        barra2 = InStr(barra1 + 1, DD, "/")
        'barra1= 3(dd/m) y barra2= 6(m/yy), siendo la fecha= DD(dd/mm/yy)

        If barra1 <> 0 And barra2 <> 0 Then ' el humano ha metido las barras de fecha
            d = Mid(DD, 1, barra1 - 1)
            m = Mid(DD, barra1 + 1, barra2 - (barra1 + 1))
            'COMPROBAR QUE D Y M SEN RAZONABLES
            y = Mid(DD, barra2 + 1, Len(DD) - (barra2))
            ' ahora le ponemos lo que le falta si no ha puesto el cero delante
            If Len(d) = 1 Then d = "0" & d
            If Len(m) = 1 Then m = "0" & m
            If NN = 10 And Len(y) = 2 Then ' houston tenemos un poblema
                x = DateAndTime.Year(DateAndTime.Today)
                xx = CStr(x)
                xx = Mid(xx, 3, 2)
                If CInt(y) > CInt(xx) Then
                    y = "19" & y
                Else
                    y = "20" & y
                End If
            End If
        End If
        FECHABIEN = d & "/" & m & "/" & y
    End Sub


    '********************************************************************************************************************
    '***********************************************************************************************************************************************************************************************





End Class
