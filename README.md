# 🎮 Bejeweled – Game Match-3 (C# WinForms)
[Bejeweled Game](https://github.com/nguyenminhthuvcst-eng/Bejeweled)
## Giới thiệu
Đây là project xây dựng game Match-3 (theo phong cách Bejeweled) sử dụng C# và WinForms.
Người chơi thực hiện đổi vị trí các gem liền kề để tạo thành chuỗi 3 hoặc nhiều gem giống nhau, ghi điểm trong thời gian giới hạn.

Project tập trung vào việc triển khai các cơ chế gameplay cơ bản và tìm hiểu cách hoạt động của vòng lặp gameplay trong game giải đố.

## Core Gameplay Loop
- Đổi vị trí 2 gem liền kề
- Tạo match (từ 3 gem giống nhau trở lên)
- Các gem được xóa khỏi lưới
- Gem phía trên rơi xuống
- Sinh gem mới để lấp đầy
- Lặp lại cho đến khi hết thời gian
  
## Chức năng chính
- Lưới game 8x8
- Kiểm tra match theo hàng và cột
- Hệ thống tính điểm
- Giới hạn thời gian chơi
- Cơ chế sụp lưới (collapse) và sinh gem mới (refill)
- Swap không hợp lệ sẽ quay lại vị trí ban đầu
- Tránh trạng thái có match ngay khi bắt đầu game

## Logic hệ thống
Game được xây dựng dựa trên các xử lý chính:

- Kiểm tra swap hợp lệ: chỉ chấp nhận swap tạo ra match
- Kiểm tra match: phát hiện chuỗi gem giống nhau
- Sụp lưới: gem rơi xuống sau khi xóa
- Sinh gem mới: lấp đầy các ô trống
## Lỗi đã ghi nhận
- Một số trường hợp gem bị lệch vị trí hiển thị
- Hiển thị chưa đồng nhất khi gem rơi nhanh

## Kết quả đạt được

Thông qua project này:

- Hiểu được cấu trúc vòng lặp gameplay (core loop)
- Thực hành xây dựng các cơ chế game cơ bản
- Rèn luyện tư duy logic và xử lý các trường hợp đặc biệt
- Làm quen với việc kiểm soát luồng hoạt động của game
