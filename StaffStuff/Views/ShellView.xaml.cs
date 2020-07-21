using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace StaffStuff.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
            Icon = BitmapFrame.Create(Application.GetResourceStream(new Uri("icon.png", UriKind.RelativeOrAbsolute)).Stream);
        }
    }
}
