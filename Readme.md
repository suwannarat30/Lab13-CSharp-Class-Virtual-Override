# การพ้องรูป (Polymorphism)

การพ้องรูปหรือ polymorphism ในการเขียนโปรแกรมแบบ OOP นั้น จะต้องเกิดขึ้นภายใต้กระบวนการสืบทอดสมบัติ Inheritance  จะไม่สามารถเกิดขึ้นได้เอง

## หลักการทำงาน

การทำ polymorphism จะต้องทำทั้งใน base class และใน derive class 

### Virtual Methods
เมื่อเราประกาศ method ด้วย keyword virtual ในคลาสฐาน (base class) เรากำลังบอกว่า method นั้นสามารถถูก "เขียนทับ" (overridden) ได้ในคลาสอนุพันธ์ (derived class) การใช้ virtual ทำให้เกิด dynamic binding  ซึ่งหมายความว่าการเรียก method จะถูกตัดสินใจในขณะรันไทม์ (runtime) ขึ้นอยู่กับประเภทของวัตถุจริง ๆ ไม่ใช่แค่ประเภทของตัวแปรที่ใช้เรียก

### Override Methods:
ใน detived class เมื่อเราต้องการให้ method มีการทำงานที่แตกต่างจาก base class เราจะใช้ keyword override เพื่อบอกว่าเรากำลังเขียนทับ method virtual จาก base class การใช้ override ช่วยให้คอมไพเลอร์ตรวจสอบได้ว่าเรากำลังเขียนทับ method ที่มีอยู่จริงในคลาสฐานหรือไม่ ป้องกันข้อผิดพลาดที่อาจเกิดขึ้น