using System;
namespace signadmin.DAO
{
    public class ItemFilterCriterio
    {
        public string IdCompany;
        public int Id;
    }

    public class AccessFilterCriterio
    {
        public string Url;
        public string Description;
        public int Id;
    }

    public class AccessDetailFilterCriterio {
        public int Id;
        public int IdAccount;
        public int IdAccess;
    }
}
