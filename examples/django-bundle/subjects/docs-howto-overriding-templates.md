# docs/howto/overriding-templates

- Subject: docs/howto/overriding-templates (id `e5cfd2d5-4e9e-4081-a222-fee139cd6007`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 25 of 35
- Conflicts: 0
- Gaps: 0

## Facts

- BASE_DIR = Path(__file__).resolve().parent.parent [5c820c09]
- INSTALLED_APPS = [ ..., "blog", ..., ] [0ca4f8cf]
- TEMPLATES = [ { "BACKEND": "django.template.backends.django.DjangoTemplates", "DIRS": [BASE_DIR / "templates"], "APP_DIRS": True, # ... }, ] [c0a52139]
- TEMPLATES = [ { # ... "APP_DIRS": True, # ... }, ] [304c7c9c]
- from pathlib import Path [ae4c89fe]
- myapp/ templates/ blog/ list.html post.html [0678ef2c]
- templates/ blog/ list.html post.html [f821b7d3]
- {% block branding %} <img src="link/to/logo.png" alt="logo"> {{ block.super }} {% endblock %} [527d1010]
- {% extends "admin/base_site.html" %} [92c13913]
- Read :ref:`overriding-built-in-widget-templates` if you're looking to do that. [ccce63d2]
- * The example creates a file at ``templates/admin/base_site.html`` that uses the configured project-level ``templates`` directory to override ``admin/base_site.html``. * The new template extends ``admin/base_site.html``, which is the same template as is being overridden. * The template replaces just the ``branding`` block, adding a custom logo, and using ``block.super`` to retain the prior content. * The rest of the template is inherited unchanged from ``admin/base_site.html``. [5a15b0eb]
- .. _extending_an_overridden_template: [3728feb6]
- .. code-block:: html+django :caption: ``templates/admin/base_site.html`` [1680087e]
- .. code-block:: none [591022f6b117516e]
- .. code-block:: none [591022f6b117516e-2]
- .. seealso:: [6b4a5e54e001d097-9]
- ========================= How to override templates ========================= [32de9e89]
- First, make sure your template settings are checking inside app directories:: [2cca548b]
- First, we'll explore overriding templates by creating replacement templates in your project's templates directory. [14816c7e]
- For example, you can use this technique to add a custom logo to the ``admin/base_site.html`` template: [299829ce]
- If you have app and project templates directories that both contain overrides, the default Django template loader will try to load the template from the project-level directory first. In other words, :setting:`DIRS <TEMPLATES-DIRS>` is searched before :setting:`APP_DIRS <TEMPLATES-APP_DIRS>`. [901a85a2]
- If you want to put the template overrides in an app called ``myapp`` and the templates to override are named ``blog/list.html`` and ``blog/post.html``, then your directory structure will look like: [8cdb7df0]
- In your project, you might want to override a template in another Django application, whether it be a third-party application or a contrib application such as ``django.contrib.admin``. You can either put template overrides in your project's templates directory or in an application's templates directory. [b049fa84]
- Key points to note: [efc66e4e]
- Overriding from an app's template directory =========================================== [0a4471c0]

## Beyond the budget

9 more facts did not fit in the budget: [e65b5dc0] [48630b3b] [409e595e] [cf81c818] [b5df9ed5] [da7995b7] [5477b826] [fad6a46d] [80824bde]
