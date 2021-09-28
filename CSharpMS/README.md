# BlogCSharpMS
C Sharp Microservice for Blog Project
# Solution(.sln) File [Container encapsulating all projects for blog microservices]
- BlogMS.sln

# Overview of Architecture [ 6-Projects in 1-solution container ]
------------------------------------------------------------------------------
- BlogMS.WebApi [project] : ASP.NET Core (hosting web apis toward UI)

- BlogMS.Bll [Project] : .Net Core Console (hosting integration logic toward Web Api)

- BlogMS.Repository [Project] .Net Core Console (hosting db/dbs fetch logic)

- BlogMS.Utils [Project] .Net Core Console (hosting calls to other microservices)

- BlogMS.Model [Project] .Net Core Console (utility project to host data model classes)

- BlogMS.DTO [Project] .Net Core Console (utility project to host data transfer object types)
------------------------------------------------------------------------------

