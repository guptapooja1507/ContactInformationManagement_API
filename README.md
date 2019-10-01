Architecture Of Project - 

This is three layered architecture project named as – 
Service Layer
1.1 ContactController – To perform CRUD operation.

Business Layer – Perform business logic and manipulate result set from repository..
1.1 Interface - IContactManager
1.2 Implementation - ContactManager

Data access Layer – To establish database connection.
1.1 Interface - IContactRepository
1.2 Implementation – ContactRepository

Dependency Injection – SimpleInjectorDependencyResolver 
Exception Handling – CustomExceptionFilterAttribute - Registered this attribute in WebApiConfig file.

Used static contact list as data storage for sample

Used custom attribute.

PFB all URL – 
GET: api/contact/GetContactDetails
Post: api/contact/AddContactDetail
Put: api/contact/EditContactDetail
api/contact/DeleteContactDetail


TO RUN THE APPLICATION FOLLOW BELOW STEP – 

1.Ungip the folder.
2.Open ContactInfoManagement_API solution in visual studio.
3.Either run locally or host into IIS server.
4. use below URL to get all contact details – 
api/contact/GetContactDetails

for remaining API use postman or create console application.
