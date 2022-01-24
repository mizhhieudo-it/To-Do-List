24/01/2022 
- Mô tả ứng dụng : ứng dụng to do list giúp người dùng liệt kê những công việc phải làm .
- Tác dụng của app : Liệt kê các công việc của bản thân , ứng dụng giúp ghi nhớ , nhắc nhở 
- Chức năng : Thêm , Sửa xóa công việc. Liệt kê ra các công việc con , Đặt giờ thông báo nhắc nhở 
- Mổ tả UI: 
        -----------------------------------------------------------------
        ứng dụng To Do List 
        Ngày XX Tháng YY NĂM YYYY                   (Bell) 
        chào UserName , Hãy liệt kê công việc của bạn ! 
        (+) 5:00 AM - Wakeup :
            (-) Đánh răng 
            (-) Rửa Mặt
            (-) WC 
            (-) Tăm Rửa
        (+) 6:00 AM - Prepare Breakfast
            (-) Căm cơm 
            (-) Rán trứng 
            (-) Kho thịt
        ------------------------------------------------------------
- Phân tích bài toán : Mô hình sử dụng MVC
Thêm - Sửa - Xóa (Task) : Input : Time (value hẹn giờ) , Text ( nội dung công việc) 
    Từ Task Cha - Thêm - Sửa - Xóa Sub-Task
    - Lấy giờ từ lịch hẹn giờ của user - còn khoảng 5 phút thì gửi thông báo 
    - hết giờ => thông báo 
    - bắt đầu task mới => thông báo 
    - nhiều task = > import file excel Input : File (dữ liệu gồm công việc , giờ theo format)
    - xóa theo date mà user lọc theo ngày  Input : DateTime (value ngày muống xóa)


