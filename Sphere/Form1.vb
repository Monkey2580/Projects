Public Class Form1
    Dim formGraphics As System.Drawing.Graphics
    Dim myPen As Pen
    Dim canvas As Bitmap
    Dim rotangle, nlat, nlong As New Integer
    Dim dlong, dlat, r As Double
    Dim tempvertex(,), polygonlist(,) As Double
    Private Wt(4, 4), Vt(4, 4), sT(4, 4) As Double
    Dim V(), VW(), VR(), VS() As TPoint
    Dim PolyPoints() As Poly
    Dim lightSrc(2) As Double
    Public Class TPoint
        Public x, y, z, w As Double
    End Class
    Public Class Poly
        Public p1, p2, p3 As Integer
    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)

        formGraphics = Graphics.FromImage(canvas)
        formGraphics.Clear(Color.Black)

        myPen = New Pen(Color.Red)

        rotangle = 0
        InsertingMatrix(Wt, 0, 1, 0, 0, 0)
        InsertingMatrix(Wt, 1, 0, 1, 0, 0)
        InsertingMatrix(Wt, 2, 0, 0, 1, 0)
        InsertingMatrix(Wt, 3, 0, 0, 0, 1)

        InsertingMatrix(Vt, 0, 1, 0, 0, 0) 'InsertingMatrix(Vt, 0, 0, 0, 1, 0) untuk tampak atas 
        InsertingMatrix(Vt, 1, 0, 1, 0, 0) 'InsertingMatrix(Vt, 1, 1, 0, 0, 0)
        InsertingMatrix(Vt, 2, 0, 0, 0, 0) 'InsertingMatrix(Vt, 2, 0, 0, 0, 0)
        InsertingMatrix(Vt, 3, 0, 0, 0, 1) 'InsertingMatrix(Vt, 3, 0, 0, 0, 1)

        InsertingMatrix(sT, 0, 1, 0, 0, 200)
        InsertingMatrix(sT, 1, 0, -1, 0, 200)
        InsertingMatrix(sT, 2, 0, 0, 0, 0)
        InsertingMatrix(sT, 3, 0, 0, 0, 1)
        Draw_poly()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formGraphics.Clear(Color.Black)
        PictureBox1.Image = canvas
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LatitudeTB.Text = 3
        LongitudeTB.Text = 4
        RadiusTB.Text = 120
        formGraphics.Clear(Color.Black)
        PictureBox1.Image = canvas
        Draw_poly()
    End Sub
    Private Sub SetTPoint(ByVal points As TPoint, ByVal x As Double, ByVal y As Double, ByVal z As Double, ByVal w As Double)
        points.x = x
        points.y = y
        points.z = z
        points.w = w
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Start()
    End Sub
    Private Sub STPRotBtn_Click(sender As Object, e As EventArgs) Handles STPRotBtn.Click
        Timer1.Stop()
    End Sub
    Private Sub SetTPoly(ByVal Poly As Poly, ByVal p1 As Integer, ByVal p2 As Integer, ByVal p3 As Integer)
        Poly.p1 = p1
        Poly.p2 = p2
        Poly.p3 = p3
    End Sub
    Private Sub InsertingMatrix(ByVal Matrix(,) As Double, ByVal idx As Integer, ByVal i As Double, ByVal j As Double, ByVal k As Double, ByVal l As Double)
        Matrix(idx, 0) = i
        Matrix(idx, 1) = j
        Matrix(idx, 2) = k
        Matrix(idx, 3) = l
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TransX.Text = 0
        TransY.Text = 0
        TransZ.Text = 0
        InsertingMatrix(Wt, 0, 1, 0, 0, TransX.Text)
        InsertingMatrix(Wt, 1, 0, 1, 0, TransY.Text)
        InsertingMatrix(Wt, 2, 0, 0, 1, TransZ.Text)
        InsertingMatrix(Wt, 3, 0, 0, 0, 1)
        formGraphics.Clear(Color.Black)
        PictureBox1.Image = canvas
        Draw_poly()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        InsertingMatrix(Wt, 0, 1, 0, 0, TransX.Text)
        InsertingMatrix(Wt, 1, 0, 1, 0, TransY.Text)
        InsertingMatrix(Wt, 2, 0, 0, 1, TransZ.Text)
        InsertingMatrix(Wt, 3, 0, 0, 0, 1)
        formGraphics.Clear(Color.Black)
        PictureBox1.Image = canvas
        Draw_poly()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        rotangle = 0
        InsertingMatrix(Wt, 0, 1, 0, 0, 0)
        InsertingMatrix(Wt, 1, 0, 1, 0, 0)
        InsertingMatrix(Wt, 2, 0, 0, 1, 0)
        InsertingMatrix(Wt, 3, 0, 0, 0, 1)
        formGraphics.Clear(Color.Black)
        PictureBox1.Image = canvas
        Draw_poly()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        LatitudeTB.Text = 10
        LongitudeTB.Text = 10
        RadiusTB.Text = 120
        TransX.Text = 0
        TransY.Text = 0
        TransZ.Text = 0
        rotangle = 0
        Timer1.Stop()
        InsertingMatrix(Wt, 0, 1, 0, 0, 0)
        InsertingMatrix(Wt, 1, 0, 1, 0, 0)
        InsertingMatrix(Wt, 2, 0, 0, 1, 0)
        InsertingMatrix(Wt, 3, 0, 0, 0, 1)

        InsertingMatrix(Vt, 0, 1, 0, 0, 0)
        InsertingMatrix(Vt, 1, 0, 1, 0, 0)
        InsertingMatrix(Vt, 2, 0, 0, 0, 0)
        InsertingMatrix(Vt, 3, 0, 0, 0, 1)

        InsertingMatrix(sT, 0, 1, 0, 0, 200)
        InsertingMatrix(sT, 1, 0, -1, 0, 200)
        InsertingMatrix(sT, 2, 0, 0, 0, 0)
        InsertingMatrix(sT, 3, 0, 0, 0, 1)
        formGraphics.Clear(Color.Black)
        PictureBox1.Image = canvas
        Draw_poly()
    End Sub
    Private Sub SpesialInsertingMatrix(ByVal Matrix(,) As Double, ByVal idx As Integer, ByVal i As Double, ByVal j As Double, ByVal k As Double, ByVal l As Double)
        Matrix(idx, 0) = i
        Matrix(idx + 1, 0) = j
        Matrix(idx + 2, 0) = k
        Matrix(idx + 3, 0) = l
    End Sub
    Private Function MatrixMulti(ByVal Matrix1(,) As Double, ByVal Matrix2(,) As Double) As Double(,)
        Dim result(UBound(Matrix2, 1) - 1, UBound(Matrix1, 2) - 1) As Double
        For i As Integer = 0 To UBound(result, 2)
            For j As Integer = 0 To UBound(Matrix1, 1) - 1
                For k As Integer = 0 To UBound(Matrix2, 2) - 1
                    result(j, i) += Matrix1(k, i) * Matrix2(j, k)
                Next
            Next
        Next
        Return result
    End Function
    Private Function UnitVector(ByVal vector() As Double)
        Dim temp As Double
        If vector(0) = 0 And vector(1) = 0 And vector(2) = 0 Then
            temp = 1
        Else
            temp = Math.Sqrt(vector(0) ^ 2 + vector(1) ^ 2 + vector(2) ^ 2)
        End If

        vector(0) = vector(0) / temp
        vector(1) = vector(1) / temp
        vector(2) = vector(2) / temp
        Return vector
    End Function
    Private Function UnitVector(ByVal vector As TPoint) As TPoint
        Dim temp As Double
        If vector.x = 0 And vector.y = 0 And vector.z = 0 Then
            temp = 1

        Else
            temp = Math.Sqrt(vector.x ^ 2 + vector.y ^ 2 + vector.z ^ 2)
        End If

        vector.x = vector.x / temp
        vector.y = vector.y / temp
        vector.z = vector.z / temp
        Return vector
    End Function
    Private Function DotUnitVector(ByVal vector1 As TPoint, ByVal vector2 As TPoint) As Double
        Dim temp As Double
        temp = (vector1.x * vector2.x) + (vector1.y * vector2.y) + (vector1.z * vector2.z)
        Return temp
    End Function
    Function Ambient(ByVal ka As Double)
        Dim amb(2) As Double
        amb(0) = ka * 255
        amb(1) = ka * 0
        amb(2) = ka * 0
        Return amb
    End Function
    Private Function Diffuse(kd As Double, LdotN As Double)
        Dim temp(2) As Double
        If LdotN < 0 Then
            LdotN = 0
        End If
        temp(0) = kd * 255 * LdotN
        temp(1) = kd * 255 * LdotN
        temp(2) = kd * 255 * LdotN
        Return temp
    End Function
    Private Function Specular(ByVal ks As Double, ByVal VdotR As Double, ByVal exponent As Integer)
        Dim temp(2) As Double
        If VdotR < 0 Then
            VdotR = 0
        End If
        temp(0) = ks * 255 * (VdotR ^ exponent)
        temp(1) = ks * 255 * (VdotR ^ exponent)
        temp(2) = ks * 255 * (VdotR ^ exponent)
        Return temp
    End Function
    Private Function ItotP(ByVal Ambient() As Double, ByVal Diffuse() As Double, ByVal Specular() As Double)
        Dim temp(2) As Integer
        temp(0) = Ambient(0) + Diffuse(0) + Specular(0)
        temp(1) = Ambient(1) + Diffuse(1) + Specular(1)
        temp(2) = Ambient(2) + Diffuse(2) + Specular(2)
        If temp(0) >= 255 Then
            temp(0) = 255
        End If
        If temp(0) <= 0 Then
            temp(0) = 0
        End If
        If temp(1) >= 255 Then
            temp(1) = 255
        End If
        If temp(1) <= 0 Then
            temp(1) = 0
        End If
        If temp(2) >= 255 Then
            temp(2) = 255
        End If
        If temp(2) <= 0 Then
            temp(2) = 0
        End If
        Return temp
    End Function
    Private Function VerticeNormal(ByVal vertice As TPoint, ByVal CenterOfSphere As TPoint) As TPoint
        Dim Normal As TPoint
        Normal = New TPoint

        Normal.x = vertice.x - CenterOfSphere.x
        Normal.y = vertice.y - CenterOfSphere.y
        Normal.z = vertice.z - CenterOfSphere.z

        Return Normal
    End Function
    Private Function UnitVectorR(ByVal LdotN As Double, ByVal vertice As TPoint, ByVal Ls As TPoint) As TPoint
        Dim R As TPoint
        R = New TPoint

        R.x = 2 * LdotN * vertice.x - Ls.x
        R.y = 2 * LdotN * vertice.y - Ls.y
        R.z = 2 * LdotN * vertice.z - Ls.z
        Return R
    End Function
    Private Function UnitVectorL(ByVal LightSource() As Double, ByVal vertice As TPoint) As TPoint
        Dim L As TPoint
        L = New TPoint

        L.x = LightSource(0) - (vertice.x)
        L.y = LightSource(1) - (vertice.y)
        L.z = LightSource(2) - (vertice.z)
        L = UnitVector(L)
        Return L
    End Function
    Private Function UnitVectorV(ByVal vertice As TPoint) As TPoint
        Dim V As TPoint
        V = New TPoint

        V.x = 0 - (vertice.x)
        V.y = 0 - (vertice.y)
        V.z = 1000 - (vertice.z)
        V = UnitVector(V)
        Return V
    End Function
    Private Function ItotAtPoint(ByVal itotp1() As Integer, itotp2() As Integer, vertice1 As TPoint, vertice2 As TPoint, YofP As Integer) As Integer()
        Dim RGB(2) As Integer
        RGB(0) = itotp1(0) - (itotp1(0) - itotp2(0)) * ((vertice1.y - YofP) / (vertice1.y - vertice2.y))
        RGB(1) = itotp1(1) - (itotp1(1) - itotp2(1)) * ((vertice1.y - YofP) / (vertice1.y - vertice2.y))
        RGB(2) = itotp1(2) - (itotp1(2) - itotp2(2)) * ((vertice1.y - YofP) / (vertice1.y - vertice2.y))
        Return RGB
    End Function
    Private Function ItotAtPoint(ByVal IatB() As Integer, IatA() As Integer, XofB As Double, XofA As Double, XofP As Integer) As Integer()
        Dim RGB(2) As Integer
        Dim temp As Integer
        temp = XofB - XofA
        If temp = 0 Then
            temp = 1
        End If
        RGB(0) = IatB(0) - (IatB(0) - IatA(0)) * ((XofB - XofP) / temp)
        RGB(1) = IatB(1) - (IatB(1) - IatA(1)) * ((XofB - XofP) / temp)
        RGB(2) = IatB(2) - (IatB(2) - IatA(2)) * ((XofB - XofP) / temp)

        If RGB(0) >= 255 Then
            RGB(0) = 255
        End If
        If RGB(0) <= 0 Then
            RGB(0) = 0
        End If
        If RGB(1) >= 255 Then
            RGB(1) = 255
        End If
        If RGB(1) <= 0 Then
            RGB(1) = 0
        End If
        If RGB(2) >= 255 Then
            RGB(2) = 255
        End If
        If RGB(2) <= 0 Then
            RGB(2) = 0
        End If
        Return RGB
    End Function
    Private Function NormalAtPoint(NormalAtP1 As TPoint, NormalAtP2 As TPoint, vertice1 As TPoint, vertice2 As TPoint, YofP As Integer) As TPoint
        Dim Normal As TPoint
        Normal = New TPoint
        Normal.x = NormalAtP1.x - (NormalAtP1.x - NormalAtP2.x) * ((vertice1.y - YofP) / (vertice1.y - vertice2.y))
        Normal.y = NormalAtP1.y - (NormalAtP1.y - NormalAtP2.y) * ((vertice1.y - YofP) / (vertice1.y - vertice2.y))
        Normal.z = NormalAtP1.z - (NormalAtP1.z - NormalAtP2.z) * ((vertice1.y - YofP) / (vertice1.y - vertice2.y))
        Return Normal
    End Function
    Private Function NormalAtPoint(NormalAtP1 As TPoint, NormalAtP2 As TPoint, XofB As Double, XofA As Double, XofP As Integer) As TPoint
        Dim Normal As TPoint
        Normal = New TPoint
        Dim temp As Integer
        temp = XofB - XofA
        If temp = 0 Then
            temp = 1
        End If
        Normal.x = NormalAtP1.x - (NormalAtP1.x - NormalAtP2.x) * ((XofB - XofP) / temp)
        Normal.y = NormalAtP1.y - (NormalAtP1.y - NormalAtP2.y) * ((XofB - XofP) / temp)
        Normal.z = NormalAtP1.z - (NormalAtP1.z - NormalAtP2.z) * ((XofB - XofP) / temp)
        Return Normal
    End Function
    Private Function ScanLine(ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double, ByVal X3 As Double, ByVal Y3 As Double, up As Boolean)
        Dim dx, dy, idx As Integer
        Dim Set1(2, 3), xfirst(Math.Abs(Y1 - Y3)), xsecond(Math.Abs(Y1 - Y3)), xymin1, xymin2, xline(Math.Abs(Y1 - Y3), 1) As Double
        If up = True Then
            Set1(0, 0) = Y3
            Set1(0, 1) = X1
            dx = X3 - X1
            dy = Y3 - Y1
            If dy < 0 Then
                dy *= -1
                dx *= -1
            End If
            Set1(0, 2) = dx
            Set1(0, 3) = dy
            Set1(1, 0) = Y3
            Set1(1, 1) = X2



            If Y2 = Y3 Then

                dx = X2 - X1
                dy = Y2 - Y1

                If dy < 0 Then
                    dy = dy * -1
                    dx = dx * -1
                End If
            Else
                dx = X3 - X2
                dy = Y3 - Y2
                If dy < 0 Then
                    dy = dy * -1
                    dx = dx * -1
                End If
            End If
            Set1(1, 2) = dx
            Set1(1, 3) = dy
            xymin1 = X1
            xymin2 = X2
        Else
            Set1(0, 0) = Y2
            Set1(0, 1) = X1
            dx = X2 - X1
            dy = Y2 - Y1
            If dy < 0 Then
                dy = dy * -1
                dx = dx * -1
            End If
            Set1(0, 2) = dx
            Set1(0, 3) = dy
            Set1(1, 0) = Y3
            Set1(1, 1) = X1



            If Y2 = Y3 Then

                dx = X3 - X1
                dy = Y3 - Y1

                If dy < 0 Then
                    dy = dy * -1
                    dx = dx * -1
                End If
            Else
                dx = X3 - X2
                dy = Y3 - Y2
                If dy < 0 Then
                    dy = dy * -1
                    dx = dx * -1
                End If
            End If
            Set1(1, 2) = dx
            Set1(1, 3) = dy
            xymin1 = X1
            xymin2 = X1
        End If

        xline(0, 0) = CInt(xymin1)
        xline(0, 1) = CInt(xymin2)
        idx = 1
        For i As Integer = Y1 To Y3 - 1
            xymin1 = (Set1(0, 3) * xymin1 + Set1(0, 2)) / Set1(0, 3)

            xymin2 = (Set1(1, 3) * xymin2 + Set1(1, 2)) / Set1(1, 3)
            If Y2 = Y3 Then
                xline(idx, 0) = CInt(xymin2)
                xline(idx, 1) = CInt(xymin1)
            Else
                xline(idx, 0) = CInt(xymin1)
                xline(idx, 1) = CInt(xymin2)
            End If
            idx += 1
        Next
        Return xline
    End Function
    Private Function DegreesToRadians(ByVal degrees As Double) As Double
        Return degrees * Math.PI / 180
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        formGraphics.Clear(Color.Black)
        rotangle += 2
        If RBRotZ.Checked = True Then
            InsertingMatrix(Wt, 0, Math.Cos(DegreesToRadians(rotangle)), -Math.Sin(DegreesToRadians(rotangle)), 0, 0)
            InsertingMatrix(Wt, 1, Math.Sin(DegreesToRadians(rotangle)), Math.Cos(DegreesToRadians(rotangle)), 0, 0)
            InsertingMatrix(Wt, 2, 0, 0, 1, 0)
            InsertingMatrix(Wt, 3, 0, 0, 0, 1)
        ElseIf RBRotY.Checked = True Then
            InsertingMatrix(Wt, 0, Math.Cos(DegreesToRadians(rotangle)), 0, Math.Sin(DegreesToRadians(rotangle)), 0)
            InsertingMatrix(Wt, 1, 0, 1, 0, 0)
            InsertingMatrix(Wt, 2, -Math.Sin(DegreesToRadians(rotangle)), 0, Math.Cos(DegreesToRadians(rotangle)), 0)
            InsertingMatrix(Wt, 3, 0, 0, 0, 1)
        Else
            InsertingMatrix(Wt, 0, 1, 0, 0, 0)
            InsertingMatrix(Wt, 1, 0, Math.Cos(DegreesToRadians(rotangle)), -Math.Sin(DegreesToRadians(rotangle)), 0)
            InsertingMatrix(Wt, 2, 0, Math.Sin(DegreesToRadians(rotangle)), Math.Cos(DegreesToRadians(rotangle)), 0)
            InsertingMatrix(Wt, 3, 0, 0, 0, 1)
        End If
        Draw_poly()
    End Sub
    Function Polartocartesian(ByVal r As Double, ByVal d As Double, ByVal e As Integer) As Double()
        Dim x As Double = r * Math.Cos(DegreesToRadians(e)) * Math.Sin(DegreesToRadians(d))
        Dim y As Double = r * Math.Sin(DegreesToRadians(e))
        Dim z As Double = r * Math.Cos(DegreesToRadians(e)) * Math.Cos(DegreesToRadians(d))
        Return New Double() {x, y, z}
    End Function
    Function Crossproduct(ByVal a As TPoint, ByVal b As TPoint) As TPoint
        Dim result As TPoint
        result = New TPoint
        result.x = (a.y * b.z) - (a.z * b.y)
        result.y = (a.z * b.x) - (a.x * b.z)
        result.z = (a.x * b.y) - (a.y * b.x)
        Return result
    End Function
    Function Dotproduct(ByVal b As TPoint) As Double
        Dim a As Double
        a = (0 * b.x) + (0 * b.y) + (-1 * b.z)

        Return a
    End Function
    Private Sub Sphere_vertex()

        nlat = CInt(LatitudeTB.Text)
        nlong = CInt(LongitudeTB.Text)
        dlong = 360 / nlong
        dlat = 90 / nlat
        r = CInt(RadiusTB.Text)
        ReDim tempvertex(2 * (nlong * nlat) + 1, 2)
        Dim idx As Integer = 0
        For j As Integer = 0 To nlat - 1
            For i As Integer = 0 To nlong - 1
                tempvertex(idx, 0) = r
                tempvertex(idx, 1) = i * dlong
                tempvertex(idx, 2) = j * dlat
                idx = idx + 1
            Next
        Next
        tempvertex(idx, 0) = r
        tempvertex(idx, 1) = 0
        tempvertex(idx, 2) = 90
        idx = idx + 1
        For j As Integer = 0 To nlat - 1
            For i As Integer = 0 To nlong - 1
                tempvertex(idx, 0) = r
                tempvertex(idx, 1) = i * dlong
                tempvertex(idx, 2) = -j * dlat
                idx = idx + 1
            Next
        Next
        tempvertex(2 * (nlong * nlat) + 1, 0) = r
        tempvertex(2 * (nlong * nlat) + 1, 1) = 0
        tempvertex(2 * (nlong * nlat) + 1, 2) = -90





        ReDim V(UBound(tempvertex, 1))
        For i As Integer = 0 To UBound(tempvertex, 1)
            V(i) = New TPoint
            SetTPoint(V(i), Polartocartesian(tempvertex(i, 0), tempvertex(i, 1), tempvertex(i, 2))(0), Polartocartesian(tempvertex(i, 0), tempvertex(i, 1), tempvertex(i, 2))(1), Polartocartesian(tempvertex(i, 0), tempvertex(i, 1), tempvertex(i, 2))(2), 1)
        Next

        Dim temppoints(4, 1) As Double
        ReDim VW(UBound(V, 1))
        ReDim VR(UBound(V, 1))
        ReDim VS(UBound(V, 1))
        For i As Integer = 0 To UBound(V, 1)
            SpesialInsertingMatrix(temppoints, 0, V(i).x, V(i).y, V(i).z, V(i).w)
            VW(i) = New TPoint
            SetTPoint(VW(i), MatrixMulti(temppoints, Wt)(0, 0), MatrixMulti(temppoints, Wt)(1, 0), MatrixMulti(temppoints, Wt)(2, 0), MatrixMulti(temppoints, Wt)(3, 0))
            SpesialInsertingMatrix(temppoints, 0, VW(i).x, VW(i).y, VW(i).z, VW(i).w)
            VR(i) = New TPoint
            SetTPoint(VR(i), MatrixMulti(temppoints, Vt)(0, 0), MatrixMulti(temppoints, Vt)(1, 0), MatrixMulti(temppoints, Vt)(2, 0), MatrixMulti(temppoints, Vt)(3, 0))
            SpesialInsertingMatrix(temppoints, 0, VR(i).x, VR(i).y, VR(i).z, VR(i).w)
            VS(i) = New TPoint
            SetTPoint(VS(i), MatrixMulti(temppoints, sT)(0, 0), MatrixMulti(temppoints, sT)(1, 0), MatrixMulti(temppoints, sT)(2, 0), MatrixMulti(temppoints, sT)(3, 0))
        Next

    End Sub
    Private Sub Sphere_poly()
        Sphere_vertex()
        lightSrc(0) = CInt(TxtBoxLgtsrcx.Text)
        lightSrc(1) = CInt(TxtBoxLgtsrcY.Text)
        lightSrc(2) = CInt(TxtBoxLgtsrcZ.Text)
        Dim idx = 0
        nlat = CInt(LatitudeTB.Text)
        nlong = CInt(LongitudeTB.Text)

        Dim k As Integer

        ReDim polygonlist(UBound(V, 1) * 2, 2)
        For j = 0 To nlat - 2
            For i = 0 To nlong - 2
                k = j * nlong + i
                polygonlist(idx, 0) = k
                polygonlist(idx, 1) = 1 + k
                polygonlist(idx, 2) = k + nlong + 1
                idx = idx + 1
                polygonlist(idx, 0) = k
                polygonlist(idx, 1) = k + nlong + 1
                polygonlist(idx, 2) = nlong + k
                idx = idx + 1
            Next
            k = j * nlong
            polygonlist(idx, 0) = k + nlong - 1
            polygonlist(idx, 1) = k
            polygonlist(idx, 2) = k + nlong
            idx = idx + 1
            polygonlist(idx, 0) = k + nlong - 1
            polygonlist(idx, 1) = k + nlong
            polygonlist(idx, 2) = k + 2 * nlong - 1
            idx = idx + 1

        Next
        Dim diff As Integer
        For i As Integer = 0 To nlong - 2
            If nlat > nlong Then
                diff = nlat - nlong
                polygonlist(idx, 0) = i + (nlat * (nlong - 1)) + diff
                polygonlist(idx, 1) = i + (nlat * (nlong - 1) + 1) + diff
                polygonlist(idx, 2) = nlat * nlong
                idx = idx + 1
            ElseIf nlat < nlong Then
                diff = nlong - nlat
                polygonlist(idx, 0) = i + (nlat * (nlong - 1)) - diff
                polygonlist(idx, 1) = i + (nlat * (nlong - 1) + 1) - diff
                polygonlist(idx, 2) = nlat * nlong
                idx = idx + 1
            Else
                polygonlist(idx, 0) = i + (nlat * (nlong - 1))
                polygonlist(idx, 1) = i + (nlat * (nlong - 1) + 1)
                polygonlist(idx, 2) = nlat * nlong
                idx = idx + 1
            End If

        Next

        polygonlist(idx, 0) = (nlat) * (nlong) - 1
        polygonlist(idx, 1) = (nlat) * (nlong) - nlong
        polygonlist(idx, 2) = nlat * nlong
        idx = idx + 1


        For j = nlat To 2 * nlat - 2
            For i = 0 To nlong - 2
                k = j * nlong + i + 1
                polygonlist(idx, 0) = k
                polygonlist(idx, 1) = k + nlong
                polygonlist(idx, 2) = k + 1
                idx = idx + 1
                polygonlist(idx, 0) = k + 1
                polygonlist(idx, 1) = nlong + k
                polygonlist(idx, 2) = k + nlong + 1
                idx = idx + 1
            Next
            k = j * nlong + 1
            polygonlist(idx, 0) = k + nlong - 1
            polygonlist(idx, 1) = k + 2 * nlong - 1
            polygonlist(idx, 2) = k
            idx = idx + 1
            polygonlist(idx, 0) = k
            polygonlist(idx, 1) = k + 2 * nlong - 1
            polygonlist(idx, 2) = k + nlong
            idx = idx + 1

        Next

        For i As Integer = 0 To nlong - 2
            If nlat < nlong Then
                diff = nlong - nlat
                polygonlist(idx, 0) = i + nlat + (2 * nlat * (nlong - 1)) + 1 - diff
                polygonlist(idx, 1) = (2 * nlat * nlong) + 1
                polygonlist(idx, 2) = i + nlat + (2 * nlat * (nlong - 1) + 1) + 1 - diff
                idx = idx + 1
            ElseIf nlat > nlong Then
                diff = nlat - nlong
                polygonlist(idx, 0) = i + nlat + (2 * nlat * (nlong - 1)) + 1 + diff
                polygonlist(idx, 1) = (2 * nlat * nlong) + 1
                polygonlist(idx, 2) = i + nlat + (2 * nlat * (nlong - 1) + 1) + 1 + diff
                idx += 1
            Else
                polygonlist(idx, 0) = i + nlat + (2 * nlat * (nlong - 1)) + 1
                polygonlist(idx, 1) = (2 * nlat * nlong) + 1
                polygonlist(idx, 2) = i + nlat + (2 * nlat * (nlong - 1) + 1) + 1
                idx = idx + 1
            End If
        Next

        polygonlist(idx, 0) = 2 * nlat * nlong
        polygonlist(idx, 1) = 2 * nlat * nlong + 1
        polygonlist(idx, 2) = 2 * nlat * nlong + 1 - nlong

        ReDim PolyPoints(UBound(polygonlist, 1))

        For i As Integer = 0 To UBound(polygonlist, 1)
            PolyPoints(i) = New Poly
            SetTPoly(PolyPoints(i), polygonlist(i, 0), polygonlist(i, 1), polygonlist(i, 2))
        Next

        Dim po1, po2, po3, cbtesting1, cbtesting2, cbtesting3, temp1, temp2, NormalAtA, NormalAtB, NormalAtP As TPoint
        Dim Normal, Normalatv1, Normalatv2, Normalatv3, L, centerOfsphere, R, UnitV As TPoint
        Dim ans, temp(2), Er(2), LdotN, VdotR, VectorV(2), xloop(,), idx1, ex As Double
        Dim itotp1(2), itotp2(2), itotp3(2), IatA(2), IatB(2), IatP(2) As Integer
        Dim points As PointF()
        Dim brush As Brush
        temp1 = New TPoint
        temp2 = New TPoint
        Normal = New TPoint
        Normalatv1 = New TPoint
        Normalatv2 = New TPoint
        Normalatv3 = New TPoint
        NormalAtA = New TPoint
        NormalAtB = New TPoint
        NormalAtP = New TPoint
        L = New TPoint
        R = New TPoint
        UnitV = New TPoint


        For i As Integer = 0 To UBound(polygonlist, 1)
            po1 = VS(PolyPoints(i).p1)
            po2 = VS(PolyPoints(i).p2)
            po3 = VS(PolyPoints(i).p3)

            cbtesting1 = VW(PolyPoints(i).p1)
            cbtesting2 = VW(PolyPoints(i).p2)
            cbtesting3 = VW(PolyPoints(i).p3)

            temp1.x = CInt(cbtesting2.x - cbtesting1.x)
            temp1.y = CInt(cbtesting2.y - cbtesting1.y)
            temp1.z = CInt(cbtesting2.z - cbtesting1.z)
            temp2.x = CInt(cbtesting3.x - cbtesting1.x)
            temp2.y = CInt(cbtesting3.y - cbtesting1.y)
            temp2.z = CInt(cbtesting3.z - cbtesting1.z)
            ans = Dotproduct(Crossproduct(temp1, temp2))

            If RdBttnFlatShading.Checked = True Then
                Dim center As TPoint
                center = New TPoint
                center.x = (cbtesting1.x + cbtesting2.x + cbtesting3.x) / 3
                center.y = (cbtesting1.y + cbtesting2.y + cbtesting3.y) / 3
                center.z = (cbtesting1.z + cbtesting2.z + cbtesting3.z) / 3
                Normal.x = Crossproduct(temp1, temp2).x
                Normal.y = Crossproduct(temp1, temp2).y
                Normal.z = Crossproduct(temp1, temp2).z
                Normal = UnitVector(Normal)
                points = {New PointF(po1.x, po1.y), New PointF(po2.x, po2.y), New PointF(po3.x, po3.y)}
                L = UnitVectorL(lightSrc, center)
                LdotN = DotUnitVector(Normal, L)
                R = UnitVectorR(LdotN, Normal, L)
                UnitV = UnitVectorV(Normal)
                VdotR = DotUnitVector(R, UnitV)

                Dim ColorAfter As Integer() = ItotP(Ambient(CDbl(TxtBoxKa.Text)), Diffuse(CDbl(TxtBoxKd.Text), LdotN), Specular(CDbl(TxtBoxKs.Text), VdotR, CDbl(TextBoxExponent.Text)))

                brush = New SolidBrush(Color.FromArgb(255, Math.Abs(ColorAfter(0)), Math.Abs(ColorAfter(1)), Math.Abs(ColorAfter(2))))
                myPen = New Pen(brush)
            ElseIf RdBttnGouraud.Checked = True Then
                centerOfsphere = New TPoint
                centerOfsphere.x = 0
                centerOfsphere.y = 0
                centerOfsphere.z = 0

                Normalatv1 = UnitVector(VerticeNormal(cbtesting1, centerOfsphere))
                Normalatv2 = UnitVector(VerticeNormal(cbtesting2, centerOfsphere))
                Normalatv3 = UnitVector(VerticeNormal(cbtesting3, centerOfsphere))
                L = UnitVectorL(lightSrc, cbtesting1)
                LdotN = DotUnitVector(Normalatv1, L)
                R = UnitVectorR(LdotN, Normalatv1, L)
                UnitV = UnitVectorV(cbtesting1)
                VdotR = DotUnitVector(R, UnitV)
                itotp1 = ItotP(Ambient(CDbl(TxtBoxKa.Text)), Diffuse(CDbl(TxtBoxKd.Text), LdotN), Specular(CDbl(TxtBoxKs.Text), VdotR, CDbl(TextBoxExponent.Text)))

                L = UnitVectorL(lightSrc, cbtesting2)
                LdotN = DotUnitVector(Normalatv2, L)
                R = UnitVectorR(LdotN, Normalatv2, L)
                UnitV = UnitVectorV(cbtesting2)
                VdotR = DotUnitVector(R, UnitV)
                itotp2 = ItotP(Ambient(CDbl(TxtBoxKa.Text)), Diffuse(CDbl(TxtBoxKd.Text), LdotN), Specular(CDbl(TxtBoxKs.Text), VdotR, CDbl(TextBoxExponent.Text)))

                L = UnitVectorL(lightSrc, cbtesting3)
                LdotN = DotUnitVector(Normalatv3, L)
                R = UnitVectorR(LdotN, Normalatv3, L)
                UnitV = UnitVectorV(cbtesting3)
                VdotR = DotUnitVector(R, UnitV)
                itotp3 = ItotP(Ambient(CDbl(TxtBoxKa.Text)), Diffuse(CDbl(TxtBoxKd.Text), LdotN), Specular(CDbl(TxtBoxKs.Text), VdotR, CDbl(TextBoxExponent.Text)))
            ElseIf RdBttnPhong.Checked = True Then

                centerOfsphere = New TPoint
                centerOfsphere.x = 0
                centerOfsphere.y = 0
                centerOfsphere.z = 0

                Normalatv1 = UnitVector(VerticeNormal(cbtesting1, centerOfsphere))
                Normalatv2 = UnitVector(VerticeNormal(cbtesting2, centerOfsphere))
                Normalatv3 = UnitVector(VerticeNormal(cbtesting3, centerOfsphere))
            End If


            If ans <= 0 Then
                If RdBttnGouraud.Checked = True Then
                    myPen = New Pen(Color.Red)
                    If cbtesting1.y = cbtesting2.y And cbtesting2.y = cbtesting3.y Then
                        Return
                    End If
                    If po1.y > po3.y Then
                        If cbtesting1.y = cbtesting2.y Then
                            xloop = ScanLine(CInt(cbtesting1.x), CInt(cbtesting1.y), CInt(cbtesting2.x), CInt(cbtesting2.y), CInt(cbtesting3.x), CInt(cbtesting3.y), True)
                            idx1 = UBound(xloop, 1)
                            For j As Integer = CInt(cbtesting3.y) To CInt(cbtesting1.y) Step -1

                                IatA = ItotAtPoint(itotp3, itotp1, cbtesting3, cbtesting1, j)
                                IatB = ItotAtPoint(itotp3, itotp2, cbtesting3, cbtesting1, j)
                                For xline As Integer = xloop(idx1, 0) To xloop(idx1, 1)
                                    IatP = ItotAtPoint(IatB, IatA, xloop(idx1, 1), xloop(idx1, 0), xline)
                                    myPen = New Pen(Color.FromArgb(255, IatP(0), IatP(1), IatP(2)))
                                    formGraphics.DrawRectangle(myPen, CInt(xline + 200), CInt(200 - j), 1, 1)
                                Next
                                idx1 -= 1
                            Next
                        Else
                            xloop = ScanLine(CInt(cbtesting1.x), CInt(cbtesting1.y), CInt(cbtesting2.x), CInt(cbtesting2.y), CInt(cbtesting3.x), CInt(cbtesting3.y), False)
                            idx1 = UBound(xloop, 1)
                            For j As Integer = CInt(cbtesting3.y) To CInt(cbtesting1.y) Step -1
                                IatA = ItotAtPoint(itotp3, itotp1, cbtesting3, cbtesting1, j)
                                IatB = ItotAtPoint(itotp2, itotp1, cbtesting2, cbtesting1, j)
                                For xline As Integer = xloop(idx1, 0) To xloop(idx1, 1)

                                    IatP = ItotAtPoint(IatB, IatA, xloop(idx1, 1), xloop(idx1, 0), xline)
                                    myPen = New Pen(Color.FromArgb(255, IatP(0), IatP(1), IatP(2)))
                                    formGraphics.DrawRectangle(myPen, CInt(xline + 200), CInt(200 - j), 1, 1)
                                Next
                                idx1 -= 1
                            Next
                        End If
                    Else
                        If cbtesting1.y = cbtesting3.y Then
                            xloop = ScanLine(CInt(cbtesting2.x), CInt(cbtesting2.y), CInt(cbtesting3.x), CInt(cbtesting3.y), CInt(cbtesting1.x), CInt(cbtesting1.y), False)
                            idx1 = UBound(xloop, 1)
                            For j As Integer = CInt(cbtesting1.y) To CInt(cbtesting2.y) Step -1
                                IatA = ItotAtPoint(itotp1, itotp2, cbtesting1, cbtesting2, j)
                                IatB = ItotAtPoint(itotp3, itotp2, cbtesting3, cbtesting2, j)
                                For xline As Integer = xloop(idx1, 0) To xloop(idx1, 1)
                                    IatP = ItotAtPoint(IatB, IatA, xloop(idx1, 1), xloop(idx1, 0), xline)
                                    myPen = New Pen(Color.FromArgb(255, IatP(0), IatP(1), IatP(2)))
                                    formGraphics.DrawRectangle(myPen, CInt(xline + 200), CInt(200 - j), 1, 1)
                                Next
                                idx1 -= 1
                            Next
                        Else
                            xloop = ScanLine(CInt(cbtesting2.x), CInt(cbtesting2.y), CInt(cbtesting3.x), CInt(cbtesting3.y), CInt(cbtesting1.x), CInt(cbtesting1.y), True)
                            idx1 = UBound(xloop, 1)
                            For j As Integer = CInt(cbtesting1.y) To CInt(cbtesting2.y) Step -1
                                IatA = ItotAtPoint(itotp1, itotp2, cbtesting1, cbtesting2, j)
                                IatB = ItotAtPoint(itotp1, itotp3, cbtesting1, cbtesting3, j)
                                For xline As Integer = xloop(idx1, 0) To xloop(idx1, 1)
                                    IatP = ItotAtPoint(IatB, IatA, xloop(idx1, 1), xloop(idx1, 0), xline)
                                    myPen = New Pen(Color.FromArgb(255, IatP(0), IatP(1), IatP(2)))
                                    formGraphics.DrawRectangle(myPen, CInt(xline + 200), CInt(200 - j), 1, 1)
                                Next
                                idx1 -= 1
                            Next
                        End If
                    End If
                ElseIf RdBttnPhong.Checked = True Then
                    myPen = New Pen(Color.Red)
                        If cbtesting1.y = cbtesting2.y And cbtesting2.y = cbtesting3.y Then
                            Return
                        End If
                        If po1.y > po3.y Then
                            If cbtesting1.y = cbtesting2.y Then
                                xloop = ScanLine(CInt(cbtesting1.x), CInt(cbtesting1.y), CInt(cbtesting2.x), CInt(cbtesting2.y), CInt(cbtesting3.x), CInt(cbtesting3.y), True)
                                idx1 = UBound(xloop, 1)
                                For j As Integer = CInt(cbtesting3.y) To CInt(cbtesting1.y) Step -1

                                'IatA = ItotAtPoint(itotp3, itotp1, cbtesting3, cbtesting1, j)
                                'IatB = ItotAtPoint(itotp3, itotp2, cbtesting3, cbtesting1, j)
                                NormalAtA = UnitVector(NormalAtPoint(Normalatv3, Normalatv1, cbtesting3, cbtesting1, j))
                                NormalAtB = UnitVector(NormalAtPoint(Normalatv3, Normalatv2, cbtesting3, cbtesting1, j))
                                For xline As Integer = xloop(idx1, 0) To xloop(idx1, 1)
                                    NormalAtP = UnitVector(NormalAtPoint(NormalAtB, NormalAtA, xloop(idx1, 1), xloop(idx1, 0), xline))
                                    L = UnitVectorL(lightSrc, NormalAtP)
                                    LdotN = DotUnitVector(NormalAtP, L)
                                    R = UnitVectorR(LdotN, NormalAtP, L)
                                    UnitV = UnitVectorV(NormalAtP)
                                    VdotR = DotUnitVector(R, UnitV)
                                    IatP = ItotP(Ambient(CDbl(TxtBoxKa.Text)), Diffuse(CDbl(TxtBoxKd.Text), LdotN), Specular(CDbl(TxtBoxKs.Text), VdotR, CDbl(TextBoxExponent.Text)))
                                    myPen = New Pen(Color.FromArgb(255, IatP(0), IatP(1), IatP(2)))
                                    formGraphics.DrawRectangle(myPen, CInt(xline + 200), CInt(200 - j), 1, 1)
                                Next
                                idx1 -= 1
                                Next
                            Else
                                xloop = ScanLine(CInt(cbtesting1.x), CInt(cbtesting1.y), CInt(cbtesting2.x), CInt(cbtesting2.y), CInt(cbtesting3.x), CInt(cbtesting3.y), False)
                                idx1 = UBound(xloop, 1)
                                For j As Integer = CInt(cbtesting3.y) To CInt(cbtesting1.y) Step -1
                                '    IatA = ItotAtPoint(itotp3, itotp1, cbtesting3, cbtesting1, j)
                                'IatB = ItotAtPoint(itotp2, itotp1, cbtesting2, cbtesting1, j)
                                NormalAtA = UnitVector(NormalAtPoint(Normalatv3, Normalatv1, cbtesting3, cbtesting1, j))
                                NormalAtB = UnitVector(NormalAtPoint(Normalatv2, Normalatv1, cbtesting2, cbtesting1, j))
                                For xline As Integer = xloop(idx1, 0) To xloop(idx1, 1)
                                    NormalAtP = UnitVector(NormalAtPoint(NormalAtB, NormalAtA, xloop(idx1, 1), xloop(idx1, 0), xline))
                                    L = UnitVectorL(lightSrc, NormalAtP)
                                    LdotN = DotUnitVector(NormalAtP, L)
                                    R = UnitVectorR(LdotN, NormalAtP, L)
                                    UnitV = UnitVectorV(NormalAtP)
                                    VdotR = DotUnitVector(R, UnitV)
                                    IatP = ItotP(Ambient(CDbl(TxtBoxKa.Text)), Diffuse(CDbl(TxtBoxKd.Text), LdotN), Specular(CDbl(TxtBoxKs.Text), VdotR, CDbl(TextBoxExponent.Text)))
                                    myPen = New Pen(Color.FromArgb(255, IatP(0), IatP(1), IatP(2)))
                                        formGraphics.DrawRectangle(myPen, CInt(xline + 200), CInt(200 - j), 1, 1)
                                    Next
                                    idx1 -= 1
                                Next
                            End If
                        Else
                            If cbtesting1.y = cbtesting3.y Then
                                xloop = ScanLine(CInt(cbtesting2.x), CInt(cbtesting2.y), CInt(cbtesting3.x), CInt(cbtesting3.y), CInt(cbtesting1.x), CInt(cbtesting1.y), False)
                                idx1 = UBound(xloop, 1)
                                For j As Integer = CInt(cbtesting1.y) To CInt(cbtesting2.y) Step -1
                                '    IatA = ItotAtPoint(itotp1, itotp2, cbtesting1, cbtesting2, j)
                                'IatB = ItotAtPoint(itotp3, itotp2, cbtesting3, cbtesting2, j)
                                NormalAtA = UnitVector(NormalAtPoint(Normalatv1, Normalatv2, cbtesting1, cbtesting2, j))
                                NormalAtB = UnitVector(NormalAtPoint(Normalatv3, Normalatv2, cbtesting3, cbtesting2, j))
                                For xline As Integer = xloop(idx1, 0) To xloop(idx1, 1)
                                    NormalAtP = UnitVector(NormalAtPoint(NormalAtB, NormalAtA, xloop(idx1, 1), xloop(idx1, 0), xline))
                                    L = UnitVectorL(lightSrc, NormalAtP)
                                    LdotN = DotUnitVector(NormalAtP, L)
                                    R = UnitVectorR(LdotN, NormalAtP, L)
                                    UnitV = UnitVectorV(NormalAtP)
                                    VdotR = DotUnitVector(R, UnitV)
                                    IatP = ItotP(Ambient(CDbl(TxtBoxKa.Text)), Diffuse(CDbl(TxtBoxKd.Text), LdotN), Specular(CDbl(TxtBoxKs.Text), VdotR, CDbl(TextBoxExponent.Text)))
                                    myPen = New Pen(Color.FromArgb(255, IatP(0), IatP(1), IatP(2)))
                                    formGraphics.DrawRectangle(myPen, CInt(xline + 200), CInt(200 - j), 1, 1)
                                Next
                                idx1 -= 1
                                Next
                            Else
                                xloop = ScanLine(CInt(cbtesting2.x), CInt(cbtesting2.y), CInt(cbtesting3.x), CInt(cbtesting3.y), CInt(cbtesting1.x), CInt(cbtesting1.y), True)
                                idx1 = UBound(xloop, 1)
                                For j As Integer = CInt(cbtesting1.y) To CInt(cbtesting2.y) Step -1
                                '    IatA = ItotAtPoint(itotp1, itotp2, cbtesting1, cbtesting2, j)
                                'IatB = ItotAtPoint(itotp1, itotp3, cbtesting1, cbtesting3, j)
                                NormalAtA = UnitVector(NormalAtPoint(Normalatv1, Normalatv2, cbtesting1, cbtesting2, j))
                                NormalAtB = UnitVector(NormalAtPoint(Normalatv1, Normalatv3, cbtesting1, cbtesting3, j))
                                For xline As Integer = xloop(idx1, 0) To xloop(idx1, 1)
                                    NormalAtP = UnitVector(NormalAtPoint(NormalAtB, NormalAtA, xloop(idx1, 1), xloop(idx1, 0), xline))
                                    L = UnitVectorL(lightSrc, NormalAtP)
                                    LdotN = DotUnitVector(NormalAtP, L)
                                    R = UnitVectorR(LdotN, NormalAtP, L)
                                    UnitV = UnitVectorV(NormalAtP)
                                    VdotR = DotUnitVector(R, UnitV)
                                    IatP = ItotP(Ambient(CDbl(TxtBoxKa.Text)), Diffuse(CDbl(TxtBoxKd.Text), LdotN), Specular(CDbl(TxtBoxKs.Text), VdotR, CDbl(TextBoxExponent.Text)))
                                    myPen = New Pen(Color.FromArgb(255, IatP(0), IatP(1), IatP(2)))
                                    formGraphics.DrawRectangle(myPen, CInt(xline + 200), CInt(200 - j), 1, 1)
                                Next
                                idx1 -= 1
                                Next
                            End If
                        End If
                    ElseIf RdBttnFlatShading.Checked = True Then
                    If integerCB.Checked = True Then
                        formGraphics.DrawLine(myPen, CInt(po1.x), CInt(po1.y), CInt(po2.x), CInt(po2.y))
                        formGraphics.DrawLine(myPen, CInt(po2.x), CInt(po2.y), CInt(po3.x), CInt(po3.y))
                        formGraphics.DrawLine(myPen, CInt(po3.x), CInt(po3.y), CInt(po1.x), CInt(po1.y))
                    Else
                        formGraphics.DrawLine(myPen, New PointF(po1.x, po1.y), New PointF(po2.x, po2.y))
                        formGraphics.DrawLine(myPen, New PointF(po2.x, po2.y), New PointF(po3.x, po3.y))
                        formGraphics.DrawLine(myPen, New PointF(po3.x, po3.y), New PointF(po1.x, po1.y))
                        formGraphics.FillPolygon(brush, points)
                    End If
                Else
                End If
            End If
        Next
    End Sub
    Private Sub Draw_poly()
        Sphere_poly()
        PictureBox1.Image = canvas
    End Sub
    Private Sub Sphere_Click(sender As Object, e As EventArgs) Handles Sphere.Click
        formGraphics.Clear(Color.Black)
        Ambient(CDbl(TxtBoxLgtsrcx.Text))
        PictureBox1.Image = canvas
        Draw_poly()
    End Sub
End Class