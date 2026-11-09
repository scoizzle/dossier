# django/contrib/staticfiles/testing

- Subject: django/contrib/staticfiles/testing (id `582839d7-19fb-48ad-93ab-5980fb652125`)
- Kind: subject
- Budget: 1200 tokens
- Used: 140 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- static_handler = StaticFilesHandler [3cf60040]
- class StaticLiveServerTestCase(LiveServerTestCase): """ Extend django.test.LiveServerTestCase to transparently overlay at test execution-time the assets provided by the staticfiles app finders. This means you don't need to run collectstatic before or as a part of your tests setup. """ [5f02434d]
- from django.contrib.staticfiles.handlers import StaticFilesHandler from django.test import LiveServerTestCase [72ad14bb]
