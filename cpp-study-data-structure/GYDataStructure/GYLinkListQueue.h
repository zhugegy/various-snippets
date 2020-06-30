#pragma once

#include "GYLinkList.h"

template<typename T>
class CGYLinkListQueue
{
public:
  CGYLinkListQueue();
  virtual ~CGYLinkListQueue();
private:
  CGYLinkList<T> m_linklist;
public:
  bool add(const T & tData);
  bool get(T & tData);
  T get();
  const T & peek();
  bool is_empty();
  int __test_print();
};

template<typename T>
CGYLinkListQueue<T>::CGYLinkListQueue()
{
}


template<typename T>
CGYLinkListQueue<T>::~CGYLinkListQueue()
{
}


template<typename T>
bool CGYLinkListQueue<T>::add(const T & tData)
{
  m_linklist.insert_to_head(tData);

  return true;
}


template<typename T>
bool CGYLinkListQueue<T>::get(T & tData)
{
  tData = *(m_linklist.get_iterator_of_tail_node());

  m_linklist.remove_tail_node();

  return true;
}


template<typename T>
T CGYLinkListQueue<T>::get()
{
  T tDataTmp = *(m_linklist.get_iterator_of_tail_node());

  m_linklist.remove_tail_node();

  return tDataTmp;
}


template<typename T>
const T & CGYLinkListQueue<T>::peek()
{
  return *(m_linklist.get_iterator_of_tail_node());
}


template<typename T>
bool CGYLinkListQueue<T>::is_empty()
{
  return m_linklist.is_empty();
}


template<typename T>
int CGYLinkListQueue<T>::__test_print()
{
  m_linklist.__test_print_list();
  return 0;
}
