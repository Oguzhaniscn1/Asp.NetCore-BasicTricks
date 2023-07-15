namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course()
                {
                    Id=1,
                    Title="aspnetkursu",
                    Description="güzel urs",
                    Image="deneresim.jpg",
                    Tags = new string[] {"aspnet", "web geliştirme"},
                    isActive=true,
                    isHome=true
                    },
                new Course()
                {
                    Id=2,
                    Title="phpkusu",
                    Description="güzel urs",
                    Image="satis.png",
                    Tags = new string[] {"php", "web geliştirme"},
                    isActive=true,
                    isHome=true
                    },
                new Course()
                {
                    Id=3,
                    Title="djangokrusu",
                    Description="güzel urs",
                    Image="unnamed.jpg",
                    isActive=true,
                    isHome=false
                    },
                new Course()
                {
                    Id=4,
                    Title="jskursu",
                    Description="güzel urs",
                    Image="unnamed.jpg",
                    isActive=true,
                    isHome=true
                }

            };
        }


        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }


        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

    }
}