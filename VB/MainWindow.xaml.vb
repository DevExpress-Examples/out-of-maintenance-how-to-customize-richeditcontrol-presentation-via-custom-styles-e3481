Namespace RichEditCustomStylesWpf

    Public Partial Class MainWindow
        Inherits System.Windows.Window

        Public Sub New()
            Me.InitializeComponent()
            Me.richEditControl1.ApplyTemplate()
            Me.richEditControl1.ActiveView.ZoomFactor = 0.5F
        End Sub
    End Class
End Namespace
