# docs/faq/usage

- Subject: docs/faq/usage (id `254280f9-d610-4bba-92ab-dc705223909d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 18 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- #. Add the :class:`~django.db.models.FileField` or :class:`~django.db.models.ImageField` to your model, defining the :attr:`~django.db.models.FileField.upload_to` option to specify a subdirectory of :setting:`MEDIA_ROOT` to use for uploaded files. [ef876104]
- #. All that will be stored in your database is a path to the file (relative to :setting:`MEDIA_ROOT`). You'll most likely want to use the convenience :attr:`~django.db.models.fields.files.FieldFile.url` attribute provided by Django. For example, if your :class:`~django.db.models.ImageField` is called ``mug_shot``, you can get the absolute path to your image in a template with ``{{ object.mug_shot.url }}``. [eace47c0]
- #. In your settings file, you'll need to define :setting:`MEDIA_ROOT` as the full path to a directory where you'd like Django to store uploaded files. (For performance, these files are not stored in the database.) Define :setting:`MEDIA_URL` as the base public URL of that directory. Make sure that this directory is writable by the web server's user account. [7546234d884fd995]
- * Said module is on ``sys.path`` (``import mysite.settings`` should work). [a19fc886]
- * The environment variable :envvar:`DJANGO_SETTINGS_MODULE` is set to a fully-qualified Python module (i.e. ``mysite.settings``). [ce023f9f]
- * The module doesn't contain syntax errors. [1b65a6f8]
- ================= FAQ: Using Django ================= [246ec1d4]
- Do I have to use your model/database layer? =========================================== [889a0c5f]
- How do I make a variable available to all my templates? ======================================================= [03c49a18]
- How do I use image and file fields? =================================== [de91af1f]
- I can't stand your template language. Do I have to use it? ========================================================== [c2589a84]
- Make sure that: [9b8fee35]
- Nope. Just like the template system, the model/database layer is decoupled from the rest of the framework. [8f3129f5]
- Sometimes your templates all need the same thing. A common example would be dynamically generated menus. At first glance, it seems logical to add a common dictionary to the template context. [96e51bf3]
- The best way to do this in Django is to use a ``RequestContext``. Details on how to do this are here: :ref:`subclassing-context-requestcontext`. [e459f120]
- The one exception is: If you use a different database library, you won't get to use Django's automatically-generated admin site. That app is coupled to the Django database layer. [6e89c79c]
- Using a :class:`~django.db.models.FileField` or an :class:`~django.db.models.ImageField` in a model takes a few steps: [2270824e]
- We happen to think our template engine is the best thing since chunky bacon, but we recognize that choosing a template language runs close to religion. There's nothing about Django that requires using the template language, so if you're attached to Jinja2, Mako, or whatever, feel free to use those. [35713bf0]

## Beyond the budget

1 more facts did not fit in the budget: [11a82584]
