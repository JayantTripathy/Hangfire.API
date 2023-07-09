# Hangfire.API

<img src="https://jayanttripathy.com/wp-content/uploads/2023/07/Background-Jobs-in-ASP.Net-Core-Hangfire.png"/>
What Is Hangfire?
Hangfire is an open-source and well-documented task scheduler for ASP.NET and ASP.NET Core. It’s multi-threaded, easily scalable, and offers a variety of job types. It’s well structured, simple to use, and gives a powerful performance.

Hangfire Workflow
The client, server, and storage are the three essential components of Hangfire architecture. They are connected throughout the process and rely on one another.

Role of Each Component
Let’s see what each component is responsible for:

Hangfire client – These are the actual libraries inside our application. The client creates the job, serializes its definition, and makes sure to store it into our persistent storage.
Hangfire storage – This is our database. It uses a couple of designated tables that Hangfire creates for us. It stores all the information about our jobs – definitions, execution status, etc. Hangfire supports both RDBMS and NoSQL options, so we can choose which one works for our project. By default, it uses SQL Server, but any other supported option is also easy to configure.
Hangfire server – The server has the task of picking up job definitions from the storage and executing them. It’s also responsible for keeping our job storage clean from any data that we don’t use anymore. The server can live within our application, or it can be on another server. It always points to the database storage so its location doesn’t play a role, but this diversity can be very useful.


For more details please visit the blog post link
https://jayanttripathy.com/hangfire-with-asp-net-core-7/
