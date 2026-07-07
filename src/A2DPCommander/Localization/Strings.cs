namespace BTAudioDriver.Localization;

public static class Strings
{
    private static Language _currentLanguage = Language.Russian;
    private static readonly Dictionary<string, Dictionary<Language, string>> _strings = new();

    public static event EventHandler? LanguageChanged;

    static Strings()
    {
        InitializeStrings();
    }

    public static Language CurrentLanguage
    {
        get => _currentLanguage;
        set
        {
            if (_currentLanguage != value)
            {
                _currentLanguage = value;
                LanguageChanged?.Invoke(null, EventArgs.Empty);
            }
        }
    }

    public static string Get(string key)
    {
        if (_strings.TryGetValue(key, out var translations))
        {
            if (translations.TryGetValue(_currentLanguage, out var value))
                return value;
            if (translations.TryGetValue(Language.English, out var fallback))
                return fallback;
        }
        return key;
    }

    public static string AppName => Get("AppName");
    public static string AppDescription => Get("AppDescription");

    public static string MainWindow_Title => Get("MainWindow.Title");
    public static string MainWindow_Subtitle => Get("MainWindow.Subtitle");
    public static string MainWindow_CurrentMode => Get("MainWindow.CurrentMode");
    public static string MainWindow_Music => Get("MainWindow.Music");
    public static string MainWindow_Calls => Get("MainWindow.Calls");
    public static string MainWindow_MusicDescription => Get("MainWindow.MusicDescription");
    public static string MainWindow_CallsDescription => Get("MainWindow.CallsDescription");
    public static string MainWindow_Settings => Get("MainWindow.Settings");
    public static string MainWindow_Diagnostics => Get("MainWindow.Diagnostics");
    public static string MainWindow_MinimizeToTray => Get("MainWindow.MinimizeToTray");
    public static string MainWindow_Help => Get("MainWindow.Help");

    public static string Device_NotConnected => Get("Device.NotConnected");
    public static string Device_Connected => Get("Device.Connected");

    public static string Mode_Music => Get("Mode.Music");
    public static string Mode_Calls => Get("Mode.Calls");
    public static string Mode_Unknown => Get("Mode.Unknown");
    public static string Mode_MusicFull => Get("Mode.MusicFull");
    public static string Mode_CallsFull => Get("Mode.CallsFull");

    public static string Settings_Title => Get("Settings.Title");
    public static string Settings_General => Get("Settings.General");
    public static string Settings_AudioQuality => Get("Settings.AudioQuality");
    public static string Settings_AppRules => Get("Settings.AppRules");
    public static string Settings_Language => Get("Settings.Language");
    public static string Settings_BluetoothDevice => Get("Settings.BluetoothDevice");
    public static string Settings_Refresh => Get("Settings.Refresh");
    public static string Settings_DefaultMode => Get("Settings.DefaultMode");
    public static string Settings_MusicHighQuality => Get("Settings.MusicHighQuality");
    public static string Settings_CallsWithMic => Get("Settings.CallsWithMic");
    public static string Settings_Behavior => Get("Settings.Behavior");
    public static string Settings_AutoStart => Get("Settings.AutoStart");
    public static string Settings_ShowNotifications => Get("Settings.ShowNotifications");
    public static string Settings_AutoSwitchOnConnect => Get("Settings.AutoSwitchOnConnect");
    public static string Settings_AutoSwitchByApp => Get("Settings.AutoSwitchByApp");
    public static string Settings_ConfigureApps => Get("Settings.ConfigureApps");
    public static string Settings_Save => Get("Settings.Save");
    public static string Settings_Cancel => Get("Settings.Cancel");

    public static string Audio_CurrentStatus => Get("Audio.CurrentStatus");
    public static string Audio_RefreshInfo => Get("Audio.RefreshInfo");
    public static string Audio_PreferredCodec => Get("Audio.PreferredCodec");
    public static string Audio_CodecHint => Get("Audio.CodecHint");
    public static string Audio_Processing => Get("Audio.Processing");
    public static string Audio_DisableEnhancements => Get("Audio.DisableEnhancements");
    public static string Audio_DisableEnhancementsHint => Get("Audio.DisableEnhancementsHint");
    public static string Audio_SetAsDefault => Get("Audio.SetAsDefault");
    public static string Audio_Additional => Get("Audio.Additional");
    public static string Audio_OptimizeMMCSS => Get("Audio.OptimizeMMCSS");
    public static string Audio_OptimizeMMCSSHint => Get("Audio.OptimizeMMCSSHint");
    public static string Audio_MMCSSEnabled => Get("Audio.MMCSSEnabled");
    public static string Audio_MMCSSDisabled => Get("Audio.MMCSSDisabled");
    public static string Audio_ApplySettings => Get("Audio.ApplySettings");

    public static string Rules_Description => Get("Rules.Description");
    public static string Rules_Add => Get("Rules.Add");
    public static string Rules_Remove => Get("Rules.Remove");
    public static string Rules_MoveUp => Get("Rules.MoveUp");
    public static string Rules_MoveDown => Get("Rules.MoveDown");
    public static string Rules_Reset => Get("Rules.Reset");
    public static string Rules_Application => Get("Rules.Application");
    public static string Rules_Process => Get("Rules.Process");
    public static string Rules_Profile => Get("Rules.Profile");
    public static string Rules_Priority => Get("Rules.Priority");

    public static string Tray_Open => Get("Tray.Open");
    public static string Tray_Music => Get("Tray.Music");
    public static string Tray_Calls => Get("Tray.Calls");
    public static string Tray_Settings => Get("Tray.Settings");
    public static string Tray_Diagnostics => Get("Tray.Diagnostics");
    public static string Tray_Exit => Get("Tray.Exit");

    public static string Help_Title => Get("Help.Title");
    public static string Help_About => Get("Help.About");
    public static string Help_Description => Get("Help.Description");
    public static string Help_Author => Get("Help.Author");
    public static string Help_AuthorName => Get("Help.AuthorName");
    public static string Help_Donate => Get("Help.Donate");
    public static string Help_DonateDescription => Get("Help.DonateDescription");
    public static string Help_CopyBTC => Get("Help.CopyBTC");
    public static string Help_Copied => Get("Help.Copied");
    public static string Help_Version => Get("Help.Version");
    public static string Help_License => Get("Help.License");
    public static string Help_Close => Get("Help.Close");

    public static string Tab_Control => Get("Tab.Control");
    public static string Tab_Settings => Get("Tab.Settings");
    public static string Tab_Diagnostics => Get("Tab.Diagnostics");
    public static string Tab_About => Get("Tab.About");

    public static string Mode_MusicDesc => Get("Mode.MusicDesc");
    public static string Mode_CallsDesc => Get("Mode.CallsDesc");

    public static string About_Description => Get("About.Description");
    public static string About_Author => Get("About.Author");
    public static string About_AuthorName => Get("About.AuthorName");
    public static string About_Support => Get("About.Support");
    public static string About_SupportDesc => Get("About.SupportDesc");
    public static string About_Copy => Get("About.Copy");
    public static string About_License => Get("About.License");
    public static string About_VersionFormat => Get("About.VersionFormat");

    public static string Diag_Audio => Get("Diag.Audio");
    public static string Diag_Codec => Get("Diag.Codec");
    public static string Diag_OpenLogs => Get("Diag.OpenLogs");
    public static string Diag_Device => Get("Diag.Device");
    public static string Diag_AudioEndpoints => Get("Diag.AudioEndpoints");
    public static string Diag_A2dpEndpoint => Get("Diag.A2dpEndpoint");
    public static string Diag_HfpEndpoint => Get("Diag.HfpEndpoint");
    public static string Diag_Yes => Get("Diag.Yes");
    public static string Diag_No => Get("Diag.No");
    public static string Diag_NoConnectedDevices => Get("Diag.NoConnectedDevices");
    public static string Diag_PairedDevices => Get("Diag.PairedDevices");
    public static string Diag_PlaybackDevices => Get("Diag.PlaybackDevices");
    public static string Diag_BluetoothEndpoints => Get("Diag.BluetoothEndpoints");
    public static string Diag_EndpointsForDevice => Get("Diag.EndpointsForDevice");
    public static string Diag_CodecLabel => Get("Diag.CodecLabel");
    public static string Diag_Frequency => Get("Diag.Frequency");
    public static string Diag_BitDepth => Get("Diag.BitDepth");
    public static string Diag_Channels => Get("Diag.Channels");
    public static string Diag_Bitrate => Get("Diag.Bitrate");
    public static string Diag_NoActiveA2dp => Get("Diag.NoActiveA2dp");
    public static string Diag_CodecDataUnavailable => Get("Diag.CodecDataUnavailable");
    public static string Diag_Loading => Get("Diag.Loading");

    public static string Settings_Saved => Get("Settings.Saved");
    public static string Settings_SaveError => Get("Settings.SaveError");
    public static string Settings_Error => Get("Settings.Error");
    public static string Settings_AutoSwitchByAppHint => Get("Settings.AutoSwitchByAppHint");
    public static string Diag_LoadError => Get("Diag.LoadError");
    public static string Diag_RealCodec => Get("Diag.RealCodec");
    public static string Diag_EstimatedCodec => Get("Diag.EstimatedCodec");
    public static string Diag_WindowsCodecs => Get("Diag.WindowsCodecs");
    public static string Diag_AvailableCodecs => Get("Diag.AvailableCodecs");
    public static string Diag_Enabled => Get("Diag.Enabled");
    public static string Diag_Disabled => Get("Diag.Disabled");
    public static string Diag_AACEnabled => Get("Diag.AACEnabled");
    public static string Diag_AACDisabled => Get("Diag.AACDisabled");
    public static string Diag_ReconnectRequired => Get("Diag.ReconnectRequired");
    public static string Diag_AACToggleFailed => Get("Diag.AACToggleFailed");
    public static string Diag_DisableAACHint => Get("Diag.DisableAACHint");
    public static string Diag_IntelAdapterDetected => Get("Diag.IntelAdapterDetected");
    public static string Diag_IntelAACWarning => Get("Diag.IntelAACWarning");
    public static string Diag_DisableAAC => Get("Diag.DisableAAC");
    public static string Diag_EnableAAC => Get("Diag.EnableAAC");
    public static string Diag_AACStatus => Get("Diag.AACStatus");
    public static string Diag_BluetoothAdapter => Get("Diag.BluetoothAdapter");
    public static string Diag_ReconnectWarning => Get("Diag.ReconnectWarning");
    public static string Diag_Dismiss => Get("Diag.Dismiss");
    public static string Diag_RebootRequired => Get("Diag.RebootRequired");

    public static string Codec_TableHeader => Get("Codec.TableHeader");
    public static string Codec_ColumnCodec => Get("Codec.ColumnCodec");
    public static string Codec_ColumnBitrate => Get("Codec.ColumnBitrate");
    public static string Codec_ColumnQuality => Get("Codec.ColumnQuality");
    public static string Codec_ColumnNote => Get("Codec.ColumnNote");
    public static string Codec_Quality_Basic => Get("Codec.Quality.Basic");
    public static string Codec_Quality_Good => Get("Codec.Quality.Good");
    public static string Codec_Quality_Excellent => Get("Codec.Quality.Excellent");
    public static string Codec_Quality_High => Get("Codec.Quality.High");
    public static string Codec_Quality_HiRes => Get("Codec.Quality.HiRes");
    public static string Codec_Note_SBC => Get("Codec.Note.SBC");
    public static string Codec_Note_RequiresWin10 => Get("Codec.Note.RequiresWin10");
    public static string Codec_Note_NeedsAdapter => Get("Codec.Note.NeedsAdapter");
    public static string Codec_Note_ChangesAfterReconnect => Get("Codec.Note.ChangesAfterReconnect");
    public static string Codec_TableNote => Get("Codec.TableNote");
    public static string Codec_SupportedCodecs => Get("Codec.SupportedCodecs");

    public static string Codec_Auto => Get("Codec.Auto");
    public static string Codec_SBC => Get("Codec.SBC");
    public static string Codec_AAC => Get("Codec.AAC");
    public static string Codec_AptX => Get("Codec.AptX");
    public static string Codec_AptXHD => Get("Codec.AptXHD");
    public static string Codec_LDAC => Get("Codec.LDAC");
    public static string Codec_Unknown => Get("Codec.Unknown");

    public static string CodecDesc_Auto => Get("CodecDesc.Auto");
    public static string CodecDesc_SBC => Get("CodecDesc.SBC");
    public static string CodecDesc_AAC => Get("CodecDesc.AAC");
    public static string CodecDesc_AptX => Get("CodecDesc.AptX");
    public static string CodecDesc_AptXHD => Get("CodecDesc.AptXHD");
    public static string CodecDesc_LDAC => Get("CodecDesc.LDAC");

    public static string Status_CriticalError => Get("Status.CriticalError");
    public static string Status_InitError => Get("Status.InitError");
    public static string Status_DeviceNotConnected => Get("Status.DeviceNotConnected");
    public static string Status_Error => Get("Status.Error");
    public static string Status_SwitchError => Get("Status.SwitchError");
    public static string Status_Unknown => Get("Status.Unknown");

    public static string Notification_AdminRequired => Get("Notification.AdminRequired");
    public static string Notification_SwitchFailed => Get("Notification.SwitchFailed");
    public static string Notification_LogsFolderNotFound => Get("Notification.LogsFolderNotFound");

    public static string Dialog_Warning => Get("Dialog.Warning");
    public static string Dialog_Confirm => Get("Dialog.Confirm");

    public static string Audio_ClickRefresh => Get("Audio.ClickRefresh");
    public static string Audio_AptxHdAvailable => Get("Audio.AptxHdAvailable");

    public static string Priority_Normal => Get("Priority.Normal");
    public static string Priority_High => Get("Priority.High");
    public static string Priority_Critical => Get("Priority.Critical");

    public static string Diag_A2dpSupported => Get("Diag.A2dpSupported");
    public static string Diag_HfpSupported => Get("Diag.HfpSupported");
    public static string Diag_AvrcpSupported => Get("Diag.AvrcpSupported");
    public static string Diag_EnhancementsEnabled => Get("Diag.EnhancementsEnabled");
    public static string Diag_EnhancementsDisabled => Get("Diag.EnhancementsDisabled");
    public static string Diag_CodecInfoUnavailable => Get("Diag.CodecInfoUnavailable");
    public static string Diag_ServiceNotInit => Get("Diag.ServiceNotInit");
    public static string Diag_AutoStart => Get("Diag.AutoStart");
    public static string Diag_AutoSwitch => Get("Diag.AutoSwitch");
    public static string Diag_Notifications => Get("Diag.Notifications");
    public static string Diag_ErrorGettingData => Get("Diag.ErrorGettingData");
    public static string Diag_NoLogsFound => Get("Diag.NoLogsFound");

    public static string App_Application => Get("App.Application");

    public static string Adapter_Title => Get("Adapter.Title");
    public static string Adapter_Select => Get("Adapter.Select");
    public static string Adapter_Current => Get("Adapter.Current");
    public static string Adapter_SupportedCodecs => Get("Adapter.SupportedCodecs");
    public static string Adapter_Switch => Get("Adapter.Switch");
    public static string Adapter_NoAdapters => Get("Adapter.NoAdapters");
    public static string Adapter_Active => Get("Adapter.Active");
    public static string Adapter_Disabled => Get("Adapter.Disabled");
    public static string Adapter_Warning => Get("Adapter.Warning");
    public static string Adapter_SwitchWarning => Get("Adapter.SwitchWarning");
    public static string Adapter_SwitchSuccess => Get("Adapter.SwitchSuccess");
    public static string Adapter_SwitchFailed => Get("Adapter.SwitchFailed");
    public static string Adapter_Refresh => Get("Adapter.Refresh");

    private static void InitializeStrings()
    {
        Add("AppName", "A2DP Commander", "A2DP Commander", "A2DP Commander");
        Add("AppDescription", "Управление Bluetooth аудио профилями", "Bluetooth Audio Profile Manager", "蓝牙音频配置管理器");

        Add("MainWindow.Title", "A2DP Commander", "A2DP Commander", "A2DP Commander");
        Add("MainWindow.Subtitle", "Управление Bluetooth аудио профилями", "Bluetooth Audio Profile Manager", "蓝牙音频配置管理器");
        Add("MainWindow.CurrentMode", "Текущий режим:", "Current mode:", "当前模式：");
        Add("MainWindow.Music", "Музыка", "Music", "音乐");
        Add("MainWindow.Calls", "Звонки", "Calls", "通话");
        Add("MainWindow.MusicDescription", "A2DP — высокое качество", "A2DP — high quality", "A2DP — 高品质音频");
        Add("MainWindow.CallsDescription", "HFP — с микрофоном", "HFP — with microphone", "HFP — 含麦克风");
        Add("MainWindow.Settings", "Настройки", "Settings", "设置");
        Add("MainWindow.Diagnostics", "Диагностика", "Diagnostics", "诊断");
        Add("MainWindow.MinimizeToTray", "Свернуть в трей", "Minimize to tray", "最小化到托盘");
        Add("MainWindow.Help", "Справка", "Help", "帮助");

        Add("Device.NotConnected", "Устройство не подключено", "Device not connected", "设备未连接");
        Add("Device.Connected", "Подключено", "Connected", "已连接");

        Add("Mode.Music", "Музыка", "Music", "音乐");
        Add("Mode.Calls", "Звонки", "Calls", "通话");
        Add("Mode.Unknown", "Не определён", "Unknown", "未知");
        Add("Mode.MusicFull", "Музыка (A2DP)", "Music (A2DP)", "音乐（A2DP）");
        Add("Mode.CallsFull", "Звонки (HFP)", "Calls (HFP)", "通话（HFP）");

        Add("Settings.Title", "A2DP Commander — Настройки", "A2DP Commander — Settings", "A2DP Commander — 设置");
        Add("Settings.General", "Основные", "General", "常规");
        Add("Settings.AudioQuality", "Качество звука", "Audio Quality", "音质");
        Add("Settings.AppRules", "Правила приложений", "App Rules", "应用规则");
        Add("Settings.Language", "Язык / Language", "Language", "语言 / Language");
        Add("Settings.BluetoothDevice", "Bluetooth устройство", "Bluetooth Device", "蓝牙设备");
        Add("Settings.Refresh", "Обновить", "Refresh", "刷新");
        Add("Settings.DefaultMode", "Режим по умолчанию", "Default Mode", "默认模式");
        Add("Settings.MusicHighQuality", "Музыка (A2DP) — высокое качество звука", "Music (A2DP) — high quality audio", "音乐（A2DP）— 高品质音频");
        Add("Settings.CallsWithMic", "Звонки (HFP) — с микрофоном", "Calls (HFP) — with microphone", "通话（HFP）— 含麦克风");
        Add("Settings.Behavior", "Поведение", "Behavior", "行为");
        Add("Settings.AutoStart", "Запускать при старте Windows", "Start with Windows", "开机自动启动");
        Add("Settings.ShowNotifications", "Показывать уведомления", "Show notifications", "显示通知");
        Add("Settings.AutoSwitchOnConnect", "Автоматически переключать режим при подключении", "Auto-switch mode on connect", "连接时自动切换模式");
        Add("Settings.AutoSwitchByApp", "Автоматически переключать профиль по приложениям", "Auto-switch profile by application", "按应用自动切换模式");
        Add("Settings.ConfigureApps", "Настроить приложения...", "Configure apps...", "配置应用");
        Add("Settings.Save", "Сохранить", "Save", "保存");
        Add("Settings.Cancel", "Отмена", "Cancel", "取消");

        Add("Audio.CurrentStatus", "Текущий статус", "Current Status", "当前状态");
        Add("Audio.RefreshInfo", "Обновить информацию", "Refresh Info", "刷新信息");
        Add("Audio.PreferredCodec", "Предпочитаемый кодек", "Preferred Codec", "首选编码器");
        Add("Audio.CodecHint", "Выберите кодек для Bluetooth аудио (требует переподключения):", "Select codec for Bluetooth audio (requires reconnect):", "选择首选蓝牙音频编码器");
        Add("Audio.Processing", "Обработка звука", "Audio Processing", "音频处理");
        Add("Audio.DisableEnhancements", "Отключить улучшения звука Windows", "Disable Windows audio enhancements", "禁用音频增强");
        Add("Audio.DisableEnhancementsHint", "Рекомендуется отключить для лучшего качества", "Recommended to disable for better quality", "关闭Windows音频增强以获得纯净音质");
        Add("Audio.SetAsDefault", "Направлять весь звук на BT наушники при подключении", "Route all audio to BT headphones when connected", "设为默认设备");
        Add("Audio.Additional", "Дополнительно", "Additional", "高级设置");
        Add("Audio.OptimizeMMCSS", "Оптимизировать MMCSS для аудио (уменьшает запинания)", "Optimize MMCSS for audio (reduces stuttering)", "优化MMCSS");
        Add("Audio.OptimizeMMCSSHint", "Отключает троттлинг сети и повышает приоритет аудио. Требует перезагрузки.", "Disables network throttling and increases audio priority. Requires restart.", "提升音频线程优先级以减少延迟");
        Add("Audio.MMCSSEnabled", "Включена", "Enabled", "MMCSS已启用");
        Add("Audio.MMCSSDisabled", "Выключена", "Disabled", "MMCSS已禁用");
        Add("Audio.ApplySettings", "Применить настройки качества", "Apply quality settings", "应用设置");

        Add("Rules.Description", "Настройте автоматическое переключение профиля при запуске приложений. Правило с наивысшим приоритетом побеждает при конфликте.", "Configure automatic profile switching when applications start. Higher priority rule wins on conflict.", "应用规则");
        Add("Rules.Add", "Добавить", "Add", "添加");
        Add("Rules.Remove", "Удалить", "Remove", "删除");
        Add("Rules.MoveUp", "Вверх", "Up", "上移");
        Add("Rules.MoveDown", "Вниз", "Down", "下移");
        Add("Rules.Reset", "Сбросить", "Reset", "重置");
        Add("Rules.Application", "Приложение", "Application", "应用");
        Add("Rules.Process", "Процесс", "Process", "进程");
        Add("Rules.Profile", "Профиль", "Profile", "模式");
        Add("Rules.Priority", "Приоритет", "Priority", "优先级");

        Add("Tray.Open", "Открыть A2DP Commander", "Open A2DP Commander", "打开");
        Add("Tray.Music", "Музыка (A2DP)", "Music (A2DP)", "音乐模式");
        Add("Tray.Calls", "Звонки (HFP)", "Calls (HFP)", "通话模式");
        Add("Tray.Settings", "Настройки...", "Settings...", "设置");
        Add("Tray.Diagnostics", "Диагностика...", "Diagnostics...", "诊断");
        Add("Tray.Exit", "Выход", "Exit", "退出");

        Add("Help.Title", "О программе — A2DP Commander", "About — A2DP Commander", "帮助");
        Add("Help.About", "О программе", "About", "关于");
        Add("Help.Description", "A2DP Commander — бесплатная утилита для управления Bluetooth аудио профилями (A2DP/HFP) в Windows.\n\nПозволяет быстро переключаться между режимами высокого качества звука и режимом с микрофоном для любых Bluetooth наушников.", "A2DP Commander — a free utility for managing Bluetooth audio profiles (A2DP/HFP) in Windows.\n\nAllows you to quickly switch between high-quality audio mode and microphone mode for any Bluetooth headphones.", "蓝牙音频配置管理工具");
        Add("Help.Author", "Автор:", "Author:", "作者");
        Add("Help.AuthorName", "Андрей Юмашев / Andrey Yumashev", "Andrey Yumashev", "Yumash");
        Add("Help.Donate", "Поддержать проект", "Support the Project", "捐赠");
        Add("Help.DonateDescription", "Если программа оказалась полезной, вы можете поддержать разработку:", "If you find this program useful, you can support development:", "支持开发者");
        Add("Help.CopyBTC", "Копировать BTC адрес", "Copy BTC address", "复制BTC地址");
        Add("Help.Copied", "Скопировано!", "Copied!", "已复制");
        Add("Help.Version", "Версия:", "Version:", "版本");
        Add("Help.License", "Лицензия: MIT License", "License: MIT License", "MIT 许可证");
        Add("Help.Close", "Закрыть", "Close", "关闭");

        Add("Tab.Control", "Управление", "Control", "控制");
        Add("Tab.Settings", "Настройки", "Settings", "设置");
        Add("Tab.Diagnostics", "Диагностика", "Diagnostics", "诊断");
        Add("Tab.About", "О программе", "About", "关于");

        Add("Mode.MusicDesc", "A2DP — высокое качество", "A2DP — high quality", "高品质立体声音频");
        Add("Mode.CallsDesc", "HFP — с микрофоном", "HFP — with microphone", "含麦克风双向通话");

        Add("About.Description", "A2DP Commander — бесплатная утилита для управления Bluetooth аудио профилями (A2DP/HFP) в Windows.\n\nПозволяет быстро переключаться между режимами высокого качества звука и режимом с микрофоном для любых Bluetooth наушников.", "A2DP Commander — a free utility for managing Bluetooth audio profiles (A2DP/HFP) in Windows.\n\nAllows you to quickly switch between high-quality audio mode and microphone mode for any Bluetooth headphones.", "A2DP Commander - 蓝牙音频配置管理工具");
        Add("About.Author", "Автор:", "Author:", "作者");
        Add("About.AuthorName", "Андрей Юмашев", "Andrey Yumashev", "Yumash");
        Add("About.Support", "Поддержать проект", "Support the Project", "支持项目");
        Add("About.SupportDesc", "Если программа оказалась полезной, вы можете поддержать разработку:", "If you find this program useful, you can support development:", "如果这个工具对你有帮助");
        Add("About.Copy", "Копировать", "Copy", "复制");
        Add("About.License", "Лицензия: MIT License", "License: MIT License", "MIT 许可证");
        Add("About.VersionFormat", "Версия {0}", "Version {0}", "版本 {0}");

        Add("Diag.Audio", "Аудио устройства", "Audio Devices", "音频");
        Add("Diag.Codec", "Кодек", "Codec", "编码器");
        Add("Diag.OpenLogs", "Открыть логи", "Open Logs", "打开日志");
        Add("Diag.Device", "Устройство", "Device", "设备");
        Add("Diag.AudioEndpoints", "Audio endpoints", "Audio endpoints", "音频端点");
        Add("Diag.A2dpEndpoint", "A2DP endpoint", "A2DP endpoint", "A2DP端点");
        Add("Diag.HfpEndpoint", "HFP endpoint", "HFP endpoint", "HFP端点");
        Add("Diag.Yes", "Да", "Yes", "是");
        Add("Diag.No", "Нет", "No", "否");
        Add("Diag.NoConnectedDevices", "Нет подключённых устройств", "No connected devices", "无已连接设备");
        Add("Diag.PairedDevices", "Сопряжённых", "Paired", "已配对设备");
        Add("Diag.PlaybackDevices", "Устройств воспроизведения", "Playback devices", "播放设备");
        Add("Diag.BluetoothEndpoints", "Bluetooth endpoints", "Bluetooth endpoints", "蓝牙端点");
        Add("Diag.EndpointsForDevice", "Endpoints для устройства", "Endpoints for device", "设备端点");
        Add("Diag.CodecLabel", "Кодек", "Codec", "编码器");
        Add("Diag.Frequency", "Частота", "Frequency", "采样率");
        Add("Diag.BitDepth", "Глубина", "Bit depth", "位深度");
        Add("Diag.Channels", "Каналы", "Channels", "声道");
        Add("Diag.Bitrate", "Битрейт", "Bitrate", "比特率");
        Add("Diag.NoActiveA2dp", "Нет активного A2DP подключения", "No active A2DP connection", "无活跃A2DP连接");
        Add("Diag.CodecDataUnavailable", "Подключение есть, данные кодека недоступны", "Connected, but codec data unavailable", "编码器数据不可用");
        Add("Diag.Loading", "Загрузка...", "Loading...", "加载中...");

        Add("Settings.Saved", "Настройки сохранены", "Settings saved", "设置已保存");
        Add("Settings.SaveError", "Не удалось сохранить настройки", "Failed to save settings", "保存设置失败");
        Add("Settings.Error", "Ошибка", "Error", "错误");
        Add("Settings.AutoSwitchByAppHint", "Автоматически переключает профиль при запуске определённых приложений (Discord, Zoom → Звонки)", "Automatically switches profile when specific apps start (Discord, Zoom → Calls)", "为每个应用设置进程名和目标模式");
        Add("Diag.LoadError", "Ошибка загрузки", "Loading error", "加载失败");
        Add("Diag.RealCodec", "реальный", "real", "实际编码器");
        Add("Diag.EstimatedCodec", "оценка", "estimated", "预估编码器");
        Add("Diag.WindowsCodecs", "Настройки кодеков Windows", "Windows Codec Settings", "Windows编码器");
        Add("Diag.AvailableCodecs", "Доступные кодеки", "Available codecs", "可用编码器");
        Add("Diag.Enabled", "Включён", "Enabled", "已启用");
        Add("Diag.Disabled", "Отключён", "Disabled", "已禁用");
        Add("Diag.AACEnabled", "AAC кодек включён", "AAC codec enabled", "AAC已启用");
        Add("Diag.AACDisabled", "AAC кодек отключён. Windows будет использовать SBC.", "AAC codec disabled. Windows will use SBC.", "AAC已禁用");
        Add("Diag.ReconnectRequired", "Переподключите Bluetooth устройство для применения изменений.", "Reconnect Bluetooth device for changes to take effect.", "需要重新连接");
        Add("Diag.AACToggleFailed", "Не удалось изменить настройку AAC. Требуются права администратора.", "Failed to change AAC setting. Administrator rights required.", "AAC切换失败");
        Add("Diag.DisableAACHint", "Отключение AAC может решить проблему запинаний на Intel адаптерах", "Disabling AAC may fix stuttering issues on Intel adapters", "禁用AAC以在Intel适配器上使用aptX");
        Add("Diag.IntelAdapterDetected", "Обнаружен Intel Bluetooth адаптер", "Intel Bluetooth adapter detected", "检测到Intel适配器");
        Add("Diag.IntelAACWarning", "Intel адаптеры часто имеют проблемы с AAC кодеком, что вызывает запинания звука. Рекомендуется отключить AAC.", "Intel adapters often have issues with AAC codec causing audio stuttering. Disabling AAC is recommended.", "Intel适配器上AAC可能存在问题");
        Add("Diag.DisableAAC", "Отключить AAC", "Disable AAC", "禁用AAC");
        Add("Diag.EnableAAC", "Включить AAC", "Enable AAC", "启用AAC");
        Add("Diag.AACStatus", "Статус AAC:", "AAC Status:", "AAC状态");
        Add("Diag.BluetoothAdapter", "Bluetooth адаптер:", "Bluetooth adapter:", "蓝牙适配器");
        Add("Diag.ReconnectWarning", "Настройки AAC изменены! Для применения требуется перезагрузка компьютера.", "AAC settings changed! A computer restart is required to apply changes.", "更改后需重新连接设备");
        Add("Diag.Dismiss", "Понятно", "Dismiss", "忽略");
        Add("Diag.RebootRequired", "Перезагрузить", "Reboot", "需重启");

        Add("Codec.TableHeader", "Bluetooth кодеки", "Bluetooth Codecs", "蓝牙音频编码器对比");
        Add("Codec.ColumnCodec", "Кодек", "Codec", "编码器");
        Add("Codec.ColumnBitrate", "Битрейт", "Bitrate", "最大比特率");
        Add("Codec.ColumnQuality", "Качество", "Quality", "音质");
        Add("Codec.ColumnNote", "Примечание", "Note", "备注");
        Add("Codec.Quality.Basic", "Базовое", "Basic", "基础");
        Add("Codec.Quality.Good", "Хорошее", "Good", "良好");
        Add("Codec.Quality.Excellent", "Отличное", "Excellent", "优秀");
        Add("Codec.Quality.High", "Высокое", "High", "高");
        Add("Codec.Quality.HiRes", "Hi-Res", "Hi-Res", "高解析度");
        Add("Codec.Note.SBC", "Стандартный, всегда доступен", "Standard, always available", "所有蓝牙设备支持");
        Add("Codec.Note.RequiresWin10", "Требуется Win 10 2004+", "Requires Win 10 2004+", "需要Windows 10+");
        Add("Codec.Note.NeedsAdapter", "Нужен специальный BT адаптер", "Requires special BT adapter", "需要适配器支持");
        Add("Codec.Note.ChangesAfterReconnect", "Изменения применятся после переподключения", "Changes take effect after reconnection", "重新连接后生效");
        Add("Codec.TableNote", "Примечание: Windows поддерживает SBC по умолчанию. AAC требует Windows 10 2004+. aptX/LDAC требуют специальный Bluetooth адаптер (Creative BT-W5, FiiO BTA30 Pro и др.).", "Note: Windows supports SBC by default. AAC requires Windows 10 2004+. aptX/LDAC require special Bluetooth adapter (Creative BT-W5, FiiO BTA30 Pro, etc.).", "注：实际音质取决于设备和信号环境");
        Add("Codec.SupportedCodecs", "Поддерживаемые кодеки:", "Supported codecs:", "支持编码器");

        Add("Codec.Auto", "Автоматически", "Auto", "自动");
        Add("Codec.SBC", "SBC (базовый)", "SBC (basic)", "SBC");
        Add("Codec.AAC", "AAC (хороший)", "AAC (good)", "AAC");
        Add("Codec.AptX", "aptX (отличный)", "aptX (excellent)", "aptX");
        Add("Codec.AptXHD", "aptX HD (высший)", "aptX HD (high-end)", "aptX HD");
        Add("Codec.LDAC", "LDAC (максимум)", "LDAC (maximum)", "LDAC");
        Add("Codec.Unknown", "Неизвестно", "Unknown", "未知");

        Add("CodecDesc.Auto", "Система выберет лучший доступный кодек автоматически.", "System will select the best available codec automatically.", "由系统自动选择最佳编码器");
        Add("CodecDesc.SBC", "Базовый кодек, 328 kbps. Поддерживается всеми устройствами.", "Basic codec, 328 kbps. Supported by all devices.", "基础编码器，所有蓝牙音频设备均支持");
        Add("CodecDesc.AAC", "Хорошее качество, 256 kbps. Популярен на устройствах Apple.", "Good quality, 256 kbps. Popular on Apple devices.", "苹果设备常用，音质优于SBC");
        Add("CodecDesc.AptX", "Отличное качество, 352 kbps. Требует поддержки Qualcomm.", "Excellent quality, 352 kbps. Requires Qualcomm support.", "Qualcomm低延迟编码器");
        Add("CodecDesc.AptXHD", "Высшее качество, 576 kbps. Требует aptX HD поддержки.", "High-end quality, 576 kbps. Requires aptX HD support.", "24-bit高清音频");
        Add("CodecDesc.LDAC", "Максимальное качество, до 990 kbps. Требует специальный драйвер.", "Maximum quality, up to 990 kbps. Requires special driver.", "索尼高解析度音频编码器，最高990kbps");

        Add("Status.CriticalError", "Критическая ошибка инициализации", "Critical initialization error", "严重错误");
        Add("Status.InitError", "Ошибка инициализации", "Initialization error", "初始化失败");
        Add("Status.DeviceNotConnected", "Устройство не подключено", "Device not connected", "设备未连接");
        Add("Status.Error", "Ошибка", "Error", "错误");
        Add("Status.SwitchError", "Ошибка переключения", "Switch error", "切换失败");
        Add("Status.Unknown", "Неизвестно", "Unknown", "未知状态");

        Add("Notification.AdminRequired", "Требуются права администратора для смены режима", "Administrator rights required to change mode", "需要管理员权限");
        Add("Notification.SwitchFailed", "Не удалось переключить режим", "Failed to switch mode", "切换失败");
        Add("Notification.LogsFolderNotFound", "Папка с логами не найдена", "Logs folder not found", "未找到日志文件夹");

        Add("Dialog.Warning", "Внимание", "Warning", "警告");
        Add("Dialog.Confirm", "Подтверждение", "Confirmation", "确认");

        Add("Audio.ClickRefresh", "Нажмите 'Обновить' для получения информации", "Click 'Refresh' to get information", "点击刷新获取当前状态");
        Add("Audio.AptxHdAvailable", "Доступен", "Available", "aptX HD可用");

        Add("Priority.Normal", "Обычный", "Normal", "普通");
        Add("Priority.High", "Высокий", "High", "高");
        Add("Priority.Critical", "Критический", "Critical", "最高");

        Add("Diag.A2dpSupported", "A2DP", "A2DP", "A2DP支持");
        Add("Diag.HfpSupported", "HFP", "HFP", "HFP支持");
        Add("Diag.AvrcpSupported", "AVRCP", "AVRCP", "AVRCP支持");
        Add("Diag.EnhancementsEnabled", "Улучшения Windows: Включены", "Windows Enhancements: Enabled", "音频增强已启用");
        Add("Diag.EnhancementsDisabled", "Улучшения Windows: Отключены", "Windows Enhancements: Disabled", "音频增强已禁用");
        Add("Diag.CodecInfoUnavailable", "Информация о кодеке недоступна", "Codec information unavailable", "编码器信息不可用");
        Add("Diag.ServiceNotInit", "Сервис качества звука не инициализирован", "Audio quality service not initialized", "服务未初始化");
        Add("Diag.AutoStart", "Автозапуск", "Autostart", "开机启动");
        Add("Diag.AutoSwitch", "Автопереключение", "Auto-switch", "自动切换");
        Add("Diag.Notifications", "Уведомления", "Notifications", "通知");
        Add("Diag.ErrorGettingData", "Ошибка получения данных", "Error getting data", "获取数据失败");
        Add("Diag.NoLogsFound", "Логи не найдены", "No logs found", "未找到日志");

        Add("App.Application", "приложение", "application", "应用");

        Add("Adapter.Title", "Bluetooth адаптер", "Bluetooth Adapter", "蓝牙适配器");
        Add("Adapter.Select", "Выберите активный адаптер:", "Select active adapter:", "选择活动适配器：");
        Add("Adapter.Current", "Текущий:", "Current:", "当前：");
        Add("Adapter.SupportedCodecs", "Поддерживаемые кодеки:", "Supported codecs:", "支持编码器：");
        Add("Adapter.Switch", "Переключить", "Switch", "切换");
        Add("Adapter.NoAdapters", "Bluetooth адаптеры не найдены", "No Bluetooth adapters found", "未找到蓝牙适配器");
        Add("Adapter.Active", "Активен", "Active", "已激活");
        Add("Adapter.Disabled", "Отключён", "Disabled", "已禁用");
        Add("Adapter.Warning", "Внимание!", "Warning!", "警告！");
        Add("Adapter.SwitchWarning", "При переключении адаптера:\n\n• Все Bluetooth устройства будут отключены\n• Сопряжённые устройства НЕ переносятся между адаптерами\n• Потребуется заново подключить наушники к новому адаптеру\n• Может потребоваться перезагрузка компьютера\n\nПродолжить?", "When switching adapters:\n\n• All Bluetooth devices will be disconnected\n• Paired devices do NOT transfer between adapters\n• You will need to re-pair your headphones with the new adapter\n• A computer restart may be required\n\nContinue?", "切换适配器时：\n\n• 所有蓝牙设备将断开连接\n• 已配对设备不会在适配器间迁移\n• 需要重新将耳机配对到新适配器\n• 可能需要重启计算机\n\n是否继续？");
        Add("Adapter.SwitchSuccess", "Адаптер переключён. Перезагрузите компьютер для применения изменений.", "Adapter switched. Restart your computer to apply changes.", "适配器已切换。请重启计算机以应用更改。");
        Add("Adapter.SwitchFailed", "Не удалось переключить адаптер. Требуются права администратора.", "Failed to switch adapter. Administrator rights required.", "切换适配器失败。需要管理员权限。");
        Add("Adapter.Refresh", "Обновить список", "Refresh list", "刷新列表");
    }

    private static void Add(string key, string russian, string english, string? chinese = null)
    {
        _strings[key] = new Dictionary<Language, string>
        {
            { Language.Russian, russian },
            { Language.English, english },
            { Language.Chinese, chinese ?? english }
        };
    }
}

public enum Language
{
    Russian,
    English,
    Chinese
}
