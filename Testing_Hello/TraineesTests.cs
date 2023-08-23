using HelloTest;
namespace Testing_Hello{
[TestFixture]
    public class TraineesTests {
        private Trainees _trainee;
        [SetUp]
        public void SetUp(){
            _trainee = new Trainees();
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("            ")]
        public void AddStudent_CallwithEmptyorNullorWhiteSpaces_ThrowAnError(string input){
            Assert.That(()=> _trainee.AddStudent(input),
            Throws.Exception.TypeOf<ArgumentNullException>().With.Message.Contain("is required"));
        }
        [Test]
        public void AddStudent_WithValidName_AddName(){
            _trainee.AddStudent("Flynn");
            _trainee.AddStudent("Dennis");
            Assert.That(_trainee.student_count, Is.EqualTo(2));
        }

            [Test]
        public void AddStudent_WithValidNameBut_AlreadyExists_AddName(){
            _trainee.AddStudent("Flynn");
            _trainee.AddStudent("Dennis");
            Assert.That(_trainee.student_count, Is.EqualTo(2));

            // Assert.That(()=> _trainee.AddStudent("Flynn"), Throws.Exception.TypeOf<InvalidOperationException>());
        }

            [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("            ")]
        public void RemoveStudent_CallwithEmptyorNullorWhiteSpaces_ThrowAnError(string input){
            Assert.That(()=> _trainee.RemoveStudent(input),
            Throws.Exception.TypeOf<ArgumentNullException>().With.Message.Contain("is required"));
        }

           [Test]
        public void RemoveStudent_WithValidName_RemoveName(){
            _trainee.AddStudent("Flynn");
            _trainee.AddStudent("Dennis");
            _trainee.RemoveStudent("Flynn");
            Assert.That(_trainee.student_count, Is.EqualTo(1));
        }


            [Test]
        public void RemoveStudent_WithUnexistingName_AddName_ThrowAnError(){
            _trainee.AddStudent("Flynn");
            _trainee.AddStudent("Dennis");
            // Assert.That(_trainee.student_count, Is.EqualTo(2));

            Assert.That(()=> _trainee.RemoveStudent("Mel"), Throws.Exception.TypeOf<InvalidOperationException>().With.Message.Contain("does not exist"));
        }

             [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("            ")]
        public void SearchTrainee_WhenCalledEmptyorNull(string input){
            Assert.That(()=> _trainee.SearchStudent(input),
            Throws.Exception.TypeOf<ArgumentNullException>().With.Message.Contain("is required"));
        }
        [Test]
        [TestCase("Flynn", "Flynn")]
        [TestCase("Mel", "")]
         public void SearchTrainee_WhenCalledNameExist_ReturnName(string input, string output){

            _trainee.AddStudent("Flynn");
            _trainee.AddStudent("Dennis");

            var results = _trainee.SearchStudent(input);
            Assert.That(results, Is.EqualTo(output));
         }
}
}

