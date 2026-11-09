# docs/internals/contributing/writing-code/unit-tests

- Subject: docs/internals/contributing/writing-code/unit-tests (id `22856e96-592c-4655-a418-d326465b23ee`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 29 of 193
- Conflicts: 0
- Gaps: 0

## Facts

- ... [c059dbb7f93ef187]
- class OtherAppModel(models.Model): class Meta: app_label = "other_app_label" [9193c383]
- ... [c059dbb7f93ef187-2]
- class TestModelDefinition(SimpleTestCase): @isolate_apps("app_label", "other_app_label") def test_model_definition(self): # This model automatically receives app_label='app_label' class TestModel(models.Model): pass [483fbddc]
- from django.db import models from django.test import SimpleTestCase from django.test.utils import isolate_apps [4c49fc61b7ed53de]
- $ ./runtests.py --bisect basic.tests.ModelTest.test_eq [b81fae09]
- $ ./runtests.py --pair basic.tests.ModelTest.test_eq [92afb16d]
- $ ./runtests.py --pair basic.tests.ModelTest.test_eq queries transactions [f6fbc21f]
- $ ./runtests.py basic --debug-sql [611605e0]
- $ ./runtests.py basic --parallel=1 [e85c3e85]
- $ ./runtests.py basic --shuffle $ ./runtests.py basic --reverse [ad062c5e]
- $ DJANGO_SETTINGS_MODULE=my_postgres_settings tox -e py312-postgres [e7907a27]
- $ OBJC_DISABLE_INITIALIZE_FORK_SAFETY=YES ./runtests.py [6a222188]
- $ apt-get install locales $ dpkg-reconfigure locales [99da3a0e]
- $ export LANG="en_US.UTF-8" $ export LC_ALL="en_US.UTF-8" [0d5580d5]
- $ python -m pip install tox $ tox [263dbc36]
- $ tox -e javascript [629a881f]
- $ tox -e py312-postgres -- --settings=my_postgres_settings [015d5256]
- $ tox -l py3 black blacken-docs flake8>=3.7.0 docs isort>=7.0.0 lint-docs zizmor>=1.19.0 [a37b456d]
- .. code-block:: python :caption: ``tests/app_label/tests.py`` [c7cb1f56]
- In order to make sure the models defined within the context of :func:`~django.test.utils.isolate_apps` instances are correctly installed, you should pass the set of targeted ``app_label`` as arguments: [e86e5eed]
- Models defined in a test method with no explicit :attr:`~django.db.models.Options.app_label` are automatically assigned the label of the app in which their test class is located. [6cc0b8a5]
- class SeleniumTests(SeleniumTestCase): @screenshot_cases(["desktop_size", "mobile_size", "rtl", "dark", "high_contrast"]) def test_login_button_centered(self): self.selenium.get(self.live_server_url + reverse("admin:login")) self.take_screenshot("login") ... [fb319690]
- class TestModelDefinition(SimpleTestCase): @isolate_apps("app_label") def test_model_definition(self): class TestModel(models.Model): pass [9ca2aa17]
- from django.test.selenium import SeleniumTestCase, screenshot_cases from django.urls import reverse [3dc6ba99]
- objc[42074]: +[__NSPlaceholderDate initialize] may have been in progress in another thread when fork() was called. [49c1c36b]
- $ ./runtests.py --selenium=firefox,chrome [2af4cb6e]
- $ ./runtests.py --settings=path.to.settings generic_relations i18n [57e2a9f2]
- $ ./runtests.py --start-after=wsgi [e7e4c59e]

## Beyond the budget

161 more facts did not fit in the budget: [78ec7507] [676b8f15] [aa35972b] [15652fe0] [b2bf88d8] [0d4e2d8a] [d6a7d415] [f116c5ee] [47aa4cba] [fef1c65a] [057eb191] [1ad84e90] [01287e6d] [93c6faed] [f27f3b5f] [568f39c7] [8041332b] [685f0802] [ee10ecc0] [c65f3a7e] [b9d9d9ff] [9da252fb] [1241d4d1] [94c85b53] [d51c3af3] [83d5fc62] [20ef8cdb] [039cc743] [e540035b] [b4b6ff3d] [2692e1ff] [dd5906c3] [15962a9a] [faf6f5a8efbd7831-5] [faf6f5a8efbd7831-6] [faf6f5a8efbd7831-7] [423631a5927aaff7-7] [fccd37de02dbdecc-2] [8aa7203c166b13be-28] [7714e199aac2701e-19] [7714e199aac2701e-20] [7714e199aac2701e-21] [7714e199aac2701e-22] [7714e199aac2701e-23] [7714e199aac2701e-24] [7714e199aac2701e-25] [7714e199aac2701e-26] [7714e199aac2701e-27] [7714e199aac2701e-28] [7714e199aac2701e-29] [7714e199aac2701e-30] [7714e199aac2701e-31] [7714e199aac2701e-32] [7714e199aac2701e-33] [7714e199aac2701e-34] [7714e199aac2701e-35] [7714e199aac2701e-36] [7714e199aac2701e-37] [7714e199aac2701e-38] [7714e199aac2701e-39] [82d93b9b] [833c88a7] [8e24b69a] [bc04d64f] [e7596b47] [bb4c706d] [2af19c22] [97b18f26] [a11a4641] [e0f4552e] [9f6bd7b9] [e9826596] [3d0bbce1] [724408d2] [4e796152] [5acbb376] [93fa3778] [27a52f39] [e69e41ce] [dc0dad33] [6dfe083f] [8ec07757] [c86efd61b4d2ef12] [39f9aa0c] [f6362d0e] [d88de21b] [41b69840] [9c0f4ae8] [7e3d5c99] [37074aa5] [ce9c2bbc] [900d357e] [e73903f1] [72e9b003] [545abc52] [170f7a4e] [79aa75f7] [607f9e8a] [2831de7a] [53eb2705] [3f136d84] [3f14bd4d] [669278d1] [556c5b56] [aad20fdf] [d86397b7] [c4b462d5] [7df7b2aa] [9ba4ef33] [87503232] [3a25640f] [27cadfc7] [7cea4523] [47463484] [8a07a8e1] [22bd1b64] [07306c67] [b68139a0] [ed0d1413] [b9b42252] [e21094aa] [783c56c0] [a21bec4e] [b2752760] [1ba245b1] [a075c2f1] [1512cdf8] [17cbd482] [43517ba4] [930f8ffd] [e2bf6f25] [044fa1e7] [1c29d5ad] [75893f76] [37186434] [ec262a55] [2f25acd4] [b7c4cce3] [984c9e9e] [2400fc96] [9bd7b303e940ce88] [45441029] [e2d58a9b] [8be560a7] [2e421668] [581cf3fc] [df4c96eb] [23326231] [83835780] [809ffa53] [a015dc50] [293d6a16] [25250ec8] [7909166a] [edbbba12] [7fe56fb9] [779d3aeb] [1cc5f916] [cd01bb90] [fc7fd8f2] [893fd7ac]
