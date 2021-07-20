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

using System.ComponentModel;

namespace MVVM_ListBox_Example
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public ListCollectionView MyCollectionView;

        public Employee currentEmp;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void rootElement_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MyCollectionView = (ListCollectionView)CollectionViewSource.GetDefaultView(rootElement);
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;

            MyCollectionView.SortDescriptions.Clear();

            switch (b.Name)
            {
                case "BtnEmpNo":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("EmpNo", ListSortDirection.Ascending));
                    break;
                case "BtnEmpName":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("EmpName", ListSortDirection.Ascending));
                    break;
                case "BtnEmpJob":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("EmpJob", ListSortDirection.Ascending));
                    break;
            }
        }

        private void OnMove(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;

            switch (b.Name)
            {
                case "Previous":
                    if (MyCollectionView.MoveCurrentToPrevious())
                        currentEmp = MyCollectionView.CurrentAddItem as Employee;
                    else
                        MyCollectionView.MoveCurrentToNext();
                    break;
                case "Next":
                    if (MyCollectionView.MoveCurrentToNext())
                        currentEmp = MyCollectionView.CurrentAddItem as Employee;
                    else
                        MyCollectionView.MoveCurrentToLast();
                    break;
            }
        }
    }
}
