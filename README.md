# red-coding-challenge-backend
Backend for the RED Technologies coding challenge

## PROJECT OVERVIEW:

- Controllers: Currently contains a single controller for the Order API
- DataModels: This is where any data layer models live, currently just Order
- Enums: A location for any application enums
- Interfaces: Stubbed out schemas for a DI implementation of a data reader
- Projections: These are POCO/DTO classes for the API to return data
- Program: This is where the in-memory data is initialized as a dictionary

### DELIVERABLES:
 - [ ] Upgrade the in-memory (hardcoded) data dictionary to any kind of external store. Files, normalized/non-normalized databases, caching etc are acceptable. Preference will be given to normalized database implementations (SQL scripts are an ok deliverable).
    - started creating a dockerized postgres server 
 - [ ] Implement 3 new APIs:
    - [x] A search API that searches on Customer and OrderType
    - [x] A create API that creates a new Order given all the fields an Order object has
    - [ ] A delete API that removes a list of orders by id
  - [ ] Create and implement at least a repository layer using Dependency Injection (DI). Feel free to use .NET Core’s native features or a 3rd party package if preferred.
  - [ ] Implement unit tests using the platform of your choice for the CRUD operations that validate that the data (or service layer) is called with the expected values from the API


MANDATORY FEATURES:
- [ ] Fully functional set of endpoints to match the expected deliverables. Endpoints should return ‘Bad Request’ statuses if given incomplete/faulty data.
- [ ] Any kind of external data store for source data
    -  started creating a dockerized postgres server 
- [x] Basic DI Implementation for a data ingress class
- [ ] Basic unit tests as application guardrails (controller or service layer)

ABOVE AVERAGE FEATURES:
- [ ] A normalized data store for application entities. A SQL script is an acceptable deliverable. Special consideration is given for knowledge/implementation of Entity Framework. Code-first or Database-first is acceptable.
- [ ] Install Swagger on top of the project
- [ ] Demonstrated knowledge of Dependency Injection lifetime management. A transient or scoped service layer to handle business logic or repository passthrough is acceptable.
- [ ] Unit tests at all layers including Controllers and DI classes

EXCEPTIONAL FEATURES:
- [ ] All the above-average deliverables
- [ ] Host your Database and API in a location accessible remotely i.e. publicly
  - Would have dockerized dotnet application and hosted on heruko, [following this example](https://dev.to/alrobilliard/deploying-net-core-to-heroku-1lfe)
  - In a real production setting, it would be preferred, but not necessary, to have both the frontend and the backend use the same infrastructure provider. 
- [ ] Implement authentication (username/password, token, etc) for the API
- [ ] Utilize containerization and/or a deployment pipeline to host the app programmatically
