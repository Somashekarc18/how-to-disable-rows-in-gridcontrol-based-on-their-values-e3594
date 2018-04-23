using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Grid;
using System.Windows.Data;

namespace WpfApplication
{
    public static class RowStateHelper
    {
        public static readonly DependencyProperty IsHelperEnabledProperty = DependencyProperty.RegisterAttached("IsHelperEnabled", typeof(bool), typeof(RowStateHelper), new UIPropertyMetadata(false, new PropertyChangedCallback(OnIsHelperEnabledChanged)));

        public static bool GetIsHelperEnabled(DependencyObject target)
        {
            return (bool)target.GetValue(IsHelperEnabledProperty);
        }
        public static void SetIsHelperEnabled(DependencyObject target, bool value)
        {
            target.SetValue(IsHelperEnabledProperty, value);
        }
        private static void OnIsHelperEnabledChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            OnIsHelperEnabledChanged(o, (bool)e.OldValue, (bool)e.NewValue);
        }
        private static void OnIsHelperEnabledChanged(DependencyObject o, bool oldValue, bool newValue)
        {
            GridViewBase view = o as GridViewBase;
            view.ShowingEditor -= RowStateHelper_ShowingEditor;
            if (newValue)
                view.ShowingEditor += RowStateHelper_ShowingEditor;

        }

        static void RowStateHelper_ShowingEditor(object sender, ShowingEditorEventArgs e)
        {
            e.Cancel = !IsRowEnabled(e.Row);
        }

        public static bool IsRowEnabled(object row)
        {
            GridItem datarow = row as GridItem;
            if (datarow == null)
                return true;
            return datarow.AllowEdit;
        }

    }
}