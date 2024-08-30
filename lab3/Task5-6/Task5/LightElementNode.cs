using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public bool IsBlock { get; set; } 
        public bool IsSelfClosing { get; set; } 
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

       
        public Dictionary<string, string> Style { get; set; }

        public LightElementNode(string tagName, bool isBlock = true, bool isSelfClosing = false)
        {
            TagName = tagName;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            Style = new Dictionary<string, string>(); 
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public void RemoveChild(LightNode child)
        {
            Children.Remove(child);
        }

        public override string OuterHTML
        {
            get
            {
                var sb = new StringBuilder();

                if (IsSelfClosing)
                {
                    sb.Append($"<{TagName}");
                    if (CssClasses.Count > 0)
                    {
                        sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");
                    }
                    sb.Append(" />");
                }
                else
                {
                    sb.Append($"<{TagName}");
                    if (CssClasses.Count > 0)
                    {
                        sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");
                    }
                    sb.Append(">");
                    sb.Append(InnerHTML);
                    sb.Append($"</{TagName}>");
                }

                return sb.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }
    }
}

