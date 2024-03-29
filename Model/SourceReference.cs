﻿using System.Collections.ObjectModel;

namespace DataCompare {
    public class SourceReference {
        public string Name { get; set; }
        public string Path { get; set; }
        public ObservableCollection<ISourceReferenceItem> Items { get; set; }

        public SourceReference() {
            this.Items = new ObservableCollection<ISourceReferenceItem>();
        }
    }
}