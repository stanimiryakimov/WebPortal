using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPortalDataMapper.UnweConnection
{
    public class News
    {
        public int Id { get; set; }
        public int Department_Id { get; set; }
        public string Published { get; set; }
        public string Description { get; set; }
    }

}
