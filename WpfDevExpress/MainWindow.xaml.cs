using DevExpress.Xpf.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Docking;
using DevExpress.XtraBars;
namespace WpfDevExpress
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : DXRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int i;
        void addEmptyButton_Click(object sender, RoutedEventArgs e)
        {
            DocumentPanel panel = dockManager.DockController.AddDocumentPanel(documentContainer);
            panel.Caption = "Empty Panel " + (i++).ToString();
            dockManager.Activate(panel);
        }
        void addUserControlUriButton_Click(object sender, RoutedEventArgs e)
        {
            DocumentPanel panel = dockManager.DockController.AddDocumentPanel(
                documentContainer, new Uri("/DockingDemo;component/Layouts/ChildUserControl.xaml", UriKind.Relative));
            panel.Caption = "UserControl " + (i++).ToString();
            dockManager.Activate(panel);
        }
        void addWindowUriButton_Click(object sender, RoutedEventArgs e)
        {
            DocumentPanel panel = dockManager.DockController.AddDocumentPanel(
                documentContainer, new Uri("/DockingDemo;component/Layouts/ChildWindow.xaml", UriKind.Relative));
            panel.Caption = "Window " + (i++).ToString();
            dockManager.Activate(panel);
        }
        void addPageUriButton_Click(object sender, RoutedEventArgs e)
        {
            DocumentPanel panel = dockManager.DockController.AddDocumentPanel(
                documentContainer, new Uri("/DockingDemo;component/Layouts/ChildPage.xaml", UriKind.Relative));
            panel.Caption = "Page " + (i++).ToString();
            dockManager.Activate(panel);
        }
    }
}
