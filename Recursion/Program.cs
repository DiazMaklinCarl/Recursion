using System;
using System.Collections.Generic;

class Branch
{
    public List<Branch> branches;

    public Branch()
    {
        branches = new List<Branch>();
    }
}

class Program
{
    static int CalculateDepth(Branch branch)
    {
        if (branch.branches.Count == 0)
        {
            return 1;
        }

        int maxChildDepth = 0;
        foreach (var childBranch in branch.branches)
        {
            int childDepth = CalculateDepth(childBranch);
            if (childDepth > maxChildDepth)
            {
                maxChildDepth = childDepth;
            }
        }

        return 1 + maxChildDepth;
    }

    static void Main()
    {
        // Creating the hierarchical structure
        Branch rootBranch = new Branch();
        Branch branch1 = new Branch();
        Branch branch2 = new Branch();
        Branch branch3 = new Branch();
        Branch branch4 = new Branch();
        Branch branch5 = new Branch();
        rootBranch.branches.Add(branch1);
        rootBranch.branches.Add(branch2);
        branch2.branches.Add(branch3);
        branch3.branches.Add(branch4);
        branch4.branches.Add(branch5);
        // Calculating the depth of the provided structure
        int depth = CalculateDepth(rootBranch);

        // Displaying the result
        Console.WriteLine($"The depth of the provided hierarchical structure is: {depth}");
    }
}
