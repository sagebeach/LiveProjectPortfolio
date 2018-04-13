# LiveProjectPortfolio
I was brought onto a live project through my school for one of their clients. Included are code samples from a three week period working with a live team on this project part-time.

## Changelog:

### Week 1:
------------------------------------------------
#### Day 1:
1321 - Checked out project and familiarized myself with the codebase.
#### Day 2:
Further exploration of the codebase. I was at work all day and had little time to work on the project.

#### Day 3:
1323 - I had to add  @Styles.Render("~/Content/Site.css") to the _Layout.cshtml in order for the style I added to render in the About page. I was able to add the requested styles without any direct changes to About.cshtml. The only edit I made to About.cshtml was to add missing div tags. Additional note, following the current pattern I specified a section of the Site.css page for styles on the About page for current and future use. CHECK IN
1328 - I modified the default user admin to include the email for sign-in, but due to issues with the user registration controller I have been unable to test the actual sign-in of the Admin.

#### Day 4:
1329 - Added a new Promotion class to the Models Folder linked with the ApplicationUser and the Campaign model.  Also includes a code first migration pushed into the database. CHECK IN
1323 - I was able to get a specified password string to save in the database as a password hash but the Admin account still is unable to log in.
#### Day 5:
1323 - I was able to resolve the login issue after speaking with the project manager and the admin login credentials are now operational. CHECK IN
1329 - The UserId property in the promotion class needed to be a string not an int value so I updated the change and pushed a new database migration. CHECK IN
Worked on implementing a new action/method in the AccountController to retrieve the user’s firstname from the database using the userID. Having trouble passing the username to the view, need to troubleshoot tomorrow.
### Week 2:
------------------------------------------------
#### Day 1(6):
1285 - I rewrote the action with what should get the User’s Firstname from the DBContext using the UserId from the current context however I cannot troubleshoot why it is not displaying anything when passed to the viewbag/view. Pending instructor review tomorrow.
#### Day 2-3
1285 - It took several attempts to find the right process for pulling the User’s information through the Identity Model. Only a an hour or two per night after work so not much progress.
#### Day 4
1285 - Final solution was to make a new claim in the identityModel. The current active Users FirstName now displays for their accounts across all views. CHECK IN

![alt text](https://github.com/sagebeach/LiveProjectPortfolio/blob/master/AdminLogin.PNG "Created Admin account")
![alt text](https://github.com/sagebeach/LiveProjectPortfolio/blob/master/AdminLoginDone.PNG "Admin Logs in and admin name is pulled from database")
![alt text](https://github.com/sagebeach/LiveProjectPortfolio/blob/master/customname.PNG "Current User name is pulled through Identity model from database")
1349 - *Includes Migration* Changed (GUID)SellerID to (String)UserID and virtual Seller Seller, to ApplicationUser ApplicationUser. Updated reference changes CampaignsController.cs and migrated changes to database. CHECK IN

### Week 3:
------------------------------------------------
#### Day 1-2: busy with work
#### Day 3:
Troubleshooted issues with a database migration. Attempts to update the database threw login errors. Solved by recreating the database.
A changeset from one of my teammates was throwing HTTP errors. I traced the error down to the specific changeset and found the changed code causing the exception. Fixed and now up and running.
![alt text](https://github.com/sagebeach/LiveProjectPortfolio/blob/master/FixedChangesetBug.PNG "Tracked down bug causing HTTP error 404.15")

1254 - Created AdminController with CRUD functionality and modified/updated the AdminViewModel with the Campaign model. CHECK IN
#### Day 5:
Wrapped up my time on the project with a code retrospective and a report essay.
