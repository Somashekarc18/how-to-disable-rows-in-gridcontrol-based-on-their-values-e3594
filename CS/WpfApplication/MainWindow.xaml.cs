using System.Windows;
using DevExpress.Xpf.Grid;

namespace WpfApplication {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void tableView1_ShowingEditor(object sender, ShowingEditorEventArgs e) {
            e.Cancel = !(gridControl1.CurrentItem as GridItem).AllowEdit;
        }
    }
}