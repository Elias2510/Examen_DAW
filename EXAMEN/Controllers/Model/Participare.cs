namespace EXAMEN.Controllers.Model
{
    public class Participare
    {
        
            public int ParticipareId { get; set; }
            public int EvenimentId { get; set; }
            public Eveniment Eveniment { get; set; }

            public int ParticipantId { get; set; }
            public Participant Participant { get; set; }
        
    }
}
