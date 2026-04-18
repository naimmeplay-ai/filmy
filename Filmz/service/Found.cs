using Filmz.bd;
namespace Filmz.service
{
    internal class Found
    {
        public static List<Film> FoundInfo(string Name = "", string Author = "", string Type = "")
        {
            var films = Getz.GetFilmz();
            if (!string.IsNullOrWhiteSpace(Name))
            {
                films = films.Where(a => a.Name?.Contains(Name, StringComparison.OrdinalIgnoreCase) == true).ToList();
            }
            if (!string.IsNullOrWhiteSpace(Author))
            {
                films = films.Where(b =>b.Author?.Contains(Author, StringComparison.OrdinalIgnoreCase) == true).ToList();
            }
            if (!string.IsNullOrWhiteSpace(Type))
            {
                films = films.Where(c =>c.Type?.Contains(Type, StringComparison.OrdinalIgnoreCase) == true).ToList();
            }
            return films;
        }
    }
}
