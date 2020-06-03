using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFSeparatedDataTemplate.Models;

namespace XFSeparatedDataTemplate
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Book> _books;
        public ObservableCollection<Book> Books
        {
            get => _books;
            set
            {
                _books = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            var tempList = new List<Book>();
            for(int i=0;i<20;i++)
            {
                tempList.Add(new Book
                {
                    AuthorName = $"Author{i}",
                    Title = $"Title{i}",
                    Description = $"Description{i}",
                });
            }

            Books = new ObservableCollection<Book>(tempList);
        }
    }
}
