# docs/howto/deployment/wsgi/index

- Subject: docs/howto/deployment/wsgi/index (id `eea2a2b4-b74b-4794-a891-f030b2f0e80c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1027 tokens
- Facts shown: 24 of 24
- Conflicts: 0
- Gaps: 0

## Highlights

- Since environment variables are process-wide, this doesn't work when you run multiple Django sites in the same process. This happens with mod_wsgi. [9a7408d9]
- To avoid this problem, use mod_wsgi's daemon mode with each site in its own daemon process, or override the value from the environment by enforcing ``os.environ["DJANGO_SETTINGS_MODULE"] = "mysite.settings"`` in your :file:`wsgi.py`. [31d129b0]
- application = HelloWorldApplication(application) [d3305bba]
- from helloworld.wsgi import HelloWorldApplication [ca58a7e8]
- granian gunicorn uwsgi modwsgi apache-auth [4e547237]
- .. _WSGI: https://wsgi.readthedocs.io/en/latest/ [54be1072bdafdbaa]
- .. note:: [942ae6c11625c81c-5]
- .. toctree:: :maxdepth: 1 [2237daa5fedafa78-2]
- ======================= How to deploy with WSGI ======================= [8f44ca43]
- Applying WSGI middleware ======================== [cbf620b5]
- Configuring the settings module =============================== [b932520826c1e82f-2]
- Django includes getting-started documentation for the following WSGI servers: [55856026]
- Django uses the :envvar:`DJANGO_SETTINGS_MODULE` environment variable to locate the appropriate settings module. It must contain the dotted path to the settings module. You can use a different value for development and production; it all depends on how you organize your settings. [d858574c98736ab8-2]
- Django's :djadmin:`startproject` management command sets up a minimal default WSGI configuration for you, which you can tweak as needed for your project, and direct any WSGI-compliant application server to use. [128f1afe]
- Django's primary deployment platform is WSGI_, the Python standard for web servers and applications. [a4d96fe2]
- If this variable isn't set, the default :file:`wsgi.py` sets it to ``mysite.settings``, where ``mysite`` is the name of your project. That's how :djadmin:`runserver` discovers the default settings file by default. [f21ea3a8]
- It's used both by Django's development server and in production WSGI deployments. [57ee7df7]
- The :djadmin:`startproject` command creates a file :file:`<project_name>/wsgi.py` that contains such an ``application`` callable. [5785e38e]
- The ``application`` object ========================== [ce64a33ae6dc1c9c-2]
- The key concept of deploying with WSGI is the ``application`` callable which the application server uses to communicate with your code. It's commonly provided as an object named ``application`` in a Python module accessible to the server. [2180a486]
- To apply :pep:`WSGI middleware <3333#middleware-components-that-play-both-sides>` you can wrap the application object. For instance you could add these lines at the bottom of :file:`wsgi.py`:: [1055a78c]
- When the WSGI server loads your application, Django needs to import the settings module — that's where your entire application is defined. [5d949fdf]

## All facts

- [9f0c4b59] WSGI servers obtain the path to the ``application`` callable from their configuration. Django's built-in server, namely the :djadmin:`runserver` command, reads it from the :setting:`WSGI_APPLICATION` setting. By default, it's set to ``<project_name>.wsgi.application``, which points to the ``application`` callable in :file:`<project_name>/wsgi.py`.
- [37163efd] You could also replace the Django WSGI application with a custom WSGI application that later delegates to the Django WSGI application, if you want to combine a Django application with a WSGI application of another framework.
