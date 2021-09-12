// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "ProcessManager.generated.h"

/**
 *
 */
UCLASS()
class AUTOBIOCOMPUNREAL_API UProcessManager : public UBlueprintFunctionLibrary
{
    GENERATED_BODY()

    UFUNCTION(BlueprintCallable, Category = "Execute", meta = (Keywords = "Execute"))
        static void OpenEXE(FString name, AProcessTracker *tracker);

    UFUNCTION(BlueprintCallable, Category = "Execute", meta = (Keywords = "Execute"))
    static void CloseEXE(AProcessTracker *tracker);

    UFUNCTION(BlueprintPure, Category = "Execute", meta = (Keywords = "Execute"))
        static FString GetProjectDir();

    static void ToClipboard(FString &s);
};
