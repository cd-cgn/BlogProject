

namespace BlogMS.Major.HbmModel
{
    class Blog
    {
        public virtual int id { get; set; }
        public virtual string title { get; set; }
        public virtual string body { get; set; }
        public virtual string author { get; set; }
    }
}
