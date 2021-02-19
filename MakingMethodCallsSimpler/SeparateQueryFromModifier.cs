using System;

namespace MakingMethodCallsSimpler
{
    public class SeparateQueryFromModifier
    {
        public void CheckSecurity(string[] people)
        {
            var found = FoundMiscreant(people);
            SomeLaterCode(found);
        }


        public string FoundMiscreant(string[] people)
        {
            for (var i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    return FoundPerson(people);
                }

                if (people[i].Equals("John"))
                {
                    SendAlert();
                    return FoundPerson(people);
                }
            }

            return FoundPerson(people);
        }

        public string FoundPerson(string[] people)
        {
            for (var i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    return "Don";
                }

                if (people[i].Equals("John"))
                {
                    SendAlert();
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