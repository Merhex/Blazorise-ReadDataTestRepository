# Blazorise-ReadDataTestRepository
This is a project to recreate the double readdata call when using OnInitialized async and awaiting inside it.

Steps to reproduce.

1. Open project and the browsers console log.
2. Go to Datagrid tab on the left of the project.
3. Navigate to page 2 or 3.
4. Press the set state button, which takes you back to the home page.
5. Go to Datagrid page again, and see the double ReadData call in the console.

If you put breakpoints on the OnInitialized, and on the ReadData method, you can see the passing between the methods. You would expect that even if it's async, that OnInitialized will always finish first before the ReadData method.
