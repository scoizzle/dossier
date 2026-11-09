# django/contrib/staticfiles/testing

- Subject: django/contrib/staticfiles/testing (id `4ef366e9-0106-4b43-a3d8-f63448fbd02b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 140 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- static_handler = StaticFilesHandler [3cf60040]
- class StaticLiveServerTestCase(LiveServerTestCase): """ Extend django.test.LiveServerTestCase to transparently overlay at test execution-time the assets provided by the staticfiles app finders. This means you don't need to run collectstatic before or as a part of your tests setup. """ [5f02434d]
- from django.contrib.staticfiles.handlers import StaticFilesHandler from django.test import LiveServerTestCase [72ad14bb]
