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

namespace Focus.HW
{
    public partial class MainWindow : Window
    {
        public static readonly RoutedCommand ChangeColorCommand = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();

            CommandBinding colorCommandBinding = new CommandBinding(ChangeColorCommand, ChangeColorExecuted);
            this.CommandBindings.Add(colorCommandBinding);
            KeyGesture keyGesture = new KeyGesture(Key.R, ModifierKeys.Control);
            InputBinding inputBinding = new InputBinding(ChangeColorCommand, keyGesture);
            this.InputBindings.Add(inputBinding);
        }

        private void ChangeColorExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SetFocusedControlColor();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetFocusedControlColor();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SetFocusedControlColor();
        }

        private void SetFocusedControlColor()
        {
            if (Keyboard.FocusedElement is Control focusedControl)
            {
                focusedControl.Background = Brushes.Red;
            }
        }
    }
}
