# docs/intro/tutorial01

- Subject: docs/intro/tutorial01 (id `78ed0554-d8ce-414e-a372-a95a0d591b72`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 23 of 91
- Conflicts: 0
- Gaps: 0

## Facts

- $ python -m django --version [c0d0c013]
- $ python manage.py startapp polls [88dbfd94]
- If you get an error page here, check that you're going to http://localhost:8000/polls/ and not http://localhost:8000/. [d1a2c9e7]
- If you're having trouble going through this tutorial, please head over to the :doc:`Getting Help</faq/help>` section of the FAQ. [eff105796d7d4d6a]
- Performing system checks... [1aa8cc64]
- System check identified no issues (0 silenced). [97612504]
- The development server automatically reloads Python code for each request as needed. You don't need to restart the server for code changes to take effect. However, some actions like adding files don't trigger a restart, so you'll have to restart the server in these cases. [a1201711]
- WARNING: This is a development server. Do not use it in a production setting. Use a production WSGI or ASGI server instead. For more information on production servers see: https://docs.djangoproject.com/en/|version|/howto/deployment/ [656fe31e172006d5]
- What's the difference between a project and an app? An app is a web application that does something -- e.g., a blog system, a database of public records or a small poll app. A project is a collection of configuration and apps for a particular website. A project can contain multiple apps. An app can be in multiple projects. [0637d861]
- You have unapplied migrations; your app may not work properly until they are applied. Run 'python manage.py migrate' to apply them. [472ed64d]
- You should always use ``include()`` when you include other URL patterns. The only exception is ``admin.site.urls``, which is a pre-built URLconf provided by Django for the default admin site. [c9467858]
- You'll need to avoid naming projects after built-in Python or Django components. In particular, this means you should avoid using names like ``django`` (which will conflict with Django itself) or ``test`` (which conflicts with a built-in Python package). [7a9accbf]
- def index(request): return HttpResponse("Hello, world. You're at the polls index.") [5b9bac90]
- djangotutorial/ manage.py mysite/ __init__.py settings.py urls.py asgi.py wsgi.py [eec93658]
- from . import views [c00926fe3424edad-2]
- from django.contrib import admin from django.urls import include, path [3aa91c069f17dcf2]
- from django.http import HttpResponse [c672e2c6d47dd35c]
- from django.urls import path [c537d1941a7e3025-2]
- polls/ __init__.py admin.py apps.py migrations/ __init__.py models.py tests.py urls.py views.py [8193f8ce]
- urlpatterns = [ path("", views.index, name="index"), ] [9c081e49]
- urlpatterns = [ path("polls/", include("polls.urls")), path("admin/", admin.site.urls), ] [e920bfe4]
- |today| - 15:50:53 Django version |version|, using settings 'mysite.settings' Starting development server at http://127.0.0.1:8000/ Quit the server with CONTROL-C. [7feace5d]
- $ django-admin startproject mysite djangotutorial [67dfad41]

## Beyond the budget

65 more facts did not fit in the budget: [46c9a5006c713d0c] [12abaf36] [48701711] [c04d39ba] [0fdc81d7] [55d04ee7] [46cf4fb8] [88259420] [04fbb5eb] [57c8129f] [81543381] [b8950d77] [1d1154a6] [dbb2ef17dd903b2b-2] [dfc99ccd] [5c9a4d2d821e33d5] [d59bf1960628576c] [3a9340cd0d877339-10] [3a9340cd0d877339-11] [3a9340cd0d877339-12] [7714e199aac2701e-66] [7714e199aac2701e-67] [7714e199aac2701e-68] [7714e199aac2701e-69] [7714e199aac2701e-70] [942ae6c11625c81c-20] [d17c070d] [3cb0eef97def623a-3] [fab0712f] [27c825fe] [8d6c7e85] [da0c17d5] [a837fdee] [604e1187] [f8fc7262] [3e99c22c] [96b70aad] [94abd339] [1194b4f6] [470761fc] [da8d9ff3] [96bb12cb] [bf978955] [a22a6654] [884c830d] [fe1d8fe7] [92beda0c] [40ea635d] [d37fc7ce] [819c964e] [9ff4a3c2] [270ba926] [e18eb4a9] [588588d0] [d8ac6556] [ad1f40a1] [bb7fdbdb] [515f9a1d] [cad8bad1] [2acdc022] [fbc6644f] [f9946af4] [b538b363] [6a39483c] [0e96e64d]
