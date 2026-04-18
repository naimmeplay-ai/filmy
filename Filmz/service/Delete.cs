using Filmz.bd;

namespace Filmz.service
{
    internal class Delete
    {
        public static bool DeteleFilmz(int filmzId)
        {
            try
            {
                using var db = new Serivce();
                var CheckFilmz = db.Films.Find(filmzId);
                if(CheckFilmz != null)
                {
                    db.Films.Remove(CheckFilmz);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Не удалось удалить запись");
                return false;
            }
        }
    }
}
