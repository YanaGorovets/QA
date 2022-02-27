using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProjectPageObject.PageObjects
{
    class Standard_User
    {
        public  static string UsernameStandard_user { get; set; } = "standard_user";
        public  static string PasswordsStandard_user { get; set; } = "secret_sauce";
    }


    class Locked_out_user
    {
        public static string UserNameLocked_out_user { get; set; } = "locked_out_user";
        public static string PassWordLocked_out_user { get; set; } = "secret_sause";
    }

    class Problem_user
    {
        public static string UserNameProblem_user { get; set; } = "problem_user";
        public static string PassWordProblem_user { get; set; } = "secret_sause";
    }
    class performance_glitch_user
    {
        public static string UserNamePerformance_glitch_user { get; set; } = "performance_glitch_user";
        public static string PassWordPerformance_glitch_user { get; set; } = "secret_sause";
    }

}
