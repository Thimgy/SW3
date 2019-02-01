using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using ROLine = System.Collections.Generic.IReadOnlyList<string>;

namespace SW3
{
    public class Content
    {
        private IReadOnlyList<ROLine> content;

        public Content(IList<string> lines)
        {
            var tmp = new List<ROLine>(lines.Count);
            foreach (var l in lines)
            {
                tmp.Add(new List<string>(l.Split(' ')).AsReadOnly());
            }
            this.content = tmp.AsReadOnly();
        }

        public IReadOnlyList<IReadOnlyList<string>> GetContent()
        {
            return this.content;
        }

        public IEnumerable<List<string>> IterLines()
        {
            foreach (var elt in this.content)
            {
                yield return new List<string>(elt);
            }
        }
    }
}
