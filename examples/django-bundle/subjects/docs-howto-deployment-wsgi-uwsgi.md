# docs/howto/deployment/wsgi/uwsgi

- Subject: docs/howto/deployment/wsgi/uwsgi (id `1ef94f54-25f4-47ac-9ce6-b6054ad56d59`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 24 of 35
- Conflicts: 0
- Gaps: 0

## Facts

- env = LANG=en_US.UTF-8 [d2048346]
- # Install current stable version. $ python -m pip install uwsgi [cc3b3e36]
- .. _tutorial: https://uwsgi.readthedocs.io/en/latest/tutorials/Django_and_nginx.html [bb46507a]
- .. code-block:: ini [ab16e0aa61fdec9d]
- If you get a ``UnicodeEncodeError`` when uploading files with file names that contain non-ASCII characters, make sure uWSGI is configured to accept non-ASCII file names by adding this to your ``uwsgi.ini``: [5efbd032]
- See the :ref:`unicode-files` section of the Unicode reference guide for details. [a6477368d2a92fa4-2]
- The uWSGI docs offer a `tutorial`_ covering Django, nginx, and uWSGI (one possible deployment setup of many). The docs below are focused on how to integrate Django with uWSGI. [d1568b6e]
- [uwsgi] chdir=/path/to/your/project module=mysite.wsgi:application master=True pidfile=/tmp/project-master.pid vacuum=True max-requests=5000 daemonize=/var/log/uwsgi/yourproject.log [7f3ce72a]
- uwsgi --chdir=/path/to/your/project \ --module=mysite.wsgi:application \ --env DJANGO_SETTINGS_MODULE=mysite.settings \ --master --pidfile=/tmp/project-master.pid \ --socket=127.0.0.1:49152 \ # can also be a file --processes=5 \ # number of worker processes --uid=1000 --gid=2000 \ # if root, uwsgi can drop privileges --harakiri=20 \ # respawn processes taking more than 20 seconds --max-requests=5000 \ # respawn processes after serving 5000 requests --vacuum \ # clear environment on exit --home=/path/to/virtual/env \ # optional path to a virtual environment --daemonize=/var/log/uwsgi/yourproject.log # background the process [8cd1f0f9]
- uwsgi --ini uwsgi.ini [d0f4e1fa]
- * ``chdir``: The path to the directory that needs to be on Python's import path -- i.e., the directory containing the ``mysite`` package. * ``module``: The WSGI module to use -- probably the ``mysite.wsgi`` module that :djadmin:`startproject` creates. * ``env``: Should probably contain at least :envvar:`DJANGO_SETTINGS_MODULE`. * ``home``: Optional path to your project virtual environment. [6982ecce]
- .. _configuration documentation: https://uwsgi.readthedocs.io/en/latest/Configuration.html [287107ae]
- .. _installation procedures: https://uwsgi-docs.readthedocs.io/en/latest/Install.html [8d23f853]
- .. _managing the uWSGI process: https://uwsgi-docs.readthedocs.io/en/latest/Management.html [72e009c2]
- .. _uWSGI: https://uwsgi-docs.readthedocs.io/ [299a49e4]
- .. admonition:: Fixing ``UnicodeEncodeError`` for file uploads [4f3c18d50a4df529-2]
- .. code-block:: console [faf6f5a8efbd7831]
- .. code-block:: ini [ab16e0aa61fdec9d-2]
- .. code-block:: shell [8aa7203c166b13be-15]
- .. code-block:: shell [8aa7203c166b13be-16]
- .. seealso:: [6b4a5e54e001d097]
- ============================ How to use Django with uWSGI ============================ [e460d669]
- Configuring and starting the uWSGI server for Django ---------------------------------------------------- [57c8759e]
- uWSGI model ----------- [7e568247]

## Beyond the budget

11 more facts did not fit in the budget: [d4c253ae] [35afd56b] [9868b15c] [0fb7f393] [283a326e] [d0ee42c7] [c80c5458] [c652159d] [c731a106] [f3552a0d] [820d8ba5]
