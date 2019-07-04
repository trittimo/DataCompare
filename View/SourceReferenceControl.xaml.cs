using System;
using System.Windows.Controls;

namespace DataCompare
{
    /// <summary>
    /// Interaction logic for SourceReferenceControl.xaml
    /// </summary>
    public partial class SourceReferenceControl : UserControl
    {
        public SourceReferenceControl()
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
