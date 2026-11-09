# docs/internals/contributing/writing-code/coding-style

- Subject: docs/internals/contributing/writing-code/coding-style (id `167c77a6-c868-4661-977d-2edb58105f16`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 41 of 167
- Conflicts: 0
- Gaps: 0

## Facts

- class Meta: verbose_name_plural = "people" [d2fbaaca]
- first_name = models.CharField(max_length=20) last_name = models.CharField(max_length=40) [077c98ce]
- Code goes here [7993aa08e60edc44]
- Code goes here [7993aa08e60edc44-2]
- {% block content %} ... [f3ddba74]
- # Django from django.http import Http404 from django.http.response import ( Http404, HttpResponse, HttpResponseNotAllowed, StreamingHttpResponse, cookie, ) [2953d80d]
- # future from __future__ import annotations [a14733db]
- # local Django from .models import LogEntry [e78cc79b]
- # standard library import json from itertools import chain [c8909f46]
- # third-party import bcrypt [9e5f2f1b]
- # try/except try: import yaml except ImportError: yaml = None [63d0ad5f]
- $ python -m pip install "isort >= 7.0.0" $ isort . [27dfa690]
- CONSTANT = "foo" [7742c603]
- class Example: ... [6b079228]
- class Person(models.Model): FirstName = models.CharField(max_length=20) Last_Name = models.CharField(max_length=40) [33299c8e]
- class Person(models.Model): class Meta: verbose_name_plural = "people" [ff82ca3f]
- class Person(models.Model): first_name = models.CharField(max_length=20) last_name = models.CharField(max_length=40) [c770f1c830f731fb]
- def my_view(req, foo): ... [07a984b9]
- def my_view(request, foo): ... [a40f35aa]
- from django.views import View [312d6da0ca4d357f]
- from django.views.generic.base import View [ade7bb4e]
- import module # isort:skip [76d4244e]
- {# This is a comment #} {% extends "base.html" %} [c9629579]
- {% block content %} [3d4c4e5442e939f4-2]
- {% block content %} <h1 class="font-semibold text-xl"> {{ pages.title }} </h1> {% endblock content %} [3314cec1ab70bd73]
- {% block header %} [a0fd446ea9becfa4]
- {% block header %} [a0fd446ea9becfa4-2]
- {% endblock %} [27937693bf26c47c-2]
- {% endblock header %} [a3a4c5ea]
- {% extends "base.html" %} [0a6c70ed0cb3c3fb-2]
- {% extends "base.html" %} [0a6c70ed0cb3c3fb-3]
- {% extends "base.html" %} [0a6c70ed0cb3c3fb-4]
- {% load humanize %} [500a4a3bf5772a1b]
- {% load i18n %} {% extends "base.html" %} [6af8978e]
- {% load i18n l10 tz %} [eec4aa95]
- {%load humanize%} [2aa9890a]
- {{ user }} [4fa65860]
- {{user}} [302d00e8]
- # Allowed f"hello {user}" f"hello {user.name}" f"hello {self.user.name}" [2e6e6639]
- # Allowed with local variable assignment user = get_user() f"hello {user}" user_days_old = user.age * 365.25 f"you are {user_days_old} days old" [15df7ec8]
- # Disallowed f"hello {get_user()}" f"you are {user.age * 365.25} days old" [ad57c958]

## Beyond the budget

98 more facts did not fit in the budget: [2894405ebdfc4412-2] [c176e0ad] [5a0e447d] [413cfd8b] [06d1b3a4] [e0d111f1d44acb07] [176acd86] [81f95c79] [8aa52b95] [4b946cd6] [ecada48d] [685d15dfb6eb2285-27] [ef446009] [7714e199aac2701e-15] [1f3535c2] [fd04c2fa] [795f9a42b1ba8673] [795f9a42b1ba8673-2] [795f9a42b1ba8673-3] [795f9a42b1ba8673-4] [795f9a42b1ba8673-5] [795f9a42b1ba8673-6] [795f9a42b1ba8673-7] [572f3869fd620fc3] [572f3869fd620fc3-2] [572f3869fd620fc3-3] [44c358dc648f3d03] [cbd439cb] [5a5c7092] [a2fe3aed] [b9c33714] [bb93ff6c] [cecaea75] [0d67d811] [27f88c9b] [e7478738] [09660690] [e34e2b51] [3923dcea] [0f349f44] [9a8fb5bc] [40a35507] [0e9062a8] [0ef38758] [0571ff8f] [d7b840e1] [0c945701] [a5a221d8] [e28b1ed3] [78f606d0] [b64853a3] [c058dd6b] [fb4a2541] [ce480089] [aec197b8] [a79b1e57] [31d5f039] [7e3b0946] [cfc61cc1] [dbf2bb69] [5f67e1af] [b0223d90] [e00cee1c] [df1c2631] [f358ff30] [a49ea55b] [f3db5c8c] [9919fa74] [2d6ff2df] [8d4d1fa1] [fb951c92] [f6c61a69] [261ed26b] [eee5e97f] [63dc52ac] [7714e199aac2701e-16] [cf7a8fb4] [d8716531] [90a398d8] [dc88d6ae] [72b9bee7] [f243777d] [93566f29] [0ff9bdda] [5969ec76] [860302bc192c8ae4-2] [c001f1ef] [3b8013af] [b8db4c82] [7b1addf6] [f0b41751] [3e41d16b] [08231f7b] [5db669d9] [413da022] [d1f17a65] [82319f4e] [cc38fa12]
