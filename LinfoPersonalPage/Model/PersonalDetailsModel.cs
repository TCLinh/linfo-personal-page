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
            contact_me = new List<ContactMeModel>();
            skills = new List<SkillsModel>();
            work_experience= new List<WorkExperienceModel>();
        }

        public string? full_name { get; set; }

        public string? alias { get; set; }

        public string? dob { get; set; }

        public string? about_me { get; set; }

        public List<ContactMeModel>? contact_me { get; set; }

        public List<SkillsModel>? skills { get; set; }

        public List<WorkExperienceModel>? work_experience { get; set; }

    }
}
