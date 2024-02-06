using System.ComponentModel;

namespace AppModel.Models
{
    public enum RoleTypesEnum
    {
        [Description("Admin")]
        Admin,
        [Description("User")]
        User
    }
    public class RolesTypes
    {
        public const string Admin = "Admin";
        public const string User = "User";

        public static string getRolesString(params RoleTypesEnum[] roles)
        {
            var rolesString = string.Join(",", roles.Select(r => r.ToString()));
            return rolesString;
        }
    }
}
