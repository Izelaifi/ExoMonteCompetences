using System.Collections;


namespace EnumExo2
{
    public class ConnexionResult
    {
        public enum ConnexionResultOprion
        {
            ConnexionOK,
            WrongLogin,
            Wrongpassword
        }
        public ConnexionResultOprion UserCanConnect(string login, string pass)
        {
            if (UserExsist(login))
            {
                if (LoginAndPasswordMatch(login, pass))
                {
                    return ConnexionResultOprion.ConnexionOK;
                }
                else
                    return ConnexionResultOprion.Wrongpassword;
            }
            return ConnexionResultOprion.WrongLogin;
        }
        public static bool LoginAndPasswordMatch(string login, string pass)
        {
            string existPass;

            ArrayList passtest = new ArrayList();
            passtest.Add("toto");
            passtest.Add("papa");
            passtest.Add("Mama");

            for (int i = 0; i < passtest.Count; i++)
            {
                existPass = passtest[i].ToString();
                if (pass == existPass)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool UserExsist(string login)
        {
            string existLog;

            ArrayList logintest = new ArrayList();
            logintest.Add("toto");
            logintest.Add("papa");
            logintest.Add("Mama");

            for (int i = 0; i < logintest.Count; i++)
            {
                existLog = logintest[i].ToString();
                if (login == existLog)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
