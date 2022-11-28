# Repository design pattern
- Triển khai theo SOLID
## Mô tả
- Không có repository : API -> Business object -> Database
- Có repository : API-> Business object -> repository -> Database

## Mục đích
- Là abstraction layer giữa business layer và database context
- Unit test có thể mocking data để test

## Triển khai trong code cụ thể
- Tạo một interface chứa các method CRUD database context, Controller sẽ sử dụng interface này để lấy dữ liệu
- Tạo một class implement interface
- Trong dependency injection, thiết lập lifecycle cho interface và class implement

