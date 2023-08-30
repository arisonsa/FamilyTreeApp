using System.Collections.Generic;

namespace FamilyTreeApp.Models
{
    public class FamilyTree
    {
        public TreeNode Root { get; set; }
        public string Status { get; set; } // "Draft" or "Published"
    }
}