# How to disable rows in GridControl based on their values


<p>To disable a row, use either of the following approaches: <br>1. Handle the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridGridViewBase_ShowingEditortopic">ShowingEditor </a> event and set the <strong>e.Cancel</strong> property to true in the event handler.<br>2. Bind the editor's <strong>IsReadOnly</strong> property inside <strong>CellTemplate</strong> (supported starting with version <strong>15.2</strong>).<br><br>Both these approaches are demonstrated in the underlying sample project. </p>

<br/>


