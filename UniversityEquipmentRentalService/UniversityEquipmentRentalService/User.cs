namespace UniversityEquipmentRentalService;

public class User
{
    public string firstName;

    public string lastName;

    public string userID;

    public enum userType
    {
        student,
        employee
    }
    
    protected virtual string generateUserID()
    {
        return userID + "-" + firstName + "-" + lastName;
    }

    public User(string firstName, string lastName, string userType)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}