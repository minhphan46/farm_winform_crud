namespace FarmWinform.Dtos
{
    public class AnimalDTO
    {
        public int AnimalId { get; set; }
        public int AnimalTypeId { get; set; }
        public string AnimalTypeName { get; set; }
        public double MilkProduced { get; set; }
        public int OffspringCount { get; set; }
        public int OffspringGenerated { get; set; }
        public double MilkProducedInRound { get; set; }
    }
}
