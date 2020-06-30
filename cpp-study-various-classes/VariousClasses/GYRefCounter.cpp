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

    /*CGYRefCounter������ɱ��CGYRefCounter������������Ҫ�����ü�������Ķ������Լ�
    �Ĺ��캯��new������(CGYRefCounter������Ϊ��Ҫ�����ü�������ģ�˽�У����ݳ�Ա)��*/
    delete this;
  }
}
