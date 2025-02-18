using FinanceTracker.DAL;

namespace FinanceTracker.Domain.DTO
{
    public class AccountViewerData
    {
        public int Id;
        public string TypeName;
        public string Name;
        public string Balance;

        public static AccountViewerData Map(Account account)
        {
            return new AccountViewerData
            {
                Id = account.Id,
                TypeName = account.Type?.Name.Trim() ?? string.Empty,
                Name = account.Name.Trim(),
                Balance = account.Balance.ToString(),
            };
        }
    }
}
