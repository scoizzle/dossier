# docs/ref/contrib/contenttypes

- Subject: docs/ref/contrib/contenttypes (id `c6e6724a-7bbe-4894-8177-9588b479b54d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 16 of 157
- Conflicts: 0
- Gaps: 0

## Facts

- class ContentTypesTests(TestCase): def setUp(self): ContentType.objects.clear_cache() self.addCleanup(ContentType.objects.clear_cache) [0a021c12]
- Clears an internal cache used by :class:`~django.contrib.contenttypes.models.ContentType` to keep track of models for which it has created :class:`~django.contrib.contenttypes.models.ContentType` instances. You probably won't need to call this method in application code yourself; Django will call it automatically when it's needed. [fc29d358]
- Lookup a :class:`~django.contrib.contenttypes.models.ContentType` by ID. Since this method uses the same shared cache as :meth:`~django.contrib.contenttypes.models.ContentTypeManager.get_for_model`, it's preferred to use this method over the usual ``ContentType.objects.get(pk=id)`` [3f5a145f]
- Returns the :class:`~django.contrib.contenttypes.models.ContentType` instance uniquely identified by the given application label and model name. The primary purpose of this method is to allow :class:`~django.contrib.contenttypes.models.ContentType` objects to be referenced via a :ref:`natural key<topics-serialization-natural-keys>` during deserialization. [18e84f56]
- Takes a variadic number of model classes, and returns a dictionary mapping the model classes to the :class:`~django.contrib.contenttypes.models.ContentType` instances representing them. ``for_concrete_models=False`` allows fetching the :class:`~django.contrib.contenttypes.models.ContentType` of proxy models. [04d934bd]
- Takes either a model class or an instance of a model, and returns the :class:`~django.contrib.contenttypes.models.ContentType` instance representing that model. ``for_concrete_model=False`` allows fetching the :class:`~django.contrib.contenttypes.models.ContentType` of a proxy model. [8f7d7a4b]
- The human-readable name of the content type. This is taken from the :attr:`verbose_name <django.db.models.Field.verbose_name>` attribute of the model. [f0307268]
- The name of the :class:`~django.contrib.contenttypes.models.ContentType` foreign key field on the model. Defaults to ``content_type``. [77dc7d0c]
- The name of the application the model is part of. This is taken from the :attr:`app_label` attribute of the model, and includes only the *last* part of the application's Python import path; ``django.contrib.contenttypes``, for example, becomes an :attr:`app_label` of ``contenttypes``. [f1d8f8c9]
- The name of the integer field that represents the ID of the related object. Defaults to ``object_id``. [c58d7b23]
- The name of the model class. [b5beb53c]
- The relation on the related object back to this object doesn't exist by default. Setting ``related_query_name`` creates a relation from the related object back to this one. This allows querying and filtering from the related object. [a724d504]
- You may need to clear the cache when testing, to reset between tests, or after preparing test state. For example:: [6296ef4e]
- class Meta: indexes = [ models.Index(fields=["content_type", "object_id"]), ] [d74d20e5]
- def __str__(self): return self.tag [1f8ee5fe]
- .. attribute:: GenericForeignKey.for_concrete_model [7027f5cf]

## Beyond the budget

141 more facts did not fit in the budget: [7ca12aa8] [15fbfe26] [2dca3233] [beb88fbf] [fa52ca0a] [a598e6014e379321-4] [80d47dc5547c9038-4] [6f4c5501] [39846542] [92730246] [bc7f268e] [17a99e5d] [fc595e83] [ad42993a] [b3117a8c] [8bef85b4] [ad660cb2] [da113343] [83aa8d1d] [cc1f0155] [396264d0] [fa7a111e] [f1091420] [d9a50092] [282877f0] [2bebf892] [fb7781ac] [e92edbe0] [0e9569d3] [8d98d17e] [245816cf] [aab3c7a1] [ddb353a0] [2e206a51] [e1e2969a] [86a1ecbe] [bcd6a379] [6a8edfb6] [12bed7cd] [576c5e73] [7a6ce1a3] [3927b34d] [799d974b] [b69eb8da727ca46d-2] [7bf43d7e] [d270991f] [72e7326f] [c9fc8099] [c354f97d] [c84061e8] [70e94084] [dfbff5a9] [db0fa3d7] [9aa06203] [d3389329] [e99118e6] [1e3846e0] [162cbb0a] [f78f023b] [600697de] [087bfcf9] [c9c0919f] [ca8ee880] [30aaa30d] [458bab13] [79f0a65a] [1289b765] [c1e8b77b] [eaf050be34acb41d-17] [eaf050be34acb41d-18] [eaf050be34acb41d-19] [eaf050be34acb41d-20] [eaf050be34acb41d-21] [eaf050be34acb41d-22] [eaf050be34acb41d-23] [eaf050be34acb41d-24] [eaf050be34acb41d-25] [eaf050be34acb41d-26] [eaf050be34acb41d-27] [eaf050be34acb41d-28] [eaf050be34acb41d-29] [eaf050be34acb41d-30] [091fc2a9] [55d3c263] [c756d7bc] [b2e77a80] [792f95e3] [993ffecf] [578d0647] [5fffdf62] [fea0b25c] [e892f46e] [bbb37da7] [13ec95de] [d31bf7ca] [6001da78] [a597d665] [78e4a282] [f0dff0b7] [c9f6f153] [2f62a0f7] [370e54a8] [4e4776ea] [1c443718] [a9361572] [5f0d0412] [c27e53c1] [8b8fd4a4] [8b6690a9] [1d6b2795] [8b9293ea] [f5bb23df] [23ed42f1] [f32e6209] [ed38ee8e] [e004ab80] [cb6fa021] [54ac3e3b] [baba761d] [113b500a] [75696e16fcbb84ec-5] [f0f2c4a0] [c495101e] [355443c5] [26db75cb] [c91088bf] [da1833a6] [75edf987] [c0bb7111] [ac94e564] [77c88c13] [86f1194a] [2e82a11c] [1d72010f] [bd38c1ed] [41ffcc9d] [00a2937e] [8db07730] [44964465] [a0aa072f] [9943a2ae]
