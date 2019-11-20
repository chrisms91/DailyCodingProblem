﻿### Lowest Common Ancestor

Find the lowest common ancestor of two items in a binary tree

#### Assumptions:
- Each value in the tree is unique (there are no two nodes with the same value)
- Each node has at most two children, left and right
- You do not have a level attribute in each of your node
- Each node has pointers to left and right children, but there is no back link

#### Examples:
```
head =  5
       / \
      1   4
     / \ / \
    3  8 9  2
	 / \
	6   7
```
- LCA of 8 and 7 is 1
- LCA of 4 and 2 is 4