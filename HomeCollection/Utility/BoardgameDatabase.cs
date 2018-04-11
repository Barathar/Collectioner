using HomeCollection.Data;
using HomeCollection.Interfaces;
using System;
using System.Collections.Generic;

namespace HomeCollection.Utility
{
    public class BoardgameDatabase : IDatabase
    {
        private readonly string DATABASE_NAME = "boardgames";

        private XmlDatabase database;
        private BoardgameCollection collection;

        public event EventHandler DatabaseChanged;

        public BoardgameDatabase()
        {
            Initialize();
        }

        // IDatabase
        public List<object> GetEntries()
        {
            List<object> result = new List<object>();
            foreach (var current in collection.Boardgames)
                result.Add(current);

            return result;
        }
        public void Add(object entry)
        {
            collection.Boardgames.Add(entry as Boardgame);
            Sort();
            NotifyDatabaseChanged();
        }
        public void Delete(object entry)
        {
            collection.Boardgames.Remove(entry as Boardgame);
            Sort();
            NotifyDatabaseChanged();
        }
        public void Modify(object entry)
        {            
            Delete(entry);
            Add(entry);
            Sort();
            NotifyDatabaseChanged();
        }

        public void LoadDatabase()
        {
            object loadedData = database.Load();
            if (loadedData == null)
                return;

            collection = loadedData as BoardgameCollection;
            NotifyDatabaseChanged();
        }
        public void SaveDatabase()
        {
            database.Save(collection);
        }

        private void Initialize()
        {
            database = new XmlDatabase(DATABASE_NAME, typeof(BoardgameCollection));
            collection = new BoardgameCollection();
        }
        private void Sort()
        {
            collection.Boardgames.Sort((left, right) => left.Title.CompareTo(right.Title));
        }
        private void NotifyDatabaseChanged()
        {
            if (DatabaseChanged != null)
                DatabaseChanged(this, new EventArgs());
        }
    }
}
