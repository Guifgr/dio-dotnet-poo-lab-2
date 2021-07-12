using System.Collections.Generic;
using System.Linq;
using dio_dotnet_poo_lab_2.Interfaces;
using dio_dotnet_poo_lab_2.Models;

namespace dio_dotnet_poo_lab_2.Repository
{
    public class Repository:IRepository<Series>
    {
        private readonly List<Series> _seriesList = new List<Series>();
        public List<Series> List()
        {
            return _seriesList;
        }

        public Series FindById(long id)
        {
            return _seriesList.First(c => c.Id == id);
        }

        public void Insert(Series entity)
        {
            _seriesList.Add(entity);
        }

        public void Delete(long id)
        {
            var entityFind = FindById(id);
            entityFind.Delete();
        }

        public void Update(long id, Series entity)
        {
            _seriesList[(int) id] = entity;
        }

        public long NextId()
        {
            return _seriesList.Count;
        }
    }
}