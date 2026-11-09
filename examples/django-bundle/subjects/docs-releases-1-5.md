# docs/releases/1.5

- Subject: docs/releases/1.5 (id `bb8d46bb-8096-4e28-8027-08efc1d4b98c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 16 of 202
- Conflicts: 0
- Gaps: 0

## Facts

- >>> first_poll = Poll.objects.all()[0] >>> first_choice = first_poll.choice_set.all()[0] >>> first_choice.poll is first_poll True [5e7368c1]
- In addition to the changes outlined in this section, be sure to review the :ref:`deprecation plan <deprecation-removed-in-1.5>` for any features that have been removed. If you haven't updated your code within the deprecation timeline for a given feature, its removal may appear as a backwards incompatible change. [894632e7]
- Some WSGI servers and middleware do not always call ``close`` on the response object after handling a request, most notably uWSGI prior to 1.2.6 and Sentry's error reporting middleware up to 2.0.7. In those cases the ``request_finished`` signal isn't sent at all. This can result in idle connections to database and memcache servers. [a4af8454]
- {% for date in date_list reversed %} [1c2d24b6]
- Moreover, when you output errors or messages in your custom commands, you should now use ``self.stdout.write('message')`` and ``self.stderr.write('error')`` (see the note on :ref:`management commands output <management-commands-output>`). [945721b4]
- * ... and more; `see below <#what-s-new-in-django-1-5>`_. [f4058ee1]
- * :class:`django.forms.ModelMultipleChoiceField` now returns an empty ``QuerySet`` as the empty value instead of an empty list. [e67bf591]
- * :class:`~django.contrib.gis.geos.LineString` and :class:`~django.contrib.gis.geos.MultiLineString` GEOS objects now support the :meth:`~django.contrib.gis.geos.GEOSGeometry.interpolate` and :meth:`~django.contrib.gis.geos.GEOSGeometry.project` methods (so-called linear referencing). [68a0c580]
- * :func:`~django.utils.http.int_to_base36` properly raises a :exc:`TypeError` instead of :exc:`ValueError` for non-integer inputs. [6f45876c]
- * :meth:`BoundField.label_tag <django.forms.BoundField.label_tag>` now escapes its ``contents`` argument. To avoid the HTML escaping, use :func:`django.utils.safestring.mark_safe` on the argument before passing it. [7fbb81fc]
- * :meth:`QuerySet.bulk_create() <django.db.models.query.QuerySet.bulk_create>` now has a batch_size argument. By default the batch_size is unlimited except for SQLite where single batch is limited so that 999 parameters per query isn't exceeded. [70404fbf]
- * :meth:`~django.test.SimpleTestCase.assertXMLEqual` and :meth:`~django.test.SimpleTestCase.assertXMLNotEqual` new assertions allow you to test equality for XML content at a semantic level, without caring for syntax differences (spaces, attribute order, etc.). [8c74dab2]
- * :mod:`django.contrib.auth` provides a new signal that is emitted whenever a user fails to login successfully. See :data:`~django.contrib.auth.signals.user_login_failed` [6d137999]
- * :mod:`django.utils.timezone` provides a helper for converting aware datetimes between time zones. See :func:`~django.utils.timezone.localtime`. [6bff8f64]
- * Accessing reverse one-to-one relations fetched via :meth:`~django.db.models.query.QuerySet.select_related` now raises :exc:`~django.db.models.Model.DoesNotExist` instead of returning ``None``. [f5f6a22b]
- *February 26, 2013* [3fb07246]

## Beyond the budget

186 more facts did not fit in the budget: [dbd85b3a] [27dbda4f] [73f253ad] [2c9e788d] [f35dff46] [7a041954] [d27408d1] [b0acedee] [2393aa6a] [5a32bff2] [f2b1b64e] [f431a50a] [724fc35d] [9290a417] [cf955588] [f47600a4] [0f46f01e] [b8e39f2f] [02911d20] [6fc3af3e] [ed7634fb] [1df2ff02] [48f4a888] [d25b6b9c] [aec94ffb] [e31642a5] [3305a650] [922e62b1] [93a43cb1] [e06ccd5a] [f6ee8846] [36fd2b90] [694f9c37] [26c34f39] [b9c73cca] [31cfcdb4] [a6e74376] [48e2b546] [53f6edc6] [f3da9be5] [3f0fb6f0] [c6cc7d48] [256d7a1b] [17a89fe2] [685d15dfb6eb2285-317] [eaf050be34acb41d-617] [942ae6c11625c81c-157] [c54b54cb0805732a-94] [8e2860a3] [54cd34d9] [04c6ca62] [21001a2a] [d6bf1cd2] [d9039bae] [af33f8e0] [26468414] [200a52e4] [36dca53b] [df540e58] [3a430b10] [59aeb93a] [45c14930] [59a8bb3e] [d50d3697] [0d6b7b48] [9374c6aa] [d774379b] [5e640e03] [e3ff7411] [6ac4d400] [45c5b5c8] [c4f36569] [a459b2c5] [fdeb5512] [67a2ea93] [73550615] [bb5de575] [77873d4e] [cff01a46] [d1965f3e] [c001eb85] [ba3119a8] [34fde489] [7339c257] [ef37bcad] [e002918e] [5836d895] [477f513818a1ad7d-6] [6baeaf39] [5c86fc9b] [5bdb2d7d] [db99a82a] [2c927e86] [20d6b6ad] [5412755c] [3f5f3d25] [df4ea2e7] [580f6c08] [23d4573e] [aa829363] [fd44c45e] [4ac11039] [d4d5de50] [dc8e51fc] [22429010] [5630c0af] [32cecf2752c82bab-4] [7e0dde20fe81851d-5] [9595ede0] [6cc143a9] [46695c30] [f5b5a8f8] [2788e40f] [6f4b988b] [65c88c8c] [fc4a4711] [a4b27f38] [75696e16fcbb84ec-14] [851065e2] [83651d33] [33a8a38d] [652725da] [ae34cf4ae6f76a23-7] [25e96b0d] [89c31cbd] [60b830cb] [719afd3c] [6f0f1225] [663cdd0b] [5aef557f] [cec21d1e] [0a1e414c] [aac5dbc8] [1ee70049] [3583d26f] [95896434] [401f9bb7] [50468c03] [fa496ada] [92fc73c7] [dd6f143e] [34371a23] [6a346a03] [3a3a65cf] [4f5f298d] [0a3d60ce] [4a5302ed] [ed69c1fb] [a60a25e6] [a2f8860c] [4739a1a9] [67b931af] [daa4b220] [be6d079d] [c690f292] [ab60bd54] [af6f87ab] [a8653772] [1e59d264] [f6d7de3a] [637084ff] [bb9adbef] [2e877061] [4ed1452d] [80778ba5] [7a834f51] [bc134216] [574077b3] [2b883e08] [ea04c1f2] [cc2aa776] [276854cb] [8f08c385] [1753e391] [ae2cee24] [78880fc9] [1c10de08] [70e91815] [7e674960] [b1ba3556] [a6cb7537] [b8e7831e] [a957fa5a] [d4d33602] [0084f66b] [8b4bc3af]
