using InvoiceRegister22.UserControls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace InvoiceRegister22.UserControls
{
    /// <summary>
    /// Interaction logic for DrawerMenu.xaml
    /// </summary>
    public partial class DrawerMenu : UserControl
    {
        public static readonly DependencyProperty TextMenuProperty = DependencyProperty.Register("TextMenu", typeof(string), typeof(DrawerMenu));
        public static readonly DependencyProperty MenuIconColorForMouseOverProperty = DependencyProperty.Register("MenuIconColorForMouseOver", typeof(string), typeof(DrawerMenu));
        public static readonly DependencyProperty MenuIconColorForIsCheckedProperty = DependencyProperty.Register("MenuIconColorForIsChecked", typeof(string), typeof(DrawerMenu));
        public static readonly DependencyProperty MenuIconColorProperty = DependencyProperty.Register("MenuIconColor", typeof(string), typeof(DrawerMenu));
        public static readonly DependencyProperty IconNameProperty = DependencyProperty.Register("IconName", typeof(string), typeof(DrawerMenu));
        public static readonly DependencyProperty TextMenuFontSizeProperty = DependencyProperty.Register("TextMenuFontSize", typeof(double), typeof(DrawerMenu));
        public static readonly DependencyProperty ShadowColorProperty = DependencyProperty.Register("ShadowColor", typeof(string), typeof(DrawerMenu));

        public static readonly DependencyProperty ButtonsColorProperty = DependencyProperty.Register("ButtonsColor", typeof(string), typeof(DrawerMenu));
        public static readonly DependencyProperty ButtonsColorIsCheckedProperty = DependencyProperty.Register("ButtonsColorIsChecked", typeof(string), typeof(DrawerMenu));
        public static readonly DependencyProperty ButtonsColorMouseOverProperty = DependencyProperty.Register("ButtonsColorMouseOver", typeof(string), typeof(DrawerMenu));

        

        public static readonly RoutedEvent MenuIconCheckedEvent = EventManager.RegisterRoutedEvent("MenuIconChecked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DrawerMenu));
        public static readonly RoutedEvent MenuIconUncheckedEvent = EventManager.RegisterRoutedEvent("MenuIconUnchecked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DrawerMenu));
        public static readonly DependencyProperty MenuIconIsCheckedProperty = DependencyProperty.Register("MenuIconIsChecked", typeof(bool), typeof(MenuButton));

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(DrawerMenu));
        public static readonly DependencyProperty CommandParameterProperty = DependencyProperty.Register("CommandParameter", typeof(object), typeof(DrawerMenu));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        //public object CommandParameter
        //{
        //    get { return GetValue(CommandParameterProperty); }
        //    set { SetValue(CommandParameterProperty, value); }
        //}

        public bool MenuIconIsChecked
        {
            get { return (bool)GetValue(MenuIconIsCheckedProperty); }
            set { SetValue(MenuIconIsCheckedProperty, value); }
        }
        public event RoutedEventHandler MenuIconChecked
        {
            add { AddHandler(DrawerMenu.MenuIconCheckedEvent, value); }
            remove { RemoveHandler(DrawerMenu.MenuIconCheckedEvent, value); }
        }
        public event RoutedEventHandler MenuIconUnchecked
        {
            add { AddHandler(DrawerMenu.MenuIconUncheckedEvent, value); }
            remove { RemoveHandler(DrawerMenu.MenuIconUncheckedEvent, value); }
        }

       

        public string ButtonsColor
        {
            get { return (string)GetValue(ButtonsColorProperty); }
            set { SetValue(ButtonsColorProperty, value); }
        }
        public string ButtonsColorIsChecked
        {
            get { return (string)GetValue(ButtonsColorIsCheckedProperty); }
            set { SetValue(ButtonsColorIsCheckedProperty, value); }
        }
        public string ButtonsColorMouseOver
        {
            get { return (string)GetValue(ButtonsColorMouseOverProperty); }
            set { SetValue(ButtonsColorMouseOverProperty, value); }
        }

        public double TextMenuFontSize
        {
            get { return (double)GetValue(TextMenuFontSizeProperty); }
            set { SetValue(TextMenuFontSizeProperty, value); }
        }
        public string IconName
        {
            get { return (string)GetValue(IconNameProperty); }
            set { SetValue(IconNameProperty, value); }
        }
        public string MenuIconColor
        {
            get  {return (string)GetValue(MenuIconColorProperty); }
            set { SetValue(MenuIconColorProperty, value); }
        }
        public string MenuIconColorForIsChecked
        {
            get { return (string)GetValue(MenuIconColorForIsCheckedProperty); }
            set { SetValue(MenuIconColorForIsCheckedProperty, value); }
        }
        public string MenuIconColorForMouseOver
        {
            get { return (string)GetValue(MenuIconColorForMouseOverProperty); }
            set { SetValue(MenuIconColorForMouseOverProperty, value); }
        }
        public string ShadowColor
        {
            get { return (string)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }
        public string TextMenu
        {
            get { return (string)GetValue(TextMenuProperty); }
            set { SetValue(TextMenuProperty, value); }
        }

        public DrawerMenu()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (ToggleButtonMenu.IsChecked == true)
            {
                ToolTipNewInvoice.Visibility = Visibility.Collapsed;
                ToolTipListInvoice.Visibility = Visibility.Collapsed;
                ToolTipMyCompany.Visibility = Visibility.Collapsed;
                ToolTipMyContractors.Visibility = Visibility.Collapsed;
                ToolTipWarehouse.Visibility = Visibility.Collapsed;
                ToolTipContacts.Visibility = Visibility.Collapsed;
                ToolTipSettings.Visibility = Visibility.Collapsed;
                ToolTipAbout.Visibility = Visibility.Collapsed;
            }
            else
            {
                ToolTipNewInvoice.Visibility = Visibility.Visible;
                ToolTipListInvoice.Visibility = Visibility.Visible;
                ToolTipMyCompany.Visibility = Visibility.Visible;
                ToolTipMyContractors.Visibility = Visibility.Visible;
                ToolTipWarehouse.Visibility = Visibility.Visible; 
                ToolTipContacts.Visibility = Visibility.Visible;
                ToolTipSettings.Visibility = Visibility.Visible;
                ToolTipAbout.Visibility = Visibility.Visible;
            }
        }
        private void Button_ButtonClick(object sender, RoutedEventArgs e)
        {
            var menuButton = (MenuButton)sender;
            var nameButton = menuButton.Name;
            TrunOffButtons(menuButton);
            TrunOnButton(nameButton);
        }
        private void TrunOffButtons(MenuButton button)
        {
            if(button.ButtonIsChecked == true)
            {
                ButtonNewInvoice.ButtonIsChecked = false;
                ButtonListInvoice.ButtonIsChecked = false;
                ButtonMyCompanies.ButtonIsChecked = false;
                ButtonContractors.ButtonIsChecked = false;
                ButtonWarehouse.ButtonIsChecked = false;
                ButtonContacts.ButtonIsChecked = false;
                ButtonSettings.ButtonIsChecked = false;
                ButtonAboutProgram.ButtonIsChecked = false;
            }
        }
        private void TrunOnButton(string nameButton)
        {
            switch (nameButton)
            {
                case nameof(ButtonNewInvoice):
                    ButtonNewInvoice.ButtonIsChecked = true;
                    break;
                case nameof(ButtonListInvoice):
                    ButtonListInvoice.ButtonIsChecked = true;
                    break;
                case nameof(ButtonMyCompanies):
                    ButtonMyCompanies.ButtonIsChecked = true;
                    break;
                case nameof(ButtonContractors):
                    ButtonContractors.ButtonIsChecked = true;
                    break;
                case nameof(ButtonWarehouse):
                    ButtonWarehouse.ButtonIsChecked = true;
                    break;
                case nameof(ButtonContacts):
                    ButtonContacts.ButtonIsChecked = true;
                    break;
                case nameof(ButtonSettings):
                    ButtonSettings.ButtonIsChecked = true;
                    break;
                case nameof(ButtonAboutProgram):
                    ButtonAboutProgram.ButtonIsChecked = true;
                    break;
            }
        }

        private void ToggleButtonMenu_Checked(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs ea = new RoutedEventArgs(DrawerMenu.MenuIconCheckedEvent, this);
            this.RaiseEvent(ea);
        }

        private void ToggleButtonMenu_Unchecked(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs ea = new RoutedEventArgs(DrawerMenu.MenuIconUncheckedEvent, this);
            this.RaiseEvent(ea);
        }
    }
}
//public static readonly DependencyProperty ButtonNewInvoiceCommandProperty = DependencyProperty.Register("ButtonNewInvoiceCommand", typeof(ICommand), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonNewInvoiceCommandParameterProperty = DependencyProperty.Register("ClickFileCommandParameter", typeof(object), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonListInvoiceCommandProperty = DependencyProperty.Register("ButtonListInvoiceCommand", typeof(ICommand), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonListInvoiceCommandParameterProperty = DependencyProperty.Register("ButtonListInvoiceCommandParameter", typeof(object), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonMyCompaniesCommandProperty = DependencyProperty.Register("ButtonMyCompaniesCommand", typeof(ICommand), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonMyCompaniesCommandParameterProperty = DependencyProperty.Register("ButtonMyCompaniesCommandParameter", typeof(object), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonContractorsCommandProperty = DependencyProperty.Register("ButtonContractorsCommand", typeof(ICommand), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonContractorsCommandParameterProperty = DependencyProperty.Register("ButtonContractorsCommandParameter", typeof(object), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonWarehouseCommandProperty = DependencyProperty.Register("ButtonWarehouseCommand", typeof(ICommand), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonWarehouseCommandParameterProperty = DependencyProperty.Register("ButtonWarehouseCommandParameter", typeof(object), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonContactsCommandProperty = DependencyProperty.Register("ButtonContactsCommand", typeof(ICommand), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonContactsCommandParameterProperty = DependencyProperty.Register("ButtonContactsCommandParameter", typeof(object), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonSettingsCommandProperty = DependencyProperty.Register("ButtonSettingsCommand", typeof(ICommand), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonSettingsCommandParameterProperty = DependencyProperty.Register("ButtonSettingsCommandParameter", typeof(object), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonAboutProgramCommandProperty = DependencyProperty.Register("ButtonAboutProgramCommand", typeof(ICommand), typeof(DrawerMenu));
//public static readonly DependencyProperty ButtonAboutProgramCommandParameterProperty = DependencyProperty.Register("ButtonAboutProgramCommandParameter", typeof(object), typeof(DrawerMenu));


//public ICommand ButtonNewInvoiceCommand
//{
//    get { return (ICommand)GetValue(ButtonNewInvoiceCommandProperty); }
//    set { SetValue(ButtonNewInvoiceCommandProperty, value); }
//}

//public object ButtonNewInvoiceCommandParameter
//{
//    get { return GetValue(ButtonNewInvoiceCommandParameterProperty); }
//    set { SetValue(ButtonNewInvoiceCommandParameterProperty, value); }
//}

//public ICommand ButtonListInvoiceCommand
//{
//    get { return (ICommand)GetValue(ButtonListInvoiceCommandProperty); }
//    set { SetValue(ButtonListInvoiceCommandProperty, value); }
//}

//public object ButtonListInvoiceCommandParameter
//{
//    get { return GetValue(ButtonListInvoiceCommandParameterProperty); }
//    set { SetValue(ButtonListInvoiceCommandParameterProperty, value); }
//}


//public ICommand ButtonMyCompaniesCommand
//{
//    get { return (ICommand)GetValue(ButtonMyCompaniesCommandProperty); }
//    set { SetValue(ButtonMyCompaniesCommandProperty, value); }
//}

//public object ButtonMyCompaniesCommandParameter
//{
//    get { return GetValue(ButtonMyCompaniesCommandParameterProperty); }
//    set { SetValue(ButtonMyCompaniesCommandParameterProperty, value); }
//}

//public ICommand ButtonContractorsCommand
//{
//    get { return (ICommand)GetValue(ButtonContractorsCommandProperty); }
//    set { SetValue(ButtonContractorsCommandProperty, value); }
//}

//public object ButtonContractorsCommandParameter
//{
//    get { return GetValue(ButtonContractorsCommandParameterProperty); }
//    set { SetValue(ButtonContractorsCommandParameterProperty, value); }
//}

//public ICommand ButtonWarehouseCommand
//{
//    get { return (ICommand)GetValue(ButtonWarehouseCommandProperty); }
//    set { SetValue(ButtonWarehouseCommandProperty, value); }
//}

//public object ButtonWarehouseCommandParameter
//{
//    get { return GetValue(ButtonWarehouseCommandParameterProperty); }
//    set { SetValue(ButtonWarehouseCommandParameterProperty, value); }
//}

//public ICommand ButtonContactsCommand
//{
//    get { return (ICommand)GetValue(ButtonWarehouseCommandProperty); }
//    set { SetValue(ButtonWarehouseCommandProperty, value); }
//}

//public object ButtonContactsCommandParameter
//{
//    get { return GetValue(ButtonContactsCommandProperty); }
//    set { SetValue(ButtonContactsCommandParameterProperty, value); }
//}

//public ICommand ButtonSettingsCommand
//{
//    get { return (ICommand)GetValue(ButtonSettingsCommandProperty); }
//    set { SetValue(ButtonSettingsCommandProperty, value); }
//}

//public object ButtonSettingsCommandParameter
//{
//    get { return GetValue(ButtonSettingsCommandParameterProperty); }
//    set { SetValue(ButtonSettingsCommandParameterProperty, value); }
//}

//public ICommand ButtonAboutProgramCommand
//{
//    get { return (ICommand)GetValue(ButtonAboutProgramCommandProperty); }
//    set { SetValue(ButtonAboutProgramCommandProperty, value); }
//}

//public object ButtonAboutProgramCommandParameter
//{
//    get { return GetValue(ButtonAboutProgramCommandParameterProperty); }
//    set { SetValue(ButtonAboutProgramCommandParameterProperty, value); }
//}