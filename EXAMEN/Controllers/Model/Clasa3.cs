using System.ComponentModel.DataAnnotations;

namespace EXAMEN.Controllers.Model
{
    public class Clasa3
    {
        [Key]
        public int Clasa3Id { get; set; }
        public int ParticipareId { get; set; }
        // alte proprietăți dacă este necesar

        public int EvenimentId { get; set; }
        public Eveniment Eveniment { get; set; }

        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }
}
