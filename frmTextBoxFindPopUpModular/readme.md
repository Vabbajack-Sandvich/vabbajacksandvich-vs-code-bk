'============================================================
# frmTextBoxFindPopUpModular:
'============================================================

This can be copy and pasted in to another vb.net project folder and used as a modular form.

This goes in the button to show the form. This is also in the form and the vabbajacksandvich.vb at the top of the module for easy copy and pasting.

You can use one form with multiple text boxes one at a time by re-specifying the text box and or the form before you call frmTextBoxFindPopUpModular.Show()

Note: you can't use the same form for multple boxes at the same time. For that you need 2 copies of the form and need to refactor the form name within itself to something else to prevent ambiguity errors, but after that, it will work the same way.

Example: 

Using only 1 find module form in the project for multiple forms and multple text boxes.

Button1:
btFind1:

This uses the form its on, assmuing form1 or form main kind of thing and uses txtLog to search through.

```
    Private Sub btFind1_Click(sender As Object, e As EventArgs) Handles btFind.Click
        'have to set this everytime before the form gets shown
        'it "forgets" when it gets closed
        frmTextBoxFindPopUpModular.zFormTemp = Me
        frmTextBoxFindPopUpModular.zTxtLog = txtLog
        frmTextBoxFindPopUpModular.Show()
    End Sub
```

Button2:
btFind2:

This uses Form2 and uses txtOutput on Form2 to search through.

```
    Private Sub btFind2_Click(sender As Object, e As EventArgs) Handles btFind.Click
        'have to set this everytime before the form gets shown
        'it "forgets" when it gets closed
        frmTextBoxFindPopUpModular.zFormTemp = Form2
        frmTextBoxFindPopUpModular.zTxtLog = txtOutput
        frmTextBoxFindPopUpModular.Show()
    End Sub
```

```
'============================================================
'this goes in the target project main form load section
'set it to whatver textbox on the target main form
'============================================================
'	frmTextBoxFindPopUpModular.zTxtLog = txtLog
'	frmTextBoxFindPopUpModular.zFormTemp = Me
'============================================================
```

```
'============================================================
'this goes in the target project main form button to show the find window
'============================================================
    '2026-07-07-21-33-41-PM
    'adding this to the copy paste section
    'this is for the modular form
    '
    'Private Sub btFind_Click(sender As Object, e As EventArgs) Handles btFind.Click
    '    'have to set this everytime before the form gets shown
    '    'it "forgets" when it gets closed
    '    frmTextBoxFindPopUpModular.zFormTemp = Me
    '    frmTextBoxFindPopUpModular.zTxtLog = txtLog
    '    frmTextBoxFindPopUpModular.Show()
    'End Sub

```


'============================================================

2026-07-07-20-45-25-PM

i was fixing this an i broke it

here you go


```


                                                  
							AAAAA  A   AAAA   AA AAAAAA     
							AA                        AAA    
							A          AAA         AAAAAA    
							AAAAA AAAA         AAAAAAAAAA    
							AA    A   A    AAAAAA AAAAAAA    
							A          A A AAAAAAAAA AA A    
							A AA         A A AAAAA    A A    
				AA A		  AAA         AAAAAAAAAAAAAA    
			AAA   A 		       AA    A  AAAAAAAAAAA    
			AAAAAA  		 A   A AAA AAA  A  AA  AA AAAA    
		AAA         		   A           AA AAA AAAAAAA    
	AAA            A		AAA AAA AA  A AAA  AAAAA        
	AA          AAAA		AAAA     AA    AAAAAA     AAA    
	AAAAAA   AAAAAAA		AAAA       AAAAAA             AA 
	AAAA AAAAAAAAAAA		AAA A                     AAAAAA 
	A  A AAAAAAAAAAA		    A A               AAAAAAAA A 
	AAAAA  AAAAAA   		    A             AAAAA  AAAAA A 
		AAAAAAA     		   AA         AAAAAA     AAAAAAAA 
		A           		AAAAAA AAAAA AA        AAAAAA  
								A  A   AAAAA         AA       
								AAAA         AA A  AAA        
								AAA AA   AAAAA AAAAAAA        
								AA AA  AA     AAAAAAA        
								A    A        A A   A        
								A   AAAAAAA   AA AAAAA       
								A      A A    A AAAAA        
								A      A AAAA AAAAAAA        
								A         A   AAAAAAA        
								A          AA AAAAAAA        
								A             AAAAAAA        
								AA    A       AAAAAAA        
								AAAAAA AA     AAAAAAA        
								A             AAAAAAA        
								A      A AAAA AAAAAAA        
								A          A  AAAAAAA        
								AAAAA         AAAAAAA        
								A AAAAA    A  AAAAAAA        
								A     AAAAA   AAAAAAA        
								AAAAA    AAAA AAAAAAA        
											AA    A        


```

no its not actually broken

