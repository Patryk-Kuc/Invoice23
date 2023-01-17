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

namespace InvoiceRegister22.UserControls
{
    /// <summary>
    /// Interaction logic for MenuButton.xaml
    /// </summary>
    public partial class MenuButton : UserControl
    {
        public static readonly DependencyProperty TextButtonProperty = DependencyProperty.Register("TextButton", typeof(string), typeof(MenuButton));
        public static readonly DependencyProperty ButtonIconColorMouseOverProperty = DependencyProperty.Register("ButtonIconColorMouseOver", typeof(string), typeof(MenuButton));
        public static readonly DependencyProperty ButtonIconColorIsCheckedProperty = DependencyProperty.Register("ButtonIconColorIsChecked", typeof(string), typeof(MenuButton));
        public static readonly DependencyProperty ButtonIconColorProperty = DependencyProperty.Register("ButtonIconColor", typeof(string), typeof(MenuButton));
        public static readonly DependencyProperty IconNameProperty = DependencyProperty.Register("IconName", typeof(string), typeof(MenuButton));
        public static readonly DependencyProperty TextMenuFontSizeProperty = DependencyProperty.Register("TextMenuFontSize", typeof(double), typeof(MenuButton));

        public static readonly DependencyProperty ButtonIsCheckedProperty = DependencyProperty.Register("ButtonIsChecked", typeof(bool), typeof(MenuButton));

        public static readonly RoutedEvent ButtonClickEvent = EventManager.RegisterRoutedEvent("ButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MenuButton));

        public static readonly DependencyProperty ButtonCommandProperty = DependencyProperty.Register("ButtonCommand", typeof(ICommand), typeof(MenuButton));
        public static readonly DependencyProperty ButtonCommandParameterProperty = DependencyProperty.Register("ButtonCommandParameter", typeof(object), typeof(MenuButton));

        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        public object ButtonCommandParameter
        {
            get { return GetValue(ButtonCommandParameterProperty); }
            set { SetValue(ButtonCommandParameterProperty, value); }
        }

        public event RoutedEventHandler ButtonClick
        {
            add { AddHandler(MenuButton.ButtonClickEvent, value); }
            remove { RemoveHandler(MenuButton.ButtonClickEvent, value);}
        }

        public bool ButtonIsChecked
        {
            get { return (bool)GetValue(ButtonIsCheckedProperty); }
            set { SetValue(ButtonIsCheckedProperty, value); }
        }
        
        public string IconName
        {
            get { return (string)GetValue(IconNameProperty); }
            set { SetValue(IconNameProperty, value); }
        }
        public string ButtonIconColor
        {
            get { return (string)GetValue(ButtonIconColorProperty); }
            set { SetValue(ButtonIconColorProperty, value); }
        }
        public string ButtonIconColorIsChecked
        {
            get { return (string)GetValue(ButtonIconColorIsCheckedProperty); }
            set { SetValue(ButtonIconColorIsCheckedProperty, value); }
        }
        public string ButtonIconColorMouseOver
        {
            get { return (string)GetValue(ButtonIconColorMouseOverProperty); }
            set { SetValue(ButtonIconColorMouseOverProperty, value); }
        }

        public string TextButton
        {
            get { return (string)GetValue(TextButtonProperty); }
            set { SetValue(TextButtonProperty, value); }
        }
        public double TextMenuFontSize
        {
            get { return (double)GetValue(TextMenuFontSizeProperty); }
            set { SetValue(TextMenuFontSizeProperty, value); }
        }     

        public MenuButton()
        {
            InitializeComponent();
        }

        private void BtMenu_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs ea = new RoutedEventArgs(MenuButton.ButtonClickEvent, this);
            this.RaiseEvent(ea);
        }
    }
}
