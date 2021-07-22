Our junior colleague was tasked with writing an app that reads client data from the given source and saves it into the database. The colleague claimed to have completed the task. Unfortunately, the testers reported that the application is failing for some input files, especially Legal Entity data looks out of order. Additionally, the code seems to be of low quality.

Your tasks:
-	Identify and annotate the shortcomings in the current implementation as if you were doing a code review, using comments in the files.
-	In a fresh solution, refactor this implementation into clean,  elegant, rock-solid, testable & well performing code, without over-engineering. Where you make trade offs, comment & explain.

Business Requirements:
-	The input files might contain comment lines, starting from # (hash sign), these should be ignored
-	Only Legal Entities have Entity Type and Turnover
-	Listed Legal Entities with the turnover mover than $1mln should be subject to additional screening using Robotics engine
-	Legal Entities that failed the screening should not be added to the database
-	Natural Persons should have First and Last Names populated
-	First Name is the first word in Name (e.g. Joe in Joe Edward Doe)
-	Last Name is the last word in Name (e.g. Doe in Joe Edwards Doe)

Technical Info:
-	The input files are always valid and there is no need to validate the data
-	Robotics engine is implemented by another team and the code in Rabobank.GCOB.External has to be used as is. No modifications allowed here.
-	Updating client in ClientRepository will be implemented by another developer. Their only suggestion was that the storage they have chosen for persisting data does not support synchronous methods.
-	You are free to modify and implement all other code in any way you want.

