# docs/releases/1.4

- Subject: docs/releases/1.4 (id `6dd3b9ca-3896-4be8-9e66-bb2dd1e9c520`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 24 of 335
- Conflicts: 0
- Gaps: 0

## Facts

- def ham(self): return "eggs" [6d96320d]
- def open(self, name, mode="rb"): return Spam(open(self.path(name), mode)) [53870222]
- execute_from_command_line(sys.argv) [5306d9dc]
- from django.core.management import execute_from_command_line [b799a170]
- objects = BanningCommentManager() [1ee8b921]
- #!/usr/bin/env python import os, sys [bb4b6d52]
- @register.filter def noop(value): return value [8d49fc7c]
- @register.filter(is_safe=True) def noop(value): return value [c0e57ae0]
- @register.simple_tag def my_tag(a, b, *args, **kwargs): warning = kwargs["warning"] profile = kwargs["profile"] ... return ... [80f9f0f767ae3f52-2]
- IGNORABLE_404_STARTS = ("/cgi-bin/", "/_vti_bin", "/_vti_inf") IGNORABLE_404_ENDS = ( "mail.pl", "mailform.pl", "mail.cgi", "mailform.cgi", "favicon.ico", ".php", ) [0d5258c5]
- IGNORABLE_404_URLS = ( # for each <prefix> in IGNORABLE_404_STARTS re.compile(r"^<prefix>"), # for each <suffix> in IGNORABLE_404_ENDS re.compile(r"<suffix>$"), ) [f821dc0a]
- If you're implicitly relying on the path of the admin static files within Django's source code, you'll need to update that path. The files were moved from :file:`django/contrib/admin/media/` to :file:`django/contrib/admin/static/admin/`. [24711083]
- LOGGING = { # ... "filters": { "require_debug_false": { "()": "django.utils.log.RequireDebugFalse", } }, "handlers": { "mail_admins": { "level": "ERROR", "filters": ["require_debug_false"], "class": "django.utils.log.AdminEmailHandler", } }, } [d811b84a]
- Session data is signed and validated by the server, but it's not encrypted. This means a user can view any data stored in the session but cannot change it. Please read the documentation for further clarification before using this backend. [a16b7144]
- class BanningCommentManager(CommentManager): def get_query_set(self): qs = super().get_query_set() if getattr(settings, "COMMENTS_BANNED_USERS_GROUP", None): where = [ "user_id NOT IN (SELECT user_id FROM auth_user_groups WHERE group_id = %s)" ] params = [settings.COMMENTS_BANNED_USERS_GROUP] qs = qs.extra(where=where, params=params) return qs [f2caae32]
- class CommentWithTitle(Comment): title = models.CharField(max_length=300) [17c6b4b7]
- class Spam(File): """ Spam, spam, spam, spam and spam. """ [02a72dd3]
- class SpamStorage(FileSystemStorage): """ A custom file storage backend. """ [1e033cc0]
- django-admin.py runserver --nothreading [d8aa7963]
- django-admin.py startapp myapp /path/to/new/app django-admin.py startproject myproject /path/to/new/project [856bfb80]
- django-admin.py startproject --template=/path/to/my_project_template myproject [b63324bd]
- from django.conf import settings from django.contrib.comments.managers import CommentManager [dbfd421a]
- from django.core.files import File from django.core.files.storage import FileSystemStorage [101cdb35]
- from my_comments_app.managers import BanningCommentManager [4ee484fd]

## Beyond the budget

309 more facts did not fit in the budget: [9b5e7031] [a38efe5f] [90f4387cea1dbdff-6] [6b4c8679] [a8be9dfc] [4d65dd96] [005618072ec479e9-3] [67830c6d] [112f2b46] [8cb53772] [187e9a33] [c3c0d3f6] [f4412c12] [55514105] [6da91716] [4da7ff31] [aea92b63] [b5780e11] [659f70f4] [4b66be85] [db4145bc] [43688687] [cd7ddd0c] [31dcc88f] [97d9ae1a] [97013a18] [96e43790] [cc5322a9] [b604f7b4] [f3665eaf] [9abc2f43] [adbf1372] [93736f9e] [eb76645b] [17d04114] [6499d4f3] [73129ee9] [491a23d8] [6defa446] [360fa8b8] [086c128f] [a42eb9f1] [1f32bc72] [55ad2bc6] [86c27ef8] [57ce901f] [4b10d977] [2dbc1c4c] [c36945ac] [8aa3b1b7] [731141e3] [1b026d70] [a4c69cf5] [dce27c8c] [499d661b] [fd380f8a] [93815c87] [2decfd08] [4787a466] [4edba875] [0702d6e3] [40cafc19] [2378054f] [6ef333b5] [abf46031] [35247ed2] [b0f12011] [799d26bc] [363c4c45] [a8b8405e] [293e7231] [685d15dfb6eb2285-315] [8aa7203c166b13be-117] [8aa7203c166b13be-118] [8aa7203c166b13be-119] [3a9340cd0d877339-33] [3a9340cd0d877339-34] [c54b54cb0805732a-92] [c54b54cb0805732a-93] [ccc1de5e] [ffea29f6] [88f1137c] [8a837529] [66b09089] [383171d0] [bb3c5168] [acaaa347] [d7ccc6f8] [1a08bd75] [96d1f439] [e3d78dda] [b7f713aa] [e8f2d287] [d58dc02b] [d591153a] [8bac1bde] [aced67c2] [0cc03e48] [a3761747] [a53c56cb] [f545280e] [816db957] [35520268] [f313de34] [922f7292] [8dc4c8c8] [4066f01d] [07fcf0b3] [91402e05] [f854bdb8] [3a6a76f4] [09af46b8] [b1f76d31] [5db2e43c] [e77ec544] [dc423356] [f2d19017] [f6a48a60] [b168c4c3] [8e7bee5e] [148f2d44] [8351e511] [df456de8] [a61e66a4] [9dfd3726] [59ab6e70] [7ebd76a0] [e58d2ae5] [936f11c3] [6ad04a8e] [ada13a66] [5b575aa5] [35ebba45] [7d58d825] [5bc8737e] [aa098ff5] [c783ba41] [242992a9] [d26578a6] [93254b51] [afe9fb3f] [c51147c5] [aea26de2] [5050d165] [140f734d] [1a2f09db] [75ce085a] [58297506] [168d1e7a] [b361e54b] [855ed19a] [b3db6765] [afbdc9fe] [650f92cb] [9425cdf9] [831a4adf] [9a56b58d] [a072b733] [842d8efe] [2c96a71f] [f296d2e0] [2c6bd675] [34367fe9] [5c650c16] [75639510] [bca1cde8] [90cd0fbd] [2e68f41d] [32cecf2752c82bab-3] [65337d34] [61d9c0b0] [18a6246b] [c994c623] [2bf3a03c] [53ef17e8] [78324d15] [75696e16fcbb84ec-13] [1ee60919] [3ff7780b] [da81d6f9] [292ff4ec] [0de52be4] [c6b092be] [01c13f78] [ae34cf4ae6f76a23-5] [46cd7916] [e2c0f98d] [ba9ae36a] [a8c14d06] [39408ef9] [699533e0] [7d3b241e] [51b98523] [de38a499] [adc695f6] [24840f1a] [5985535f] [8aaff1cd] [d4c756bb] [25bf41a8] [b5828ec5] [8ff2ba65] [2b5e020e] [02b3d1dc] [1f8a1f65] [2f7477aa] [d35120dd] [d307e342] [4ea13aca] [37ca2442] [b9d6dfd2] [b4f3f809] [1f155ed3] [5fc036e1] [286fcf39] [36825f45] [df65a03f] [4e197469] [3ac104e6] [e51c0b45] [badf408a] [1ca8cc80] [1807b0dc] [abfe58a6] [3012f2cb] [9524526b] [f64f05e2] [d3d38a09] [710c7571] [4fe3c6a0] [606a26dd] [05b74721] [f45978ae] [6d5dc272] [5e517c8a] [a0987674] [4cbf0256] [e6978768] [1bcb6cae] [a65ae051] [0db12422] [c69243e5] [4d5e6f93] [f80e26b6] [e3444e3b] [a82810ef] [792ff601] [512b527b] [6c20bcc8] [c83885a2] [9b1bcd76] [28b62cce] [f8b6f6bf] [59bf9b24] [cd46097b] [c62a35c8] [13a4981d] [830ff421] [1fe6a59b] [6977a08d] [8827c36b] [13f8b08c] [fa1efb3b] [4cfe84c5] [594e970a] [600a0f0c] [982d3b51] [93863849] [2c36d01c] [128e2648] [32b30f4a] [416dbf86] [0a4ab2be] [42acebb3] [71c8c15b] [4e11692b] [157ca239] [e93af996] [8f51972f] [b7e876b7] [42e830d6] [117e4be8] [f48275bc] [56c8522c] [2f1c0522] [9350c51b] [64dd8ae8] [8b24c159] [ecfa5611] [d7ecaf6a] [08ce2f3d] [d983bc19] [437dc5fc] [28e3aa3e] [82d73a35] [58ec3af8] [9821e2ec] [16204b3b] [943138f7] [6f90a3da] [aab9fdb5] [c1195bdd] [c1d9dee9] [48cef4e5] [a3795a1d] [5c24bb88] [3780077c] [04b164c1] [783fec11]
