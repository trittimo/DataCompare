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

namespace DataCompare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SourceReference root = new SourceReference() { Name = "Root" };
            SourceReference child1 = new SourceReference() { Name = "Child1" };
            SourceReference child2 = new SourceReference() { Name = "Child2" };
            SourceReference child3 = new SourceReference() { Name = "Child3" };

            child1.Items.Add(child3);
            root.Items.Add(child1);
            root.Items.Add(child2);

            Console.WriteLine(root.Items.Count + root.Items.ToString());

            treeViewLeft.Items.Add(root);
        }
    }
}
