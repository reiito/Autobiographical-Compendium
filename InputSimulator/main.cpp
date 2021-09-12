#include "stdafx.h"

#include "VirtualKeyCode.h"
#include "KeyboardSimulator.h"

int main(void)
{
    float delayTime = 500;

    CKeyboardSimulator sim;

    Sleep(delayTime * 2);
    sim.ModifiedKeyStroke(VirtualKeyCode::LMENU, VirtualKeyCode::VK_F);

    Sleep(delayTime);
    sim.KeyPress(VirtualKeyCode::DOWN);

    Sleep(delayTime * 4);
    sim.KeyPress(VirtualKeyCode::RETURN);

    Sleep(delayTime);
    sim.ModifiedKeyStroke(VirtualKeyCode::LMENU, VirtualKeyCode::VK_D);

    Sleep(delayTime);
    sim.ModifiedKeyStroke(VirtualKeyCode::LCONTROL, VirtualKeyCode::VK_V);

    Sleep(delayTime);
    sim.KeyPress(VirtualKeyCode::RETURN);

    for (int i = 0; i < 4; i++)
    {
        Sleep(delayTime);
        sim.KeyPress(VirtualKeyCode::TAB);
    }

    Sleep(delayTime);
    sim.KeyPress(VirtualKeyCode::DOWN);

    Sleep(delayTime);
    sim.KeyPress(VirtualKeyCode::RETURN);
}