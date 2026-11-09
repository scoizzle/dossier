# docs/intro/reusable-apps

- Subject: docs/intro/reusable-apps (id `a2ced6bb-d541-4603-8e0d-f2b91d4ad8c5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 21 of 84
- Conflicts: 0
- Gaps: 0

## Facts

- INSTALLED_APPS = [ ..., "django_polls", ] [3afff1b8]
- path("polls/", include("django_polls.urls")), [74c138bd]
- intersphinx_mapping = { # ... "django": ( "https://docs.djangoproject.com/en/stable/", None, ), } [08b3d8a5]
- 1. Add "polls" to your INSTALLED_APPS setting like this:: [49351e6f]
- 2. Include the polls URLconf in your project urls.py like this:: [3621ef18]
- 3. Run ``python manage.py migrate`` to create the models. [95d908d0]
- 4. Start the development server and visit the admin to create a poll. [2e9e61f6]
- 5. Visit the ``/polls/`` URL to participate in the poll. [9e9ac0b7]
- ============ django-polls ============ [39dc5e87]
- Application labels (that is, the final part of the dotted path to application packages) *must* be unique in :setting:`INSTALLED_APPS`. Avoid using the same label as any of the Django :doc:`contrib packages </ref/contrib/index>`, for example ``auth``, ``admin``, or ``messages``. [c60425a0]
- Detailed documentation is in the "docs" directory. [df27035c]
- Quick start ----------- [05fa9729]
- When choosing a name for your package, check PyPI to avoid naming conflicts with existing packages. We recommend using a ``django-`` prefix for package names, to identify your package as specific to Django, and a corresponding ``django_`` prefix for your module name. For example, the ``django-ratelimit`` package contains the ``django_ratelimit`` module. [cf68ada1]
- [build-system] requires = ["setuptools>83"] build-backend = "setuptools.build_meta" [85bd86b3]
- [project.urls] Homepage = "https://www.example.com/" [0d10f874]
- [project] name = "django-polls" version = "0.1" dependencies = [ "django>=X.Y", # Replace "X.Y" as appropriate ] description = "A Django app to conduct web-based polls." readme = "README.rst" license = "BSD-3-Clause" requires-python = ">= 3.12" authors = [ {name = "Your Name", email = "yourname@example.com"}, ] classifiers = [ "Environment :: Web Environment", "Framework :: Django", "Framework :: Django :: X.Y", # Replace "X.Y" as appropriate "Intended Audience :: Developers", "Operating System :: OS Independent", "Programming Language :: Python", "Programming Language :: Python :: 3", "Programming Language :: Python :: 3 :: Only", "Programming Language :: Python :: 3.12", "Programming Language :: Python :: 3.13", "Programming Language :: Python :: 3.14", "Programming Language :: Python :: 3.15", "Topic :: Internet :: WWW/HTTP", "Topic :: Internet :: WWW/HTTP :: Dynamic Content", ] [65660d59]
- class PollsConfig(AppConfig): default_auto_field = "django.db.models.BigAutoField" name = "django_polls" label = "polls" [c3128380]
- django-polls is a Django app to conduct web-based polls. For each question, visitors can choose between a fixed number of answers. [9167d6d2]
- from django.apps import AppConfig [d4833f4a34e10657]
- python -m pip install --user django-polls/dist/django_polls-0.1.tar.gz [5977f02d]
- recursive-include django_polls/static * recursive-include django_polls/templates * [e48a2f5a]

## Beyond the budget

63 more facts did not fit in the budget: [6cb01735] [e425a090] [59ab91b9] [d075e539] [b91825aa] [b70cb9d2] [76b30295] [81550f46] [f34a1c8e] [8d99faff] [8aa7203c166b13be-73] [a7240724] [9346dd69] [19395c21] [5bd7dfd2] [6cd04b0e] [03285f20] [52a6f49c] [8ba814f3] [aa6fc285] [9b8446cf] [ebb64521] [6249ddda] [29b8f361] [483a1536] [0559e627] [8a4ec4f1] [3eadd37a] [5131aeb1] [3383736a] [38f8c4b4] [3af2215a] [5a23a8e6] [c4ac4575] [c2f3d9f1] [83e2c8ba] [dcdee817] [419f1614] [3c3d476e] [3a9340cd0d877339-9] [96e90c1f] [4acee594] [c7d3c8c5] [3392e7a4] [56800139] [a3ee4dfa] [934d6d94] [0dc3c201] [fca95142] [5901304b] [21ca42c7] [fda306f0] [587d2c19] [1bed9c36] [fc5d5c4c] [506058a2] [a4de774e] [9c7e7e91] [7e308b24] [2c573b61] [5f2498fa] [4e5ca330] [41a53d85]
