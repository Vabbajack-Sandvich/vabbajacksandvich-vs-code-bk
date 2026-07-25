Dim p as Point
p = Form1.Location

Debug.Print(p.X)
Debug.Print(p.Y)

If you want to set a form's location:

frm.Location = New Point(100, 300)

