using System;

namespace GenerischeTypen
{
    class Land : IEquatable<Land>
    {
        private string landesname;
        private string hauptstadt;

        public Land(string na, string hs)
        {
            landesname = na;
            hauptstadt = hs;
        }

        public bool Equals(Land x)
        {
            if (landesname == x.landesname &&
                    hauptstadt == x.hauptstadt)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return landesname + "/" + hauptstadt;
        }
    }
}
