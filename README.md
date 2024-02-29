# Headless Commerce Extensions

This project contains sample extension example for D365 Retail CRT & POS.

## Get Store Hours Sample
This extension is to get the store hours. Below are the sequence of objects created.
1. Created empty projects for ChannelDatabase, POS, Scale Unit installer and Commerce extensions.
2. Under Commerce extension folder, created a new project for CRT extension i.e. Runtime.Extension.StoreHours

	For CRT extensions
	1. Entity is created, which is basically the table structure we would like to get it from database.
	2. Request class is created, this constructs the request object based on the input parameters.
		Ex : For getting store hours, we would need store number primary input, hence we included it as parameter in class contructor. We can also add multiple input parameters 
			 based on the requirement, we can also pass recid, account Id, or list of records to process.
	3. Response class is created, response class is used for returning response object. We can take DB response as entity result and pass it to Response class.
	   In response class, based on the DB entity result, we can have multiple response methods. 
	   Even though DB returns many rows, we can chose to response only top 10, top 100, top 1000 etc.
	4. Data service class is created to handle business logic. In D365 architecture, service execute method is called based on supported request types.
	   Request class is used to get the input parameter for DB query execution/business logic process. 
	   Returns the reponse class after the execution.
	5. Controller class is created to call the specific API. API methods takes the input parameters and contructs the Request class.
	   Request is executed and response class is returned. Finally returns the result using the response class.

