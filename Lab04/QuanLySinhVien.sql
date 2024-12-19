DROP DATABASE QuanLySinhVien;
CREATE DATABASE QuanLySinhVien;

USE QuanLySinhVien;


CREATE TABLE Faculty (
    FacultyID INT PRIMARY KEY,
    FacultyName NVARCHAR(200) NOT NULL
);

CREATE TABLE Student (
    StudentID VARCHAR(11) PRIMARY KEY,
    FullName NVARCHAR(200) NOT NULL,
    AverageScore FLOAT CHECK (AverageScore >= 0 AND AverageScore <= 10),
    FacultyID INT NOT NULL,
    CONSTRAINT FK_Student_Faculty FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);


INSERT INTO Faculty (FacultyID, FacultyName) 
VALUES
	(1, N'Công Nghệ Thông Tin'),
	(2, N'Ngôn Ngữ Anh'),
	(3, N'Quản trị kinh doanh');


INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID) 
VALUES
	('1611061916', N'Nguyễn Trần Hoàng Lan', 4.5, 1),
	('1711060596', N'Đàm Minh Đức', 2.5, 1),
	('1711061004', N'Nguyễn Quốc An', 10, 2);


SELECT * FROM Faculty;
SELECT * FROM Student;
