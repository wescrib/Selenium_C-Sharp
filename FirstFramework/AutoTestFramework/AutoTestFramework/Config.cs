namespace AutoTestFramework
{
    public static class Config
    {
        public static string BaseURL = "http://testing.todvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "William";
                public static string Password = "Test1234";
                public static string RepeatPassword = "Test1234";
                public static string Email = "test@test.com";
            }
            public static class Invalid
            {
                public static class Username
                {
                    public static string FourChar = "will";
                    public static string ThirteenChar = "asdfghjklzxcv";

                }
                public static class Password
                {
                    public static string BasicFiveCharPW = "test";
                    public static string MoreThanTwelveCharPW = "testtesttesttest";

                }
                public static class Email
                {
                    public static string InvalidEmail = "william.com";

                }

            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";

            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";

            public static string PasswordLengthOutOfRange = "Password should not be empty / length be between 5 to 12";
        }
    }
}
