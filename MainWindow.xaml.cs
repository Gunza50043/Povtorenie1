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

namespace Povtorenie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SpisokDB _spisokDB;
        public MainWindow()
        {
            InitializeComponent();
            _spisokDB = new SpisokDB();
            _spisokDB.InitializeDB();
            MainGrid.ItemsSource = _spisokDB.SpisokLIST.ToList();
        }
        private void UpdateDB()
        {
            //присваивание дадагрид через "объект класса(_spisokDB).сам List(SpisokLIST).конвертирование в list для датагрид(Tolist())
            MainGrid.ItemsSource = _spisokDB.SpisokLIST.ToList();
        }

        private void b_Update_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void b_CLEAR_Click(object sender, RoutedEventArgs e)
        {
            //просто присваивание гриду пустого значения
            MainGrid.ItemsSource = null;
        }

        private void b_DELETE_Click(object sender, RoutedEventArgs e)
        {
            //Индекс почему то по дефолуту отрицательынй
            if (MainGrid.SelectedIndex >= 0)
            {
                //RemoveAt удаляет элмент списка( по выбранному индексу в дадагрид)
                _spisokDB.SpisokLIST.RemoveAt(MainGrid.SelectedIndex);
                UpdateDB();
            }
            else
            {
                //удалят последний элемент списка при отсутсвии выделения элемента
                //х индекс последнего элемента списка
                int x = _spisokDB.SpisokLIST.Count - 1 ;
                _spisokDB.SpisokLIST.RemoveAt(x);
                UpdateDB();
            }
        }

        private void b_ADD_Click(object sender, RoutedEventArgs e)
        {
            //добавление нового элеменат в список черз конструктор
            _spisokDB.SpisokLIST.Add(new Spisok(" ",0," "));
            UpdateDB();
        }
    }
}
