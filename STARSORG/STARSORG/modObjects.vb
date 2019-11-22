Module modObjects
    '' stuff that you want to be callable from the entire project 
    'You can incule this in other projects, by adding an exisiting item 
    Public Sub ClearScreenControls(ByVal objContainer As Control)
        ' this procedure will clear all controls on the form passed in as the arguemnt 
        'not all control types have been implemented here, add as needed
        Dim obj As Control
        Dim strControlType As String
        For Each obj In objContainer.Controls
            strControlType = TypeName(obj) 'TypeName return the class name of the control
            Select Case strControlType
                Case "TextBox"
                    Dim cntrl As TextBox
                    cntrl = DirectCast(obj, TextBox)
                    cntrl.Clear()
                Case "CheckBox"
                    Dim cntrl As CheckBox
                    cntrl = DirectCast(obj, CheckBox)
                    cntrl.Checked = False
                Case "ComboBox"
                    Dim cntrl As ComboBox
                    cntrl = DirectCast(obj, ComboBox)
                    cntrl.SelectedIndex = -1 ' clear only selected not list contents
                Case "RadioButton"
                    Dim cntrl As RadioButton
                    cntrl = DirectCast(obj, RadioButton)
                    cntrl.Checked = False
                Case "MaskedTextBox"
                    Dim cntrl As MaskedTextBox
                    cntrl = DirectCast(obj, MaskedTextBox)
                    cntrl.Clear()
                Case "GroupBox"
                    'must recurse through its controls collection 
                    Dim cntrl As GroupBox
                    cntrl = DirectCast(obj, GroupBox)
                    ClearScreenControls(cntrl)
                Case Else
                    ' do nothing or add some error trapping code in needed
            End Select
        Next
    End Sub
End Module
