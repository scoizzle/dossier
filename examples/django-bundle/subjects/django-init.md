# django/__init__

- Subject: django/__init__ (id `67143513-38b4-450f-aec1-4bc2c58133e2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 233 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- configure_logging(settings.LOGGING_CONFIG, settings.LOGGING) if set_prefix: set_script_prefix( "/" if settings.FORCE_SCRIPT_NAME is None else settings.FORCE_SCRIPT_NAME ) apps.populate(settings.INSTALLED_APPS) [5a9be696]
- VERSION = (6, 1, 3, "final", 0) [bf895ccf]
- __version__ = get_version(VERSION) [fc5f7320]
- def setup(set_prefix=True): """ Configure the settings (this happens as a side effect of accessing the first setting), configure logging and populate the app registry. Set the thread-local urlresolvers script prefix if `set_prefix` is True. """ from django.apps import apps from django.conf import settings from django.urls import set_script_prefix from django.utils.log import configure_logging [eaf58180]
- from django.utils.version import get_version [354faf8b]
