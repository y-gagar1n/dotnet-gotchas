#include "stdafx.h"

using namespace System;

int main(array<System::String ^> ^args)
{
	ThisEqualsNull::SelfNullChecker^ obj = nullptr;	
    Console::WriteLine(obj -> ThisIsNull());
    return 0;
}
