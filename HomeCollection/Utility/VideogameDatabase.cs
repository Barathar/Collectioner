using HomeCollection.Data;
using HomeCollection.Interfaces;
using System;
using System.Collections.Generic;

namespace HomeCollection.Utility
{
    public class VideogameDatabase : IDatabase
    {
        private readonly string DATABASE_NAME = "videogames";

        private XmlDatabase database;
        private VideogameCollection collection;

        public event EventHandler DatabaseChanged;

        public VideogameDatabase()
        {
            Initialize();
        }

        // IDatabase
        public List<object> GetEntries()
        {
            List<object> result = new List<object>();
            foreach (var current in collection.Videogames)
                result.Add(current);

            return result;
        }
        public void Add(object entry)
        {
            collection.Videogames.Add(entry as Videogame);
            NotifyDatabaseChanged();
        }
        public void Delete(object entry)
        {
            collection.Videogames.Remove(entry as Videogame);
            NotifyDatabaseChanged();
        }
        public void Modify(object entry)
        {
            Delete(entry);
            Add(entry);
        }

        public void LoadDatabase()
        {
            object loadedData = database.Load();
            if (loadedData == null)
                return;

            collection = loadedData as VideogameCollection;
            NotifyDatabaseChanged();
        }
        public void SaveDatabase()
        {
            database.Save(collection);
        }

        private void Initialize()
        {
            database = new XmlDatabase(DATABASE_NAME, typeof(VideogameCollection));
            collection = new VideogameCollection();
        }
        private void NotifyDatabaseChanged()
        {
            if (DatabaseChanged != null)
                DatabaseChanged(this, new EventArgs());
        }
    }
}
