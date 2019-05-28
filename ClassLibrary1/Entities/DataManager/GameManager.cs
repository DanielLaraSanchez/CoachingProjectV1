using DataLayer.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataLayer.Entities.DataManager
{
    public class GameManager : IDataRepository<Game>
    {
       readonly PoolChampionContext _poolChampionContext;

        public GameManager(PoolChampionContext poolChampionContext)
        {
            _poolChampionContext = poolChampionContext;
        }


        public void Add(Game entity)
        {
            _poolChampionContext.Games.Add(entity);
            _poolChampionContext.SaveChanges();
        }

        public void Delete(Game entity)
        {
            _poolChampionContext.Games.Remove(entity);
            _poolChampionContext.SaveChanges();
        }

        public Game Get(long id)
        {
            return _poolChampionContext.Games.FirstOrDefault<Game>(x => x.GameId == id);
        }

        public IEnumerable<Game> GetAll()
        {
            return _poolChampionContext.Games.ToList<Game>();//why is the tutorial not adding the type?
        }

        public void Update(Game dbEntity, Game entity)
        {
            dbEntity.Player1 = entity.Player1;
            dbEntity.Player2 = entity.Player2;
            dbEntity.Playery1Won = entity.Playery1Won;
            dbEntity.IsConfirmed = entity.IsConfirmed;

            _poolChampionContext.SaveChanges();
            
        }
    }
}
