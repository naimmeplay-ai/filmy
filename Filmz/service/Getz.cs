using Filmz.bd;
namespace Filmz.service
{
    internal class Getz
    {
        public static List<Film> GetFilmz()
        {
            using var db = new Serivce();
            var list = db.Films.ToList();
            return list;
        }
    }
}
