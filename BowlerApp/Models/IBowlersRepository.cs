using System;
using System.Linq;

namespace BowlerApp.Models
{
    public interface IBowlersRepository
    {
        IQueryable<Bowler> Bowlers { get; }

        public Bowler GetBowler(int bowlerid);

        public void SaveBowler(Bowler b);

        public void CreateBowler(Bowler b);

        public void EditBowler(Bowler b);

        public void DeleteBowler(Bowler b);
    }
}
