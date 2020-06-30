#pragma once

#include "GYString.h"

typedef long charnumber_t;

//�ļ������࣬��ʱûд��飨new��fopen�Ŀ�ָ���飩
class CGYFileOperator
{
public:
  //CGYFileOperator();
  CGYFileOperator(const char * pszFileName);
  virtual ~CGYFileOperator();

public:
  //�����ļ��Ĵ�С���ֽ�����
  charnumber_t get_file_size_byte();
  //�ļ�ӳ�䵽�ڴ�
  int map_file_to_memory(char ** pszMemDest, charnumber_t nStartPoint = 0,
    charnumber_t nCharNum = -1, bool isEndWith0 = true);
  //��λ��д�����ݣ�������趨λ�ã�����β������
  bool write_string_into_file(const char * pszContent, charnumber_t nOffset = -1);

private:
  CGYString m_StrFileName;

  //����ļ������ڣ���һ������ʱ���������ļ�
  int create_file_in_disk();
};

