// Fill out your copyright notice in the Description page of Project Settings.

#include "ProcessManager.h"

#include "Paths.h"

#include "ProcessTracker.h"

#include <string>

#include "Windows.h"

void UProcessManager::OpenEXE(FString name, AProcessTracker *tracker)
{
    FString gamePath = "D:/Games/" + name;
    FString emulatorPath = FPaths::ProjectDir() + "External/Emulator/ePSXe.exe";
    FString inputSimPath = FPaths::ProjectDir() + "External/InputSimulator/InputSimulator.exe";

    ToClipboard(gamePath);

    tracker->runningGame = FPlatformProcess::CreateProc(*emulatorPath, nullptr, true, false, false, nullptr, 0, nullptr, nullptr);

    FPlatformProcess::CreateProc(*inputSimPath, nullptr, true, false, false, nullptr, 0, nullptr, nullptr);
}

void UProcessManager::CloseEXE(AProcessTracker *tracker)
{
    //FPlatformProcess::TerminateProc(tracker->runningGame);
}

FString UProcessManager::GetProjectDir()
{
    return FPaths::ProjectDir();
}

void UProcessManager::ToClipboard(FString &s)
{
    std::string path = std::string(TCHAR_TO_UTF8(*s));

    OpenClipboard(0);
    EmptyClipboard();
    HGLOBAL hg = GlobalAlloc(GMEM_MOVEABLE, path.size() + 1);
    if (!hg)
    {
        CloseClipboard();
        return;
    }
    memcpy(GlobalLock(hg), path.c_str(), path.size() + 1);
    GlobalUnlock(hg);
    SetClipboardData(CF_TEXT, hg);
    CloseClipboard();
    GlobalFree(hg);
}
