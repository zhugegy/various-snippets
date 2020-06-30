// GYDataStructure.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "GYDynamicArrayStack.h"
#include "GYDynamicArrayQueue.h"
#include "GYLinkList.h"
#include "GYLinkListStack.h"
#include "GYLinkListQueue.h"
#include "GYAVLTree.h"

int main()
{
  /*CGYLinkListQueue<int> stack;
 

  int m = 7;

  stack.add(m);
  stack.__test_print();

  stack.add(1);
  stack.__test_print();
  stack.add(2);
  stack.__test_print();
  
  stack.add(3);
  stack.__test_print();

  stack.get();
  stack.__test_print();

  stack.add(9);
  stack.__test_print();

  stack.get();
  stack.__test_print();

  stack.get();
  stack.__test_print();

  stack.get();
  stack.__test_print();

  stack.get();
  stack.__test_print();*/

  CGYAVLTree<double> tree;

  tree.insert_node(89.1);
  tree.insert_node(53.1);
  tree.insert_node(83.1);
  tree.insert_node(87.1);
  tree.insert_node(97.1);
  tree.insert_node(34.1);
  tree.insert_node(37.1);
  tree.insert_node(41.1);
  tree.insert_node(33.1);
  tree.insert_node(75.1);
  tree.insert_node(71.1);
  tree.insert_node(48.1);
  tree.insert_node(88.1);
  tree.insert_node(91.1);
  tree.insert_node(62.1);
  tree.insert_node(5.1);
  tree.insert_node(8.1);
  tree.insert_node(58.1);
  tree.insert_node(96.1);
  tree.insert_node(18.1);

  //层序遍历
  printf("层序遍历: ");
  tree.layer_traversal();
  printf("\r\n");

  //前根遍历
  printf("前根遍历: ");
  tree.DLR_traversal(tree.get_root_node());
  printf("\r\n");

  //中根遍历
  printf("中根遍历: ");
  tree.LDR_traversal(tree.get_root_node());
  printf("\r\n");

  //后根遍历
  printf("后根遍历: ");
  tree.LRD_traversal(tree.get_root_node());
  printf("\r\n");

  return 0;
}

