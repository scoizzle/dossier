# docs/releases/1.0-porting-guide

- Subject: docs/releases/1.0-porting-guide (id `a777580f-9d81-47b2-8f56-dabd125eca23`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 28 of 226
- Conflicts: 0
- Gaps: 0

## Facts

- class Admin: fields = ( ("group1", {"fields": ("foo", "bar"), "classes": "collapse"}), ("group2", {"fields": ("spam", "eggs"), "classes": "collapse wide"}), ) [146d1f96]
- class Admin: fields = ((None, {"fields": ("foo", "bar")}),) [513ed3c3]
- class Admin: list_display = ["first_name", "last_name"] [60598c57]
- def __str__(self): return "%s %s" % (self.first_name, self.last_name) [d015ca70]
- def __unicode__(self): return "%s %s" % (self.first_name, self.last_name) [9d7444ab]
- $ ./manage.py dumpdata --format=xml <app> > data-dump.xml $ ./manage.py reset <app> $ ./manage.py loaddata data-dump.xml [d1e71e37]
- $ django-admin.py --settings=foo.bar runserver [76f856cc]
- This will be escaped: {{ data }} This will not be escaped: {{ data|safe }} [652a5a76e4b2dc7a-2]
- def my_view(request): f = request.FILES["file_field_name"] ... [b7b3f7aa]
- from django.core import management [cc170a2553169bf6]
- management.call_command("flush", verbosity=0, interactive=False) management.call_command("loaddata", "test_data", verbosity=0) [d2043b09]
- management.flush(verbosity=0, interactive=False) management.load_data(["test_data"], verbosity=0) [3e18977a]
- {% autoescape off %} ... unescaped template content here ... {% endautoescape %} [251a1f30]
- # ... same as above, but then: c.login(username="myuser", password="mypassword") [6ee66413]
- # The next two lines enable the admin and load each admin.py file: from django.contrib import admin [d75b838a]
- * More detailed information about the changes and the reasons behind them can be found on the `NewformsAdminBranch wiki page`__ [ee5b6e4e]
- * The new admin comes with a ton of new features; you can read about them in the :doc:`admin documentation </ref/contrib/admin/index>`. [653ef617]
- A contributor to djangosnippets__ has written a script that'll `scan your models.py and generate a corresponding admin.py`__. [569ae5e9]
- The :doc:`1.0 release notes </releases/1.0>`. That document explains the new features in 1.0 more deeply; the porting guide is more concerned with helping you quickly update your code. [4e0e780d]
- __ https://code.djangoproject.com/wiki/NewformsAdminBranch [6abb5035]
- __ https://djangosnippets.org/ __ https://djangosnippets.org/snippets/603/ [c20925b5]
- admin.autodiscover() [4ad8e36e]
- admin.site.register(Author, AuthorAdmin) [581d9c391670b6e7-3]
- admin.site.register(Parent, ParentAdmin) [6a9b1343]
- c = Client() c.login("/path/to/login", "myuser", "mypassword") [c5f945f0]
- class Article(models.Model): title = models.CharField(max_length=100) published = models.DateField(default=datetime.datetime.now) [678e37cf]
- class Article(models.Model): title = models.CharField(maxlength=100) published = models.DateField(default=LazyDate()) [223830fd]
- class ModelOne(models.Model): ... [54c45c21]

## Beyond the budget

193 more facts did not fit in the budget: [612affa7] [c6691666] [fac558f8] [42e3b751] [9c88513f] [72f43d82] [c746d3cd] [6311afa8] [05d2c4dc] [8f00c102] [697fde98] [9ee3a9405e27875c-11] [36560f72] [897fa20c28c79ab4-2] [8abd8e62] [d77822b1] [3668c3f5] [b75c8d9ca5df7aa8-4] [aa0177af] [8049ac05] [8c808fb0] [798228b1] [54fce6a6] [31df9a6f] [7c98d7c6] [f8f1e225] [d8a8ca39] [c1a14017] [9eee62f4] [ceaffbf8] [faf6f5a8efbd7831-17] [faf6f5a8efbd7831-18] [faf6f5a8efbd7831-19] [685d15dfb6eb2285-304] [6b4a5e54e001d097-30] [6b4a5e54e001d097-31] [6b4a5e54e001d097-32] [c54b54cb0805732a-90] [f27b60ce] [69359985] [5916def7] [0087c564] [b76669ec] [b4b53cc3] [a4b1f662] [8322ea22] [ecdddc1f] [be8635d9] [baa190a2] [74480a51] [dba6c79b] [c7a8f2a8] [370d5edb] [3ae949ff] [54b9e4c9] [03daec79] [76c5f6ca] [fbc7afe6] [818d10d3] [13db4712] [fd2973c7] [af9e3610] [871da767] [e3ade616] [ca3d5102] [7af9ba2d] [6a216cdf] [b3a88a76] [0027b0fd] [aa5860b2] [86035bb4] [a3d96c49] [84c9f11f] [879fc8ab] [1e5c1bbe] [e1df111a] [dc07e702] [6dc56b66] [2db2a5dc] [fcc674a2] [8385acf5] [16b69f44] [b7cf3817] [6378c221] [5467be22] [6888db21] [8f58a724] [1db3363d] [8d608ed8] [caee99f6] [e3982b27] [cd72adcf] [a73b920c] [1533981d] [8e0e5196] [9564ee4e] [87d7d621] [933a5666] [d7b6af8e] [ed93b856] [4f2acabb] [41ad03dd1251d50b-2] [51ff3ae4] [dbac172a] [6477fe68] [4e0035d80bf520d7] [4e0035d80bf520d7-2] [4e0035d80bf520d7-3] [4e0035d80bf520d7-4] [4e0035d80bf520d7-5] [4e0035d80bf520d7-6] [6360e779] [9e2c1897] [bf142e70bdb63e9c-3] [6b7595b8] [f91dabb1] [157622bdfa424f46] [157622bdfa424f46-2] [157622bdfa424f46-3] [157622bdfa424f46-4] [157622bdfa424f46-5] [157622bdfa424f46-6] [1c7bf0e4] [8955969f] [5e7f78f8] [21556681] [cfdbe1f9] [b2303885] [206ac963] [0c5b55e7] [f41eaadf] [afc3727d] [1dc25356] [6e7e739c] [614af230] [0cd4a61a] [893b6ea7] [0d8f0d73] [902295c6] [a524e791] [56396844] [5acd1fef] [cea3095f] [4664c7e23c0209b4-2] [6f4876d9cd2b3e11-2] [6638661763b46374-2] [ee185473] [d3841237] [864fd132] [cfb39c5c] [ea0c4b6f] [2b9444a730838e7a-2] [87116ed1] [a53f88ba] [ecaf3003] [fedf9479] [09cd3946] [25820cb8] [77fc1688] [e77ffbd8] [7fa1abde] [8530736c] [0e9af571] [1477be4b] [9eda9d1d] [f441b70f] [8ba85e8b] [389fa802] [3f91e779] [7d0b5d30dab82953-2] [832def4f] [875beed2] [d04361b4] [3a41affc1b4582de-3] [6bb54944] [18ca67a7] [359d08eb] [ff8fdae7] [9ce2f16d] [07f4b627] [7304bbb6] [ad029ce2] [21f04cf9] [f3ac6304] [7a36d330] [4880865a] [d67b521b] [03eac8b2] [b93180c4] [89a4aaaa] [cf837c94] [ece05c22] [f78a5fad]
