# docs/howto/deployment/asgi/hypercorn

- Subject: docs/howto/deployment/asgi/hypercorn (id `a50ec734-af06-41f4-8560-92a58714dc33`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 430 tokens
- Facts shown: 14 facts
- Conflicts: 0
- Gaps: 0

## Facts

- hypercorn myproject.asgi:application [fabece8a]
- python -m pip install hypercorn [6f497255]
- .. _Hypercorn: https://hypercorn.readthedocs.io/ [38e895f2]
- .. code-block:: shell [8aa7203c166b13be-5]
- .. code-block:: shell [8aa7203c166b13be-6]
- ================================ How to use Django with Hypercorn ================================ [6e0c9b6a]
- For a typical Django project, invoking Hypercorn would look like: [3cd7724b]
- For more advanced usage, please read the `Hypercorn documentation <Hypercorn_>`_. [5618799f]
- Hypercorn_ is an ASGI server that supports HTTP/1, HTTP/2, and HTTP/3 with an emphasis on protocol support. [4496b9c7]
- Installing Hypercorn ==================== [45e28e59]
- Running Django in Hypercorn =========================== [4bff9188]
- This will start one process listening on ``127.0.0.1:8000``. It requires that your project be on the Python path; to ensure that run this command from the same directory as your ``manage.py`` file. [fe88b36b039e3e09-2]
- When :pypi:`Hypercorn` is installed, a ``hypercorn`` command is available which runs ASGI applications. Hypercorn needs to be called with the location of a module containing an ASGI application object, followed by what the application is called (separated by a colon). [33371c6c]
- You can install Hypercorn with ``pip``: [b6143496]
