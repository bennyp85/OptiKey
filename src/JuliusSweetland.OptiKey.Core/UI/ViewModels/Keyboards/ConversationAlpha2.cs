﻿// Copyright (c) 2022 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using System;
using JuliusSweetland.OptiKey.Enums;
using JuliusSweetland.OptiKey.Properties;
using JuliusSweetland.OptiKey.Rime;
using JuliusSweetland.OptiKey.UI.ViewModels.Keyboards.Base;

namespace JuliusSweetland.OptiKey.UI.ViewModels.Keyboards
{
    public class ConversationAlpha2 : BackActionKeyboard, IConversationKeyboard
    {
        public ConversationAlpha2(Action backAction)
            : base(backAction, simulateKeyStrokes: false, multiKeySelectionSupported: true)
        {
            if (Settings.Default.KeyboardAndDictionaryLanguage.ManagedByRime()) {
                var rime = MyRimeApi.rime_get_api();
                if (rime.set_option(MyRimeApi.GetSession(), "ascii_mode", true)) {
                    MyRimeApi.IsAsciiMode = true;
                }
            }
        }
    }
}
