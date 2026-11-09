# django/test/selenium

- Subject: django/test/selenium (id `8547c1b4-1d0f-4e80-80f7-fe47f0b837c8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 18 of 39
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

20 more facts did not fit in the budget: [89afe0a2] [4945b865] [97734b7f] [060fe089] [fac3af28] [12ea0a9d] [2fd7b59d] [196bf801] [0003a8eb] [73d77148] [86b30d02] [3bd1ce5d] [b539c617] [656124d6f08b58d6-2] [d40a8535] [b8c9a494] [cd649220] [75efe987] [c320fa41] [c586a5b4]
