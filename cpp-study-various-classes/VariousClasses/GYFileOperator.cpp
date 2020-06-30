#include "stdafx.h"
#include "GYFileOperator.h"

#include <string.h>
#include "GYSingleInstanceMacro.h"
#include "GYObjFactory.h"

/*
CGYFileOperator::CGYFileOperator()
{
}*/

CGYFileOperator::CGYFileOperator(const char * pszFileName)
  :m_StrFileName(pszFileName)
{
  create_file_in_disk();
}

CGYFileOperator::~CGYFileOperator()
{
}

//如果文件不存在（第一次运行时），建立文件
int CGYFileOperator::create_file_in_disk()
{
  FILE *pTmp = fopen(*m_StrFileName, "a");
  fclose(pTmp);

  return 0;
}

//返回文件的大小（字节数）
charnumber_t CGYFileOperator::get_file_size_byte()
{
  charnumber_t cntFileSizeByte = 0;
  struct stat st;

  stat(*m_StrFileName, &st);

  cntFileSizeByte = st.st_size;

  return cntFileSizeByte;
}

//文件映射到内存
int CGYFileOperator::map_file_to_memory(char ** pszMemDest, 
  charnumber_t nStartPoint, charnumber_t nCharNum, bool isEndWith0)
{
  charnumber_t nCharNumToAlloc = 0;
  FILE *pFile = fopen(*m_StrFileName, "rb+");

  nCharNumToAlloc = 
    nCharNum == -1 ? get_file_size_byte() - nStartPoint : nCharNum;

  if (isEndWith0 == true)
  {
    nCharNumToAlloc++;
  }

  *pszMemDest = new char[nCharNumToAlloc];

  fseek(pFile, nStartPoint, SEEK_SET);

  fread(*pszMemDest, sizeof(char), nCharNumToAlloc, pFile);

  if (isEndWith0 == true)
  {
    (*pszMemDest)[nCharNumToAlloc - 1] = '\0';
  }

  fclose(pFile);

  return 0;
}

//提取文件内容，放入动态数组
// int CGYFileOperator::split_file_content_into_dynamic_array(
//   CGYDynamicArray<CGYString *> &storageArray, char chDelimiter, bool isEndWith0)
// {
//   FILE *pFile = fopen(*m_StrFileName, "r+");
// 
//   char *pMemTmp = NULL;
// 
//   char szBuff[MAX_STRING_SIZE] = { '\0' };
//   int nBuffPosCounter = 0;
// 
//   CGYObjFactory<CGYString> *pStringFactory = GET_SINGLE(CGYObjFactory<CGYString>);
// 
//   CGYString *pTmp = NULL;
//   map_file_to_memory(&pMemTmp);
// 
//   while (*pMemTmp != '\0')
//   {
//     szBuff[nBuffPosCounter] = *pMemTmp;
// 
//     if (*pMemTmp == chDelimiter)
//     {
//       szBuff[nBuffPosCounter] = '\0';
//       nBuffPosCounter = 0;
//       pTmp = pStringFactory->get_an_object();
//       *pTmp = szBuff;
// 
//       storageArray.insert_element(pTmp);
//     }
//     else
//     {
//       nBuffPosCounter++;
//     }
// 
//     pMemTmp++;
//   }
// 
//   fclose(pFile);
// 
//   return 0;
// }


//向定位置写入内容，如果不设定位置，则向尾部插入
bool CGYFileOperator::write_string_into_file(const char * pszContent, 
	charnumber_t nOffset)
{	
  FILE *pFile = fopen(*m_StrFileName, "r+");

  if (nOffset == -1)
  {
    fseek(pFile, 0, SEEK_END);
  }
  else
  {
    fseek(pFile, nOffset, SEEK_SET);
  }

  fwrite(pszContent, sizeof(char), strlen(pszContent) + 1, pFile);

  fflush(pFile);

  fclose(pFile);

  return false;
}
