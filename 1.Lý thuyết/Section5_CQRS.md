# Command Query Responsibility Segregation (CQRS) 
- Là pattern dựa vào reading và writing/updating processes.
- Phân tách trách nhiệm query và command
- Command - Command Handler => thay đổi state của system => không return bất kì thứ gì
- Query - Query handler => trả về dữ liệu, không thay đổi state của system
- 2 Database của read và write có thể khác nhau. Cả 2 database này cần có Event để đồng bộ
## Eventual Consisteny and Event Sourcing
- 