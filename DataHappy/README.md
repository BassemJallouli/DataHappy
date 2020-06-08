Happy Data Project

1.	Objective 

The project is an internal web site of company, the user can do the management of conferences and he can do reviews for comments in real time. It is great tool to present many conferences for client and show him integration of machine learning using C# in ASP.NET Core.

2.	Description 

The web site will introduce the company and ensure the management of conferences, you can create or read or update or delete a project. The user can do sentiment analysis of customer reviews. You can have access for contact information.

3.	Installation

The web site needs installation of special libraries. Download and install the ML.NET Model Builder tool from the Visual Studio Marketplace. It is important to add Microsoft.Extensions.ML and Entity Framework Core from NuGet Packages. 

https://marketplace.visualstudio.com/items?itemName=MLNET.07

4.	Features 

The navigation bar connects to four pages: main, agenda, review, and contact. Main page introduces the company. Agenda page shows the management of projects using ASP.NET (MVC) framework. Review page is used to do analysis of customer reviews using ML.NET library. Contact page contains address, phone number and social media links. 

5.	Data design 

We use Entity Framework Core to manipulate the data names of projects when we create or read or update or delete. We use the library ML.NET to train the data to make analysis of reviews. We choose a local file in tsv format.

6.	Challenges

We add razor file using bootstrap framework in ASP.NET Core. MVC design need to be done with good wiring between models, controllers, and services. We need to connect the ML.NET model with the main web site. I already read and watch a tutorial about razor, MVC and ML.NET in ASP.NET Core.

7.	Frameworks and languages 

dot NET CORE[MVC-Razor Pages], C#, CSS, JavaScript and ML.NET
