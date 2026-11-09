# docs/howto/overriding-templates

- Subject: docs/howto/overriding-templates (id `159b38fc-6611-4736-88a9-41fe6fc96c4c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1475 tokens
- Facts shown: 34 of 35
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [e65b5dc0] Let's say you're trying to override the templates for a third-party application called ``blog``, which provides the templates ``blog/post.html`` and ``blog/list.html``. The relevant settings for your project would look like::
- [48630b3b] Overriding from the project's templates directory =================================================
- [409e595e] Since you're overriding templates located outside of one of your project's apps, it's more common to use the first method and put template overrides in a project's templates folder. If you prefer, however, it's also possible to put the overrides in an app's template directory.
- [cf81c818] The :setting:`TEMPLATES` setting and ``BASE_DIR`` will already exist if you created your project using the default project template. The setting that needs to be modified is :setting:`DIRS<TEMPLATES-DIRS>`.
- [b5df9ed5] The template loader first looks for templates in the ``DIRS`` directory. When the views in the ``blog`` app ask for the ``blog/post.html`` and ``blog/list.html`` templates, the loader will return the files you just created.
- [da7995b7] These settings assume you have a ``templates`` directory in the root of your project. To override the templates for the ``blog`` app, create a folder in the ``templates`` directory, and add the template files to that folder:
- [5477b826] This technique works because the template loader does not consider the already loaded override template (at ``templates/admin/base_site.html``) when resolving the ``extends`` tag. Combined with ``block.super`` it is a powerful technique to make small customizations.
- [fad6a46d] With :setting:`APP_DIRS<TEMPLATES-APP_DIRS>` set to ``True``, the template loader will look in the app's templates directory and find the templates.
- [80824bde] With your template loaders configured, you can extend a template using the :ttag:`{% extends %}<extends>` template tag whilst at the same time overriding it. This can allow you to make small customizations without needing to reimplement the entire template.
