using System;
using System.Linq;

namespace BowlerApp.Models
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlersDbContext _context { get; set; }

        public EFBowlersRepository(BowlersDbContext x)
        {
            _context = x;
        }

        public IQueryable<Bowler> Bowlers => _context.Bowlers;
        public IQueryable<Team> Teams => _context.Teams;

        public Bowler GetBowler(int bowlerid)
        {
            //ViewBag.Teams = _context.Teams.ToList();

            var bowler = _context.Bowlers.Single(x => x.BowlerID == bowlerid);
            return bowler;
        }

        public void SaveBowler(Bowler b)
        {
            _context.SaveChanges();
        }

        public void CreateBowler(Bowler b)
        {
            _context.Add(b);
            _context.SaveChanges();
        }

        public void EditBowler(Bowler b)
        {
            _context.Update(b);
            _context.SaveChanges();
        }

        public void DeleteBowler(Bowler b)
        {
            _context.Remove(b);
            _context.SaveChanges();
        }
    }
}
