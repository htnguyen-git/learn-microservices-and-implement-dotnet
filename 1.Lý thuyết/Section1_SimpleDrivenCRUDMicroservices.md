# Simple data - driven, CRUD microservices

## Single asembly
- API/ APlication --> Domain Model Layer --> Infrastructure
- API/ Aplication layer: 
    - Entry point để vào services, 
    - Exposes enpoints và enforces validation,
    - Không có business logic.
    - API layeer là controller class
- Domain layer: 
    - Chứa business logic, 
    - Là nơi implement business operation
- Infrastructures: Code cơ sở

