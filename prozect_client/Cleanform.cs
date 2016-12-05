using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prozect_client
{
    class Cleanform 
    {
        client c = new client();

       

        public void cleanAfterAddMed()
        {
            c.text_id = null;
        }
    }
}
