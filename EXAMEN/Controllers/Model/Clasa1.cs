using System.ComponentModel.DataAnnotations;

namespace EXAMEN.Controllers.Model
{
    public class Clasa1
    {
        [Key]
        public int Clasa1Id { get; set; }
        public int EvenimentId { get; set; }
        public string Nume { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Participare> Participanti { get; set; }

        // Relație către Clasa2
        public Clasa2 Clasa2Reference { get; set; }
    }
}
