using System;

namespace MakingMethodCallsSimpler
{
    public class SeparateQueryFromModifier
    {
        public void CheckSecurity(string[] people)
        {
            SendAlert(people);
            var found = FoundPerson(people);
            SomeLaterCode(found);
        }


        public void SendAlert(string[] people)
        {
            if (!FoundPerson(people).Equals(""))
            {
                SendAlert();
            }
        }

        public string FoundPerson(string[] people)
        {
            for (var i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return "Don";
                }

                if (people[i].Equals("John"))
                {
                    return "John";
                }
            }

            return "";
        }

        private void SomeLaterCode(string found)
        {
            throw new NotImplementedException();
        }

        private void SendAlert()
        {
            throw new NotImplementedException();
        }
    }
}