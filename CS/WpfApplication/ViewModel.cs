
using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.POCO;

namespace WpfApplication {
    public class ViewModel {
        public virtual ObservableCollection<GridItem> Items { get; set; }
        public virtual GridItem CurrentItem { get; set; }

        public ViewModel() {
            Items = new ObservableCollection<GridItem>();
            for (int i = 0; i < 15; i++)
                Items.Add(ViewModelSource.Create(() => new GridItem() { AllowEdit = i % 3 != 0, Name = String.Format("Name{0}", i), ID = i }));
            CurrentItem = Items[0];
        }
    }

    public class GridItem {
        public virtual string Name { get; set; }
        public virtual int ID { get; set; }
        public virtual bool AllowEdit { get; set; }
    }
}
