namespace Solution__Student__Test_JavaToCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Management Student!");
            Controller controller = new Controller();
            controller.addStudent();
            controller.updateStudent();
            controller.deleteStudent();
            controller.showAllStudent();
            int idInput = int.TryParse(Console.ReadLine(), out idInput) ? idInput : 0;
            Console.WriteLine(controller.getStudentById(idInput));
            string nameInput = Console.ReadLine();
            Console.WriteLine(controller.getStudentByName(nameInput));
        }
    }
}