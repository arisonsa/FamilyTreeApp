using System.Collections.Generic;

namespace FamilyTreeApp.Models
{
    public class TreeNode
    {
        public Person Person { get; set; }
        public List<TreeNode> Children { get; set; }
    }
}