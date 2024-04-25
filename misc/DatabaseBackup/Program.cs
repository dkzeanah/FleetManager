using System;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

class Program
{
    static void Main(string[] args)
    {
        Server dbServer = new Server(new ServerConnection("(localdb)\\MSSQLLocalDB"));
        Backup dbBackup = new Backup()
        {
            Action = BackupActionType.Database,
            Database = "Cars"
        };
        Backup dbBackup2 = new Backup()
        {
            Action = BackupActionType.Database,
            Database = "aspnet-BlazorApp1-32af5dc5-fac4-456d-ae23-1af4965f1bcf"
        };

        dbBackup.Devices.AddDevice(@"C:\Temp\Cars.bak", DeviceType.File);
        dbBackup.Initialize = true;
        dbBackup.PercentComplete += DbBackup_PercentComplete;
        dbBackup.Complete += DbBackup_Complete;
        dbBackup.SqlBackupAsync(dbServer);

        dbBackup2.Devices.AddDevice(@"C:\Temp\BlazorCarApp.bak", DeviceType.File);
        dbBackup2.Initialize = true;
        dbBackup2.PercentComplete += DbBackup_PercentComplete;
        dbBackup2.Complete += DbBackup_Complete;
        dbBackup2.SqlBackupAsync(dbServer);
    }
    

   
    

private static void DbBackup_Complete(object sender, ServerMessageEventArgs e)
    {
        Console.WriteLine("Backup complete.");
        Console.WriteLine(e.Error.Message);
    }

    private static void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
    {
        Console.WriteLine($"{e.Percent}% complete");
    }
}
