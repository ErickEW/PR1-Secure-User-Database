using System;

namespace Secure_Database
{
    class data
    {

        public string name;
        public string key;
        public int id;


        public override string ToString()
        {
            return name + " - " + id + " - " + key;
        }

        public string Name()
        {
            return name;
        }
        public string Key()
        {
            return key;
        }

        public int Id()
        {
            return id;
        }


    }
}