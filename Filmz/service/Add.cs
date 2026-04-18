using Filmz.bd;
namespace Filmz.service
{
    internal class Add
    {
        public static bool AddFilm(Film filmz)
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
                var newFilm = new Film
                {
                    Name = filmz.Name,
                    Author = filmz.Author,
                    Type = filmz.Type,
                    DateRel = filmz.DateRel
                };

                db.Add(newFilm);
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
