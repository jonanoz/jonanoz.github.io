## Welcome to the Tic Tac Tactical Game!

Hello Everyone,

My name is Jon and I wanted to strengthen my knowledge using C#/.NET framework by creating a simple textbased RPG/TicTacToe inspired game. 
The game is called Tic Tac Tactical where you are asked to select three characters from a list to defeat your enemy (the computer). 
The character list can be found in the main menu by selecting option 2, or by opening and reviwing the CharactersCSV.csv file on the main page above. 
Your team will fight against the enemy team automatically in the background and return if you won or not. 

<-- To easily navigate click on the shortcuts within the navigation pane.

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

### Algorithms and Data Structures
   -The artifact being utilized is a previous final that covers nested loops. Within the code you can find inserts, removes, search and adding of nodes with node management. Trees are a good use of sorting in the code as each node is considered either a parent of a child and can easily configure itself to change with managing pointers. This process was managed into temporary tables and lists rather than individual nodes to enable segregation for security. Let’s say we remove a node that has a parent and also has a child, removing that node will change the parent and child pointers to the parent and child of that previous node respectfully. 
   -The inclusion of the nested loops was made to complete the game as multiple classes were being called at once. Speciically, one instance of th game requires that the user selects a team. The user selects a character from the options which triggers a selection from the computer. Once the computer selects a random character, it re-calls the loop for the user to add more members into their team. I chose these as they are simpler algorithms that can easily be given more complexity and touch far more objects than the previous courses would allow. I want to be able to have the code itself complete all of the functions necessary for this project while not affecting the core database and it’s values as a whole. The code in the application will simply utilize the database and not affect it whatsoever when utilizing a temporary table to progress through the game. 
   -Reflecting on this portion of the project this was one of the more difficult to implement due to being new with calling outside sources through c#. From this practice i was able to grasp a good understanding of what modules were needed to manipulate the data from the csv which brough me more understanding of the C# language and it's syntax differences. 

### Databases
   -The artifact being utilized is a previous final that covers the call functions.The artifact used from the previous class is simply the calls from a mongodb. I am not using this approach but I am using the type of style that I used for this artifact. The mongo db was called from a web tool which we used to call files from another root folder to modify. I am taking this approach so that I can called the data from my excel database to push/pull functions. Instead of utilizing a mongodb, this program utilizes a csv file as the database.
    -I chose this type of artifact because it’s a rudimentary way to make my calls and it allows the access to most individuals as in today’s world most people have some sort of Microsoft office application on the machines. I am using excel because of this, if I wanted to change this from excel I could easily do that to create a CSV file as a text as it’s more universal over Microsoft office. But for the sake of completion I like the use of Excel as it provides an easier look with it’s UI. Dialogue through the play through was added to enhance user experience, while making it as simple as possible so that the users can pick the game up much easier instead of needing to read through a booklet to understand what is going on. The overall structure of the game won’t necessarily require huge changes with the new approach so I am not worried about the fundamental change. 
    -The enhancement of the artifact isn’t simple changing the structure, but more or less going to be enabling other uses and elements for further complexity. I learned that one result from the tree search for example, can update other areas that are also going to be affected within the final product so that I don’t have to “reinvent the wheel” for each piece I want to implement. I am learning a lot about my personal workflow and really coming together on how I like to approach these types of project and seeing how going piece by piece really assists me and my learning. This opportunity to create something is really invigorating and providing me a lot of freedom to really explore the possibilities which I am very grateful for. 

### Professional Self-Assessment


