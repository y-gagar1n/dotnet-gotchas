// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
using namespace ThisEqualsNull


int _tmain(int argc, _TCHAR* argv[])
{
	ThisEqualsNull::SelfNullChecker^ obj = nullptr;
    obj->NullTest();
    Console::ReadLine();
    return 0;
}

