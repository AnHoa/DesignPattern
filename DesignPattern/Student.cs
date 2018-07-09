namespace DesignPattern
{
    public class Student
    {
        private int _tuoi;
        private string _ten;

        public void SetTuoi(int tuoi)
        {
            _tuoi = tuoi;
        }

        public int GetTuoi()
        {
            int tuoi = 90;
            int a = 9;
            return tuoi + a;
        }

        public void SetTen(string ten)
        {
            _ten = ten;
        }

        public string GetTen()
        {
            return _ten;
        }

        public Student(string ten, int tuoi)
        {
            _ten = ten;
            _tuoi = tuoi;
        }
    }
}
