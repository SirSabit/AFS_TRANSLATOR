# AFS_TRANSLATOR

Installation
 
 1- Make sure that you have postgre sql installed on your local machine
 2-Make sure to implement your own connection string under the AFS_TRANSLATOR.DAL/DBConnections/PgDbContext.cs 
 3-Set AFS_TRANSLATOR.DAL project as a start up project
 4-Go to the Nuget package manager console and set default project as AFS_TRANSLATOR.DAL again
 5-Run the command update-database
 6-Set AFS_TRANSLATOR.MVC project and you are good to go. Have fun :-)
 
 About This Project
 This project is using N-Tier design pattern along side with repository design pattern. Data access layer and Bussiness Logic layer contains their own builder extensions. Presentation layer based on MVC desing pattern. You can't find any jquery or ajax implementation since I don't know a lot about them. I used model binding, tag helpers and basic css to create front-end part. Project has a basic authentication with cookies. Only login part is covered and it simply checks NickName and Password without even going to Db. There is an external api call in the project which translates a plain text to leet speak. I also keep the history table of the tranlations.
 
 DB table contains the text to be translated, translation of the text, translation type of the text(It's only leetspeak for now but in the future i could add another type of Translations if requested), and requestTime to keep track of time.
 
 Overall I tried to implement OOP rules and design patterns as much as i can. I Hope you like the project.
