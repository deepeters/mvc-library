# Project Name: MVC Library

## Project Description

A simple ASP.NET Core 3.1 application to test out routing in dotnet MVC by building a simple library application with a list of books.

<img src = "images/BookListMVC.png">

### Setup Instructions

    - Clone repository from https://github.com/deepeters/mvc-library
    - Apply database models by running the following commands on the Package Manager Console:
        add-migration AddBookToDb -  Creates a script to be executed on the Database
        update-database - Create the database and the tables (Push the migrations)
    - Run project on browser at https://localhost:44346/BookList

### In addition

Add the following scripts to improve the UI using readymade interfaces.

    link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
    link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
    link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
    link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.css" />

    <script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

### Technologies and Frameworks Used

1. C#
2. Javascript
3. HTML5
4. CSS 3
5. ASP.NET framework
6. Microsoft SQL server.
7. MySQL Database

### License: [MIT LICENSE](https://raw.githubusercontent.com/deepeters/razor-library/master/LICENSE)
