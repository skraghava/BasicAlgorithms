﻿using System.Collections.Generic;
using BasicAlgorithms.Trees.Models;

namespace BasicAlgorithms.Trees.Interfaces
{
    public interface ITree
    {
        BinaryTreeResults<int> Delete(BinaryTree tree, int item);
        BinaryTreeResults<BinaryTree> Deserialize(List<int> data);
        BinaryTreeResults<int> Insert(BinaryTree tree, int item);
        BinaryTreeResults<int> Search(BinaryTree tree, int item);
        BinaryTreeResults<List<int>> Serialize(BinaryTree tree);
    }
}