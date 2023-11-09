using LaunchMod1Week5Assessment;

namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void IsCreated()
        {
            var user = new User("alex", "alex@gmail.com");
            Assert.Equal("alex@gmail.com", user.Email);

        }


        [Fact]
        public void ifSetupCompleteWorks()
        {
            var user = new User("alex", "alex@gmail.com");
            user.CreatePassword("alex@gmail.com", "1234321");

            
            Assert.True(user.IsSetupComplete());
        }
        [Fact]
        public void IfCreatPAsswordCreates() 
        {
            var user = new User("alex", "alex@gmail.com");
            
            user.CreatePassword("alex@gmail.com", "1234321");
            
            Assert.Equal("Password Created", user.Confirmation());
        }

        [Fact] 
        public void IfCOnfirmationWorks()
        {
            var user = new User("alex", "alex@gmail.com");
            Assert.Equal("",user.Confirmation());
        }
        [Fact]  
        public void IfLogin_Logsin()
        {
            var user = new User("alex", "alex@gmail.com");

            user.CreatePassword("alex@gmail.com", "1234321");
            Assert.Equal("Logged In", user.LogIn("1234321"));
        }
        [Fact]
        public void IfLogOut_Logsout()
        {
            var user = new User("alex", "alex@gmail.com");

            user.CreatePassword("alex@gmail.com", "1234321");
            user.LogIn("1234321");
            Assert.True(user.IsLoggedIn);

            user.LogOut();
            Assert.False(user.IsLoggedIn);

        }

    }
}