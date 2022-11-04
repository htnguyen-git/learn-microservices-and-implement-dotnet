# So sánh Monolithic và microservices
## Monolithic pros, cons
- Là kiến trúc
- Single codebase: Một app tổng thể, chứa nhiều modules
- Dễ develop, debug, deployement ( so với develop/debug/deploy từng phần...)
- App càng lớn, càng phức tạp.
- Khó cho nhiều team cùng làm việc cùng lúc
- Khi có một sự thay đổi, toàn bộ app phải deploy lại
- Không có khả năng áp dụng công nghệ mới.
- Low scaleable.

## Microservice pros, cons
- Là kiến trúc gồm nhiều services nhỏ, có thể làm việc cùng nhau, giao tiếp qua api network, build và deploy độc lập.
- Independent Services : Nếu có lỗi trong microservices - không ảnh hưởng tới các thành phần khác của app
- Better scalability: Dễ thêm feature hơn monolithic
- Technology diversity: mỗi service có thể là một công nghệ khác nhau (python, dotnet,...)
- Agility: nếu có lỗi thì chỉ ảnh hưởng trong một microservice -> Khi có thay đổi/ cần test thì risk thấp, lỗi ít hơn.
- Small, focused team: Người mới có thể thích nghi nhanh do không cần đọc toàn bộ mã.
- Dễ hiểu, dễ quản lý ( so với monolithic).
- Không nên sử dụng cho ứng dụng nhỏ
- Cần deploy cho từng services

## So sánh monolithic và microservices
| Tiêu chí            | Monolithic                          | Microservces                            |
|---------------------|-------------------------------------|-----------------------------------------|
| Code base           | Một codebase chứa nhiều modules     | Mỗi micro sevices có một codebase riêng |
| Modules             | module chia theo chức năng          | Mỗi serivces là một module              |
| Data state          | Mỗi data layer chứa dữ liệu độc lập | Mỗi micro services chứa dữ liệu độc lập |
| Deploy              | Một file execute/ deployable        | Mỗi service cần deploy độc lập          |
| Khi có thay đổi     | Cần deploye toàn bộ app             | Chỉ cần deploy service thay đổi         |
| Giao tiếp           |                                     | Thông qua APIs đã define                |
| Chi tiết triển khai | Public                              | Hidden                                  |
| Technology          | Cần lựa chọn                        | Trung lập (agnotis)/ Không dùng chung   |
|||