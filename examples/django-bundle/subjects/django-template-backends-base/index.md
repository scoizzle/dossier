# django/template/backends/base

- Subject: django/template/backends/base (id `5eabdde2-3ca2-4253-b58e-b5755cb7160e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 705 tokens
- Facts shown: 14 facts
- Conflicts: 0
- Gaps: 0

## Facts

- Ignore files that don't lie inside configured template dirs to avoid directory traversal attacks. """ for template_dir in self.template_dirs: try: yield safe_join(template_dir, template_name) except SuspiciousFileOperation: # The joined path was located outside of this template_dir # (it might be inside another one, so this isn't fatal). pass [aca753dd]
- Raise TemplateDoesNotExist if no such template exists. """ raise NotImplementedError( "subclasses of BaseEngine must provide a get_template() method" ) [5cf86db7]
- This method is optional. """ raise NotImplementedError( "subclasses of BaseEngine should provide a from_string() method" ) [4a7ab107]
- `params` is a dict of configuration settings. """ params = params.copy() self.name = params.pop("NAME") self.dirs = list(params.pop("DIRS")) self.app_dirs = params.pop("APP_DIRS") if params: raise ImproperlyConfigured( "Unknown parameters: {}".format(", ".join(params)) ) [8f72e5a5]
- # Utility methods: they are provided to minimize code duplication and # security issues in third-party backends. [85e35457]
- @cached_property def template_dirs(self): """ Return a list of directories to search for templates. """ # Immutable return value because it's cached and shared by callers. template_dirs = tuple(self.dirs) if self.app_dirs: template_dirs += get_app_template_dirs(self.app_dirname) return template_dirs [3291a4da]
- @property def app_dirname(self): raise ImproperlyConfigured( "{} doesn't support loading templates from installed " "applications.".format(self.__class__.__name__) ) [a5933f02]
- def __init__(self, params): """ Initialize the template engine. [5496aad6]
- def check(self, **kwargs): return [] [29d2ea2570acf4bf-4]
- def from_string(self, template_code): """ Create and return a template for the given source code. [00221739]
- def get_template(self, template_name): """ Load and return a template for the given name. [cf122f1a]
- def iter_template_filenames(self, template_name): """ Iterate over candidate files for template_name. [27d259e5]
- class BaseEngine: # Core methods: engines have to provide their own implementation # (except for from_string which is optional). [104fe7f4]
- from django.core.exceptions import ImproperlyConfigured, SuspiciousFileOperation from django.template.utils import get_app_template_dirs from django.utils._os import safe_join from django.utils.functional import cached_property [47a253af]
