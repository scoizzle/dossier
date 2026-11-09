# docs/howto/deployment/wsgi/modwsgi

- Subject: docs/howto/deployment/wsgi/modwsgi (id `69dd819b-7a5d-4cfd-bd89-25cc2b5a8624`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 24 of 71
- Conflicts: 0
- Gaps: 0

## Facts

- WSGIDaemonProcess example.com lang='en_US.UTF-8' locale='en_US.UTF-8' [d5c170e0]
- export LANG='en_US.UTF-8' export LC_ALL='en_US.UTF-8' [6ac6d180]
- os.environ.setdefault("DJANGO_SETTINGS_MODULE", "{{ project_name }}.settings") [09865886]
- .. code-block:: shell [8aa7203c166b13be-14]
- .. code-block:: text [3a9340cd0d877339-4]
- <Directory /path/to/mysite.com/media> Require all granted </Directory> [8772f1b1]
- <Directory /path/to/mysite.com/mysite> <Files wsgi.py> Require all granted </Files> </Directory> [641e6993571cd81b]
- <Directory /path/to/mysite.com/static> Require all granted </Directory> [80a0f316]
- A common location to put this configuration is ``/etc/apache2/envvars``. [4a517fdb]
- Alias /media/ /path/to/mysite.com/media/ Alias /static/ /path/to/mysite.com/static/ [09a2bb87]
- Alias /robots.txt /path/to/mysite.com/static/robots.txt Alias /favicon.ico /path/to/mysite.com/static/favicon.ico [c0505b71]
- Alternatively, if you are :ref:`using mod_wsgi daemon mode<daemon-mode>` you can add ``lang`` and ``locale`` options to the ``WSGIDaemonProcess`` directive: [d9a2afe9]
- If multiple Django sites are run in a single mod_wsgi process, all of them will use the settings of whichever one happens to run first. This can be solved by changing:: [869d14d6]
- If you get a ``UnicodeEncodeError`` when uploading or writing files with file names or content that contains non-ASCII characters, make sure Apache is configured to support UTF-8 encoding: [4397faec]
- See the :ref:`unicode-files` section of the Unicode reference guide for details. [a6477368d2a92fa4]
- WSGIDaemonProcess example.com python-home=/path/to/venv python-path=/path/to/mysite.com WSGIProcessGroup example.com [78b04da6]
- WSGIScriptAlias / /path/to/mysite.com/mysite/wsgi.py [b252bc2a3a786de2-2]
- WSGIScriptAlias / /path/to/mysite.com/mysite/wsgi.py WSGIPythonHome /path/to/venv WSGIPythonPath /path/to/mysite.com [ab38adca]
- WSGIScriptAlias /mysite /path/to/mysite.com/mysite/wsgi.py process-group=example.com [1047d726]
- in ``wsgi.py``, to:: [5b3a1d5e]
- or by :ref:`using mod_wsgi daemon mode<daemon-mode>` and ensuring that each site runs in its own daemon process. [9b6f6e86]
- "Daemon mode" is the recommended mode for running mod_wsgi (on non-Windows platforms). To create the required daemon process group and delegate the Django instance to run in it, you will need to add appropriate ``WSGIDaemonProcess`` and ``WSGIProcessGroup`` directives. A further change required to the above configuration if you use daemon mode is that you can't use ``WSGIPythonPath``; instead you should use the ``python-path`` option to ``WSGIDaemonProcess``, for example: [68c5a8ee]
- * Nginx_ * A stripped-down version of Apache_ [ac3f6c4228e684da]
- .. More details on configuring a mod_wsgi site to serve static files can be found .. in the mod_wsgi documentation on `hosting static files`_. [78cb1b3c]

## Beyond the budget

44 more facts did not fit in the budget: [3fb9ff93] [7334fd784939ff19] [54be1072bdafdbaa-2] [1f50f65c] [1399f262] [4051c526] [0d7c5567] [3bae6125] [4545541a] [103eec0e] [e8935729] [4f3c18d50a4df529] [1e18959e4cc41bff-4] [1e18959e4cc41bff-5] [1e18959e4cc41bff-6] [1e18959e4cc41bff-7] [c54b54cb0805732a-5] [7493f727] [26308161] [57198abc] [c31de609] [aed2091d] [8baab1d1] [94fe3268] [fc3d7116] [4dc57bdb] [891596de] [e158382f] [d06907da] [bca76ee6] [83e3aec8] [fde2c20c] [42fef4dc] [d8ed003f] [1b54b36a] [c4f2903f] [002dd209] [03982f10] [558da8bb] [3df37499] [690da821] [d976d27d] [5e237043] [7ec8f149]
