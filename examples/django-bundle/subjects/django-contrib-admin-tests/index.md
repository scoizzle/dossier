# django/contrib/admin/tests

- Subject: django/contrib/admin/tests (id `e7964c6f-9d9f-4edf-bcdb-b427e5f561fd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 17 of 38
- Conflicts: 0
- Gaps: 0

## Facts

- WebDriverWait(self.selenium, timeout).until(callback) [69bb4cac]
- `root_element` allow restriction to a pre-selected node. """ from selenium.webdriver.common.by import By [4a090968]
- if values: options = self.selenium.find_elements(By.CSS_SELECTOR, options_selector) actual_values = [] for option in options: actual_values.append(option.get_attribute("value")) self.assertEqual(values, actual_values) else: # Prevent the `find_elements(By.CSS_SELECTOR, …)` call from # blocking if the selector doesn't match any options as we expect # it to be the case. with self.disable_implicit_wait(): self.wait_until( lambda driver: not driver.find_elements( By.CSS_SELECTOR, options_selector ) ) [f9040aae]
- old_page = self.selenium.find_element(By.TAG_NAME, "html") yield # Wait for the next page to be loaded try: self.wait_until(ec.staleness_of(old_page), timeout=timeout) except WebDriverException: # Issue in version 113+ of Chrome driver where a WebDriverException # error is raised rather than a StaleElementReferenceException. # See: https://issues.chromium.org/issues/42323468 pass [0cea8800]
- return ( self.selenium.find_element(By.CSS_SELECTOR, selector).get_attribute( "disabled" ) == "true" ) [f02e8e95]
- root_element = root_element or self.selenium self.assertEqual( len(root_element.find_elements(By.CSS_SELECTOR, selector)), count ) [f5111ad9]
- select = Select(self.selenium.find_element(By.CSS_SELECTOR, selector)) select.deselect_by_value(value) [6c0635d4]
- self.selenium.get("%s%s" % (self.live_server_url, login_url)) username_input = self.selenium.find_element(By.NAME, "username") username_input.send_keys(username) password_input = self.selenium.find_element(By.NAME, "password") password_input.send_keys(password) login_text = _("Log in") with self.wait_page_loaded(): self.selenium.find_element( By.XPATH, '//input[@value="%s"]' % login_text ).click() [32c2d3b6]
- self.wait_page_ready(timeout=timeout) [2526a30f]
- self.wait_until( ec.invisibility_of_element_located((By.CSS_SELECTOR, css_selector)), timeout ) [b4e13f93]
- self.wait_until( ec.presence_of_element_located((By.CSS_SELECTOR, css_selector)), timeout ) [dd51704a]
- self.wait_until( ec.text_to_be_present_in_element((By.CSS_SELECTOR, css_selector), text), timeout, ) [bec08bfb]
- self.wait_until( ec.visibility_of_element_located((By.CSS_SELECTOR, css_selector)), timeout ) [eb1ae1c5]
- @contextmanager def wait_page_loaded(self, timeout=10): """ Block until a new page has loaded and is ready. """ from selenium.common.exceptions import WebDriverException from selenium.webdriver.common.by import By from selenium.webdriver.support import expected_conditions as ec [fd945e37]
- def _assertOptionsValues(self, options_selector, values): from selenium.webdriver.common.by import By [c1ee9879]
- def admin_login(self, username, password, login_url="/admin/"): """ Log in to the admin. """ from selenium.webdriver.common.by import By [784787a0]
- def assertCountSeleniumElements(self, selector, count, root_element=None): """ Assert number of matches for a CSS selector. [4171abff]

## Beyond the budget

16 more facts did not fit in the budget: [120c20b2] [5ac080bb] [4a8e4867] [9050ebbb] [f03cf946] [afe8ebac] [4d14e576] [a4c6c553] [72f0a45c] [03f013bc] [87c1048d] [5d8b07bb] [a66b34ca8afbcd43] [f82d938e] [710f9c6e] [e04bc6d6]
