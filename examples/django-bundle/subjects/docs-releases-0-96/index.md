# docs/releases/0.96

- Subject: docs/releases/0.96 (id `997c0a19-ce07-4318-959c-7ef2fd5309b2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 21 of 69
- Conflicts: 0
- Gaps: 0

## Facts

- from django import forms # 0.95-style from django import oldforms as forms # 0.96-style [88c57b35]
- # Find text containing a single backslash MyModel.objects.filter(text__contains="\\") [42711046]
- DATABASE_ENGINE = "mysql" [d6d388fe]
- DATABASE_ENGINE = "mysql_old" [a7c8547f]
- from django.conf.urls.defaults import * [897fa20c28c79ab4]
- from django.conf.urls.defaults import * from django.contrib.auth.decorators import login_required from django.views.generic.list_detail import object_list from mysite.myapp.models import MyModel [14b6c8c2]
- from django.conf.urls.defaults import * from mysite.myapp.views import myview [e61ba916]
- info = { "queryset": MyModel.objects.all(), } [1fbdf0ab]
- urlpatterns = patterns("", ("^myview/$", "mysite.myapp.views.myview")) [4bc3e958]
- urlpatterns = patterns("", ("^myview/$", login_required(object_list), info)) [eee7efad]
- urlpatterns = patterns("", ("^myview/$", myview)) [7cd77ad0]
- * Everyone who submitted a bug report, patch or ticket comment. We can't possibly thank everyone by name -- over 200 developers submitted patches that went into 0.96 -- but everyone who's contributed to Django is listed in :source:`AUTHORS`. [89466165]
- * Our new release manager, James Bennett, for his work in getting out 0.95.1, 0.96, and (hopefully) future release. [3be06c27]
- * Our ticket managers Chris Beaven (aka SmileyChris), Simon Greenhill, Michael Radziej, and Gary Wilson. They agreed to take on the monumental task of wrangling our tickets into nicely cataloged submission. Figuring out what to work on is now about a million times easier; thanks again, guys. [653ef447]
- * Russell Keith-Magee and Malcolm Tredinnick for their major code contributions. This release wouldn't have been possible without them. [cbebd4d8]
- * The ``sqlinitialdata`` command has been renamed to ``sqlcustom`` to emphasize that ``loaddata`` should be used for data (and ``sqlcustom`` for other custom SQL -- views, stored procedures, etc.). [47c2eb13]
- * The next official release of Django will move the current ``django.newforms`` to ``django.forms``. This will be a backwards-incompatible change, and anyone still using the old version of ``django.forms`` at that time will need to change their import statements as described above. [07a7bcd4]
- * The next release after that will completely remove ``django.oldforms``. [e44dd102]
- * The vestigial ``install`` command has been removed. Use ``syncdb``. [7ca023e6]
- * There are new ``dumpdata`` and ``loaddata`` commands which, as you might expect, will dump and load data to/from the database. These commands can operate against any of Django's supported serialization formats. [2381cafc]
- * We've copied the current ``django.forms`` to ``django.oldforms``. This allows you to upgrade your code *now* rather than waiting for the backwards-incompatible change and rushing to fix your code after the fact. Just change your import statements like this:: [0a3b1c19]

## Beyond the budget

47 more facts did not fit in the budget: [fad3170d] [af616bf6] [29d7a687] [bd3c8016] [0b6433e2] [4a36e225] [342c5fb9] [461ebd69] [5a70bf89] [463b3b5f48db2249] [e380ae76] [5cba5f23] [8717435e] [b3a0e5cf] [2865284b] [a127295d] [06f6e31a] [be6c4e49] [3de33eaa] [b369c6e8] [0c8499b8] [f614e920] [432326ef] [ac62cfbe] [cc419757] [8631be8e] [237fd40c] [3936a303] [fe3847bc] [241f4533] [2e5dbafd] [370fce67] [bff43019] [43c4a8a1] [a75a2e5d] [27bef1ff] [b31dd49f] [26409e34] [f2b8700a] [de034129] [21fa195d] [a75d83e6] [8df0354b] [07b7ecb3] [3d7dc357] [a44248cf] [1e89a00498496058]
