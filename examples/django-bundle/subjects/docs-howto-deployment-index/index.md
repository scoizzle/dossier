# docs/howto/deployment/index

- Subject: docs/howto/deployment/index (id `6ea35067-4ac8-44a9-b4a9-b302bd1c2530`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 545 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- wsgi/index asgi/index checklist [79d97fd9]
- * `ASGI`_ is the new, asynchronous-friendly standard that will allow your Django site to use asynchronous Python features, and asynchronous Django features as they are developed. [4413f9cb]
- * `WSGI`_ is the main Python standard for communicating between web servers and applications, but it only supports synchronous code. [8510294a]
- .. _WSGI: https://wsgi.readthedocs.io/en/latest/ .. _ASGI: https://asgi.readthedocs.io/en/latest/ [0f1ace45]
- .. toctree:: :maxdepth: 2 [13f532897bf9e689-2]
- ==================== How to deploy Django ==================== [978bff83]
- Django currently supports two interfaces: WSGI and ASGI. [0bd30c84]
- Django is full of shortcuts to make web developers' lives easier, but all those tools are of no use if you can't easily deploy your sites. Since Django's inception, ease of deployment has been a major goal. [07e6c6eb]
- Django, being a web framework, needs a web server in order to operate. And since most web servers don't natively speak Python, we need an interface to make that communication happen. The :djadmin:`runserver` command starts a lightweight development server, which is not suitable for production. [bfc16664]
- Finally, before you deploy your application to production, you should run through our :doc:`deployment checklist </howto/deployment/checklist>` to ensure that your configurations are suitable. [b7ead114]
- There are many options for deploying your Django application, based on your architecture or your particular business needs, but that discussion is outside the scope of what Django can give you as guidance. [d62bf7fa]
- You should also consider how you will handle :doc:`static files </howto/static-files/deployment>` for your application, and how to handle :doc:`error reporting</howto/error-reporting>`. [5cc0bfdc]
