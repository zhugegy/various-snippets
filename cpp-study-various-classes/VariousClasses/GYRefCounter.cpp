#include "stdafx.h"
#include "GYRefCounter.h"


/*
CGYRefCounter::CGYRefCounter()
{

}*/

CGYRefCounter::CGYRefCounter(void *pBuf)
{
  m_pContentPtr = pBuf;
  m_nCount = 1;
}

CGYRefCounter::~CGYRefCounter()
{
}


void CGYRefCounter::increase_ref_count()
{
  m_nCount++;
}


void CGYRefCounter::decrease_ref_count()
{
  m_nCount--;

  if (m_nCount == 0)
  {
    if (m_pContentPtr != NULL)
    {
      delete m_pContentPtr;
      m_pContentPtr = NULL;
    }

    /*CGYRefCounter对象自杀，CGYRefCounter对象本来就是需要用引用计数的类的对象在自己
    的构造函数new出来的(CGYRefCounter对象作为需要用引用计数的类的（私有）数据成员)。*/
    delete this;
  }
}
