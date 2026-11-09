# django/utils/version

- Subject: django/utils/version (id `dd98d9b3-7719-4af8-9f90-d63080596882`)
- Kind: subject
- Budget: 1200 tokens
- Used: 877 tokens
- Facts shown: 16 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- # Now build the two parts of the version number: # main = X.Y[.Z] # sub = .devN - for pre-alpha releases # | {a|b|rc}N - for alpha, beta, and rc releases [e42e3663]
- The result is the UTC timestamp of the changeset in YYYYMMDDHHMMSS format. This value isn't guaranteed to be unique, but collisions are very unlikely, so it's sufficient for generating the development version numbers. """ # Repository may not be found if __file__ is undefined, e.g. in a frozen # module. if "__file__" not in globals(): return None repo_dir = os.path.dirname(os.path.dirname(os.path.abspath(__file__))) git_log = subprocess.run( "git log --pretty=format:%ct --quiet -1 HEAD", capture_output=True, shell=True, cwd=repo_dir, text=True, ) timestamp = git_log.stdout tz = datetime.UTC try: timestamp = datetime.datetime.fromtimestamp(int(timestamp), tz=tz) except ValueError: return None return timestamp.strftime("%Y%m%d%H%M%S") [fa94fac5]
- elif version[3] != "final": mapping = {"alpha": "a", "beta": "b", "rc": "rc"} sub = mapping[version[3]] + str(version[4]) [e239be0b]
- main = get_main_version(version) [52b4e493]
- return main + sub [f728c41a]
- return version [0980ec44]
- sub = "" if version[3] == "alpha" and version[4] == 0: git_changeset = get_git_changeset() if git_changeset: sub = ".dev%s" % git_changeset [2dcf1ce1]
- # Private, stable API for detecting the Python implementation. PYPY = sys.implementation.name == "pypy" [c35a0021]
- # Private, stable API for detecting the Python version. PYXY means "Python X.Y # or later". So that third-party apps can use these values, each constant # should remain as long as the oldest supported Django version supports that # Python version. PY310 = sys.version_info >= (3, 10) PY311 = sys.version_info >= (3, 11) PY312 = sys.version_info >= (3, 12) PY313 = sys.version_info >= (3, 13) PY314 = sys.version_info >= (3, 14) PY315 = sys.version_info >= (3, 15) [9c9a0175]
- @functools.lru_cache def get_git_changeset(): """Return a numeric identifier of the latest git changeset. [997f6f53]
- def get_complete_version(version=None): """ Return a tuple of the django version. If version argument is non-empty, check for correctness of the tuple provided. """ if version is None: from django import VERSION as version else: assert len(version) == 5 assert version[3] in ("alpha", "beta", "rc", "final") [32fe8433]
- def get_docs_version(version=None): version = get_complete_version(version) if version[3] != "final": return "dev" else: return "%d.%d" % version[:2] [aacab218]
- def get_main_version(version=None): """Return main version (X.Y[.Z]) from VERSION.""" version = get_complete_version(version) parts = 2 if version[2] == 0 else 3 return ".".join(str(x) for x in version[:parts]) [3e37db0d]
- def get_version(version=None): """Return a PEP 440-compliant version number from VERSION.""" version = get_complete_version(version) [acf44363]
- from django.utils.regex_helper import _lazy_re_compile [e384d60811aaeff5-2]
- import datetime import functools import os import subprocess import sys [6f81ca69]

## Beyond the budget

2 more facts did not fit in the budget: [8b85b832] [4bb8dfc3]
