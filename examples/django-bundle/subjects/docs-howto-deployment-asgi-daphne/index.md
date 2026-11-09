# docs/howto/deployment/asgi/daphne

- Subject: docs/howto/deployment/asgi/daphne (id `3f40b22e-c51a-4ef4-a127-3118ddb46bda`)
- Kind: subject
- Budget: 1200 tokens
- Used: 553 tokens
- Facts shown: 18 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- ASGI_APPLICATION = "myproject.asgi.application" [f2b3ca67]
- INSTALLED_APPS = [ "daphne", ..., ] [5af7d948]
- daphne myproject.asgi:application [4029664a]
- python -m pip install daphne [a0f3b1a1]
- .. _daphne-runserver: [bcf82bec]
- .. code-block:: shell [8aa7203c166b13be]
- .. code-block:: shell [8aa7203c166b13be-2]
- :pypi:`Daphne <daphne>` is a pure-Python ASGI server for UNIX, maintained by members of the Django project. It acts as the reference server for ASGI. [45e01291]
- ============================= How to use Django with Daphne ============================= [af1209fb]
- Daphne provides a :djadmin:`runserver` command to serve your site under ASGI during development. [1f864203]
- For a typical Django project, invoking Daphne would look like: [22e53f59]
- Installing Daphne =================== [a08b5c53]
- Integration with ``runserver`` ============================== [8fe62b32]
- Running Django in Daphne ======================== [778cfd95]
- This can be enabled by adding ``daphne`` to the start of your :setting:`INSTALLED_APPS` and adding an ``ASGI_APPLICATION`` setting pointing to your ASGI application object:: [0af6c763]
- This will start one process listening on ``127.0.0.1:8000``. It requires that your project be on the Python path; to ensure that run this command from the same directory as your ``manage.py`` file. [fe88b36b039e3e09]
- When Daphne is installed, a ``daphne`` command is available which starts the Daphne server process. At its simplest, Daphne needs to be called with the location of a module containing an ASGI application object, followed by what the application is called (separated by a colon). [b5f6db5f]
- You can install Daphne with ``pip``: [4e46003e]
