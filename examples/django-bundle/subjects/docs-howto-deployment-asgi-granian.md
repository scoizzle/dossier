# docs/howto/deployment/asgi/granian

- Subject: docs/howto/deployment/asgi/granian (id `34eef962-2640-4791-bfcc-bca1e7c4a87c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 438 tokens
- Facts shown: 14 of 14
- Conflicts: 0
- Gaps: 0

## Facts

- granian myproject.asgi:application --interface asgi [a17ec37b]
- python -m pip install granian [91cecfceb8b06e10]
- .. _Granian: https://github.com/emmett-framework/granian [3d68eea4c1765924]
- .. code-block:: shell [8aa7203c166b13be-3]
- .. code-block:: shell [8aa7203c166b13be-4]
- ============================== How to use Django with Granian ============================== [6826eb95df973ceb]
- For a typical Django project, invoking Granian would look like: [6cc847a1f31001ff]
- For more advanced usage, please read the `Granian documentation <Granian_>`_. [b1ce3a2ee6a277e9]
- Granian_ is a Rust-based high-performance HTTP server for Python applications, supporting ASGI and WSGI interfaces. [ee8736c6d8c95426]
- Installing Granian ================== [b0affcc7a9ababe6]
- Running Django in Granian ========================= [7c2cc7b0512be679]
- This will start one process listening on ``127.0.0.1:8000``. It requires that your project be on the Python path; to ensure that, run this command from the same directory as your ``manage.py`` file. [16bb3c319ea90534]
- When Granian is installed, a ``granian`` command is available which runs ASGI applications. Granian needs to be called with the location of a module containing an ASGI application object, followed by what the application is called (separated by a colon), using the ``--interface asgi`` option. [37ab7396]
- You can install Granian with ``pip``: [06b1490fa10f7ffa]
