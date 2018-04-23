namespace RichEditCustomStylesWpf {
    public partial class MainWindow : System.Windows.Window {
        public MainWindow() {
            InitializeComponent();

            richEditControl1.ApplyTemplate();
            richEditControl1.ActiveView.ZoomFactor = 0.5f;
        }
    }
}
