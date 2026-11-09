# django/contrib/admin/tests

- Subject: django/contrib/admin/tests (id `81059428-a22c-45bd-b427-e0156c6ff79d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2304 tokens
- Facts shown: 38 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- WebDriverWait(self.selenium, timeout).until(callback) [69bb4cac]
- `root_element` allow restriction to a pre-selected node. """ from selenium.webdriver.common.by import By [4a090968]
- if values: options = self.selenium.find_elements(By.CSS_SELECTOR, options_selector) actual_values = [] for option in options: actual_values.append(option.get_attribute("value")) self.assertEqual(values, actual_values) else: # Prevent the `find_elements(By.CSS_SELECTOR, …)` call from # blocking if the selector doesn't match any options as we expect # it to be the case. with self.disable_implicit_wait(): self.wait_until( lambda driver: not driver.find_elements( By.CSS_SELECTOR, options_selector ) ) [f9040aae]
- old_page = self.selenium.find_element(By.TAG_NAME, "html") yield # Wait for the next page to be loaded try: self.wait_until(ec.staleness_of(old_page), timeout=timeout) except WebDriverException: # Issue in version 113+ of Chrome driver where a WebDriverException # error is raised rather than a StaleElementReferenceException. # See: https://issues.chromium.org/issues/42323468 pass [0cea8800]
- return ( self.selenium.find_element(By.CSS_SELECTOR, selector).get_attribute( "disabled" ) == "true" ) [f02e8e95]
- root_element = root_element or self.selenium self.assertEqual( len(root_element.find_elements(By.CSS_SELECTOR, selector)), count ) [f5111ad9]
- select = Select(self.selenium.find_element(By.CSS_SELECTOR, selector)) select.deselect_by_value(value) [6c0635d4]
- select = Select(self.selenium.find_element(By.CSS_SELECTOR, selector)) select.select_by_value(value) [d5c1388e]
- self.selenium.get("%s%s" % (self.live_server_url, login_url)) username_input = self.selenium.find_element(By.NAME, "username") username_input.send_keys(username) password_input = self.selenium.find_element(By.NAME, "password") password_input.send_keys(password) login_text = _("Log in") with self.wait_page_loaded(): self.selenium.find_element( By.XPATH, '//input[@value="%s"]' % login_text ).click() [32c2d3b6]
- self.wait_page_ready(timeout=timeout) [2526a30f]
- self.wait_until( ec.invisibility_of_element_located((By.CSS_SELECTOR, css_selector)), timeout ) [b4e13f93]
- self.wait_until( ec.presence_of_element_located((By.CSS_SELECTOR, css_selector)), timeout ) [dd51704a]
- self.wait_until( ec.text_to_be_present_in_element((By.CSS_SELECTOR, css_selector), text), timeout, ) [bec08bfb]
- self.wait_until( ec.text_to_be_present_in_element_value( (By.CSS_SELECTOR, css_selector), text ), timeout, ) [f2ef233b]
- self.wait_until( ec.visibility_of_element_located((By.CSS_SELECTOR, css_selector)), timeout ) [eb1ae1c5]
- @contextmanager def wait_page_loaded(self, timeout=10): """ Block until a new page has loaded and is ready. """ from selenium.common.exceptions import WebDriverException from selenium.webdriver.common.by import By from selenium.webdriver.support import expected_conditions as ec [fd945e37]
- def _assertOptionsValues(self, options_selector, values): from selenium.webdriver.common.by import By [c1ee9879]
- from contextlib import contextmanager [710f9c6e]

## All facts

- [784787a0] def admin_login(self, username, password, login_url="/admin/"): """ Log in to the admin. """ from selenium.webdriver.common.by import By
- [4171abff] def assertCountSeleniumElements(self, selector, count, root_element=None): """ Assert number of matches for a CSS selector.
- [120c20b2] def assertSelectOptions(self, selector, values): """ Assert that the <SELECT> widget identified by `selector` has the options with the given `values`. """ self._assertOptionsValues("%s > option" % selector, values)
- [5ac080bb] def assertSelectedOptions(self, selector, values): """ Assert that the <SELECT> widget identified by `selector` has the selected options with the given `values`. """ self._assertOptionsValues("%s > option:checked" % selector, values)
- [4a8e4867] def deselect_option(self, selector, value): """ Deselect the <OPTION> with the value `value` inside the <SELECT> widget identified by the CSS selector `selector`. """ from selenium.webdriver.common.by import By from selenium.webdriver.support.ui import Select
- [9050ebbb] def is_disabled(self, selector): """ Return True if the element identified by `selector` has the `disabled` attribute. """ from selenium.webdriver.common.by import By
- [a1086397] def select_option(self, selector, value): """ Select the <OPTION> with the value `value` inside the <SELECT> widget identified by the CSS selector `selector`. """ from selenium.webdriver.common.by import By from selenium.webdriver.support.ui import Select
- [f03cf946] def tearDown(self): # Ensure that no CSP violations were logged in the browser. self.assertEqual(self.get_browser_logs(source="security"), []) super().tearDown()
- [afe8ebac] def trigger_resize(self): width = self.selenium.get_window_size()["width"] height = self.selenium.get_window_size()["height"] self.selenium.set_window_size(width + 1, height) self.wait_page_ready() self.selenium.set_window_size(width, height) self.wait_page_ready()
- [4d14e576] def wait_for(self, css_selector, timeout=10): """ Block until a CSS selector is found on the page. """ from selenium.webdriver.common.by import By from selenium.webdriver.support import expected_conditions as ec
- [a4c6c553] def wait_for_and_switch_to_popup(self, num_windows=2, timeout=10): """ Block until `num_windows` are present and are ready (usually 2, but can be overridden in the case of pop-ups opening other pop-ups). Switch the current window to the new pop-up. """ self.wait_until(lambda d: len(d.window_handles) == num_windows, timeout) self.selenium.switch_to.window(self.selenium.window_handles[-1]) self.wait_page_ready()
- [72f0a45c] def wait_for_text(self, css_selector, text, timeout=10): """ Block until the text is found in the CSS selector. """ from selenium.webdriver.common.by import By from selenium.webdriver.support import expected_conditions as ec
- [90ab951a] def wait_for_value(self, css_selector, text, timeout=10): """ Block until the value is found in the CSS selector. """ from selenium.webdriver.common.by import By from selenium.webdriver.support import expected_conditions as ec
- [03f013bc] def wait_page_ready(self, timeout=10): """ Block until the page is ready. """ self.wait_until( lambda driver: driver.execute_script("return document.readyState;") == "complete", timeout, )
- [87c1048d] def wait_until(self, callback, timeout=10): """ Block the execution of the tests until the specified callback returns a value that is not falsy. This method can be called, for example, after clicking a link or submitting a form. See the other public methods that call this function for more details. """ from selenium.webdriver.support.wait import WebDriverWait
- [5d8b07bb] def wait_until_invisible(self, css_selector, timeout=10): """ Block until the element described by the CSS selector is invisible. """ from selenium.webdriver.common.by import By from selenium.webdriver.support import expected_conditions as ec
- [39a3fc3d] def wait_until_visible(self, css_selector, timeout=10): """ Block until the element described by the CSS selector is visible. """ from selenium.webdriver.common.by import By from selenium.webdriver.support import expected_conditions as ec
- [a66b34ca8afbcd43] # Make unittest ignore frames in this module when reporting failures. __unittest = True
- [f82d938e] @modify_settings( MIDDLEWARE={"append": "django.middleware.csp.ContentSecurityPolicyMiddleware"} ) @override_settings( SECURE_CSP={ "default-src": [CSP.NONE], "connect-src": [CSP.SELF], "img-src": [CSP.SELF], "script-src": [CSP.SELF], "style-src": [CSP.SELF], }, ) class AdminSeleniumTestCase(SeleniumTestCase, StaticLiveServerTestCase): available_apps = [ "django.contrib.admin", "django.contrib.auth", "django.contrib.contenttypes", "django.contrib.sessions", "django.contrib.sites", ]
- [e04bc6d6] from django.contrib.staticfiles.testing import StaticLiveServerTestCase from django.test import modify_settings, override_settings from django.test.selenium import SeleniumTestCase from django.utils.csp import CSP from django.utils.translation import gettext as _
