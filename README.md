## Employee Management API

---

Company XYZ began creating an API that will allow them to View and Add employees to their database. They have now hired you to make some adjustments and add features. Below is their wish list.

### Wish List

1. When getting employees, the API should only provide ID, Name and Manager Name.
1. Create an endpoint that can return a single employee by their employee id.
1. Create an endpoint that will allow me to add a new employee.  
   a. An employee must be assigned a manager.  
   b. The employee being assigned as manager must be a manager.
   c. If the employee is going to be a manager, their manager can be set to anyone that is also a manager.
   d. An id will automatically be assigned to the employee upon creation. (See CreateEmployee iside EmployeeRepository.cs)
1. Create a way to set an employee to Inactive.


### Candidate Instructions:

1. Fork the code and begin working.
1. Code is using .Net core 3.1 so you will need Visual Studio 2019+, VS Code or any choice of alternate editor. If this is a problem, please reach out ASAP so we can provide you an alternate solution.  
  a. If using VSCode, you can start the application by going to Run and Debug and pressing the Green button.   Route to https://localhost:5001/employees  
  b. If using Visual Studio, you can start the application by pressing the Green Button. A window will popup automatically routed to the solution.  
1. Try to write at least 1 unit test. We have supplied NSubstitute, but you are free to add Moq or use any other method you choose to to make your stubs and mocks.


### Submitting your solution
1. You are free to submit your solution using a GitHub repository link, zip file or external storage solution. 
1. Provide the amount of time you spent on the algorithm and the amount of time you spent on this solution.

## Important Note: 
We understand that you can spend hours or even days tweaking and fixing code. Please do not spend more than 2-3 hours on this as we will review and do some additional coding together. 

You are free to make any changes to any pre-supplied code.

### In Memory Storage
To make things easier, we have supplied an in-memory storage solution and repositories so you can jump-start faster without worrying about how to access data. You are free to come up with your own solution.

### Troubleshooting
If you are having trouble starting the application, please let us know.