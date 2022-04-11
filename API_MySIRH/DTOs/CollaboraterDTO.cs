namespace API_MySIRH.DTOs
{
    public class CollaboraterDTO : DtoBase
    {
        public int RegistrationNumber { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Agency { get; set; }
        public bool Civility { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SkillsCenter { get; set; }
        public string Post { get; set; }
        public string Level { get; set; }
        public string TypeOfContract { get; set; }
        public DateTime DateOf1stExperience { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime InternshipStartDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Diplomas { get; set; }
    }
}
