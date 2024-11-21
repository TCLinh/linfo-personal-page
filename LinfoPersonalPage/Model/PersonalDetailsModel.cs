namespace LinfoPersonalPage.Model
{
    public class PersonalDetailsModel
    {
        public PersonalDetailsModel()
        {
            full_name= null;
            alias= null;
            dob= null;
            about_me = null;
            skills = new List<SkillsModel>();
            work_experience= new List<WorkExperienceModel>();
            education = new List<EducationModel>();
        }

        public string? full_name { get; set; }

        public string? alias { get; set; }

        public string? dob { get; set; }

        public string? about_me { get; set; }

        public string? email { get; set; }

        public string? linkedin { get; set; }

        public string? github { get; set; }

        public List<SkillsModel>? skills { get; set; }

        public List<WorkExperienceModel>? work_experience { get; set; }

        public List<EducationModel>? education { get; set; }

    }
}
