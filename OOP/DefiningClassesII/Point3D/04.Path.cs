using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        public readonly List<StructPoint3D> list = new List<StructPoint3D>();

        public List<StructPoint3D> CreatePath
        {
            get { return this.list; }
        }
    }
}
