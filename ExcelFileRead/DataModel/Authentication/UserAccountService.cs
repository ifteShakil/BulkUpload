namespace BulkUpload.DataModel.Authentication
{
    public class UserAccountService
    {
        private readonly ApplicationDbContext _context;

        public UserAccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        public UserAccount GetByUserName(string loginName, string password)
        {
            var result = (from a in _context.tbl_User
                          join b in _context.tbl_UserPassword on a.UserID equals b.UserID
                          join c in _context.tbl_UserRole on a.RoleID equals c.RoleID
                          where a.LoginName == loginName && b.Password == password
                          select new UserAccount
                          {
                              UserId = a.UserID,
                              LoginName = a.LoginName,
                              Password = b.Password,
                              RoleName = c.RoleName,
                              OCode = a.OCode,
                              FullName = a.UserFullName,
                              EmployeeId = a.EID,
                              Email = a.Use_Email

                          }).FirstOrDefault();


            return result;
        }
    }
}
