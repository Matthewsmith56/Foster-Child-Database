# Foster-Child-Database
Database for tracking foster children

  When I was around 13 years old my family opened our house to be a foster home. Over the next ten years we would have around eleven children stay with us anywhere from three days to three years. My family would end up adopting two children who to this day are growing up way too fast. Due to my family’s lengthy work with the foster care industry I knew that I wanted to develop an application that might help mitigate the foster care crisis.

  Currently foster children are tracked with an Excel spread sheet that is consolidated weekly. Unfortunately, in an industry where children can sometimes be moved daily a spread sheet can prove to be outdated. This project I am working on is an instantly updateable database built in the ASP.NET framework that will allow foster agencies to track the placement and information of foster children across the south Florida region.

Basic Requirements
1.	Master database  should be a consolidation of all sub databases. 

2.	Master database should only be accessible be director of the agency and should be encrypted to secure personal information about children and parents.

3.	Sub databases should be accessible by employees of organizations that answer to the head agency and must be able to push information up to the   

4.	master database regularly, either through a user-initiated refresh or through regularly scheduled updates with the master database. 

5.	Each Sub database should be independent of other sub databases and should not be accessible by other organizations.

Florida Foster Crisis Information:

http://www.dcf.state.fl.us/programs/childwelfare/dashboard/c-in-ooh.shtml

References I used for this project:

https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started

https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
