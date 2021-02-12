# Blazorise-ReadDataTestRepository
This is a project to recreate the double readdata call when using OnInitialized async and awaiting inside it.

Expected outcome:
Navigating from the DataGrid page, via the save state button, will save the columns sorting direction and page. Once you click back on the DataGrid page, it will take you back to the DataGrid with same sorting direction and page.


Current outcome:
Column sorting direction is persisted in local storage but not displayed in DataGrid. Read data will call with the same page and size, but loses direction for some reason.
Also, it will make 2 ReadData calls when navigating back from page 2 or 3. But only make 1 call when coming back from page 1.


Steps to reproduce.

1. Open project and the browsers console log.
2. Go to Datagrid tab on the left of the project.
3. Navigate to page 2 or 3.
4. Press the set state button, which takes you back to the home page.
5. Go to Datagrid page again, and see the double ReadData call in the console.

If you put breakpoints on the OnInitialized, and on the ReadData method, you can see the passing between the methods. You would expect that even if it's async, that OnInitialized will always finish first before the ReadData method.

If you uncomment the line in OnInitializedAsync inside the DataGridPage.razor file, to make the method run synchronously, it saves the state of the grid as expected.
