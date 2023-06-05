using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAirport.Classes
{
    public class Auth
    {
        Repository conn = new Repository();
         
        public User IsExist(string username, string password)
        {
            User user = new User();
            conn.Open();
            string querry = "SELECT staff.`id`, profession FROM staff WHERE username = '"+username+"' AND PASSWORD = '"+password+"'";
            var dtable = conn.Get(querry);

            if (dtable.Rows.Count > 0)
            {

                user.Exist = true;
                user.id = int.Parse(dtable.Rows[0]["id"].ToString());
                var a = dtable.Rows[0]["profession"].ToString();
                if (a == "admin")
                {
                    user.Roless = Roles.admin;
                    user.Name = dtable.Rows[0]["profession"].ToString();
                }
                else if(a == "staff")
                {
                    user.Roless = Roles.staff;
                    user.Name = dtable.Rows[0]["profession"].ToString();
                }
                else if(a == "operator")
                {
                    user.Roless = Roles.operatorr;
                    user.Name = dtable.Rows[0]["profession"].ToString();
                }
                return user; 
            }
            else
            {
                user.Exist = false;
                return user;
            }
            conn.Close();
        }
    }
}
