# docs/howto/deployment/asgi/uvicorn

- Subject: docs/howto/deployment/asgi/uvicorn (id `24cf6156-56ec-4e78-a9e3-122887e6a61e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 683 tokens
- Facts shown: 23 of 23
- Conflicts: 0
- Gaps: 0

## Facts

- python -m gunicorn myproject.asgi:application -k uvicorn_worker.UvicornWorker [02eef531]
- python -m pip install uvicorn [9cee188f]
- python -m pip install uvicorn uvicorn-worker gunicorn [ee974a94]
- python -m uvicorn myproject.asgi:application [574d5e7a]
- .. _Uvicorn: https://www.uvicorn.dev/ .. _Gunicorn: https://gunicorn.org/ [837d3a23]
- .. code-block:: shell [8aa7203c166b13be-7]
- .. code-block:: shell [8aa7203c166b13be-8]
- .. code-block:: shell [8aa7203c166b13be-9]
- .. code-block:: shell [8aa7203c166b13be-10]
- ============================== How to use Django with Uvicorn ============================== [d20029d4]
- Deploying Django using Uvicorn and Gunicorn =========================================== [9d23d0fb]
- For a typical Django project, invoking Uvicorn would look like: [83cc6500]
- For more advanced usage, please read the `Uvicorn documentation <Uvicorn_>`_. [77ecf135]
- Gunicorn_ is a robust web server that implements process monitoring and automatic restarts. This can be useful when running Uvicorn in a production environment. [c0436532]
- In development mode, you can add ``--reload`` to cause the server to reload any time a file is changed on disk. [e574e6bb]
- Installing Uvicorn ================== [33bd01f5]
- Running Django in Uvicorn ========================= [6ef48bb8]
- Then start Gunicorn using the Uvicorn worker class like this: [3dcfb172]
- This will start one process listening on ``127.0.0.1:8000``. It requires that your project be on the Python path; to ensure that run this command from the same directory as your ``manage.py`` file. [fe88b36b039e3e09-3]
- To install Uvicorn and Gunicorn, use the following: [a54bec8d]
- Uvicorn_ is an ASGI server based on ``uvloop`` and ``httptools``, with an emphasis on speed. [e9c95e25]
- When Uvicorn is installed, a ``uvicorn`` command is available which runs ASGI applications. Uvicorn needs to be called with the location of a module containing an ASGI application object, followed by what the application is called (separated by a colon). [d816f375]
- You can install Uvicorn with ``pip``: [d33734be]
