using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class JsTreeNode
    {
        public JsTreeNode()
        { }

        public Attributes attr { get; set; }

        public Data data { get; set; }

        public string state { get; set; }

        public List<JsTreeNode> children = new List<JsTreeNode>();

    }

    public class Attributes
    {
        public string id { get; set; }

        public string rel { get; set; }


        public string mdata { get; set; }
    }

    public class Data
    {
        public string title { get; set; }

        public string icon { get; set; }
    }
}
