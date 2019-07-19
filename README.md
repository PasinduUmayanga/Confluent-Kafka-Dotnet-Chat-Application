# Confluent-Kafka-Dotnet-Chat-Application


![logo](https://user-images.githubusercontent.com/21302583/61532098-75a9b680-aa46-11e9-8ffb-80e42c87c4ca.png)

Before Start application you must setup like this.

Downloading the Required Files
• Download Server JRE
• Download and install 7-zip 
• Download and extract ZooKeeper using 7-zip
• Download and extract Kafka using 7-zip

Do All Extract to C:\Tools

## Installation

### A. JDK Setup
1. Start the JRE installation and hit the “Change destination folder” checkbox, then click 'Install.'
 
2. Change the installation directory to any path without spaces in the folder name. E.g. C:\Java\jre1.8.0_xx\. (By default it will be C:\Program Files\Java\jre1.8.0_xx), then click 'Next.'
3. Now open the system environment variables dialogue by opening Control Panel -> System -> Advanced system settings -> Environment Variables.
4. Hit the New User Variable button in the User variables section, then type JAVA_HOME in Variable name and give your jre path in the Variable value. It should look like the below image:
 (Java path and version may change according to the version of Kafka you are using)
5. Now click OK.
6. Search for a Path variable in the “System Variable” section in the “Environment Variables” dialogue box you just opened.
7. Edit the path and type “;%JAVA_HOME%\bin” at the end of the text already written there, just like the image below:
 
8. To confirm the Java installation, just open cmd and type “java –version.” You should be able to see the version of Java you just installed.
 



















### B. ZooKeeper Installation
1.	Go to your ZooKeeper config directory. (C:\Tools\zookeeper-3.5.5\conf)
2.	Rename file “zoo_sample.cfg” to “zoo.cfg”
3.	Open zoo.cfg in any text editor, like Notepad; I prefer Notepad++.
4.	Find and edit dataDir=/tmp/zookeeper to :\ zookeeper-3.5.5\data  
5.	Add an entry in the System Environment Variables as we did for Java.
a.	Add ZOOKEEPER_HOME = C:\Tools\zookeeper-3.5.5 to the System Variables.
b.	Edit the System Variable named “Path” and add ;%ZOOKEEPER_HOME%\bin; 
6.	You can change the default Zookeeper port in zoo.cfg file (Default port 2181).
7.	Run ZooKeeper by opening a new cmd and type zkserver.
You will see the command prompt with some details, like the image below:
 



### C. Setting Up Kafka
1.	Go to your Kafka config directory. For me its C:\Tools \ kafka_2.12-2.3.0 \config.
2.	Edit the file “server.properties.”.
3.	Find and edit the line log.dirs=/tmp/kafka-logs” to “log.dir= C:\Tools \ kafka_2.12-2.3.0 \kafka-logs.
4.	If your ZooKeeper is running on some other machine or cluster you can edit “zookeeper.connect:2181”.




















### D. Running a Kafka Server
Important: Please ensure that your ZooKeeper instance is up and running before starting a Kafka server.
1.	Go to your Kafka installation directory: C:\Tools \ kafka_2.12-2.3.0 
2.	Open a command prompt here by pressing Shift + right click and choose the “Open command window here” option).
3.	Now type .\bin\windows\kafka-server-start.bat .\config\server.properties and press Enter.
.\bin\windows\kafka-server-start.bat .\config\server.properties

4. If everything went fine, your command prompt will look like this:
 

