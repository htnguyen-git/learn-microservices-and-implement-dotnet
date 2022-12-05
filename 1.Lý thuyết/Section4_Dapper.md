# Dapper

## Daper là gì
- Dapper là micro ORM.
- ORM là Object relational mapping, dùng để xây dựng và liên kết bảng trên database với đối tượng trong project

## Ưu điểm của dapper
- Tốc độ, hiệu suất
- ORM
- Support Store producer
- RAW SQL
- Support multiple query


## Cách dapper hoạt động
- Tạo đối tượng IDBConnection với connection string
- Viết query và lưu như đối tượng string thông thường 
- Dùng method connection.Execute() hoặc connection.ExecuteAsync() để thực thi câu query.

## Các method thường dùng trong Dapper
- using var connection = new NpgsqlConnection(connectionString)
- connection.Execute
- connection.ExecuteAsync
- connection.Open
- using var command = new NpgsqlCommand {Connection= connection};
- command.ExecuteNonQuery()


## So sánh dapper với Ef Core
| Tiêu chí  | Dapper        | EF Core  |
|-----------|---------------|----------|
| Hiệu suất | Cao hơn       | Thấp hơn |
| Câu query | Viết tay      | Tự sinh  |
| RAW query | Sử dụng chính | Hỗ trợ   |

