using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Student
    {
        private int SID;
        private string Tensv;
        private string Khoa;
        private float DiemTB;
        public Student() //Constructor xac dinh
        {
            SID = 1;
            Tensv = "Trần Văn Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public Student(Student s) //Constructor sao chep
        {
            SID = s.SID;
            Tensv = s.Tensv;
            Khoa = s.Khoa;
            DiemTB = s.DiemTB;
        }
        //Constructor tham so
        public Student(int id, string ten, string khoa, float dtb)
        {
            SID = id;
            Tensv = ten;
            Khoa = khoa;
            DiemTB = dtb;
        }
        //Cac property cho tung thuoc tinh cua lop
        public int StudentID
        {
            get { return SID; } //Lay du lieu
            set { SID = value; } //Gan du lieu
        }
        public string Name
        {
            get { return Tensv; }
            set { Tensv = value; }
        }
        public string Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        //Phuong thuc hien thi du lieu
        public void Show()
        {
            Console.WriteLine("Mã số sinh viên: {0}", this.SID);
            Console.WriteLine("Tên sinh viên: {0}", this.Tensv);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Điểm trung bình: {0}", this.DiemTB);
        }
    }
    class Tester
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Student[] DSSV;
            int n;
            Console.Write("Nhập số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n]; //tạo mảng n phần tử
            Console.WriteLine("\n ===NHẬP DANH SÁCH SINH VIÊN===");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("Nhập mã sinh viên {0}: ", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Họ tên SV: ");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhập khoa: ");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhập điểm TB: ");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }
            //Xuất DS sinh viên
            Console.WriteLine("\n ===XUẤT DANH SÁCH SINH VIÊN===");
            foreach (Student sv in DSSV)
            {
                sv.Show();
                Console.ReadLine();
            }
        }
    }
}