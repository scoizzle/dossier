# docs/howto/deployment/wsgi/apache-auth

- Subject: docs/howto/deployment/wsgi/apache-auth (id `8f8604e6-24d2-4682-81e5-a6a33dd064dd`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1605 tokens
- Facts shown: 40 of 42
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [7494fac1] .. note:: If you have installed a :ref:`custom user model <auth-custom-user>` and want to use this default auth handler, it must support an ``is_active`` attribute. If you want to use group based authorization, your custom user must have a relation named 'groups', referring to a related object that has a 'name' field. You can also specify your own custom mod_wsgi auth handler if your custom cannot conform to these requirements.
- [2ad1a693] Authorization with ``mod_wsgi`` and Django groups -------------------------------------------------
- [25020f0e] Finally, edit your WSGI script ``mysite.wsgi`` to tie Apache's authentication to your site's authentication mechanisms by importing the ``check_password`` function::
- [e28172fe] In this case, the Apache configuration should look like this:
- [ecc3e5c2] Make sure that mod_wsgi is installed and activated and that you have followed the steps to set up :doc:`Apache with mod_wsgi </howto/deployment/wsgi/modwsgi>`.
- [a976f5b8] Next, edit your Apache configuration to add a location that you want only authenticated users to be able to view:
- [2b048780] Requests beginning with ``/secret/`` will now require a user to authenticate.
- [1ff40874] Requests for ``/secret/`` will now also require user to be a member of the "secret-agents" group.
- [c7bc954e] Since keeping multiple authentication databases in sync is a common problem when dealing with Apache, you can configure Apache to authenticate against Django's :doc:`authentication system </topics/auth/index>` directly. This requires Apache version >= 2.2 and ``mod_wsgi`` >= 2.0. For example, you could:
- [7949551e] The ``WSGIAuthUserScript`` directive tells mod_wsgi to execute the ``check_password`` function in specified wsgi script, passing the user name and password that it receives from the prompt. In this example, the ``WSGIAuthUserScript`` is the same as the ``WSGIScriptAlias`` that defines your application :doc:`that is created by django-admin startproject </howto/deployment/wsgi/index>`.
- [922fcbc8] The mod_wsgi `access control mechanisms documentation`_ provides additional details and information about alternative methods of authentication.
- [e91a8e26] To support the ``WSGIAuthGroupScript`` directive, the same WSGI script ``mysite.wsgi`` must also import the ``groups_for_user`` function which returns a list of groups the given user belongs to.
- [dc40f805] mod_wsgi also provides functionality to restrict a particular location to members of a group.
