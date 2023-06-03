namespace AspnetwebappDemo.Model
{
    public class EmployeeInfoRepo:IEmployeeRepo
    {
        private EmployeeInfo EInfo;
       public EmployeeInfoRepo()
        {
            EInfo = new EmployeeInfo()
            {
                Id = 1,
                Name = "Tejaswini M"
            };
        }

        public EmployeeInfo GetEmployeeInfo()
        {
            return EInfo;
        }
    }
}
