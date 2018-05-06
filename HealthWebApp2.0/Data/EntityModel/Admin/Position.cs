namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        
        public int SectionId { get; set; }
        public virtual Section Section { get; set; }



    }
}