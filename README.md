## Welcome to the Tic Tac Tactical Game!

## Assessment:
Hello Everyone!

MMy name is Jon and I wanted to step out of my shell and learn something completely new. With C#/.NET framework being vital to millions of organizations, I ventured to strengthen my knowledge using C#/.NET framework by creating a simple text based RPG/TicTacToe inspired game. 
The game is called Tic Tac Tactical where you are asked to select three characters from a list to defeat your enemy (the computer). 
The character list can be found in the main menu by selecting option 2, or by opening and reviewing the CharactersCSV.csv file on the main page above. 
Your team will fight against the enemy team automatically in the background and return if you won or not. The game itself has more than 720 possible outcomes. I will be updating the game periodically to implement more advanced functions to alleviate any performance issues.

This program was created as my final capstone for the Computer Science Degree at Southern New Hampshire University. Throughout the program, I have been fortunate enough to have acquired deeper knowledge and understanding revolving around numerous areas of expertise. Namely, methodologies focused around SAAS/PAAS deliverables. Through the use of these methodologies I have worked with my peers within hub environments collaborating through the use of online tools to produce exceptional software deliverables. Working with my peers provided experience in communication with other stakeholders within the software life cycle. With this communication I was given the opportunity to review and work alongside with an exceptional team to create products and services for organizations. With this collaboration, I strengthened my knowledge of data structures, algorithms, and databases. Clear communication was provided to a single pane of glass with any updates to the software throughout the cycle. The updates, changes, and modifications of any sort to the software & Software Process were logged and neatly organized for transparency. With this decision made, the final product meet and exceeded original expectations with increased performance and functionality.  With my personal focus being database management and data security, these practices were applied within this project to push/pull data through the use of temporary tables. Temporary tables are used in place to copy the data from the source and allow the developer to manage that data without affecting the source database. This ensures that the original data is not tampered with so that there is always a copy. Through the use of specific calls, the program itself gathers a copy of all the data from the source and completed work from the backend. Potential design flaws within the software can come from a very blatant potion of the program which is labeled csvpath. I chose to complete the program using a simple csvpath that the user provides to run the game. In the real world I find this unacceptable when running anything within production that is pulling from a database. But for the sake of ease of access, this game is set to enable any user to pull the database from their own personal location. As a disclaimer, this game holds no personal/professional data out of the box and should not be modified for use with personal/professional data. To create a more secure game, creating variables to pass through the database rather than calling them explicitly would help increase the security aspect for the program. This process would help data plugging and prevent data inserts that external users may attempt. Best practices for a game would include the safety of the database, the segregation of technologies, (i.e database, servers, domain controllers....etc)

Please read below for more insight on the respective artifacts and what they entail.



<-- To easily navigate click on the shortcuts within the navigation pane. Or access the repo here: https://github.com/jonanoz/jonanoz.github.io

### Before you begin!!
```markdown
Prior to running the game two things must be managed by the user:

1: 
You must download the csv file "CharactersCSV.csv" to a reachable 
file location on your local machine.

2: 
You must add the UNC path of the "CharactersCSV.csv" file location 
into variable "csvpath" in the below files:

    -Play.cs
    -Characters.cs
    
Please let me know if you run into any issues. 
Thank you!

```

### Artifacts

### Software Design and Engineering
   -The artifact being utilized for Software Design and Engineering comes from a previous course I took revolving around AGILE methodologies. Through these practices I applied a segregation of duties for myself within parts similar to a khan ban board. Each section revolved around an individual piece within the game when it comes from designing the main menu, user interface, user inputs and error handlings. This affected the software design itself with how the program was going to call the csv database to function.  
    
   -Segregating the duties into smaller parts allowed myself to ensure that no piece was going in prior to another so errors could be caught. Practicing these methodologies is an industry standard when working with updating software. With the Github page able to log all changes or commits, the e-portfolio itself acts in a way that aligns with those agile methodologies.
     
   -Throughout the entirety of the Computer Science curriculum, I find this to be the most rewarding as it provides me more understanding of how business functions outside of the technology vertical. I can see how each and every team can be affected by the timeframes of specific pieces and it provides a clearer understanding of business needs for the organization.  
### Algorithms and Data Structures
   -The artifact being utilized is a previous final that covers nested loops. Within the code you can find inserts, removes, search and adding of nodes with node management. Trees are a good use of sorting in the code as each node is considered either a parent of a child and can easily configure itself to change with managing pointers. This process was managed into temporary tables and lists rather than individual nodes to enable segregation for security. Let’s say we remove a node that has a parent and also has a child, removing that node will change the parent and child pointers to the parent and child of that previous node respectfully. 
   
   -The inclusion of the nested loops was made to complete the game as multiple classes were being called at once. Specifically, one instance of the game requires that the user selects a team. The user selects a character from the options which triggers a selection from the computer. Once the computer selects a random character, it re-calls the loop for the user to add more members into their team. I chose these as they are simpler algorithms that can easily be given more complexity and touch far more objects than the previous courses would allow. I want to be able to have the code itself complete all of the functions necessary for this project while not affecting the core database and its values as a whole. The code in the application will simply utilize the database and not affect it whatsoever when utilizing a temporary table to progress through the game. 
   
   -Reflecting on this portion of the project this was one of the more difficult to implement due to being new with calling outside sources through c#. From this practice I was able to grasp a good understanding of what modules were needed to manipulate the data from the csv which brought me more understanding of the C# language and its syntax differences.  

### Databases
   -The artifact being utilized is a previous final that covers the call functions. The artifact used from the previous class is simply the calls from a mongodb. I am not using this approach but I am using the type of style that I used for this artifact. The mongo db was called from a web tool which we used to call files from another root folder to modify. I am taking this approach so that I can called the data from my excel database to push/pull functions. Instead of utilizing a mongodb, this program utilizes a csv file as the database.
   
   -I chose this type of artifact because it’s a rudimentary way to make my calls and it allows the access to most individuals as in today’s world most people have some sort of Microsoft office application on the machines. I am using excel because of this, if I wanted to change this from excel I could easily do that to create a CSV file as a text as it’s more universal over Microsoft office. But for the sake of completion I like the use of Excel as it provides an easier look with its UI. Dialogue through the play through was added to enhance user experience, while making it as simple as possible so that the users can pick the game up much easier instead of needing to read through a booklet to understand what is going on. The overall structure of the game won’t necessarily require huge changes with the new approach so I am not worried about the fundamental change.  
    
   -The enhancement of the artifact isn’t simple changing the structure, but more or less going to be enabling other uses and elements for further complexity. I learned that one result from the tree search for example, can update other areas that are also going to be affected within the final product so that I don’t have to “reinvent the wheel” for each piece I want to implement. I am learning a lot about my personal workflow and really coming together on how I like to approach these types of project and seeing how going piece by piece really assists me and my learning. This opportunity to create something is really invigorating and providing me a lot of freedom to really explore the possibilities which I am very grateful for. 




