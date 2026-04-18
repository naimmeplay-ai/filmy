using System.ComponentModel;

namespace Filmz.bd
{
    public class Film
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Название фильма")]
        public string? Name { get; set; }
        [DisplayName("Автор фильма")]
        public string? Author {  get; set; }
        [DisplayName("Тип фильма")]
        public string? Type { get; set; }
        [DisplayName("Дата выпуска")]
        public DateTime DateRel { get; set; }
    }
}
