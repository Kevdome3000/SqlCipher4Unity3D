namespace SqlCipher4Unity3D.UniTaskIntegration.Tests
{
    using System;
    using System.IO;
    using SqlCipher4Unity3D;
    using SQLite.Attributes;
    using UnityEngine;

    public class Product
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public uint TotalSales { get; set; }
    }

    public class Order
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public DateTime PlacedTime { get; set; }
    }

    public class OrderHistory 
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime Time { get; set; }
        public string Comment { get; set; }
    }

    public class OrderLine
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        [Indexed("IX_OrderProduct", 1)]
        public int OrderId { get; set; }
        [Indexed("IX_OrderProduct", 2)]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public OrderLineStatus Status { get; set; }
    }

    public enum OrderLineStatus 
    {
        Placed = 1,
        Shipped = 100
    }

    public class TestDb : SQLiteConnection
    {
        public TestDb (bool storeDateTimeAsTicks = true, object key = null, bool wal = true) : base (new SQLiteConnectionString (TestPath.GetTempFileName (), storeDateTimeAsTicks, key: key))
        {
            Trace = true;
            if (wal)
                EnableWriteAheadLogging ();
        }

        public TestDb (SQLiteConnectionString connectionString, bool wal = true) : base (connectionString)
        {
            Trace = true;
            if (wal)
                EnableWriteAheadLogging ();
        }

        public TestDb (string path, bool storeDateTimeAsTicks = true, object key = null, bool wal = true) : base (new SQLiteConnectionString (path, storeDateTimeAsTicks, key: key))
        {
            Trace = true;
            if (wal)
                EnableWriteAheadLogging ();
        }

	
    }

    public class TestPath
    {
        public static string GetTempFileName ()
        {
            return Path.Combine(Application.persistentDataPath,  $"{Guid.NewGuid()}.sqlite");
        }
    }
}