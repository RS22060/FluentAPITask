using System.Collections.Generic;

namespace DataAnnotations
{
    public class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float Price { get; set; }

        public virtual Lecturer Lecturer { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}