using Windows.UI.Xaml.Controls;

namespace Windows10Controls.Views
{
    public sealed partial class Shell
    {
        public new Frame Frame { get; }

        public Shell(Frame frame)
        {
            this.InitializeComponent();
            Frame = frame;

            MainSplitView.Content = frame;
        }

        private void TogglePane(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }
    }
}
