using System;
using System.Text.RegularExpressions;

namespace Magasin.Regular_Expression
{
    public class Regular
    {

        public Boolean CommencerParBloc(String ch)
        {
            bool isTrue = false;
            Regex r = new Regex(@"\bBloc^?");
            if (r.IsMatch(ch))
            {
                isTrue = true;
            }
            return isTrue;
        }
    }
}
