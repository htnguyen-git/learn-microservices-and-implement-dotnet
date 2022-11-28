# Mongo database 
## Mongo database là gì
- Là NoSQL database

## NoSQL Database là gì
- JSON format: key-value
- Bỏ qua tính toàn vẹn dữ liệu ( transaction ), đổi lấy khả năng mở rộng và hiệu sất

## So sánh NoSQL và SQL
- NoSQl dùng Collection thay vì table
- NoSQL dùng document thay vì rows


## Pros & cons
- Linh hoạt trong lưu trữ dữ liệu, có thể lưu bất kỳ loại nào
- Dữ liệu không có ràng buộc: không cần kiểm tra khi insert, update,...
- Tốn bộ nhớ vì lưu dữ liệu dưới dạng key-value => lặp key
- Khi insert/update/remove, ghi vào RAM, sau đó một khoảng thời gian mới lưu xuống bộ nhớ

## Dùng khi nào
- Big data, 
- Yêu cầu truy vấn nhanh
- Hệ thống có request lớn

