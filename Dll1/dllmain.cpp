// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "pch.h"
#include <cmath>

#define EXPORTING_METHOD extern "C" __declspec(dllexport)

EXPORTING_METHOD
double MySqrt(int x) {
    return std::sqrt(x);
}

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

