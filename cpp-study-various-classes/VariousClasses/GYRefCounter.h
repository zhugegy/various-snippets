#pragma once

//�������ڰ���������������ü�������Ķ��������п���ʹ�õļ�������

class CGYRefCounter
{
public:
  //CGYRefCounter();
  CGYRefCounter(void *pBuf);
  virtual ~CGYRefCounter();
  void increase_ref_count();
  void decrease_ref_count();

private:
  int m_nCount;
  void* m_pContentPtr;
};

