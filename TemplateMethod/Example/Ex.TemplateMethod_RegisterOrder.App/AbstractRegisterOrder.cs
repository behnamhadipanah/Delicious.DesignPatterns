public abstract class AbstractRegisterOrder
{

    public void Execute()
    {
        RegisterOrder();
        SaveData();
        ChangesStock();
        SendNotificationForUser();
    }


    protected void RegisterOrder()
    {
        Console.WriteLine("Order Registered...");
    }

    protected virtual void SaveData()
    {
        Console.WriteLine("Save Order in SqlServer");

    }

    protected void ChangesStock()
    {
        Console.WriteLine("Changes in the warehouse were successful");
    }


    protected abstract void SendNotificationForUser();
}