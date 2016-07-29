using System;

namespace UnitProject
{
    public class User
    {
        private readonly IJump jump;

        public User(IJump jump)
        {
            this.jump = jump;
        }

        public string GetActionName()
        {
            return jump.Action("actionName") + "Action";
        }
    }

    public interface IJump
    {
        string Action(string name);
    }

    public class Jump : IJump
    {
        public string Action(string name)
        {
            return "Jump";
        }
    }
}
