# docs/releases/0.95

- Subject: docs/releases/0.95 (id `74e99b25-2264-4b7d-9a49-cf52cffea781`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 17 of 31
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

14 more facts did not fit in the budget: [284b3732] [ba08fd46] [c2e7bb0c] [48843c68] [efc10a68] [c4981573] [feb8a28f] [b0769383] [95b82671] [bc393491] [66d6c5d7] [bb1411cd] [fad33f5b] [5c9b8480]
