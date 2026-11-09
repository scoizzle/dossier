# django/core/management/color

- Subject: django/core/management/color (id `39e3aeed-e903-45e5-a607-e8f081e02d69`)
- Kind: subject
- Budget: 1200 tokens
- Used: 877 tokens
- Facts shown: 21 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- def style_func(x): return x [61665a8d]
- setattr(style, role, style_func) [f261e7f1]
- # Avoid initializing colorama in non-Windows platforms. colorama.just_fix_windows_console() except ( AttributeError, # colorama <= 0.4.6. ImportError, # colorama is not installed. # If just_fix_windows_console() accesses sys.stdout with # WSGIRestrictedStdout. OSError, ): HAS_COLORAMA = False else: HAS_COLORAMA = True [c85289ce]
- # For backwards compatibility, # set style for ERROR_OUTPUT == ERROR style.ERROR_OUTPUT = style.ERROR [d7ef524f]
- # The nocolor palette has all available roles. # Use that palette as the basis for populating # the palette as defined in the environment. for role in termcolors.PALETTES[termcolors.NOCOLOR_PALETTE]: if color_settings: format = color_settings.get(role, {}) style_func = termcolors.make_style(**format) else: [a9e638fe]
- # isatty is not always implemented, #6223. is_a_tty = hasattr(sys.stdout, "isatty") and sys.stdout.isatty() [22b6be91]
- If config_string is empty django.utils.termcolors.DEFAULT_PALETTE is used. """ [bc5279e3]
- color_settings = termcolors.parse_color_setting(config_string) [46e09335]
- def vt_codes_enabled_in_windows_registry(): """ Check the Windows Registry to see if VT code handling has been enabled by default, see https://superuser.com/a/1300251/447564. """ try: # winreg is only available on Windows. import winreg except ImportError: return False else: try: reg_key = winreg.OpenKey(winreg.HKEY_CURRENT_USER, "Console") reg_key_value, _ = winreg.QueryValueEx(reg_key, "VirtualTerminalLevel") except FileNotFoundError: return False else: return reg_key_value == 1 [5bad0946]
- return is_a_tty and ( sys.platform != "win32" or (HAS_COLORAMA and getattr(colorama, "fixed_windows_console", False)) or "ANSICON" in os.environ or # Windows Terminal supports VT codes. "WT_SESSION" in os.environ or # Microsoft Visual Studio Code's built-in terminal supports colors. os.environ.get("TERM_PROGRAM") == "vscode" or vt_codes_enabled_in_windows_registry() ) [a5254638]
- return style [44ba38e2]
- style = Style() [a29f89a9]
- """ Sets up the terminal color scheme. """ [6aa9bfa0]
- @functools.cache def no_style(): """ Return a Style object with no color scheme. """ return make_style("nocolor") [8521ea0d]
- class Style: pass [fe0d802e]
- def color_style(force_color=False): """ Return a Style object from the Django color scheme. """ if not force_color and not supports_color(): return no_style() return make_style(os.environ.get("DJANGO_COLORS", "")) [85927bda]
- def make_style(config_string=""): """ Create a Style object from the given config_string. [298d26e0]
- def supports_color(): """ Return True if the running system's terminal supports color, and False otherwise. """ [993771d1]
- from django.utils import termcolors [5909e7df]
- import functools import os import sys [1d99d8d8]
- try: import colorama [9d9002a5]
