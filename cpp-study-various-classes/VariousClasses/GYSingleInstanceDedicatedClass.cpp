#include "stdafx.h"
#include "GYSingleInstanceDedicatedClass.h"
#include "GYObjFactory.h"
#include "GYString.h"

CGYSingleInstanceDedicatedClass::CGYSingleInstanceDedicatedClass()
{
	CREATE_SINGLE(CGYObjFactory<CGYString>)
}


CGYSingleInstanceDedicatedClass::~CGYSingleInstanceDedicatedClass()
{
	RELEASE_SINGLE(CGYObjFactory<CGYString>)
}
