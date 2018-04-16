﻿' Developer Express Code Central Example:
' How to implement hot-track for grid rows during the drag-and-drop operation
' 
' This example illustrates how to highlight rows during the drag-and-drop
' operation. In this example, we have DependencyProperty at the Window class level
' that stores a current row handle of a row over which the mouse is.
' To obtain a
' current row handle, we use the DragOver event. Also, it is necessary to define
' RowStyle and add a trigger that will compare the current row handle with a
' dependency property value and change the current row's background if necessary.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4415

' Developer Express Code Central Example:
' How to implement hot-track for grid rows during the drag-and-drop operation
' 
' This example illustrates how to highlight rows during the drag-and-drop
' operation. In this example, we have DependencyProperty at the Window class level
' that stores a current row handle of a row over which the mouse is.
' To obtain a
' current row handle, we use the DragOver event. Also, it is necessary to define
' RowStyle and add a trigger that will compare the current row handle with a
' dependency property value and change the current row's background if necessary.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4415

' Developer Express Code Central Example:
' How to implement hot-track for grid rows
' 
' This example demonstrates how to implement the hot-track functionality in
' TableView.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3859

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.235
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
    Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

'        internal Resources()
'        {
'        }

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If (resourceMan Is Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace
