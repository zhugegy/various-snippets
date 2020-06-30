// GYUtility.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "GYString.h"
#include "GYFileOperator.h"
#include "GYDynamicArray.h"
#include <time.h>
#include <stdlib.h>
#include "GYObjFactory.h"
#include "GYSingleInstanceDedicatedClass.h"


CGYSingleInstanceDedicatedClass g_don_not_use_assistance_with_single_instance;

int main()
{
  /*CGYString mystring("hello");
  CGYString string2("wow");
  printf("%s", *mystring);

  printf("\r\n");

  mystring.append(string2);
  printf("%s", *mystring);
  printf("\r\n");*/


  srand((unsigned int)time(0));


  CGYFileOperator OPER("family_name.txt");
  CGYFileOperator OPER2("given_name.txt");



  /*int n = OPER.get_file_size_byte();

  printf("%d\r\n", n);

  char *pTmp = NULL;

  OPER.map_file_to_memory(&pTmp);

  printf("%s", pTmp);* /*/

  CGYDynamicArray<CGYString *> FAMILYNAMEARRY;
  //OPER.split_file_content_into_dynamic_array(FAMILYNAMEARRY, '#');
  char *pTmpFamilyName = NULL;
  OPER.map_file_to_memory(&pTmpFamilyName);

  CGYString::split_string_into_dynamic_array(pTmpFamilyName, FAMILYNAMEARRY, '#');

  CGYDynamicArray<CGYString *> GIVENNAMEARRY;
  char *pTmpGivenName = NULL;
  OPER2.map_file_to_memory(&pTmpGivenName);
  //OPER2.split_file_content_into_dynamic_array(GIVENNAMEARRY, '#');
  CGYString::split_string_into_dynamic_array(pTmpGivenName, GIVENNAMEARRY, '#');


 //int n =  ARRY[0].get_string_length();

  int nSize1 = FAMILYNAMEARRY.get_array_element_count();
  int nSize2 = GIVENNAMEARRY.get_array_element_count();
  int pos1 = 0;
  int pos2 = 0;
  int counter = 0;
  while (true)
  {
    counter++;
    pos1 = rand() % nSize1;
    pos2 = rand() % nSize2;
    printf("%s %s", **FAMILYNAMEARRY[pos1], **GIVENNAMEARRY[pos2]);
    printf("\r\n");

    if (*FAMILYNAMEARRY[pos1] == "Öî¸ð" && *GIVENNAMEARRY[pos2] == "è¡")
    {
      printf("%d", counter);
      counter = 0;
      getchar();
    }
    
  }

  CGYFileOperator writefileoper("abcd.txt");

  writefileoper.write_string_into_file("hello#world#world");

  writefileoper.write_string_into_file("nihao", 2);




  return 0;
}