namespace EXAMEN.Controllers.Model
{
    public class Participant
    {
        
            public int ParticipantId { get; set; }
            public string Nume { get; set; }
            public string Tip { get; set; } // "Spectator" sau "Organizator"

            // Proprietate pentru relația many-to-many cu Participare
            public ICollection<Participare> Participari { get; set; }
        
    }
}
