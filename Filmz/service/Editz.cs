using Filmz.bd;

namespace Filmz.service
{
    internal class Editz
    {
        public static bool EditFilmz(Film filmz)
        {
            try
            {
                switch (true)
                {
                    case true when filmz.Name == string.Empty:
                        MessageBox.Show("Проверьте поле с названием");
                        return false;
                    case true when filmz.Author == string.Empty:
                        MessageBox.Show("Проверьте поле с автором");
                        return false;
                    case true when filmz.Type == string.Empty:
                        MessageBox.Show("Проверьте поле с типом");
                        return false;
                }
                using var db = new Serivce();
                var editFilmz = new Film
                {
                    Id = filmz.Id,
                    Name = filmz.Name,
                    Author = filmz.Author,
                    Type = filmz.Type,
                    DateRel = filmz.DateRel
                };
                db.Update(editFilmz);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Не удалось добавить");
                return false;
            }
        }
    }
}
