using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    public class GlavnaFlyoutMenuItem
    {
        public GlavnaFlyoutMenuItem()
        {
            TargetType = typeof(GlavnaFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}