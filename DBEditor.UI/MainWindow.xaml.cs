using DBEditor.Service.Model;
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

namespace DBEditor.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabaseServer Model = DatabaseServerSampleDataFactory.GetSimpleDatabaseServer();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Model;
        }

        private void TreeView_Loaded(object sender, RoutedEventArgs e)
        {
            var tree = sender as TreeView;
            foreach (var database in Model.Databases)
            {
                var item = CreateTreeItem(database, database.Name);
                tree.Items.Add(item);
            }
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var item = e.NewValue as TreeViewItem;
            if (item != null)
            {
                propertyGrid.SelectedObject = item.Tag;

                //string result = "";
                //var properties = item.Tag.GetType().GetProperties();
                //foreach (var property in properties)
                //{
                //    result += property.Name + "";
                //}
            }
        }

        public void TreeView_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;
            //if ((item.Items.Count == 1) && (item.Items[0] is string))
            {
                item.Items.Clear();
                var tag = item.Tag;
                if (tag is Database)
                {
                    var database = (Database)tag;
                    foreach (var table in database.Tables)
                    {
                        var innerItem = CreateTreeItem(table, table.Name);
                        item.Items.Add(innerItem);
                    }
                }
                if (tag is DatabaseTable)
                {
                    var table = (DatabaseTable)tag;
                    foreach (var field in table.Fields)
                    {
                        var innerItem = CreateTreeItem(field, field.Name);
                        item.Items.Add(innerItem);
                    }
                }
            }
        }

        private TreeViewItem CreateTreeItem(object o, string header)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = header;
            item.Tag = o;
            item.Items.Add("Loading...");
            item.ContextMenu = new ContextMenu();
            return item;
        }

        
        

    }
}
