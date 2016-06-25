namespace KeyBox
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnUpExecute(object sender, ExecutedRoutedEventArgs e)
        {
            dot.SetValue(Canvas.TopProperty, Canvas.GetTop(dot) - 1);
        }

        private void OnDownExecute(object sender, ExecutedRoutedEventArgs e)
        {
            dot.SetValue(Canvas.TopProperty, Canvas.GetTop(dot) + 1);
        }
    }
}
