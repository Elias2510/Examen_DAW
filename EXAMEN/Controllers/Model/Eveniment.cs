namespace EXAMEN.Controllers.Model
{
    public class Eveniment
    {
        public int EvenimentId { get; set; }
        public string Nume { get; set; }
        public DateTime Data { get; set; }

        // Proprietate pentru relația many-to-many cu Participare
        public ICollection<Participare> Participari { get; set; }
    }
}

