using System;
using System.Collections.Generic;

namespace HomeCollection.Interfaces
{
    public interface IDatabase
    {
        event EventHandler DatabaseChanged;

        List<object> GetEntries();
        void Add(object entry);
        void Delete(object entry);
        void Modify(object entry);

        void LoadDatabase();
        void SaveDatabase();
    }
}
