namespace DynamicApplication.Models.Helpers
{
    public class FormFields
    {
        public List<string> MandatoryFields { get; } =
        [
            "FirstName", "LastName", "Email"
        ];

        public List<string> OptionalFields { get; } =
        [
            "Phone", "Nationality", "Current Residence", "ID Number", "Date of Birth", "Gender"
        ];
    }
}
