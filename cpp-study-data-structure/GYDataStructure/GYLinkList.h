#pragma once

template<typename T>
class CGYLinkList
{
private:
  struct CGYLinkListNode;

public:
  CGYLinkList();
  virtual ~CGYLinkList();

  int get_node_count();
  bool is_empty();
  bool remove_head_node();
  bool remove_tail_node();
  bool __test_print_list();
  bool clear_link_list();

  class iterator;
  iterator insert(const T &tData, const iterator &it);
  iterator insert_to_head(const T &tData);
  iterator insert_to_tail(const T &tData);
  bool get_data_via_iterator(const T &tData, const iterator &it);
  const T & get_data_via_iterator(const iterator &it);
  bool set_data_via_iterator(const T &tData, const iterator &it);
  bool does_node_exist_via_iterator(const iterator &it);
  iterator find_iterator_via_data(const T &tData);
  iterator begin();
  iterator end();
  iterator get_iterator_of_head_node();
  iterator get_iterator_of_tail_node();
  bool remove_via_iterator(const iterator &it);

  /*iterator�����ã��������û�ֱ�ӻ��m_pHeadNode������m_pTailNode)����Ϊһ���û���
  �����ͷβָ�룬���˶�дָ����ָ��Ľڵ�����ݣ����������ɵ��޸�ָ��ָ��Ľڵ�pPre��
  pNext�����Խ���һ����װ(iterator��ʵ����Ψһ��һ�����ݳ�ԱCGYLinkListNode *m_pNode
  )���û�ֻ��ͨ��iterator��Ķ��������߳����Լ���ȥ�ĸ��ڵ㣬�û�ֻ�ܶ�д�ڵ��ڲ�����
  �ݣ��޷��޸Ľڵ��ڲ���pPre��pNext��

  iterator����һ���ô��������ñ��������������������ø��ӿɶ������ӷ��㡣*/
  class iterator
  {
  public:
    explicit iterator(CGYLinkListNode *pNode);
    //iterator();
    //~iterator();
  public:
    friend class CGYLinkList;    //д�������Բ�����Ԫ����������û��Ӱ�죬��Ӱ��
    bool operator==(const iterator &obj);
    bool operator!=(const iterator &obj);    
    iterator & operator++();    //ǰ��++    
    iterator & /*&*/ operator++(int);    //����++    //��̫��д
    iterator & operator--();    //ǰ��--    
    iterator & /*&*/ operator--(int);    //����--    //��̫��д
    T& operator*();

  private:
    CGYLinkListNode *m_pNode;
  };

private:
  struct CGYLinkListNode
  {
    CGYLinkListNode()
    {
      pPre = NULL;
      pNext = NULL;
    }

    CGYLinkListNode *pPre;
    CGYLinkListNode *pNext;
    T tData;
  };

  CGYLinkListNode *m_pHeadNode;
  CGYLinkListNode *m_pTailNode;
  int m_nNodeCount;
};

////////////////////////////////////////////////////////////////////////////////
template<typename T>
CGYLinkList<T>::iterator::iterator(CGYLinkListNode *pNode)
{
  m_pNode = pNode;
}

template<typename T>
bool CGYLinkList<T>::iterator::operator==(const iterator &obj)
{
  return m_pNode == obj.m_pNode ? true : false;
}

template<typename T>
bool CGYLinkList<T>::iterator::operator!=(const iterator &obj)
{
  return m_pNode != obj.m_pNode ? true : false;
}

template<typename T>
typename CGYLinkList<T>::iterator& CGYLinkList<T>::iterator::operator++()
{
  m_pNode = m_pNode->pNext;
  return *this;
}

template<typename T>
typename CGYLinkList<T>::iterator& CGYLinkList<T>::iterator::operator++(int)
{
  m_pNode = m_pNode->pNext;
  return *this;
}

template<typename T>
typename CGYLinkList<T>::iterator& CGYLinkList<T>::iterator::operator--()
{
  m_pNode = m_pNode->pPre;
  return *this;
}

template<typename T>
typename CGYLinkList<T>::iterator& CGYLinkList<T>::iterator::operator--(int)
{
  m_pNode = m_pNode->pPre;
  return *this;
}

template<typename T>
T& CGYLinkList<T>::iterator::operator*()
{
  return m_pNode->tData;
}

////////////////////////////////////////////////////////////////////////////////
template<typename T>
typename CGYLinkList<T>::iterator CGYLinkList<T>::begin()
{
  return iterator(m_pHeadNode);
}

template<typename T>
typename CGYLinkList<T>::iterator CGYLinkList<T>::end()
{
  return iterator(NULL);
}

template<typename T>
typename CGYLinkList<T>::iterator CGYLinkList<T>::get_iterator_of_head_node()
{
  return iterator(m_pHeadNode);
}

template<typename T>
typename CGYLinkList<T>::iterator CGYLinkList<T>::get_iterator_of_tail_node()
{
  return iterator(m_pTailNode);
}

template<typename T>
typename CGYLinkList<T>::iterator CGYLinkList<T>::find_iterator_via_data(
  const T &tData)
{
  CGYLinkListNode *pNext = m_pHeadNode;

  while (pNext != NULL)
  {
    if (pNext->tData == tData)
    {
      return iterator(pNext);
    }

    pNext = pNext->pNext;
  }

  return iterator(NULL);    //�ѿ�ָ��NULL��Ϊ����������iterator��Ĺ��캯��
}

////////////////////////////////////////////////////////////////////////////////

template<typename T>
CGYLinkList<T>::CGYLinkList()
{
  m_pHeadNode = NULL;
  m_pTailNode = NULL;
  m_nNodeCount = 0;
}


template<typename T>
CGYLinkList<T>::~CGYLinkList()
{
  //�ͷ�����Node
  clear_link_list();
}

template<typename T>
int CGYLinkList<T>::get_node_count()
{
  return m_nNodeCount;
}


template<typename T>
bool CGYLinkList<T>::is_empty()
{
  return m_nNodeCount == 0 ? true : false;
}

template<typename T>
bool CGYLinkList<T>::clear_link_list()
{
  CGYLinkListNode *pNext = m_pHeadNode;
  CGYLinkListNode *pTmp = NULL;

  while (pNext != NULL)
  {
    pTmp = pNext;
    pNext = pNext->pNext;

    delete pTmp;
  }

  m_pHeadNode = NULL;
  m_pTailNode = NULL;
  m_nNodeCount = 0;

  return true;
}

template<typename T>
bool CGYLinkList<T>::__test_print_list()
{
  CGYLinkListNode *pNext = m_pHeadNode;

  while (pNext != NULL)
  {
    printf("%d ", pNext->tData);
    pNext = pNext->pNext;
  }
  return false;
}

template<typename T>
bool CGYLinkList<T>::remove_head_node()
{
  if (m_nNodeCount == 0)
  {
    return false;
  }

  if (m_nNodeCount == 1)
  {
    delete m_pHeadNode;
    m_pHeadNode = NULL;
    m_pTailNode = NULL;
    m_nNodeCount = 0;

    return true;
  }

  CGYLinkListNode *pTmp = m_pHeadNode->pNext;
  pTmp->pPre = NULL;
  delete m_pHeadNode;
  m_pHeadNode = pTmp;
  m_nNodeCount--;

  return true;
}

template<typename T>
bool CGYLinkList<T>::does_node_exist_via_iterator(const iterator &it)
{
  CGYLinkListNode *pTmp = it.m_pNode;

  CGYLinkListNode *pNext = m_pHeadNode;

  while (pNext != NULL)
  {
    if (pNext == pTmp)
    {
      return true;
    }

    pNext = pNext->pNext;
  }

  return false;
}

template<typename T>
bool CGYLinkList<T>::remove_tail_node()
{
  if (m_nNodeCount == 0)
  {
    return false;
  }

  if (m_nNodeCount == 1)
  {
    delete m_pTailNode;
    m_pHeadNode = NULL;
    m_pTailNode = NULL;
    m_nNodeCount = 0;

    return true;
  }

  CGYLinkListNode *pTmp = m_pTailNode->pPre;
  pTmp->pNext = NULL;
  delete m_pTailNode;
  m_pTailNode = pTmp;
  m_nNodeCount--;

  return true;
}

template<typename T>
bool CGYLinkList<T>::remove_via_iterator(const iterator &it)
{
  CGYLinkListNode *pTmp = it.m_pNode;
  CGYLinkListNode *pPre = NULL;
  CGYLinkListNode *pNext = NULL;

  if (m_nNodeCount == 0)
  {
    return false;
  }

  if (pTmp == NULL)
  {
    /*����������NULL���Ͳ���ɾ���ˣ��൱��ɾ���ɹ����������ǣ��û��п����޲��
    ��massively������ɾ��������false���ܻ᲻��Ҫ���ж��û���������Ϊ����*/
    return false;
  }

  if (does_node_exist_via_iterator(it) == false)
  {
    return false;
  }

  if (m_nNodeCount == 1)
  {
    delete m_pHeadNode;
    m_pHeadNode = NULL;
    m_pTailNode = NULL;
    m_nNodeCount = 0;

    return true;
  }

  pPre = pTmp->pPre;
  pNext = pTmp->pNext;

  if (pPre == NULL)
  {
    m_pHeadNode = pNext;
    pNext->pPre = NULL;
  }
  else if (pNext == NULL)
  {
    m_pTailNode = pPre;
    pPre->pNext = NULL;
  }
  else
  {
    pPre->pNext = pNext;
    pNext->pPre = pPre;
  }

  delete pTmp;
  m_nNodeCount--;

  return true;
}

//������ڵ��β������
template<typename T>
typename CGYLinkList<T>::iterator CGYLinkList<T>::insert(const T &tData, 
  const iterator &it)
{
  CGYLinkListNode *pNode = it.m_pNode;

  if (pNode == NULL)
  {
    return NULL;
  }

  if (does_node_exist_via_iterator(it) == false)
  {
    return NULL;
  }

  CGYLinkListNode *pNewNode = new CGYLinkListNode;
  pNewNode->tData = tData;

  /*�ж��Ƿ�Ϊ��һ��node��Ŀǰ����20170509�����������ܽ����if�������䣬��Ϊ����Ŀǰ
  ���iterator it�ķ�ʽ���������ܻ��ڿ���������һ��it*/
  if (m_nNodeCount == 0)
  {
    pNewNode->pPre = NULL;
    pNewNode->pNext = NULL;

    m_pHeadNode = pNewNode;
    m_pTailNode = pNewNode;

    m_nNodeCount++;

    return pNewNode;
  }

  pNewNode->pPre = pNode;
  pNode->pNext = pNewNode;

  pNewNode->pNext = pNode->pNext;
  if (pNode->pNext != NULL)
  {
    pNode->pNext->pPre = pNewNode;
  }
  else
  {
    m_pTailNode = pNewNode;
  }

  m_nNodeCount++;

  return pNewNode;  //ֱ�ӵ���iterator��Ĺ��캯��������ΪpNewNode
}

template<typename T>
typename CGYLinkList<T>::iterator CGYLinkList<T>::insert_to_head(const T &tData)
{
  CGYLinkListNode *pNewNode = new CGYLinkListNode;
  pNewNode->tData = tData;

  if (m_nNodeCount == 0)
  {
    pNewNode->pPre = NULL;
    pNewNode->pNext = NULL;

    m_pHeadNode = pNewNode;
    m_pTailNode = pNewNode;

    m_nNodeCount++;

    return iterator(pNewNode);
  }

  pNewNode->pPre = NULL;

  pNewNode->pNext = m_pHeadNode;
  m_pHeadNode->pPre = pNewNode;

  m_pHeadNode = pNewNode;

  m_nNodeCount++;

  return iterator(pNewNode);
}


template<typename T>
typename CGYLinkList<T>::iterator CGYLinkList<T>::insert_to_tail(const T &tData)
{
  CGYLinkListNode *pNewNode = new CGYLinkListNode;
  pNewNode->tData = tData;

  if (m_nNodeCount == 0)
  {
    pNewNode->pPre = NULL;
    pNewNode->pNext = NULL;

    m_pHeadNode = pNewNode;
    m_pTailNode = pNewNode;

    m_nNodeCount++;

    return iterator(pNewNode);
  }

  pNewNode->pPre = m_pTailNode;
  m_pTailNode->pNext = pNewNode;

  pNewNode->pNext = NULL;

  m_pTailNode = pNewNode;

  m_nNodeCount++;

  return iterator(pNewNode);
}

template<typename T>
bool CGYLinkList<T>::set_data_via_iterator(const T &tData, const iterator &it)
{
  CGYLinkListNode *pTmp = it.m_pNode;

  if (pTmp == NULL)
  {
    return false;
  }

  if (does_node_exist_via_iterator(it) == false)
  {
    return false;
  }

  pTmp->tData = tData;

  return true;
}

template<typename T>
bool CGYLinkList<T>::get_data_via_iterator(const T &tData, const iterator &it)
{
  // TODO: insert return statement here
  CGYLinkListNode *pTmp = it.m_pNode;

  if (pTmp == NULL)
  {
    return false;
  }

  //ָ�������nodeλ�õ����
  if (does_node_exist_via_iterator(it) == false)
  {
    return false;
  }

  tData = pTmp->tData;

  return true;
}

//�˺����Ƚ�Σ�գ�����ָ�������nodeλ�õ��������᷵�����������ֵ
template<typename T>
const T & CGYLinkList<T>::get_data_via_iterator(const iterator &it)
{
  // TODO: insert return statement here
  CGYLinkListNode *pTmp = it.m_pNode;

  return pTmp->tData;
}