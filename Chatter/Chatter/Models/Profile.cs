namespace Chatter.Models
{
    public class Profile
    {
        public virtual Member Member { get; set; }
        public virtual Demographic Demographic { get; set; }
        public virtual Interest Interest { get; set; }
        public virtual Photo Photo { get; set; }

    }
}