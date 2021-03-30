# Student Data Application

## About
This project is the continued development of the Major Project for the **Diploma of Software Development** that I successfully completed in the 2nd semester of 2020.

This was built in Visual Studio 2019 using Entity Framework 6 with code-first methodology to build and seed the database. The MSSQL database and C# code was originally designed according to the business rules laid out in the specifications for the assignment. It was designed as an administrative tool for a training provider. It has since been refactored and modified for some improvements and potential future modifications.

I will not accept any push or merge requests as this is my own work used to show an example of my abilities.

## Prerequisites
- Visual Studio 2019 + Data storage and processing component with SQL Server Data Tools selected
- MSSQLLocalDB instance

## Installation instructions
1. Clone this repository.
2. Open *"StudentApplication.sln"* in Visual Studio
3. Verify you have a *"MSSQLLocalDB"* instance installation on your machine by the following steps.
    - In Package Manager Console, type...

        `SqlLocalDB info`

    - Verify that *"MSSQLLocalDB"* appears in the list,
    - if not, in Package Mananger Console type...

        `SqlLocalDB create "MSSQLLocalDB"`

      ...to create a new DB instance.
6. In the Package Manager Console, select the project *"StudentApp_Controller"*.
7. In Package Manager Console type...

    `update-database`

   ...this will build the database and seed it with data.
8. The Project can now be run in Visual Studio with the shortcut **CTRL/F5**.

## Known issues and potential future changes
I think I have the right idea, but very likely the wrong implementaion of the BuildView and ColumnProperties classes.

### Issues
- [ ] It can be slow when displaying some large result tables. I need to find a way to optimise (or get a better understanding of) the formatting of the DataGridViews.
- [ ] When assigning units to courses, the search feature in the dialog resets any selections made. This dialog is cumbersome, it needs a rethink on the functionality.

### Tasks - not part of original scope (including wishlist)
- [x] Transactions page
- [ ] Convert from .NET Framework to ASP.NET Core
- [ ] A login system for students, teachers or administrators (delayed for my own sanity during development)
- [ ] Teachers assigned to a college
- [ ] Units assigned to subjects and subjects assigned to courses
- [ ] CSV Export
- [ ] Additional/Amended Invoice
- [ ] Make the columns sortable on the transactions page.
- [ ] Completely redo unit tests

## Disclaimer
The seed data in this project is a work of fiction. All the names, characters, businesses, places, events and incidents in the seed data are either the product of the author's imagination or used in a fictitious manner. Any resemblance to actual persons, living or dead, or actual events is purely coincidental.