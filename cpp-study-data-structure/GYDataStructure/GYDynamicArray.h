#pragma once

#include <memory.h>

template<typename T>
class CGYDynamicArray
{
public:
#define ARRAY_SIZE 4
#define ARRAY_ENLARGE_FACTOR 2

public:
  CGYDynamicArray();
  virtual ~CGYDynamicArray();

public:
  int get_array_element_count();
  bool delete_element(int nIndex);
  bool insert_element(T tData, int nIndex);
  bool change_element(T tData, int nIndex);
  bool query(int nIndex, T & tData);
  int search(T & tData);
  T & operator[](int nIndex);

private:
  bool init();
  bool release();
  bool enlarge_array();

private:
  T* m_ptData;
  int m_nArrayElementCount;    //数组的元素个数
  int m_nArrayLength;          //数组的长度

public:
  int __test_iterate_elements();
};

template<typename T>
CGYDynamicArray<T>::CGYDynamicArray()
{
  m_ptData = NULL;
  m_nArrayElementCount = 0;
  m_nArrayLength = 0;

  init();
}

template<typename T>
CGYDynamicArray<T>::~CGYDynamicArray()
{
  release();
}


template<typename T>
bool CGYDynamicArray<T>::init()
{
  m_ptData = new T[ARRAY_SIZE];
  if (m_ptData == NULL)
  {
    return false;
  }

  m_nArrayElementCount = 0;
  m_nArrayLength = ARRAY_SIZE;

  return true;
}


template<typename T>
bool CGYDynamicArray<T>::release()
{
  if (m_ptData != NULL)
  {
    delete[] m_ptData;
    m_ptData = NULL;
  }

  return true;
}

template<typename T>
int CGYDynamicArray<T>::get_array_element_count()
{
  return m_nArrayElementCount;
}

template<typename T>
bool CGYDynamicArray<T>::enlarge_array()
{
  int nNewLength = m_nArrayLength * ARRAY_ENLARGE_FACTOR;
  T* pNew = new T[nNewLength];
  if (pNew == NULL)
  {
    return false;
  }

  memcpy(pNew, m_ptData, m_nArrayLength * sizeof(T));

  if (release() != true)
  {
    return false;
  }

  m_ptData = pNew;
  m_nArrayLength = nNewLength;

  return true;
}


template<typename T>
bool CGYDynamicArray<T>::delete_element(int nIndex)
{
  if (m_nArrayElementCount <= 0)
  {
    return false;
  }

  if (nIndex < 0 || nIndex >= m_nArrayLength)
  {
    //越界删除，危险
    return false;
  }

  for (int i = nIndex; i < m_nArrayElementCount; i++)
  {
    m_ptData[i] = m_ptData[i + 1];
  }

  m_nArrayElementCount--;

  return true;
}


template<typename T>
bool CGYDynamicArray<T>::insert_element(T tData, int nIndex)
{
  while (nIndex > m_nArrayLength - 1)
  {
    if (enlarge_array() == false)
    {
      return false;
    }
  }

  if (m_nArrayElementCount >= m_nArrayLength)
  {
    if (enlarge_array() == false)
    {
      return false;
    }
  }

  if (nIndex == -1)
  {
    nIndex = m_nArrayElementCount;
  }

  for (int i = m_nArrayLength - 2; i >= nIndex; i--)
  {
    m_ptData[i + 1] = m_ptData[i];
  }

  m_ptData[nIndex] = tData;
  m_nArrayElementCount++;

  return true;
}


template<typename T>
bool CGYDynamicArray<T>::change_element(T tData, int nIndex)
{
  if (nIndex < 0 || nIndex >= m_nArrayLength)
  {
    //越界修改，危险
    return false;
  }

  m_ptData[nIndex] = tData;

  return true;
}


template<typename T>
bool CGYDynamicArray<T>::query(int nIndex, T & tData)
{
  /*if (nIndex < 0 || nIndex >= m_nArrayLength)
  {
  //越界查找，危险(吗？)
  return false;
  }*/

  tData = m_ptData[nIndex];

  return true;
}


template<typename T>
int CGYDynamicArray<T>::search(T & tData)
{
  for (int i = 0; i < m_nArrayLength; i++)
  {
    if (m_ptData[i] == tData)
    {
      return i;
    }
  }

  return -1;
}


template<typename T>
T & CGYDynamicArray<T>::operator[](int nIndex)
{
  return m_ptData[nIndex];
}

//测试用
template<typename T>
int CGYDynamicArray<T>::__test_iterate_elements()
{
  for (int i = 0; i < m_nArrayElementCount; i++)
  {
    printf("%d", m_ptData[i]);
  }

  printf("\r\n");
  return 0;
}
