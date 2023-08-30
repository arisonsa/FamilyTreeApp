# FamilyTreeApp
Private Custom .NET MAUI app for creating Family Trees

Create the Person model with properties for name, image URL, gender, date of birth, end date, and biography. 

 

Further tasks include implementing the authentication logic, initializing the family tree with data from the database, making the details of each person editable, enabling users to save their trees and export them as a .jpg, .pdf or .csv file, making the family trees shareable through links, storing the application data in an open source database such as PostgreSQL or MongoDB, adhering to good UI/UX design aesthetics and effective testing principles.


Implement a user authentication system using a standard username mechanism with a minimum password character length of 10, and also allow Gmail login.
Enable users to create interactive family trees or work leadership trees using a tree data structure. Users should be able to add person objects with attributes (name, image, gender, date of birth, end date (if deceased), biography) which will be displayed as an avatar on the object in the tree.
The details of each person object should be displayed upon clicking and these details should be editable.
The application should enable users to save their trees and export them as a .jpg, .pdf or .csv file. The exported file will be prepared within the app, ready for the user to attach and email as they see fit.
The family trees should be shareable through links, with consideration of the access permissions.
The application data should be stored in an open source database such as PostgreSQL or MongoDB.
The app should adhere to good UI/UX design aesthetics and effective testing principles.
The application should be built using the .NET 8 Preview framework for a modern look and feel.

Updated Outline.
FamilyTreeApp
├── AuthenticationSystem
│   ├── AuthenticationSystem.csproj
│   ├── ...
│   └── Pages
│       ├── Login.razor
│       └── Register.razor
├── AuthorizationSystem
│   ├── AuthorizationSystem.csproj
│   ├── ...
│   └── Pages
│       ├── RoleManagement.razor
│       └── PermissionManagement.razor
├── DatabaseAccessLayer
│   ├── DatabaseAccessLayer.csproj
│   ├── ...
│   └── Models
│       ├── Person.cs
│       ├── FamilyMember.cs # data model for family members 
│       └── Relationship.cs # data model for relationships between family members 
├── APILayer
│   ├── APILayer.csproj
│   ├── ...
│   └── Services
│       ├── APIService.cs
│       └── DataService.cs # class for fetching and manipulating data 
├── ServicesLayer # project for services such as data validation and other business logic 
│   ├── ServicesLayer.csproj 
│   ├── ... 
│   └── Services 
│       ├── DataValidationService.cs 
│       └── ... 
├── FamilyTreeApp # Main .NET MAUI Blazor Hybrid project 
│   ├── FamilyTreeApp.csproj 
│   ├── MauiProgram.cs # Defines the application's startup logic 
|    |__ Startup.cs # Configures services and middleware for the application  
|    |__ Program.cs # Entry point for the application  
|    |__ wwwroot # for static assets such as CSS stylesheets, JavaScript libraries, and image files  
|    |__ Pages # for Razor pages such as Index.razor (main view for the family tree)  
|    |__ Shared # for shared layouts and partial views  
|    |__ Models # for data models  
|    |__ Controllers # for API controllers such as FamilyTreeApiController (controller for RESTful API endpoints)  
|    |__ Components  
|        |__ FamilyTreeComponent.razor # Blazor component for the main family tree view  
|        |__ NodeComponent.razor # Blazor component for individual node elements  
|        |__ EdgeComponent.razor # Blazor component for edge lines between nodes  
|        |__ NavigationMenu.razor # component for navigation menu  
|        |__ SearchBar.razor # component for search bar  
|        |__ FilterPanel.razor # component for filter panel  
|        |__ PersonForm.razor # component for adding or editing person objects  
|        |__ TreeActions.razor # component for actions on the family tree such as saving or exporting  
└── PersonModel # Separate project for the person model 
    ├── PersonModel.csproj 
    └── Person.cs 
