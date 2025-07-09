

using System.Runtime.InteropServices;
using Banking.Domain;

namespace Banking.Tests.Account;

public class MakingDeposaits
{
    [Theory]
    [InlineData(100)]
    [InlineData(223.89)]
    [InlineData(0)]
    [InlineData(-1002.38)]
    public void MakingADepositIncreasesTheBalance(decimal amountToDeposit) 
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Deposit(amountToDeposit);

        Assert.Equal(amountToDeposit+openingBalance, account.GetBalance());
    }
}
