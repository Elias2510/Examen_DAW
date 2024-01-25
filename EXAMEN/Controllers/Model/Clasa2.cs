using System.ComponentModel.DataAnnotations;

namespace EXAMEN.Controllers.Model
{
    public class Clasa2
    {
        [Key]
        public int Clasa2Id { get; set; }
        public int ParticipantId { get; set; }
        public string Nume { get; set; }
        public string Tip { get; set; } // "Spectator" sau "Organizator"
        public ICollection<Participare> Evenimente { get; set; }

        // Relație către Clasa3
        public Clasa3 Clasa3Reference { get; set; }
    }
}
