using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using DevExpress.WinUI.Core;
using DevExpress.WinUI.Grid;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace winui_mvvm_custom_behavior
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window {
        public ViewModel ViewModel { get; set; }
        public MainWindow() {
            this.InitializeComponent();
            ViewModel = new ViewModel();
        }
    }

    public class TextBoxSelectionBehavior : Behavior<TextBox> {
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.GotFocus += AssociatedObject_GotFocus;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            AssociatedObject.GotFocus -= AssociatedObject_GotFocus;
        }
        private void AssociatedObject_GotFocus(object sender, RoutedEventArgs e) {
            AssociatedObject.SelectAll();
        }
    }
}
