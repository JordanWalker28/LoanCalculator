Running the web api:

    The Web API can be ran by loading the .sln in /Web Api, once loaded clicking run will start the api and it will be running at: http://localhost:5000/api/loans by default there is no data in the in-memory database

    If you want to test with POSTMAN or a similiar tool:

POST:

    Post requests should be sent to http://localhost:5000/api/loans

Test Data:

    [{
            "name": "Test1",
            "repaymentAmount": 1000,
            "borrowingAmount": 600
    },
    {
            "name": "Test2",
            "repaymentAmount": 3000,
            "borrowingAmount": 1500
    }]

GET

    To get an individual loan the following GET request can be sent:
    http://localhost:5000/api/loans/{id} replacing {id} with the valid id being searched for.

    The default url http://localhost:5000/api/loans will return all loans

DELETE

    To delete a loan the following DELETE request can be sent:
    http://localhost:5000/api/loans/{id} replacing {id} with the valid id being deleted.

Running the website:

    The website was created in angular and can be ran by using the terminal and navigating to the /Angular folder. 
    From there you need to use the following commands:

    npm install
    ng serve
    
    The Application should then be visible on http://localhost:4200/loans
    
Problems

    If there is any problems, please feel free to contact me. 
