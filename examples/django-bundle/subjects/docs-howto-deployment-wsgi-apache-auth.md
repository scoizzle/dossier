# docs/howto/deployment/wsgi/apache-auth

- Subject: docs/howto/deployment/wsgi/apache-auth (id `f5e684c1-6275-452c-a946-046d6c697981`)
- Kind: subject
- Budget: 1200 tokens
- Used: 883 tokens
- Facts shown: 27 of 42
- Conflicts: 0
- Gaps: 0

## Facts

- LoadModule auth_basic_module modules/mod_auth_basic.so LoadModule authz_user_module modules/mod_authz_user.so [0861217f]
- .. code-block:: apache [1e18959e4cc41bff]
- <Location "/secret"> AuthType Basic AuthName "Top Secret" AuthBasicProvider wsgi WSGIAuthUserScript /path/to/mysite.com/mysite/wsgi.py WSGIAuthGroupScript /path/to/mysite.com/mysite/wsgi.py Require group secret-agents Require valid-user </Location> [e435e24f]
- Make sure that ``mod_auth_basic`` and ``mod_authz_user`` are loaded. [642c3ef1]
- The use of ``WSGIApplicationGroup %{GLOBAL}`` in the configurations below presumes that your Apache instance is running only one Django application. If you are running more than one Django application, please refer to the `Defining Application Groups`_ section of the mod_wsgi docs for more information about this setting. [650e8184]
- These might be compiled statically into Apache, or you might need to use LoadModule to load them dynamically in your ``httpd.conf``: [cc7f2932]
- WSGIProcessGroup %{GLOBAL} WSGIApplicationGroup %{GLOBAL} [808b57a1301d2241]
- WSGIProcessGroup %{GLOBAL} WSGIApplicationGroup %{GLOBAL} [808b57a1301d2241-2]
- WSGIScriptAlias / /path/to/mysite.com/mysite/wsgi.py [b252bc2a3a786de2]
- application = WSGIHandler() [522ca3c7]
- from django.contrib.auth.handlers.modwsgi import check_password [93e7b7cc]
- from django.contrib.auth.handlers.modwsgi import check_password, groups_for_user [6d5bf289]
- from django.core.handlers.wsgi import WSGIHandler [f9c15a88]
- import os [4d707266d36fc4ec-3]
- os.environ["DJANGO_SETTINGS_MODULE"] = "mysite.settings" [6934febf]
- * Allow certain users to connect to a WebDAV share created with mod_dav_. [628ab2a7]
- * Authenticate access to a Subversion_ repository against Django users with a certain permission. [5a75d7e9]
- * Serve static/media files directly from Apache only to authenticated users. [5fdc2f93]
- .. _Defining Application Groups: https://modwsgi.readthedocs.io/en/develop/user-guides/configuration-guidelines.html#defining-application-groups .. _access control mechanisms documentation: https://modwsgi.readthedocs.io/en/develop/user-guides/access-control-mechanisms.html [610f57ff]
- .. _Subversion: https://subversion.apache.org/ .. _mod_dav: https://httpd.apache.org/docs/current/mod/mod_dav.html [dcab865c]
- .. admonition:: Using Apache 2.2+ with authentication [e8e5192a]
- .. code-block:: apache [1e18959e4cc41bff-2]
- .. code-block:: apache [1e18959e4cc41bff-3]
- .. code-block:: python [dfa717732ab88b73]
- .. note:: [942ae6c11625c81c-4]
- ============================================================== How to authenticate against Django's user database from Apache ============================================================== [8e4176bb]
- Authentication with ``mod_wsgi`` ================================ [d4f80b3a]

## Beyond the budget

13 more facts did not fit in the budget: [7494fac1] [2ad1a693] [25020f0e] [e28172fe] [ecc3e5c2] [a976f5b8] [2b048780] [1ff40874] [c7bc954e] [7949551e] [922fcbc8] [e91a8e26] [dc40f805]
