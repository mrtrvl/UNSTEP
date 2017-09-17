namespace UNSTEP.API.Models
{
    /* Important to keep in mind that Type and Value can't be just any random values. We will perform validation in the business layer */
    public class ContactModel
    {
        /* email, phone, facebook, instagram or whatever type we end up supporting */
        public string Type { get; set; }

        public string Value { get; set; }
    }
}
