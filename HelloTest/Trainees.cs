namespace HelloTest {
    public class Trainees {
        private List<string> _studentList = new List<string>();

        public int student_count => _studentList.Count;

        public void AddStudent(string studentName) {
            if (string.IsNullOrWhiteSpace(studentName))
                throw new ArgumentNullException("Name is required");

            if (_studentList.Contains(studentName)) {
                throw new InvalidOperationException("You can't add the name twice");
            }

            _studentList.Add(studentName);
        }

        public void RemoveStudent(string studentName) {
            if (string.IsNullOrWhiteSpace(studentName))
                throw new ArgumentNullException("Name is required");
            var student = _studentList.Find(x => x == studentName);
            if (student != null) {
               _studentList.Remove(studentName);
               return;
            }

            throw new InvalidOperationException("Name does not exist");
        }

        public string SearchStudent(string studentName) {
            if (string.IsNullOrWhiteSpace(studentName))
                throw new ArgumentNullException("Name is required");

            var name = _studentList.Find(x => x == studentName);
            if (name != null) {
                return name;
            }
            
            return string.Empty;
        }
    }
}
