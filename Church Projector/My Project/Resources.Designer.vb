﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18010
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Church_Projector.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property bible() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bible", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property cp() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("cp", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property cross() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("cross", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property download() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("download", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property folder_open() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("folder_open", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property homepage() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("homepage", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icon_add() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_add", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property KJV() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("KJV", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lyrics() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lyrics", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- 
        '''	File Description: Plain and Simple for Lyrics Display
        '''	Author: Felix Jeyareuben (felix@fjeyar.com)
        '''	Website: www.churchsw.org
        '''--&gt;
        '''
        '''&lt;!--SETTINGS
        '''_BACKGROUND_=#000000;
        '''_FOREGROUND_=#ffffff;
        '''SETTINGS--&gt;
        '''
        '''&lt;html&gt;
        '''&lt;head&gt;
        '''&lt;style type=&quot;text/css&quot;&gt;
        '''html, body 
        '''	{
        '''		height:100%;
        '''		margin:0;
        '''		padding:0;
        '''		overflow:hidden;
        '''	}
        '''
        '''#page-background 
        '''	{
        '''		position:fixed;
        '''		top:0; 
        '''		left:0; 
        '''		width:100%; 
        '''		height:100%;
        '''	}
        '''
        '''#content 
        '''	{
        '''		position:relative; 
        '''		z-index:1; 
        '''		padding- [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property LyricsDisplay_Plain_and_Simple() As String
            Get
                Return ResourceManager.GetString("LyricsDisplay_Plain_and_Simple", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- 
        '''	File Description: Typewriter Animation for Lyrics Display
        '''	Author: Felix Jeyareuben (felix@fjeyar.com)
        '''	Website: www.churchsw.org
        '''--&gt;
        '''
        '''&lt;!--SETTINGS
        '''_BACKGROUND_=white;
        '''_FOREGROUND_=#333;
        '''SETTINGS--&gt;
        '''
        '''&lt;html&gt;
        '''&lt;head&gt;
        '''&lt;style type=&quot;text/css&quot;&gt;
        '''html, body 
        '''	{
        '''		height:100%;
        '''		margin:0;
        '''		padding:0;
        '''		overflow:hidden;
        '''		background:_BACKGROUND_;
        '''	}
        '''
        '''#page-background 
        '''	{
        '''		position:fixed;
        '''		top:0; 
        '''		left:0; 
        '''		width:100%; 
        '''		height:100%;
        '''	}
        '''
        '''#content 
        '''	{
        '''		position:relative;  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property LyricsDisplay_Typewritter_Animation() As String
            Get
                Return ResourceManager.GetString("LyricsDisplay_Typewritter_Animation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property open() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("open", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- 
        '''	File Description: Plain and Simple for Bible Display
        '''	Author: Felix Jeyareuben (felix@fjeyar.com)
        '''	Website: www.churchsw.org
        '''--&gt;
        '''
        '''&lt;!--SETTINGS
        '''_BACKGROUND_=#000000;
        '''_FOREGROUND_=#ffffff;
        '''SETTINGS--&gt;
        '''
        '''&lt;html&gt;
        '''&lt;head&gt;
        '''&lt;style type=&quot;text/css&quot;&gt;
        '''html, body 
        '''	{
        '''		height:100%;
        '''		margin:0;
        '''		padding:0;
        '''		overflow:hidden;
        '''	}
        '''
        '''#page-background 
        '''	{
        '''		position:fixed;
        '''		top:0; 
        '''		left:0; 
        '''		width:100%; 
        '''		height:100%;
        '''	}
        '''
        '''#content 
        '''	{
        '''		position:relative; 
        '''		z-index:1; 
        '''		padding-t [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ScriptureDisplay_Plain_and_Simple() As String
            Get
                Return ResourceManager.GetString("ScriptureDisplay_Plain_and_Simple", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!-- 
        '''	File Description: Typewriter Animation for Bible Display
        '''	Author: Felix Jeyareuben (felix@fjeyar.com)
        '''	Website: www.churchsw.org
        '''--&gt;
        '''
        '''&lt;!--SETTINGS
        '''_BACKGROUND_=white;
        '''_FOREGROUND_=#333;
        '''SETTINGS--&gt;
        '''
        '''&lt;html&gt;
        '''&lt;head&gt;
        '''&lt;style type=&quot;text/css&quot;&gt;
        '''html, body 
        '''	{
        '''		height:100%;
        '''		margin:0;
        '''		padding:0;
        '''		overflow:hidden;
        '''		background:_BACKGROUND_;
        '''	}
        '''
        '''#page-background 
        '''	{
        '''		position:fixed;
        '''		top:0; 
        '''		left:0; 
        '''		width:100%; 
        '''		height:100%;
        '''	}
        '''
        '''#content 
        '''	{
        '''		position:relative;         ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ScriptureDisplay_Typewritter_Animation() As String
            Get
                Return ResourceManager.GetString("ScriptureDisplay_Typewritter_Animation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property status_error() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("status_error", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property status_loading() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("status_loading", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property status_ok() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("status_ok", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property wall_paper() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("wall_paper", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
