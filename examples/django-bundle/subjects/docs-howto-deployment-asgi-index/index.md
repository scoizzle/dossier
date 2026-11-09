# docs/howto/deployment/asgi/index

- Subject: docs/howto/deployment/asgi/index (id `bfb0d745-b3cd-4c2e-b5b9-7660f4da977e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 23 of 23
- Conflicts: 0
- Gaps: 0

## Facts

- Do not call blocking synchronous functions or libraries in any async code. Django prevents you from doing this with the parts of Django that are not async-safe, but the same may not be true of third-party apps or Python libraries. [ef14cd8e]
- While Django's default ASGI handler will run all your code in a synchronous thread, if you choose to run your own async handler you must be aware of async-safety. [7ed89ec3]
- application = AmazingMiddleware(application) [c575519d]
- from some_asgi_library import AmazingMiddleware [f0c2286c]
- daphne granian hypercorn uvicorn [4e8bdfaf]
- .. _ASGI: https://asgi.readthedocs.io/en/latest/ [60cf8473]
- .. toctree:: :maxdepth: 1 [2237daa5fedafa78]
- .. warning:: [c54b54cb0805732a-4]
- ======================= How to deploy with ASGI ======================= [9856b9af]
- ASGI servers usually take the path to the application callable as a string; for most Django projects, this will look like ``myproject.asgi:application``. [c38dd01f]
- Applying ASGI middleware ======================== [058449ae]
- As well as WSGI, Django also supports deploying on ASGI_, the emerging Python standard for asynchronous web servers and applications. [8b5bd036]
- Configuring the settings module =============================== [b932520826c1e82f]
- Django includes getting-started documentation for the following ASGI servers: [cf4ddd50]
- Django uses the :envvar:`DJANGO_SETTINGS_MODULE` environment variable to locate the appropriate settings module. It must contain the dotted path to the settings module. You can use a different value for development and production; it all depends on how you organize your settings. [d858574c98736ab8]
- Django's :djadmin:`startproject` management command sets up a default ASGI configuration for you, which you can tweak as needed for your project, and direct any ASGI-compliant application server to use. [b4a26eea]
- If this variable isn't set, the default :file:`asgi.py` sets it to ``mysite.settings``, where ``mysite`` is the name of your project. [b988b9ea]
- It's not used by the development server (``runserver``), but can be used by any ASGI server either in development or in production. [ec58c564]
- Like WSGI, ASGI has you supply an ``application`` callable which the application server uses to communicate with your code. It's commonly provided as an object named ``application`` in a Python module accessible to the server. [7cfaca97]
- The :djadmin:`startproject` command creates a file :file:`<project_name>/asgi.py` that contains such an ``application`` callable. [d8d1f888]
- The ``application`` object ========================== [ce64a33ae6dc1c9c]
- To apply ASGI middleware, or to embed Django in another ASGI application, you can wrap Django's ``application`` object in the ``asgi.py`` file. For example:: [0fb91158]
- When the ASGI server loads your application, Django needs to import the settings module — that's where your entire application is defined. [2ef00070]
