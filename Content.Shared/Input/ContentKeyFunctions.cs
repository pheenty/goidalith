// SPDX-FileCopyrightText: 2018 Acruid
// SPDX-FileCopyrightText: 2019 Pieter-Jan Briers
// SPDX-FileCopyrightText: 2019 Silver
// SPDX-FileCopyrightText: 2020 Exp
// SPDX-FileCopyrightText: 2020 Hugal31
// SPDX-FileCopyrightText: 2020 Paul Ritter
// SPDX-FileCopyrightText: 2020 Vera Aguilera Puerto
// SPDX-FileCopyrightText: 2020 chairbender
// SPDX-FileCopyrightText: 2020 derek
// SPDX-FileCopyrightText: 2020 moneyl
// SPDX-FileCopyrightText: 2021 Swept
// SPDX-FileCopyrightText: 2021 Visne
// SPDX-FileCopyrightText: 2021 ike709
// SPDX-FileCopyrightText: 2022 DrSmugleaf
// SPDX-FileCopyrightText: 2022 Jezithyr
// SPDX-FileCopyrightText: 2022 Kara
// SPDX-FileCopyrightText: 2022 Michael Phillips
// SPDX-FileCopyrightText: 2022 metalgearsloth
// SPDX-FileCopyrightText: 2022 mirrorcult
// SPDX-FileCopyrightText: 2022 wrexbe
// SPDX-FileCopyrightText: 2023 08A
// SPDX-FileCopyrightText: 2023 Leon Friedrich
// SPDX-FileCopyrightText: 2023 Miro Kavaliou
// SPDX-FileCopyrightText: 2023 Nemanja
// SPDX-FileCopyrightText: 2023 ShadowCommander
// SPDX-FileCopyrightText: 2023 Vasilis The Pikachu
// SPDX-FileCopyrightText: 2024 Morb
// SPDX-FileCopyrightText: 2024 deltanedas
// SPDX-FileCopyrightText: 2024 slarticodefast
// SPDX-FileCopyrightText: 2024 wafehling
// SPDX-FileCopyrightText: 2025 Ark
// SPDX-FileCopyrightText: 2025 ErhardSteinhauer
// SPDX-FileCopyrightText: 2025 Whatstone
// SPDX-FileCopyrightText: 2025 monolith8319
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Input;

namespace Content.Shared.Input
{
    [KeyFunctions]
    public static class ContentKeyFunctions
    {
        public static readonly BoundKeyFunction UseItemInHand = "ActivateItemInHand";
        public static readonly BoundKeyFunction AltUseItemInHand = "AltActivateItemInHand";
        public static readonly BoundKeyFunction ActivateItemInWorld = "ActivateItemInWorld";
        public static readonly BoundKeyFunction AltActivateItemInWorld = "AltActivateItemInWorld";
        public static readonly BoundKeyFunction Drop = "Drop";
        public static readonly BoundKeyFunction ExamineEntity = "ExamineEntity";
        public static readonly BoundKeyFunction FocusChat = "FocusChatInputWindow";
        public static readonly BoundKeyFunction FocusLocalChat = "FocusLocalChatWindow";
        public static readonly BoundKeyFunction FocusEmote = "FocusEmote";
        public static readonly BoundKeyFunction FocusWhisperChat = "FocusWhisperChatWindow";
        public static readonly BoundKeyFunction FocusRadio = "FocusRadioWindow";
        public static readonly BoundKeyFunction FocusLOOC = "FocusLOOCWindow";
        public static readonly BoundKeyFunction FocusOOC = "FocusOOCWindow";
        public static readonly BoundKeyFunction FocusAdminChat = "FocusAdminChatWindow";
        public static readonly BoundKeyFunction FocusDeadChat = "FocusDeadChatWindow";
        public static readonly BoundKeyFunction FocusConsoleChat = "FocusConsoleChatWindow";
        public static readonly BoundKeyFunction CycleChatChannelForward = "CycleChatChannelForward";
        public static readonly BoundKeyFunction CycleChatChannelBackward = "CycleChatChannelBackward";
        public static readonly BoundKeyFunction EscapeContext = "EscapeContext";
        public static readonly BoundKeyFunction OpenCharacterMenu = "OpenCharacterMenu";
        public static readonly BoundKeyFunction OpenEmotesMenu = "OpenEmotesMenu";
        public static readonly BoundKeyFunction OpenCraftingMenu = "OpenCraftingMenu";
        public static readonly BoundKeyFunction OpenGuidebook = "OpenGuidebook";
        public static readonly BoundKeyFunction OpenInventoryMenu = "OpenInventoryMenu";
        public static readonly BoundKeyFunction SmartEquipBackpack = "SmartEquipBackpack";
        public static readonly BoundKeyFunction SmartEquipBelt = "SmartEquipBelt";
        public static readonly BoundKeyFunction SmartEquipWallet = "SmartEquipWallet"; // Frontier
        public static readonly BoundKeyFunction SmartEquipBack = "SmartEquipBack"; // Goobstation - Smart equip to back
        public static readonly BoundKeyFunction OpenBackpack = "OpenBackpack";
        public static readonly BoundKeyFunction OpenBelt = "OpenBelt";
        public static readonly BoundKeyFunction OpenWallet = "OpenWallet"; // Frontier
        public static readonly BoundKeyFunction OpenAHelp = "OpenAHelp";
        public static readonly BoundKeyFunction SwapHands = "SwapHands";
        public static readonly BoundKeyFunction SwapHandsPrevious = "SwapHandsPrevious"; // Frontier
        public static readonly BoundKeyFunction MoveStoredItem = "MoveStoredItem";
        public static readonly BoundKeyFunction RotateStoredItem = "RotateStoredItem";
        public static readonly BoundKeyFunction SaveItemLocation = "SaveItemLocation";
        public static readonly BoundKeyFunction ThrowItemInHand = "ThrowItemInHand";
        public static readonly BoundKeyFunction TryPullObject = "TryPullObject";
        public static readonly BoundKeyFunction MovePulledObject = "MovePulledObject";
        public static readonly BoundKeyFunction ReleasePulledObject = "ReleasePulledObject";
        public static readonly BoundKeyFunction MouseMiddle = "MouseMiddle";
        public static readonly BoundKeyFunction RotateObjectClockwise = "RotateObjectClockwise";
        public static readonly BoundKeyFunction RotateObjectCounterclockwise = "RotateObjectCounterclockwise";
        public static readonly BoundKeyFunction FlipObject = "FlipObject";
        public static readonly BoundKeyFunction ToggleRoundEndSummaryWindow = "ToggleRoundEndSummaryWindow";
        public static readonly BoundKeyFunction OpenEntitySpawnWindow = "OpenEntitySpawnWindow";
        public static readonly BoundKeyFunction OpenSandboxWindow = "OpenSandboxWindow";
        public static readonly BoundKeyFunction OpenTileSpawnWindow = "OpenTileSpawnWindow";
        public static readonly BoundKeyFunction OpenDecalSpawnWindow = "OpenDecalSpawnWindow";
        public static readonly BoundKeyFunction OpenAdminMenu = "OpenAdminMenu";
        public static readonly BoundKeyFunction TakeScreenshot = "TakeScreenshot";
        public static readonly BoundKeyFunction TakeScreenshotNoUI = "TakeScreenshotNoUI";
        public static readonly BoundKeyFunction ToggleFullscreen = "ToggleFullscreen";
        public static readonly BoundKeyFunction Point = "Point";
        public static readonly BoundKeyFunction ZoomOut = "ZoomOut";
        public static readonly BoundKeyFunction ZoomIn = "ZoomIn";
        public static readonly BoundKeyFunction ResetZoom = "ResetZoom";
        public static readonly BoundKeyFunction ToggleStanding = "ToggleStanding"; // WD EDIT

        // Shitmed Change Start
        public static readonly BoundKeyFunction TargetHead = "TargetHead";
        public static readonly BoundKeyFunction TargetTorso = "TargetTorso";
        public static readonly BoundKeyFunction TargetLeftArm = "TargetLeftArm";
        public static readonly BoundKeyFunction TargetLeftHand = "TargetLeftHand";
        public static readonly BoundKeyFunction TargetRightArm = "TargetRightArm";
        public static readonly BoundKeyFunction TargetRightHand = "TargetRightHand";
        public static readonly BoundKeyFunction TargetLeftLeg = "TargetLeftLeg";
        public static readonly BoundKeyFunction TargetLeftFoot = "TargetLeftFoot";
        public static readonly BoundKeyFunction TargetRightLeg = "TargetRightLeg";
        public static readonly BoundKeyFunction TargetRightFoot = "TargetRightFoot";
        // Shitmed Change End

        public static readonly BoundKeyFunction ArcadeUp = "ArcadeUp";
        public static readonly BoundKeyFunction ArcadeDown = "ArcadeDown";
        public static readonly BoundKeyFunction ArcadeLeft = "ArcadeLeft";
        public static readonly BoundKeyFunction ArcadeRight = "ArcadeRight";
        public static readonly BoundKeyFunction Arcade1 = "Arcade1";
        public static readonly BoundKeyFunction Arcade2 = "Arcade2";
        public static readonly BoundKeyFunction Arcade3 = "Arcade3";

        public static readonly BoundKeyFunction OpenActionsMenu = "OpenAbilitiesMenu";
        public static readonly BoundKeyFunction ShuttleStrafeLeft = "ShuttleStrafeLeft";
        public static readonly BoundKeyFunction ShuttleStrafeUp = "ShuttleStrafeUp";
        public static readonly BoundKeyFunction ShuttleStrafeRight = "ShuttleStrafeRight";
        public static readonly BoundKeyFunction ShuttleStrafeDown = "ShuttleStrafeDown";
        public static readonly BoundKeyFunction ShuttleRotateLeft = "ShuttleRotateLeft";
        public static readonly BoundKeyFunction ShuttleRotateRight = "ShuttleRotateRight";
        public static readonly BoundKeyFunction ShuttleBrake = "ShuttleBrake";

        public static readonly BoundKeyFunction Hotbar0 = "Hotbar0";
        public static readonly BoundKeyFunction Hotbar1 = "Hotbar1";
        public static readonly BoundKeyFunction Hotbar2 = "Hotbar2";
        public static readonly BoundKeyFunction Hotbar3 = "Hotbar3";
        public static readonly BoundKeyFunction Hotbar4 = "Hotbar4";
        public static readonly BoundKeyFunction Hotbar5 = "Hotbar5";
        public static readonly BoundKeyFunction Hotbar6 = "Hotbar6";
        public static readonly BoundKeyFunction Hotbar7 = "Hotbar7";
        public static readonly BoundKeyFunction Hotbar8 = "Hotbar8";
        public static readonly BoundKeyFunction Hotbar9 = "Hotbar9";

        public static BoundKeyFunction[] GetHotbarBoundKeys() =>
            new[]
            {
                Hotbar1, Hotbar2, Hotbar3, Hotbar4, Hotbar5, Hotbar6, Hotbar7, Hotbar8, Hotbar9, Hotbar0
            };

        public static readonly BoundKeyFunction Vote0 = "Vote0";
        public static readonly BoundKeyFunction Vote1 = "Vote1";
        public static readonly BoundKeyFunction Vote2 = "Vote2";
        public static readonly BoundKeyFunction Vote3 = "Vote3";
        public static readonly BoundKeyFunction Vote4 = "Vote4";
        public static readonly BoundKeyFunction Vote5 = "Vote5";
        public static readonly BoundKeyFunction Vote6 = "Vote6";
        public static readonly BoundKeyFunction Vote7 = "Vote7";
        public static readonly BoundKeyFunction Vote8 = "Vote8";
        public static readonly BoundKeyFunction Vote9 = "Vote9";
        public static readonly BoundKeyFunction EditorCopyObject = "EditorCopyObject";
        public static readonly BoundKeyFunction EditorFlipObject = "EditorFlipObject";
        public static readonly BoundKeyFunction InspectEntity = "InspectEntity";

        public static readonly BoundKeyFunction MappingUnselect = "MappingUnselect";
        public static readonly BoundKeyFunction SaveMap = "SaveMap";
        public static readonly BoundKeyFunction MappingEnablePick = "MappingEnablePick";
        public static readonly BoundKeyFunction MappingEnableDelete = "MappingEnableDelete";
        public static readonly BoundKeyFunction MappingPick = "MappingPick";
        public static readonly BoundKeyFunction MappingRemoveDecal = "MappingRemoveDecal";
        public static readonly BoundKeyFunction MappingCancelEraseDecal = "MappingCancelEraseDecal";
        public static readonly BoundKeyFunction MappingOpenContextMenu = "MappingOpenContextMenu";
    }
}
