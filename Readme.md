<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication/MainWindow.xaml.vb))
* [DataHelper.cs](./CS/WpfApplication/Model/DataHelper.cs) (VB: [DataHelper.vb](./VB/WpfApplication/Model/DataHelper.vb))
* [RowStateConverter.cs](./CS/WpfApplication/RowStateHelper/RowStateConverter.cs) (VB: [RowStateConverter.vb](./VB/WpfApplication/RowStateHelper/RowStateConverter.vb))
* [RowStateHelper.cs](./CS/WpfApplication/RowStateHelper/RowStateHelper.cs) (VB: [RowStateHelper.vb](./VB/WpfApplication/RowStateHelper/RowStateHelper.vb))
* [ViewModel.cs](./CS/WpfApplication/ViewModel/ViewModel.cs) (VB: [ViewModel.vb](./VB/WpfApplication/ViewModel/ViewModel.vb))
<!-- default file list end -->
# How to disable rows in GridControl based on their values


<p>To disable a row, use either of the following approaches: <br>1. Handle the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridGridViewBase_ShowingEditortopic">ShowingEditor </a> event and set the <strong>e.Cancel</strong> property to true in the event handler.<br>2. Bind the editor's <strong>IsReadOnly</strong> property inside <strong>CellTemplate</strong> (supported starting with version <strong>15.2</strong>).<br><br>Both these approaches are demonstrated in the underlying sample project. </p>

<br/>


