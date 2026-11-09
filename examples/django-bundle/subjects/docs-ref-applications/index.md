# docs/ref/applications

- Subject: docs/ref/applications (id `d1f69a30-af1f-42c0-8657-e1be9db0facc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 21 of 163
- Conflicts: 0
- Gaps: 0

## Facts

- # registering signals with the model's string label pre_save.connect(receiver, sender="app_label.MyModel") [a86c11d8]
- MyModel = self.get_model("MyModel") [51d50472]
- def ready(self): # importing model classes from .models import MyModel # or... [e8b96800]
- Although you can access model classes as described above, avoid interacting with the database in your :meth:`ready` implementation. This includes model methods that execute queries (:meth:`~django.db.models.Model.save`, :meth:`~django.db.models.Model.delete`, manager methods etc.), and also raw SQL queries via ``django.db.connection``. Your :meth:`ready` method will run during startup of every management command. For example, even though the test database configuration is separate from the production settings, ``manage.py test`` would still execute some queries against your **production** database! [822fc472]
- Changing this attribute after migrations have been applied for an application will result in breaking changes to a project or, in the case of a reusable app, any existing installs of that app. This is because ``AppConfig.label`` is used in database tables and migration files when referencing an app in the dependencies list. [acf6054a]
- In the usual initialization process, the ``ready`` method is only called once by Django. But in some corner cases, particularly in tests which are fiddling with installed applications, ``ready`` might be called more than once. In that case, either write idempotent methods, or put a flag on your ``AppConfig`` classes to prevent rerunning code which should be executed exactly one time. [866064e3]
- class RockNRollConfig(AppConfig): # ... [777ed88d]
- default_auto_field = "django.db.models.AutoField" [4154e3c5]
- from django.apps import AppConfig from django.db.models.signals import pre_save [d593ff20]
- from django.apps import apps as django_apps [1ee1555f]
- # anthology/apps.py [409adc8a]
- # anthology/settings.py [f2cdfb9a]
- # rock_n_roll/apps.py [868773b1]
- * Loading the settings. * Setting up logging. * If ``set_prefix`` is True, setting the URL resolver script prefix to :setting:`FORCE_SCRIPT_NAME` if defined, or ``/`` otherwise. * Initializing the application registry. [6298a3fa]
- * When running an HTTP server via Django's ASGI or WSGI support. * When invoking a management command. [51391d57]
- .. note:: [942ae6c11625c81c-22]
- .. warning:: [c54b54cb0805732a-9]
- .. warning:: [c54b54cb0805732a-10]
- >>> from django.apps import apps >>> apps.get_app_config("admin").verbose_name 'Administration' [57c01534]
- Although you can't import models at the module-level where :class:`~django.apps.AppConfig` classes are defined, you can import them in ``ready()``, using either an ``import`` statement or :meth:`~AppConfig.get_model`. [5a559347]
- Application configuration objects store metadata for an application. Some attributes can be configured in :class:`~django.apps.AppConfig` subclasses. Others are set by Django and read-only. [5745be7f]

## Beyond the budget

141 more facts did not fit in the budget: [a218faf7] [75c5eba2] [0ab0aec4] [3c2a1534] [a014bcce] [acfcf117f82fd4c9] [3460cc51] [5e1aa526] [7b3cf16d] [e9cb2b51] [e9c6b215] [65b3de87] [97a78e29] [7730e811] [bdfd49d9] [a1746f1c] [79547cf0] [8c872a9b0696ed60] [3cf2695e] [5333fdf3] [3c460eb4] [bc34e56f] [416938bb] [146eba6c] [03e8f91d] [9306cad5] [fad4ce16] [aa3b98e0] [8aa18477] [f21089b2] [be11ff04] [0a6b839f] [662b880e] [e9ebd580] [5eab5c42] [e308d128] [f0c7f3bf] [81949130] [06af1855] [4f64dae5] [c56fa3c5] [2f37a70f] [8fe9a307] [d7bb13e8] [8d81b7a5] [3393bd7e] [a602d51d] [d4833f4a34e10657-2] [630d7a0e] [b7ef9720] [a7aea703] [8320aa27] [d5a4d36f] [48f3a0be] [57b1b17b] [275ca9f1] [82a25c64] [87815908] [e9e0f0f8] [0a211644] [fe2e838c] [abd85b79] [e9a79396] [4e5ea285] [1bdf9fe6] [8d0e9da3] [4d792483] [fe42502c] [09e1f38d] [a4bb5e2d] [01be3cd6] [04c3c9ec] [f480a4ed] [356897ec] [a3e0fb37] [40fcd171] [bb8aa545] [ea2f45a8] [5352f51c] [5e4f0f8f] [892ef203] [7c8bc809] [3fe4ed04] [c74a1b92] [e21d3714] [946eb983] [eaf050be34acb41d-14] [64bfa896] [19bdeac7] [2a183c3e] [17ccfed7] [30c5f891] [a15aa2af] [0a477067] [484a5898] [8ad449cc] [b847db94] [1ce7d7e2] [ed3a5118] [942ae6c11625c81c-23] [af363f47] [4ee76a3e] [a08a019f] [860760cf] [ff7d3419] [baa7bb9d] [aa1013e8] [29a55f35] [22e7035c] [b80f6c64] [a239554e] [da0ecf69] [b5d162e3] [cdae8d58] [8e8c5854] [068bbd1d] [c03ecfe4] [f7548bb7] [820e1bb9] [aa06f266] [dc17acf2] [d9b81d29] [496cdea6] [d5882157dc780592-2] [26132f40] [a817e6f1] [6d9c104b] [304b4f6a] [1daa4b9f] [3dddc3b3] [e4a417d9] [895613b2] [c4a69ee1] [51bc67ed] [dd2fffd9] [50333364] [59845339] [2663a98e] [aca3ef2a] [79557808] [8453d3d7]
