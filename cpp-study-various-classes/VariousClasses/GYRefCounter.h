#pragma once

//此类用于帮助其他类进行引用计数（类的对象的深拷贝中可以使用的技术）。

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

