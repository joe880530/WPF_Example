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

namespace DependencyProperty_Example
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty MyProperty = 
            DependencyProperty.Register(
            "MyColor",                      //의존속성으로 등록될 속성명
            typeof(String),                 //등록한 의존속성 타입
            typeof(MainWindow),             //의존속성을 소유하게될 Owner(ex. Label, Textbox etc...)
            new FrameworkPropertyMetadata(new PropertyChangedCallback(OnMyPropertyChanged)));       //속성값 변경시에 호출될 메소드.

        

        public string MyColor
        {
            get { return (string)GetValue(MyProperty); }
            set { SetValue(MyProperty, value); }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private static void OnMyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = d as MainWindow;

            SolidColorBrush brush = (SolidColorBrush)new BrushConverter().ConvertFromString(e.NewValue.ToString());
            win.Background = brush;
            win.Title = (e.OldValue == null) ? "Nothing" : "배경색 " + e.OldValue.ToString();
            win.textBox01.Text = e.NewValue.ToString();
        }

        private void ContextMenu_Click(object sender, RoutedEventArgs e)
        {
            string str = (e.Source as MenuItem).Header as string;
            MyColor = str;
        }
    }
}
