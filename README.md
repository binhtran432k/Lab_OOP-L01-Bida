# Lab_OOP-L01-Bida
Github lưu trữ chung của nhóm, Lập trình hướng đối tượng

# Thông báo
Phần BTL môn OOP có 3 phần lớn thì tạm thời ta sẽ tập trung hoàn thành phần 2 trước. Và ô @Bình Lê đã làm được hơn 4 phần nhỏ của phần 2 rồi nên phần còn lại sẽ do t với @Đạt và @Đạo Nguyễn hoàn thành nốt. Gồm phần 2.2 và 4 phần cuối của phần 2.

Tạm thời t sẽ bắt đầu làm 2.2. Còn 4 câu cuối của phần 2, @Đạt, @Đạo Nguyễn chọn bớt rồi làm trước đi. Khi nào xong 2.2 t sẽ làm thêm phần còn lại.

Hiện tại là chốt như vậy nha! Ai có thắc mắc gì thì nói lun nha.
À thêm nữa, deadline của bài này là T4 tuần sau á. Với lại tuần sau nhóm mình báo nên mn nhớ đi học học đầy đủ đấy!
# BTL
## Nhóm / Thang điểm
1. __Lược đồ lớp (2đ)__
    1. Không có lược đồ (0đ)
    1. Lược đồ sơ sài, còn nhiều lỗi (1đ)
    1. Lược đồ tương đối đầy đủ nhưng vẫn còn một vài lỗi (1.5đ)
    1. Lược đồ đầy đủ và không còn lỗi (2đ)
2. __Các chức năng cần thực hiện (7đ)__
    1. Chức năng tạo mới, cập nhật và đóng một hợp đồng thuê xe (phải thực hiện nhiều hàm khởi tạo (multiple constructors) cho đối tượng hợp đồng thuê xe) (1đ)
    1. Chức năng BookAndRent (cần có thêm định nghĩa Interface cho chức năng này) (1đ)
    1. Chức năng thêm, xóa, sửa một xe vào đội xe (phải thực hiện nhiều phương pháp thêm 1 xe vào đội xe (multiple methods)) (1đ)
    1. Các chức năng bảo quản bảo dưỡng hiện thực khác nhau cho từng class xe cụ thể khác nhau (serviceEngine, serviceTransmission, serviceTires) (1đ)
    1. Chức năng bảo quản bảo dưỡng cho cảđội xe (serviceFleet) (0.5đ)
    1. Toán tử trừ "-" cho 2 mainternance jobs bất kỳ (0.5đ)
    1. Toán tử so sánh cho 2 mainternance jobs bất kỳ (0.5đ)
    1. Xuất kết quả dữ liệu json về lịch sử bảo quản bảo dưỡng của 1 xe bất kỳ ra màn hình (0.5đ)
    1. Tạo tập tin json lưu trữ tất cả lịch sử bảo quản bảo dưỡng của 1 xe bất kỳ (1đ)
3. __Trình bày mã nguồn (1đ)__
    1. Không tuân thủ coding conventions (0đ)
    1. Có tuân thủ coding conventions nhưng chưa đầy đủ (0.5đ)
    1. Tuân thủ coding conventions một cách đầy đủ (1đ)
4. __Điểm thưởng (+1đ)__
    1. Kết nối database
    1. Chức năng nâng cao
# Hướng dẫn
## 1. Xem class diagram
- Để xem được class diagram, ta có nhiều cách nhưng mình khuyến khích nên dùng trong 2 cách sau:
    - Cách 1: Sử dụng trực tiếp server của plantuml. Vào trang: http://www.plantuml.com/plantuml/uml/SyfFKj2rKt3CoKnELR1Io4ZDoSa70000 và copy nội dung của file .plantuml vào, nhấn submit.
    - Cách 2: Sử dụng extention của vscode: plantuml. Cần jre và graphviz nếu muốn xài offline. Chi tiết ở trang sau: https://marketplace.visualstudio.com/items?itemName=jebbs.plantuml
# Nội dung lab
## 1. Lab 1: How to Think in Terms of Objects: A car rental company
A car rental company offers vehicles for rent. It manages a fleet of vehicles and a set of rental contracts. Demonstrate how you code in an OO programming language of your choosing to implement a management system for this car rental company.

Explain how you respect the following guidelines you learned in the lecture.
- Knowing the difference between the interface and implementation
- Thinking more abstractly
- Giving the user the minimal interface possible
## 2. Lab 2: OO naming convention
Follow Google naming convention to do a paper-based exercise given by the instructor

[C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

[C# at Google Style Guide](https://google.github.io/styleguide/csharp-style.html)

## 3. Lab 3: Overloading in OO: Car rental company revisited
Let's revisit the OO design for a car rental company.
<br>
<br>
Provide multiple constructors for creating a car rent. Define multiple methods that add a vehicle to the fleet of the said car rental company.

## 4. Lab 4: Inheritance and Composition
For the sake of fleet maintenance, the car rental company would like to keep track the routine maintenance performed on its vehicles. More specifically, each vehicle has a service history telling how and when its engine, transmission and tires get serviced. In your source code, define the following methods as virtual for your superclass **Vehicle**. Override them in your subclasses. When implementing them, you should check if the vehicle, depending on its current mileage, really needs to have its engine / transmission / tires serviced. Vehicles of different types get serviced differently at different frequencies.

*serviceEngine* // add a record to the vehicle history telling how the engine of the vehicle gets serviced (oil change, minor, major)

*serviceTransmission* // add a record to the vehicle history telling how the transmission of the vehicle gets serviced (fluid change, minor, overhaul)

*serviceTires* // add a record to the vehicle history telling how the tires of the vehicle get serviced (adjustment, replacement)

Make sure that **Vehicle** is an abstract class that is connected to **ServiceHistory** via a composition.
Your class **CarRentalManagement** has a method, called serviceFleet, that basically iterates through all vehicles it manages. For each vehicle, this operation calls the above methods to perform appropriate services if needed.

## 5. Lab 5: Định nghĩa lại các interface / abstract class của bạn
- BookAndRent là interface được implement bởi CarRentalManagement
- Hỏi ta có nên có một interface thể hiện công việc đưa các xe đi bảo dưỡng không?
- Rent là class mô tả hợp đồng thuê xe. Hỏi có interface nào được implement bởi Rent?

## 6. Lab 6: Operator Overloading
Remember that a vehicle in your car rental management company is associated with a service history, which keeps track of all maintenance jobs that have been done to the vehicle in question. A maintenance job should record the following pieces of information: mileage of the vehicle and date/time when the job was carried out, kind of service being performed (e.g., tires, engine oil, transmission fluid), costs, garage where the job was done.


Overload the subtraction - operator to imply the distance the vehicle had been driven between any two maintenance jobs. Moreover, you may overload the comparison operators to see if a maintenance job takes place before or after another.


Note: don't forget to check if the given two maintenance jobs were done for same vehicle. The above-mentioned operators would go meaningless otherwise.