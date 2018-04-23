using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfApplication
{
    public class DataHelper
    {
        public static object GetDataSource(int count)
        {
         ObservableCollection<GridItem> collection = new ObservableCollection<GridItem>();
            for (int i = 0; i < count; i++)
            {
                collection.Add(new GridItem(i% 3 != 0, DateTime.Now.AddMinutes(count * i).AddDays((i - count / 2) * count), String.Format("Name{0}", i), i));
            }
            return collection;
        }
  
    }

    public class GridItem: INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the GridItem class.
        /// </summary>
        /// <param name="allowEdit"></param>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="iD"></param>
        public GridItem(bool allowEdit, DateTime date, string name, int iD)
        {
            _AllowEdit = allowEdit;
            _Date = date;
            _Name = name;
            _ID = iD;
        }

        // Fields...
        private bool _AllowEdit;
        private DateTime _Date;
        private string _Name;


        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        // Fields...
        private int _ID;


        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ID"));
            }
        }


        public DateTime Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Date"));
            }
        }


        public bool AllowEdit
        {
            get { return _AllowEdit; }
            set
            {
                _AllowEdit = value;
                OnPropertyChanged(new PropertyChangedEventArgs("AllowEdit"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        #region OnPropertyChanged
        /// <summary>
        /// Triggers the PropertyChanged event.
        /// </summary>
        public virtual void OnPropertyChanged(PropertyChangedEventArgs ea)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, ea);
        }
        #endregion
    }
}