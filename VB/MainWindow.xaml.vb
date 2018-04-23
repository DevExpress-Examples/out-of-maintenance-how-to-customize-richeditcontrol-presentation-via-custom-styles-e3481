Imports Microsoft.VisualBasic
Imports System
Namespace RichEditCustomStylesWpf
	Partial Public Class MainWindow
		Inherits System.Windows.Window
		Public Sub New()
			InitializeComponent()

			richEditControl1.ApplyTemplate()
			richEditControl1.ActiveView.ZoomFactor = 0.5f
		End Sub
	End Class
End Namespace
