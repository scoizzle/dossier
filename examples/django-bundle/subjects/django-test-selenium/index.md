# django/test/selenium

- Subject: django/test/selenium (id `2a419c92-503a-4ff5-bdc7-64a48ef5644f`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2430 tokens
- Facts shown: 38 of 39
- Conflicts: 0
- Gaps: 0

## Highlights

- @wraps(func) def test(self, *args, _func=func, _case=screenshot_case, **kwargs): with getattr(self, _case)(): return _func(self, *args, **kwargs) [4ab4607d]
- test.__name__ = f"{name}_{screenshot_case}" test.__qualname__ = f"{test.__qualname__}_{screenshot_case}" test._screenshot_name = name test._screenshot_case = screenshot_case setattr(cls, test.__name__, test) [30c3194f]
- for key, value in self.get_capability(self.browser).items(): options.set_capability(key, value) [807ecb72]
- return webdriver.Remote(command_executor=self.selenium_hub, options=options) return self.import_webdriver(self.browser)(options=options) [5449d3f9]
- # Not using .execute_cdp_cmd() as it isn't supported by the remote web # driver when using --selenium-hub. self.selenium.execute( driver_command="executeCdpCommand", params={"cmd": "Emulation.setEmulatedMedia", "params": params}, ) [0ac644a0]
- caps = getattr(DesiredCapabilities, browser.upper()) if browser == "chrome": caps["goog:loggingPrefs"] = {"browser": "ALL"} [a0341c1c]
- for name, func in list(cls.__dict__.items()): if not hasattr(func, "_screenshot_cases"): continue # Remove the main test. delattr(cls, name) # Add separate tests for each screenshot type. for screenshot_case in getattr(func, "_screenshot_cases"): [46c60054]
- return caps [212c1f3d]
- @classmethod def __init_subclass__(cls, **kwargs): super().__init_subclass__(**kwargs) if not cls.screenshots: return [9d5ec8fe]
- @classmethod def _quit_selenium(cls): # quit() the WebDriver before attempting to terminate and join the # single-threaded LiveServerThread to avoid a dead lock if the browser # kept a connection alive. if hasattr(cls, "selenium"): cls.selenium.quit() [ac251a72]
- @classmethod def get_capability(cls, browser): from selenium.webdriver.common.desired_capabilities import DesiredCapabilities [00bfb50e]
- @classmethod def import_options(cls, browser): return import_string("selenium.webdriver.%s.options.Options" % browser) [b508e0f3]
- @classmethod def setUpClass(cls): cls.selenium = cls.create_webdriver() cls.selenium.implicitly_wait(cls.implicit_wait) super().setUpClass() cls.addClassCleanup(cls._quit_selenium) [19f30b20]
- @classproperty def allowed_host(cls): return cls.external_host or cls.host [4adf4303]
- @classproperty def live_server_url(cls): return "http://%s:%s" % (cls.external_host or cls.host, cls.server_thread.port) [dcc9f52a]
- @contextmanager def dark(self): # Navigate to a page before executing a script. self.selenium.get(self.live_server_url) self.selenium.execute_script("localStorage.setItem('theme', 'dark');") with self.desktop_size(): try: yield finally: self.selenium.execute_script("localStorage.removeItem('theme');") [af860c16]
- @contextmanager def desktop_size(self): with ChangeWindowSize(1280, 720, self.selenium): yield [d407c8dd]
- @contextmanager def disable_implicit_wait(self): """Disable the default implicit wait.""" self.selenium.implicitly_wait(0) try: yield finally: self.selenium.implicitly_wait(self.implicit_wait) [68dd95f3]

## All facts

- [89afe0a2] @contextmanager def high_contrast(self): self.set_emulated_media(features=[{"name": "forced-colors", "value": "active"}]) with self.desktop_size(): try: yield finally: self.set_emulated_media( features=[{"name": "forced-colors", "value": "none"}] )
- [4945b865] @contextmanager def mobile_size(self): with ChangeWindowSize(360, 800, self.selenium): yield
- [97734b7f] @contextmanager def rtl(self): with self.desktop_size(): with override_settings(LANGUAGE_CODE=settings.LANGUAGES_BIDI[-1]): yield
- [060fe089] @contextmanager def small_screen_size(self): with ChangeWindowSize(1024, 768, self.selenium): yield
- [fac3af28] def __enter__(self): self.old_size = self.selenium.get_window_size() self.selenium.set_window_size(*self.new_size) return self
- [12ea0a9d] def __exit__(self, exc_type, exc_value, traceback): self.selenium.set_window_size(self.old_size["width"], self.old_size["height"])
- [2fd7b59d] def __new__(cls, name, bases, attrs): """ Dynamically create new classes and add them to the test module when multiple browsers specs are provided (e.g. --selenium=firefox,chrome). """ test_class = super().__new__(cls, name, bases, attrs) # If the test class is either browser-specific or a test base, return # it. if test_class.browser or not any( name.startswith("test") and callable(value) for name, value in attrs.items() ): return test_class elif test_class.browsers: # Reuse the created test class to make it browser-specific. # We can't rename it to include the browser name or create a # subclass like we do with the remaining browsers as it would # either duplicate tests or prevent pickling of its instances. first_browser = test_class.browsers[0] test_class.browser = first_browser # Listen on an external interface if using a selenium hub. host = test_class.host if not test_class.selenium_hub else "0.0.0.0" test_class.host = host test_class.external_host = cls.external_host # Create subclasses for each of the remaining browsers and expose # them through the test's module namespace. module = sys.modules[test_class.__module__] for browser in test_class.browsers[1:]: browser_test_class = cls.__new__( cls, "%s%s" % (capfirst(browser), name), (test_class,), { "browser": browser, "host": host, "external_host": cls.external_host, "__module__": test_class.__module__, }, ) setattr(module, browser_test_class.__name__, browser_test_class) return test_class # If no browsers were specified, skip this class (it'll still be # discovered). return unittest.skip("No browsers specified.")(test_class)
- [196bf801] def create_options(self): options = self.import_options(self.browser)() if self.browser == "chrome": # Disable Google Password Manager "Data Breach" alert pop-ups. options.add_argument("--guest") options.add_argument("--disable-infobars") if self.headless: match self.browser: case "chrome" | "edge": options.add_argument("--headless=new") case "firefox": options.add_argument("-headless") return options
- [0003a8eb] def create_webdriver(self): options = self.create_options() if self.selenium_hub: from selenium import webdriver
- [73d77148] def get_browser_logs(self, source=None, level="ALL"): """ Return Chrome console logs filtered by level and optionally source. """ try: logs = self.selenium.get_log("browser") except AttributeError: logs = [] return [ log for log in logs if (level == "ALL" or log["level"] == level) and (source is None or log["source"] == source) ]
- [86b30d02] def set_emulated_media(self, *, media=None, features=None): if self.browser not in {"chrome", "edge"}: self.skipTest( "Emulation.setEmulatedMedia is only supported on Chromium and " "Chrome-based browsers. See https://chromedevtools.github.io/devtools-" "protocol/1-3/Emulation/#method-setEmulatedMedia for more details." ) params = {} if media is not None: params["media"] = media if features is not None: params["features"] = features
- [3bd1ce5d] def take_screenshot(self, name): if not self.screenshots: return test = getattr(self, self._testMethodName) filename = f"{test._screenshot_name}--{name}--{test._screenshot_case}.png" path = Path.cwd() / "screenshots" / filename path.parent.mkdir(exist_ok=True, parents=True) self.selenium.save_screenshot(path)
- [b539c617] def wrapper(func): func._screenshot_cases = method_names setattr(func, "tags", {"screenshot"}.union(getattr(func, "tags", set()))) return func
- [656124d6f08b58d6-2] return wrapper
- [d40a8535] @tag("selenium") class SeleniumTestCase(LiveServerTestCase, metaclass=SeleniumTestCaseBase): implicit_wait = 10 external_host = None screenshots = False
- [b8c9a494] class ChangeWindowSize: def __init__(self, width, height, selenium): self.selenium = selenium self.new_size = (width, height)
- [cd649220] class SeleniumTestCaseBase(type(LiveServerTestCase)): # List of browsers to dynamically create test classes for. browsers = [] # A selenium hub URL to test against. selenium_hub = None # The external host Selenium Hub can reach. external_host = None # Sentinel value to differentiate browser-specific instances. browser = None # Run browsers in headless mode. headless = False
- [75efe987] def screenshot_cases(method_names): if isinstance(method_names, str): method_names = method_names.split(",")
- [c320fa41] from django.conf import settings from django.test import LiveServerTestCase, override_settings, tag from django.utils.functional import classproperty from django.utils.module_loading import import_string from django.utils.text import capfirst
- [c586a5b4] import sys import unittest from contextlib import contextmanager from functools import wraps from pathlib import Path
