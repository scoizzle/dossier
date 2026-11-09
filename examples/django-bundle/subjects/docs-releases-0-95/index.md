# docs/releases/0.95

- Subject: docs/releases/0.95 (id `d76b1554-7902-42c6-823a-7203970abac8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1739 tokens
- Facts shown: 31 of 31
- Conflicts: 0
- Gaps: 0

## Highlights

- * Django now has support for managing database transactions. [2b5ef6c0]
- * Django now uses a more consistent and natural filtering interface for retrieving objects from the database. [513eba17]
- * Individual pieces of the framework now can be configured without requiring the setting of an environment variable. This permits use of, for example, the Django templating system inside other applications. [9107ac28]
- * It's now more explicit and natural to override ``save()`` and ``delete()`` methods on models, rather than needing to hook into the ``pre_save()`` and ``post_save()`` method hooks. [36d832a0]
- * It's now possible to use Django without a database. This simply means that the framework no longer requires you to have a working database set up just to serve dynamic pages. In other words, you can just use URLconfs/views on their own. Previously, the framework required that a database be configured, regardless of whether you actually used it. [12c6ba29]
- * More and more parts of the framework have been internationalized, as we've expanded internationalization (i18n) support. The Django codebase, including code and templates, has now been translated, at least in part, into 31 languages. From Arabic to Chinese to Hungarian to Welsh, it is now possible to use Django's admin site in your native language. [2c025324]
- * Some optional applications, such as the FlatPage, Sites and Redirects apps, have been decoupled and moved into ``django.contrib``. If you don't want to use these applications, you no longer have to install their database tables. [acce3742]
- * User-defined models, functions and constants now appear in the module namespace they were defined in. (Previously everything was magically transferred to the ``django.models.*`` namespace.) [f48f5ad5]
- * We've added the ability to write custom authentication and authorization backends for authenticating users against alternate systems, such as LDAP. [2d37ef39]
- * We've made it easier to add custom table-level functions to models, through a new "Manager" API. [6b315675]
- .. _Django website: https://www.djangoproject.com/ .. _django-users: https://groups.google.com/g/django-users [51398273]
- .. _Removing The Magic: https://code.djangoproject.com/wiki/RemovingTheMagic .. _checklist: https://code.djangoproject.com/wiki/MagicRemovalCheatSheet [30f5d4f5]
- ================================= Django version 0.95 release notes ================================= [21e7876d]
- Aside from that, another main theme of this release is a dramatic increase in usability. We've made countless improvements in error messages, documentation, etc., to improve developers' quality of life. [8c703fae]
- Changes and new features ======================== [6c743344]
- Finally, for those who prefer the more immediate feedback offered by IRC, there's a ``#django`` channel on ``irc.libera.chat`` that is regularly populated by Django users and developers from around the world. Friendly people are usually available at any hour of the day -- to help, or just to chat. [faa98455]
- Thanks for using Django! [d04a51ac]

## All facts

- [284b3732] For more personalized help, the `django-users`_ mailing list is a very active list, with more than 2,000 subscribers who can help you solve any sort of Django problem. We recommend you search the archives first, though, because many common questions appear with some regularity, and any particular problem may already have been answered.
- [ba08fd46] Fortunately, most of Django's core APIs won't be changing before version 1.0. There likely won't be as big of a change between 0.95 and 1.0 versions as there was between 0.91 and 0.95.
- [c2e7bb0c] However, it's not the 1.0 release, and we'll be introducing further changes before 1.0. For a clear look at which areas of the framework will change (and which ones will *not* change) before 1.0, see the ``api-stability.txt`` file, which lives in the docs/ directory of the distribution.
- [48843c68] Need help resolving a problem with Django? The documentation in the distribution is also available :doc:`online </index>` at the `Django website`_. The :doc:`FAQ </faq/index>` document is especially recommended, as it contains a number of issues that come up time and again.
- [efc10a68] Problem reports and getting help ================================
- [c4981573] Suitability and API stability =============================
- [feb8a28f] The Django Team July 2006
- [b0769383] The major changes in this release (for developers currently using the 0.91 release) are a result of merging the 'magic-removal' branch of development. This branch removed a number of constraints in the way Django code had to be written that were a consequence of decisions made in the early days of Django, prior to its open-source release. It's now possible to write more natural, Pythonic code that works as expected, and there's less "black magic" happening behind the scenes.
- [95b82671] The new features and changes introduced in 0.95 include:
- [bc393491] The number of changes required to port from 0.91-compatible code to the 0.95 code base are significant in some cases. However, they are, for the most part, reasonably routine and only need to be done once. A list of the necessary changes is described in the `Removing The Magic`_ wiki page. There is also an easy checklist_ for reference when undertaking the porting operation.
- [66d6c5d7] This release is intended to provide a stable reference point for developers wanting to work on production-level applications that use Django.
- [bb1411cd] This represents a significant advance in Django development since the 0.91 release in January 2006. The details of every change in this release would be too extensive to list in full, but a summary is presented below.
- [fad33f5b] Welcome to the Django 0.95 release.
- [5c9b8480] You may have a need to use some of the features that are marked as "subject to API change" in that document, but that's OK with us as long as it's OK with you, and as long as you understand APIs may change in the future.
