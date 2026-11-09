# docs/releases/1.3

- Subject: docs/releases/1.3 (id `583f9f7c-020d-4408-aba7-676787985719`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 26 of 224
- Conflicts: 0
- Gaps: 0

## Facts

- @transaction.commit_manually def my_view(request, name): obj = get_object_or_404(MyObject, name__iexact=name) return render_to_response("template", {"object": obj}) [6644c7da]
- /usr/lib/python2.6/gettext.py:49: ImportWarning: Not importing directory '/path/to/project/locale': missing __init__.py. import locale, copy, os, re, struct, sys [88908d7b]
- >>> ArticleFormSet({}) Traceback (most recent call last): ... ValidationError: [u'ManagementForm data is missing or has been tampered with'] [a563fab7]
- >>> Template("{{ user.get_full_name }}").render(Context({"user": user})) u'Joe Bloggs' >>> Template("{{ full_name }}").render(Context({"full_name": user.get_full_name})) u'&lt;bound method User.get_full_name of &lt;... [12058356]
- >>> class ArticleForm(Form): ... title = CharField() ... pub_date = DateField() ... >>> ArticleFormSet = formset_factory(ArticleForm) [64d13e5c]
- >>> formset = ArticleFormSet() >>> formset = ArticleFormSet(data=None) [9de61e37]
- For more details, see the documentation :doc:`Django's release process </internals/release-process>` and our :doc:`deprecation timeline </internals/deprecation>`. [4d59baa3]
- class DocumentForm(forms.ModelForm): class Meta: model = Document widgets = {"document": forms.FileInput} [a7ec4b7a]
- class LoginForm(forms.Form): username = forms.CharField(max_length=100) password = forms.CharField(widget=forms.PasswordInput(render_value=True)) [b98236b0]
- from django import forms from myapp.models import Document [b61f36e0]
- from django.utils import unittest [88aa8279]
- import unittest [b7370ddb]
- python manage.py sqlindexes sessions [51f553c9]
- with transaction.autocommit(): ... [906edeb2]
- {% extends "base.html" %} [0a6c70ed0cb3c3fb-7]
- {% extends templ %} [703bcd99]
- {% load url from future %} {% url 'sample' %} [8a6d7737]
- {% url sample %} [ea66334f]
- .. code-block:: pytb [fccd37de02dbdecc-6]
- * :class:`~django.core.mail.EmailMessage` now supports CC's. [adbee585]
- * :func:`~django.core.mail.mail_admins` and :func:`~django.core.mail.mail_managers` now support easily attaching HTML content to messages. [c8d4ff80]
- * :meth:`~django.template.Library.simple_tag` now accepts a ``takes_context`` argument, making it easier to write simple template tags that require access to template context. [739a04db]
- * A :class:`~django.test.RequestFactory` for mocking requests in tests. [4677e70b]
- * A framework for writing `class-based views`_. [4fd6aad6]
- * A new :meth:`~django.shortcuts.render` shortcut -- an alternative to ``django.shortcuts.render_to_response()`` providing a :class:`~django.template.RequestContext` by default. [9396b015]
- * A new test assertion -- :meth:`~django.test.TransactionTestCase.assertNumQueries` -- making it easier to test the database activity associated with a view. [843dd38d]

## Beyond the budget

194 more facts did not fit in the budget: [5aa3aa8a] [1aaf3303] [fe07dd3b] [f57a0e54] [8064784e] [a7b48bde] [d67606f9] [5daadd52] [8e37ccdf] [fdc36167] [c8305505] [c267c1ca] [24073513] [1b69b7c9] [6b604a1a] [d5c091f6] [0fe80891] [b5a8d549] [fe8e33b5] [a65c9a40] [a91d7314] [048d9b31] [ef7c2069] [89349850] [04971c96] [414e238b] [269de389] [1f60bdfb] [6b0a3db568b17cf8-2] [e83eff45] [cde0ad88] [1e6d2dee] [2c96f083] [22869697] [8b968d30] [cd727009] [47ad2942] [7ea3370e] [685d15dfb6eb2285-311] [eaf050be34acb41d-613] [eaf050be34acb41d-614] [eaf050be34acb41d-615] [eaf050be34acb41d-616] [8aa7203c166b13be-116] [6b4a5e54e001d097-36] [59f91962] [09a8803a] [850c6f6c] [14e4fe02] [a562978f] [ba3ee892] [1c5c21a2] [09c375f4] [23c81ad8] [0b2be39d] [230aad64] [17a84731] [98127071] [0a80499d] [ab94df37] [9173453c] [a46c2b71] [3bfb57c5] [e43a822b] [104fa35a] [f79333bf] [9c1694e9] [7d068298] [fa9b34e2] [b220459e] [fb4849bb] [1acdab0f] [fda32840] [ae0d3c1a] [6db782eb] [22630a79] [f7046026] [40ad8869] [e0ac22c1] [de5cc99d] [3919826b08d1ac96-2] [9029b9ce] [7940cf66] [8a573e63] [f88e351e] [e79ccd48] [6bec3939] [8caebb3f] [18db670c] [7a555963] [0160087e] [f07d7863] [58f19cbb] [ba95a179] [e3f9e813] [05d60c80] [8c28959d] [96485d10] [66530822] [477f513818a1ad7d-4] [477f513818a1ad7d-5] [1846742d] [12014225c08a987b-2] [91cdabf6] [20d11fbb] [79e9397a] [e351f311] [08d9e13c] [82f775f7] [e815cb22] [a0d993e2] [83868456] [41723949] [fd3c5cec] [d4871853] [530893ec] [92003f9e] [42d55435] [00387cdd] [d2d9fa6b] [c746d4c6] [59c86df6] [a960e74a] [b32a4e7c] [106163c2] [acbdebfe] [78bd6f68] [75696e16fcbb84ec-12] [715f50d9] [e5e9cd03] [2a4583a6] [e846a920] [eb725176] [7be94862] [30eb2971] [b5ead721] [53db49ec] [4dd97c9f] [254e48c1] [f992d488] [d1576337] [1af198bc] [ae34cf4ae6f76a23-4] [4e0543c3] [a7631093] [67efa09035dab44d-3] [4f56bc47] [e9cdecba] [6ab3e255] [2330c85e] [266e3a77] [8e9513d3] [351b6b4c] [f4cb9903] [a3441fb5] [9365caa7] [d9661535] [61cb3bc7] [b0544aa81cf8ca53-2] [c3609e6d] [a5907e3a] [de727e41] [c1219074] [9ba33267] [8d8f3271] [8e997d37] [014cfba2] [4d1bebff] [d08ae862] [a61cf75a] [e0bab9e25fa4176e-2] [4ea1068f] [1b96e5f7fe85b082-2] [9c568919] [d1c26fc2] [b5e855af] [a9fc6b4c] [1efd59b8] [899c045c] [864b5c41] [700d36d2] [b9f9f7a8] [61daa6bf] [29951601] [a5d13be0] [3084fd22] [50f49355] [ecbf530b] [9c9da5f5] [b7e272a3] [8fdac8d7] [cc2f1a7c] [400b6251] [4ce3dd35]
