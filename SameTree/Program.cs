using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameTree
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static Boolean IsSameTree(TreeNode p, TreeNode q)
        {
            if (p==null && q == null)
            {
                return true;
            }
            if (p != null && q != null)
            {
                if (p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
                    return true;
            }
            return false;
        }
    }
}
