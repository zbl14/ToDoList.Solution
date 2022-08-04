# To Do List

#### By _**Zhibin Liang**_  

#### _A web application for listing and sorting thing to do by customized categories._  

---
## Technologies Used

* C#
* HTML/CSS
* MySQL
* ASP.NET CORE

---
## Description

A user can add/view things to do by customized categories.

---
## Setup/Installation Requirements

<details>
<summary><strong>To Setup</strong></summary>

* Requires _MySQL_ for the database
* Install _Microsoft .NET SDK_
* Clone the repo
    ```
    $ git clone https://github.com/zbl14/ToDoList.Solution.git
    ```
</details>

<details>
<summary><strong>To Run</strong></summary>

* Navigate to  
   <pre>ToDoList.Solution
   ├── <strong>ToDoList</strong>
   └── ToDoList.Tests</pre>
* Create ```appsettings.json``` in the directory of _HairSalon_, and add following to the file with your MySQL username and password
    ```
    {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=[username];pwd=[password];"
    }
    }
    ```
* Run follwing commands
    ```
    $ dotnet restore
    ```
    ```
    $ dotnet ef database update
    ```
    ```
    $ dotnet run
    ```
</details>

<details>
<summary><strong>For Testing</strong></summary>

* Navigate to  
    <pre>ToDoList.Solution
    ├── ToDoList
    └── <strong>ToDoList.Tests</strong></pre>

    ```
    $ dotnet restore
    ```
    ```
    $ dotnet test
    ```
</details>
<br/>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _Any known issues_
* _should go here_

## License
MIT

## Contact Information
Zhibin Liang <ifthereisoneday@gmail.com>

Copyright &copy; 2022 Zhibin Liang