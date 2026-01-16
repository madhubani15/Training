namespace LPU_Entity
{
    public enum CourseType
    {
        // To make sure that the user can enter only these specific courses
        Mechanical=10,
        Electrical=20,
        Civil=30,
        CSE=40,
        IT=50
    }
    public class Student // Entity class: Student is an entity
    {
        #region properties

        public int StudentID { get; set; }
        // properties never leave footprint
        public string Name { get; set; }

        // public string Course { get; set; }
        // this property requires validation because users can fill inferior data
        // in UI a drop down list will work better
        // Here, we can't use dropdown so we'll use enum (named integer constant)

        public CourseType Course { get; set; } // Enum type property
        public string Address { get; set; }

        #endregion
    }
}
