CREATE DATABASE StudentManagement;

USE StudentManagement;

DROP TABLE Class;
DROP TABLE Student;


CREATE TABLE Class (
    ClassID CHAR(3) PRIMARY KEY,
    ClassName NVARCHAR(30) NOT NULL
);

-- Tạo bảng Student
CREATE TABLE Student (
    StudentID CHAR(6) PRIMARY KEY, -- StudentID là khóa chính
    StudentName NVARCHAR(40),     -- StudentName là trường không bắt buộc
    DateOfBirth DATE,
	ClassID CHAR(3),              -- ClassID là khóa ngoại
    FOREIGN KEY (ClassID) REFERENCES Class(ClassID) -- ClassID là khóa ngoại liên kết với bảng Class
);

INSERT INTO Class (ClassID, ClassName)
VALUES
    ('C01', N'Lớp Toán'),
    ('C02', N'Lớp Tiếng Anh');

INSERT INTO Student (StudentID, StudentName, DateOfBirth, ClassID )
VALUES
    ('S001', N'Nguyễn Văn A', '2000-01-15', 'C01'),
    ('S002', N'Nguyễn Văn B', '2000-02-20', 'C01'),
    ('S003', N'Nguyễn Văn C', '2000-03-25', 'C02'),
    ('S004', N'Nguyễn Văn D', '2000-04-10', 'C02');

SELECT * FROM Class;
SELECT * FROM Student;