namespace UserRegistrationForm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= WELCOME TO USER REGISTRTION FORM ===================");

              UserForm.userForm();
              UserForm.userEmail();
              UserForm.userMobile();
              UserForm.userPassword();
              UserForm.upperCasePassword();
        }
    }
}