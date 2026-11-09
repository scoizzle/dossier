# docs/internals/contributing/writing-documentation

- Subject: docs/internals/contributing/writing-documentation (id `1133e720-c50a-4192-84fe-a909995098b6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 47 of 278
- Conflicts: 0
- Gaps: 0

## Facts

- :param arg1: Description of the first parameter :param arg2: Description of the second parameter [3de0dd45]
- Attribute description. [c2b64f17]
- Method description. [33125769]
- The ``middle_name`` argument was added. [e197d272]
- $ SPHINXBUILD=sphinx-autobuild SPHINXOPTS="--open-browser --delay 0" make html [a63f83c4]
- .. attribute:: my_attribute [8b7b3819]
- .. method:: my_method(arg1, arg2) [fa0dc2d3]
- A brief description of the class. [95e7d4f6]
- PS> $env:SPHINXBUILD="sphinx-autobuild" PS> $env:SPHINXOPTS="--open-browser --delay 0" PS> make html [c328f478]
- $ python -m pip install sphinx-autobuild [ac0dc1aa]
- $ python manage.py shell [dc0da2cbf091829d]
- $ sphinx-autobuild . _build/html --open-browser --delay 0 [3fb6b913]
- .. django-admin-option:: --traceback [1a4202265f812714]
- .. django-admin:: migrate [7fdff13b]
- .. fieldlookup:: exact [d30e390b003d94b0]
- .. setting:: INSTALLED_APPS [e69697d84f33aaa9]
- .. templatefilter:: linebreaksbr [daa41dc3d2c8b0c3]
- .. templatetag:: regroup [84a41197c19be8aa]
- .. versionadded:: A.B [cd5fccff]
- .. versionchanged:: A.B [7bdd84ce]
- ... [c059dbb7f93ef187-3]
- :ticket:`12345` [885f80d8]
- A person who writes books. [3ca18d73]
- An author's middle name. [f8ffa978]
- ``first_name`` is ... [cf042eaf]
- ``middle_name`` is ... [4217cb0e]
- .. class:: MyClass [adecdd0f]
- Add :mod:`django.contrib.auth` to your :setting:`INSTALLED_APPS`... [0527ebf7]
- Add ``django.contrib.auth`` to your ``INSTALLED_APPS``... [0a12e6f6]
- $ cd docs $ make html [4010488b]
- $ git clone https://github.com/django/django.git [18ad04c7]
- $ make black [f088206d]
- $ make check [32e4be00]
- $ make linkcheck [f4c4d3c7]
- $ make lint [6ac9e64f]
- $ make man [ce196c24]
- $ make spelling [921bed38]
- $ python -m venv .venv $ source .venv/bin/activate $ python -m pip install -r docs/requirements.txt [3db933df]
- .. code-block:: doscon [423631a5927aaff7-8]
- .. code-block:: powershell [12e57b89]
- .. code-block:: shell [8aa7203c166b13be-49]
- .. _available-settings: [aebef3f1]
- .. _deprecated-settings: [c0f108d6]
- .. attribute:: Author.middle_name [fd4045cf]
- .. class:: Author(first_name, last_name, middle_name=None) [c9bc9dcc]
- .. code-block:: console [faf6f5a8efbd7831-8]
- .. console:: [7714e199aac2701e-40]

## Beyond the budget

228 more facts did not fit in the budget: [00054b8f4c441f62] [c059dbb7f93ef187-4] [c059dbb7f93ef187-5] [c059dbb7f93ef187-6] [5dec30ec] [ea270123] [37c4e8d6f30a41e2] [704c3a8a] [e47593b1] [ee7fabf6] [b90ff62c] [4529d318c14d8f63] [a9c1d0e3] [4cc610dc] [6efaacf4] [e00821e1] [b864dd33] [0a7c53f9] [20b80420] [031cc535] [f052e5fe778f916c] [f052e5fe778f916c-2] [aee9a20e] [78c588f4] [46ca9ebe] [1334b701] [7714e199aac2701e-41] [7714e199aac2701e-42] [d710c509] [4ab33952] [3871ddb3eff15a0e] [3871ddb3eff15a0e-2] [3871ddb3eff15a0e-3] [3871ddb3eff15a0e-4] [3871ddb3eff15a0e-5] [3871ddb3eff15a0e-6] [3871ddb3eff15a0e-7] [3871ddb3eff15a0e-8] [3871ddb3eff15a0e-9] [3871ddb3eff15a0e-10] [3871ddb3eff15a0e-11] [3871ddb3eff15a0e-12] [3871ddb3eff15a0e-13] [3871ddb3eff15a0e-14] [20ed93bf2591ccc0] [07bd63af] [17b1b45c] [b0f9968e] [fdb85cab] [6b446b89] [f0d9ab12] [a6ebeaec] [30d12b08] [c862c614] [9aedc46d] [b58813ab] [cb50ba82] [1f5653c1] [849f7e86] [a7abe21e] [7c301e7c] [1b36482f] [7cd7e5c5] [463f8a0e] [24cc0d2e] [2c180512] [634acb3c] [9d269e37] [3932badf] [288a7a50] [abbaf7f4] [d9bc4063] [e200503e] [d4aff276] [ea7e0414] [165d6cb9] [df490f5d] [06dcfe30] [b61aff23] [f1b18d57] [ee0b7b08] [e0971267] [13d383ff] [e1af05dc] [51aa78cb] [1eb4d233] [baf81dcb] [f4f9ab15] [755fa4ad] [86bd8187] [51e70e48] [4c6a5a7f] [70295e1d] [e737a953] [20680c2d] [bcba985b] [8edb4288] [7ebdefc8] [5f637ab5] [6efa9ff2] [e31beec7] [cb019011] [db543705] [038a9169] [5a30089f] [4350d084] [3c773ac0] [a1f89c43] [4e992c3c] [edbe45ed] [5974cde9] [22b60b74] [76b91320] [897e8036] [7443bc6f] [fd356caf] [009adba6] [5770341f] [01085df5] [0becf246] [89ccf19e] [faf6f5a8efbd7831-9] [423631a5927aaff7-9] [3871ddb3eff15a0e-15] [3871ddb3eff15a0e-16] [3871ddb3eff15a0e-17] [3871ddb3eff15a0e-18] [8aa7203c166b13be-50] [7714e199aac2701e-43] [7714e199aac2701e-44] [7714e199aac2701e-45] [7714e199aac2701e-46] [7714e199aac2701e-47] [7714e199aac2701e-48] [7714e199aac2701e-49] [7714e199aac2701e-50] [7714e199aac2701e-51] [c54b54cb0805732a-7] [cd67f120] [9e2987b4] [759edcc4] [69b1d3c7] [0b8980d7] [d55864f9] [c28f79d4831681bc] [88076e00] [45ad989a] [702975fc] [6a52db95] [656e3c32] [a424d592] [381a603d] [ade95f4d] [8cb5d89f] [199fbbfb] [f6d5806c] [1496409b] [48a71f14] [a41e535c] [147a4105] [9360997f] [72b49420] [4024557c] [d02befd5] [e0770de5] [c7d8dc89] [ee1e3370] [7db3bcef] [f9c3c298] [141c4e5ec809f575-2] [4018ead2] [13ecd41f] [a4644f94] [0b0ae4a8] [87ce9675] [171b3867] [ca5aca9c] [1952e2be] [210213ff] [4316dbbb] [43c69dca] [a88e415b] [55cd5d2c] [ac73be2d] [e7a5fd16] [f3d94083] [c5ae7641] [8c7b7bd3] [945f6564] [5816140c] [688a8728] [373629b9] [a188250e] [039394d8] [d6f23e25] [4c85a7a8] [6bbc250d] [c349a2e5] [4c4bb980] [d659ea98] [9a512b38] [2c0adccb] [c846d85b] [08b83601] [cbafa754] [27c4f53c] [87c8a53c] [f669204f] [c4ddf23a] [6f678c12] [8b5b85bf] [5cd78309] [6b154c56] [a11e464f] [e61f96af] [1a7db1de] [2d32a9f0] [8376c4ee] [31f85443] [a45eafe6] [85011246] [26abda73] [737ca632] [a7e89515] [a26edb33] [9bf6e550] [ec8b3d34] [5f4a3ee3]
