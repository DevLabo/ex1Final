using System;

namespace finalsolution.Domain
{

    public class User : IEntity
    {
        public User(string name, string email)
        {
            Name = name;
            Email = email;
            Status = true;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Status { get; private set; }

        public void ActivateUser()
        {
            this.Status = true;
        }

        public void InactivateUser()
        {
            this.Status = false;
        }
    }
}
