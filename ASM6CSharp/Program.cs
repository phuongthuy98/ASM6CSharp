using System;

namespace ASM6CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] RateList = {1, 2, 3};
            News program = new News(001, "Anh Sẽ Lại Cưa Em Nhé", "20/11/2018", "Nguyễn Nhậ", "Đọc là biết",RateList);
            program.Calculate();
            program.Display();
        }
    }
}