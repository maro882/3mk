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

namespace Data_Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mcDataGrid.ItemsSource = authorList();
        }
        private List<Author> authorList()
        {
            List <Author> authors = new List<Author>();
            authors.Add(new Author()
            {
                id = 1,
                name = "Test",
                bookTitlle = "bengime",
                DOB = new DateTime(1999,12,20)
            }

            ) ;
            authors.Add(new Author()
            {
                id = 1,
                name = "maro",
                bookTitlle = "c# code",
                DOB = new DateTime(1999, 1, 20)
            }

            );
            authors.Add(new Author()
            {
                id = 1,
                name = "seif",
                bookTitlle = "Ghandy",
                DOB = new DateTime(1999, 2, 20)
            }

           );
            return authors;

        }

    }
    public class Author
    {
        public int id { get; set; }
        public string  name { get; set; }
        public DateTime DOB { get; set; }
        public string bookTitlle { get; set; }
        public bool isMvp {  get; set; }
    }
    
}
