# .NET-Core-and-Angular-9-CRUD-with-Ag-Grid

Basic CRUD in a .Net Web app.

A simple test of CRUD using .NetCore 3.1 exposing one data table to an Angular client that
allows create/update/delete using a form and the Ag-grid component, which gives us paging, sorting etc
out of the box.

Has a DB init that will setup and populate the table with some test data, on startup.
The data model is one object called customer, delivered using a basic controller.



# Set up

You'll need .Net Core, Node.js, Angular 9 and npm.
If the Ag-Grid doesn't install automatically - you can do so with:

npm install --save ag-grid-community

The DB is init-ed and created on Startup, but makes use of in memory SQL server express on localhost for the 
DB.


# To Start the Server

Build and run the VS project in debug, this will load a page of json data in the browser using the exposed Service URL.

Check that this URL for the service is correct in the Angular client service at - Client\src\app\service.service.ts.

# To Start the Client and Connect:

At command prompt, run ng serve.
Browse to the URL output in the cmd prompt to see the client.

# Components used

.NET Core 3.1, Angular 9, Ag-Grid.

Ag-Grid is a very decent data grid component, check it out here:

https://www.ag-grid.com/javascript-grid-getting-started/





