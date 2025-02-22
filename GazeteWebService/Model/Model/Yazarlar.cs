using BaseLib.Model;

namespace Model.Model
{
    public class Yazarlar:BaseEntity<int>
    {
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
    }
}
