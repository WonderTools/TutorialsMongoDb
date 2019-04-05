## Day1

### Importing Databases

JSON files for databases can be found in the **TutorialsMongoDB** repo

* **100YWeatherSmall.json**
  * Command to import the database --> **mongoimport --db 100YWeatherSmall --collection data --file 100YWeatherSmall.json** 
* **Video.json**
  * Command to import the database --> **mongoimport --db Video --collection movies --file Video.json**
* **Ships.json**
  * Command to import the database --> **mongoimport --db Video --collection movies --file Ships.json**
  
All our databases will be stored locally on the host system

### Connecting to DB via shell

Command to connect to localhost --> **mongo --host localhost:27017**

To check if you are connected or not, run **"show dbs"** command to see all the databases

### Connecting to DB Compass via Compass

Once you open Compass, by default it will show to connect to localhost. So just click on the connect button and you should be connected to all the local databases, which can be seen on the left hand side panel.
You should be able to see the below databases

* 100YWeatherSmall
* Video
* Ships
* admin
* config
* local

