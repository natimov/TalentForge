namespace cvGenerator.Shared
{
    public class CVModel
    {
        public string Name { get; set; }
        public string Experience { get; set; }
        public string Skills { get; set; }
        public string Client { get; set; }
        public string Activity { get; set; }
        public string Location { get; set; }
        public DateTime? StartDate { get; set; } // Ajouter la date de début de mission
        public DateTime? EndDate { get; set; }   // Ajouter la date de fin de mission

        // Ajoute d'autres propriétés ici selon tes besoins
    }
}
