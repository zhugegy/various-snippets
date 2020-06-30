#pragma once

#include "GYDynamicArray.h"
#include "GYSingleInstanceMacro.h"
#include "GYObjFactory.h"

/*ʵ��һ���򵥵�String�࣬���ڼ򵥵���Ŀ��û���ַ������Ȱ�ȫ��飬���������û������
������дʱ������*/
class CGYString
{
public:
#define MAX_STRING_SIZE_FOR_FUNCTION_SPLIT_STRING_INTO_DYNAMIC_ARRAY 2048
public:
  CGYString();
  explicit CGYString(const char * pszStr);
  CGYString(CGYString & obj);
  virtual ~CGYString();

public:
  const char * get_string_content();
  int get_string_length();
  const char * operator*();
  CGYString & operator=(const char * pszStr);
  CGYString & operator=(const CGYString & obj);
  CGYString & append(const char * pszStr);
  CGYString & append(const CGYString & obj);
  CGYString operator+(const char * pszStr);
  CGYString operator+(const CGYString & obj);
  CGYString & operator+=(const char * pszStr);
  CGYString & operator+=(CGYString & obj);
  char& operator[](int nIndex);
  bool operator==(const char * pszStr);
  bool operator==(const CGYString & obj);
  bool operator!=(const char * pszStr);
  bool operator!=(const CGYString & obj);

private:
  bool set_string(const char * pszStr);
  bool release_string();
  bool append_string(const char * pszStr);

private:
  //int m_nStringLength;    //�ַ�������
  char *m_pString;
public:
  static int split_string_into_dynamic_array(const char * pStrToBeSplited, 
    CGYDynamicArray<CGYString *> & objStorageArray, char chDelimiter = ' ', 
    bool isEndWith0 = true);
};