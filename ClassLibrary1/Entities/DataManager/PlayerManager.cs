using DataLayer.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Entities.DataManager
{
<<<<<<< HEAD
    class PlayerManager : IDataRepository<Player>
=======
    public class PlayerManager : IDataRepository<Player>
>>>>>>> 9ede5b53204b9790adbddcb851128e74f0a8cb95
    {
        readonly PoolChampionContext _poolChampionContext;

        public PlayerManager(PoolChampionContext poolChampionContext)
        {
            _poolChampionContext = poolChampionContext;
        }

        public void Add(Player entity)
        {
            _poolChampionContext.Players.Add(entity);
            _poolChampionContext.SaveChanges();
        }

        public void Delete(Player entity)// why is this not passing an id?
        {
            _poolChampionContext.Players.Remove(entity);
            _poolChampionContext.SaveChanges();
            
        }

        public Player Get(long id)
        {
            return _poolChampionContext.Players.FirstOrDefault<Player>(x => x.PlayerId == id);
        }

        public IEnumerable<Player> GetAll()
        {
            return _poolChampionContext.Players.ToList();
        }

        public void Update(Player dbEntity, Player entity)//why are they not passing the id? how is it going to find it then? or is finding the id happening somewhere else?
        {
            dbEntity.Name = entity.Name;
            dbEntity.EmailAdress = entity.EmailAdress;

            _poolChampionContext.SaveChanges();
        }
    }
}
