#pragma once

#include "GYLinkList.h"

template<typename T>
class CGYLinkListStack
{
public:
  CGYLinkListStack();
  virtual ~CGYLinkListStack();

private:
  CGYLinkList<T> m_linklist;
public:
  bool push(const T & tData);
  const T & peek();
  bool is_empty();
  bool pop(T & tData);
  T pop();
  int __test_print();
};

template<typename T>
CGYLinkListStack<T>::CGYLinkListStack()
{
}


template<typename T>
CGYLinkListStack<T>::~CGYLinkListStack()
{
}


template<typename T>
bool CGYLinkListStack<T>::push(const T & tData)
{
  m_linklist.insert_to_tail(tData);
  return true;
}


template<typename T>
const T & CGYLinkListStack<T>::peek()
{
  return m_linklist.get_data_via_iterator(
    m_linklist.get_iterator_of_tail_node());
}


template<typename T>
bool CGYLinkListStack<T>::is_empty()
{
  return m_linklist.is_empty();
}


template<typename T>
bool CGYLinkListStack<T>::pop(T & tData)
{
  tData = m_linklist.get_data_via_iterator(
    m_linklist.get_iterator_of_tail_node());

  m_linklist.remove_tail_node();

  return true;
}


template<typename T>
T CGYLinkListStack<T>::pop()
{
  T tDataTmp = m_linklist.get_data_via_iterator(
    m_linklist.get_iterator_of_tail_node());

  m_linklist.remove_tail_node();

  return tDataTmp;
}


template<typename T>
int CGYLinkListStack<T>::__test_print()
{
  m_linklist.__test_print_list();
  return 0;
}
