# docs/howto/deployment/wsgi/gunicorn

- Subject: docs/howto/deployment/wsgi/gunicorn (id `e0ce51b5-8b3d-4a84-8b38-68f794e51466`)
- Kind: subject
- Budget: 1200 tokens
- Used: 459 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- gunicorn myproject.wsgi [fe4e8ead]
- .. _Gunicorn: https://gunicorn.org/ [a1372650]
- .. _deployment documentation: https://gunicorn.org/deploy/ [1ae24085]
- .. _gunicorn documentation: https://gunicorn.org/ [7d1d248d]
- .. code-block:: shell [8aa7203c166b13be-13]
- =============================== How to use Django with Gunicorn =============================== [4a57f17f]
- Gunicorn_ ('Green Unicorn') is a pure-Python WSGI server for UNIX. It has no dependencies and can be installed using ``pip``. [c0b8b67c]
- Install gunicorn by running ``python -m pip install gunicorn``. For more details, see the `gunicorn documentation`_. [340ddbe1]
- Installing Gunicorn =================== [05add3d4]
- Running Django in Gunicorn as a generic WSGI application ======================================================== [ffa449fe]
- See Gunicorn's `deployment documentation`_ for additional tips. [27d0f188]
- This will start one process running one thread listening on ``127.0.0.1:8000``. It requires that your project be on the Python path; the simplest way to ensure that is to run this command from the same directory as your ``manage.py`` file. [11c46408]
- When Gunicorn is installed, a ``gunicorn`` command is available which starts the Gunicorn server process. The simplest invocation of gunicorn is to pass the location of a module containing a WSGI application object named ``application``, which for a typical Django project would look like: [a1bc70e6]
