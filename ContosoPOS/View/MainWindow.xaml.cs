using ContosoPOS.Data;
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
using System.Windows.Shapes;

namespace ContosoPOS.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentDbContext _studentDbContext;
        public MainWindow()
        {
            InitializeComponent();
            _studentDbContext = new StudentDbContext();
            StudentsDataGrid.ItemsSource=_studentDbContext.Students.ToList();
        }
    }
}
