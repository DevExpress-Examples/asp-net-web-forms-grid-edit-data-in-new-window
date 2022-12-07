﻿Imports System
Imports DevExpress.Web

Partial Public Class Grid_Editing_CustomUpdate_CustomUpdate
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		'Populate grid with data on the first load
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			Dim provider As New InvoiceItemsProvider()
			provider.Populate()
		End If
	End Sub
End Class