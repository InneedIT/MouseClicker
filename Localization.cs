using System.Collections.Generic;

namespace MouseClicker
{
    // 处理应用程序的本地化和多语言支持。
    public static class Localization
    {
        // 当前选择的语言代码, 例如 “zh-CN” 或 “en-US”。
        public static string Language = "zh-CN";

        // 存储所有翻译文本的字典。
        private static readonly Dictionary<string, Dictionary<string, string>> Translations = new Dictionary<string, Dictionary<string, string>>
        {
            // 中文翻译
            {
                "zh-CN", new Dictionary<string, string>
                {
                    { "File", "文件" },
                    { "SaveConfig", "保存配置" },
                    { "LoadConfig", "读取配置" },
                    { "Language", "语言" },
                    { "Help", "帮助" },
                    { "ViewHelp", "查看教程" },
                    { "About", "关于" },
                    { "Add", "添加" },
                    { "Remove", "移除" },
                    { "MoveUp", "上移" },
                    { "MoveDown", "下移" },
                    { "IntervalLabel", "间隔(ms):" },
                    { "JitterLabel", "抖动(ms):" },
                    { "SequenceLabel", "点击顺序:" },
                    { "SequenceLoop", "自定义顺序循环" },
                    { "SequenceRandom", "随机顺序循环" },
                    { "SequenceOnce", "单次顺序点击" },
                    { "ShowOverlay", "显示浮窗" },
                    { "StartClicking", "开始点击" },
                    { "StopClicking", "停止点击 (ESC)" },
                    { "WindowTitle", "鼠标点击器" },
                    { "SaveConfigTitle", "保存配置文件" },
                    { "JsonFilter", "JSON 文件|*.json" },
                    { "ConfigSavedSuccess", "配置已成功保存。" },
                    { "Success", "成功" },
                    { "SaveConfigError", "保存配置失败: {0}" },
                    { "Error", "错误" },
                    { "LoadConfigTitle", "读取配置文件" },
                    { "ConfigLoadedSuccess", "配置已成功加载。" },
                    { "LoadConfigError", "读取配置失败: {0}" },
                    { "AboutMessage", "鼠标点击器 v1.0\n" },
                    { "SetLabelPrompt", "请输入此区域的标注字符:" },
                    { "SetLabelTitle", "设置标注" },
                    { "AreaLabelDefault", "区域" },
                    { "AddAreaFirst", "请至少添加一个点击区域" },
                    { "HelpTutorialTitle", "软件使用教程" },
                    { "HelpTutorialContent", """
欢迎使用鼠标点击器！

1. 添加点击区域:
   - 点击“添加”按钮。
   - 屏幕会变暗，此时您可以按住鼠标左键拖动，以选择一个矩形区域。
   - 松开鼠标后，您可以为此区域设置一个名称。

2. 管理点击区域:
   - “移除”: 删除列表中选中的区域。
   - “上移”/“下移”: 调整列表中区域的顺序，这会影响“自定义顺序循环”模式下的点击次序。

3. 设置点击参数:
   - “间隔(ms)”: 每次点击之间的基础等待时间（毫秒）。
   - “抖动(ms)”: 在基础间隔上增加或减去一个随机值，使点击间隔更自然。例如，间隔1000，抖动100，则实际间隔在900到1100之间。

4. 设置点击顺序:
   - “自定义顺序循环”: 按照列表中从上到下的顺序循环点击。
   - “随机顺序循环”: 在所有区域中随机选择一个进行点击，无限循环。
   - “单次顺序点击”: 按照列表顺序点击一遍，然后自动停止。

5. 开始和停止:
   - 点击“开始点击”按钮启动。
   - 在点击过程中，按钮会变为“停止点击 (ESC)”。您可以随时点击此按钮或按键盘上的 ESC 键来停止。

6. 配置文件:
   - “文件” -> “保存配置”: 将当前所有的点击区域和设置保存到一个文件中。
   - “文件” -> “读取配置”: 从文件中加载之前保存的配置。

7. 语言切换:
   - “语言”菜单允许您在中文和英文之间切换界面语言。

感谢您的使用！
""" },
                    { "CloseButton", "关闭" }
                }
            },
            // 英文翻译
            {
                "en-US", new Dictionary<string, string>
                {
                    { "File", "File" },
                    { "SaveConfig", "Save Config" },
                    { "LoadConfig", "Load Config" },
                    { "Language", "Language" },
                    { "Help", "Help" },
                    { "ViewHelp", "View Tutorial" },
                    { "About", "About" },
                    { "Add", "Add" },
                    { "Remove", "Remove" },
                    { "MoveUp", "Move Up" },
                    { "MoveDown", "Move Down" },
                    { "IntervalLabel", "Interval (ms):" },
                    { "JitterLabel", "Jitter (ms):" },
                    { "SequenceLabel", "Click Sequence:" },
                    { "SequenceLoop", "Loop in Order" },
                    { "SequenceRandom", "Loop in Random Order" },
                    { "SequenceOnce", "Click Once in Order" },
                    { "ShowOverlay", "Show Overlay" },
                    { "StartClicking", "Start Clicking" },
                    { "StopClicking", "Stop Clicking (ESC)" },
                    { "WindowTitle", "Mouse Clicker" },
                    { "SaveConfigTitle", "Save Configuration File" },
                    { "JsonFilter", "JSON Files|*.json" },
                    { "ConfigSavedSuccess", "Configuration saved successfully." },
                    { "Success", "Success" },
                    { "SaveConfigError", "Failed to save configuration: {0}" },
                    { "Error", "Error" },
                    { "LoadConfigTitle", "Load Configuration File" },
                    { "ConfigLoadedSuccess", "Configuration loaded successfully." },
                    { "LoadConfigError", "Failed to load configuration: {0}" },
                    { "AboutMessage", "Mouse Clicker v1.0\n" },
                    { "SetLabelPrompt", "Please enter a label for this area:" },
                    { "SetLabelTitle", "Set Label" },
                    { "AreaLabelDefault", "Area" },
                    { "AddAreaFirst", "Please add at least one click area." },
                    { "HelpTutorialTitle", "Software Tutorial" },
                    { "HelpTutorialContent", """
Welcome to Mouse Clicker!

1. Add a Click Area:
   - Click the "Add" button.
   - The screen will dim. Press and drag the left mouse button to select a rectangular area.
   - After releasing the mouse, you can set a name for this area.

2. Manage Click Areas:
   - "Remove": Deletes the selected area from the list.
   - "Move Up"/"Move Down": Adjusts the order of areas in the list, which affects the click sequence in "Loop in Order" mode.

3. Set Click Parameters:
   - "Interval (ms)": The base waiting time between each click (in milliseconds).
   - "Jitter (ms)": Adds or subtracts a random value to the base interval to make the clicks more natural. E.g., with an interval of 1000 and jitter of 100, the actual interval will be between 900 and 1100.

4. Set Click Sequence:
   - "Loop in Order": Clicks through the areas sequentially from top to bottom in the list, and repeats.
   - "Loop in Random Order": Randomly selects an area to click from all defined areas, repeating indefinitely.
   - "Click Once in Order": Clicks through the areas sequentially once, then stops automatically.

5. Start and Stop:
   - Click the "Start Clicking" button to begin.
   - During clicking, the button will change to "Stop Clicking (ESC)". You can click this button or press the ESC key on your keyboard to stop at any time.

6. Configuration Files:
   - "File" -> "Save Config": Saves all current click areas and settings to a file.
   - "File" -> "Load Config": Loads a previously saved configuration from a file.

7. Language Switching:
   - The "Language" menu allows you to switch the interface language between Chinese and English.

Thank you for using the application!
""" },
                    { "CloseButton", "Close" }
                }
            }
        };

        // 根据键获取当前语言的翻译文本。
        public static string Get(string key)
        {
            if (Translations.ContainsKey(Language) && Translations[Language].ContainsKey(key))
            {
                return Translations[Language][key];
            }
            if (Translations["en-US"].ContainsKey(key))
            {
                return Translations["en-US"][key];
            }
            return key;
        }
    }
}
