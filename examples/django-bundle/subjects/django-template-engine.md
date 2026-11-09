# django/template/engine

- Subject: django/template/engine (id `1036a055-44d7-44a2-897f-d74b2bb7fcec`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 14 of 28
- Conflicts: 0
- Gaps: 0

## Facts

- >>> from django.template import Context, Template >>> template = Template("Hello {{ name }}!") >>> context = Context({'name': "world"}) >>> template.render(context) 'Hello world!' """ # Since Engine is imported in django.template and since # DjangoTemplates is a wrapper around this Engine class, # local imports are required to avoid import loops. from django.template import engines from django.template.backends.django import DjangoTemplates [36a4dd44]
- This is required for preserving historical APIs that rely on a globally available, implicitly configured engine such as: [69630623]
- extra_data = getattr(template, "extra_data", {}) try: partial = extra_data["partials"][partial_name] except (KeyError, TypeError): raise TemplateDoesNotExist(partial_name, tried=[template_name]) partial.engine = self [a53e2fac]
- for engine in engines.all(): if isinstance(engine, DjangoTemplates): return engine.engine raise ImproperlyConfigured("No DjangoTemplates backend is configured.") [6b0c5ff8]
- if isinstance(loader, str): loader_class = import_string(loader) return loader_class(self, *args) else: raise ImproperlyConfigured( "Invalid value in template loaders configuration: %r" % loader ) [b62260c4]
- if not partial_name: return template [69597ffa]
- if not template_name: raise TemplateDoesNotExist(original_name) [4e229264]
- return partial [2f197fc8]
- self.dirs = dirs self.app_dirs = app_dirs self.autoescape = autoescape self.context_processors = context_processors self.debug = debug self.loaders = loaders self.string_if_invalid = string_if_invalid self.file_charset = file_charset self.libraries = libraries self.template_libraries = self.get_template_libraries(libraries) self.builtins = self.default_builtins + builtins self.template_builtins = self.get_template_builtins(self.builtins) [9c7d5d32]
- template, origin = self.find_template(template_name) if not hasattr(template, "render"): # template needs to be compiled template = Template(template, origin, template_name, engine=self) [fa386019]
- @cached_property def template_context_processors(self): context_processors = _builtin_context_processors context_processors += tuple(self.context_processors) return tuple(import_string(path) for path in context_processors) [05d27ca8]
- @cached_property def template_loaders(self): return self.get_template_loaders(self.loaders) [0da8af3b]
- @staticmethod @functools.lru_cache def get_default(): """ Return the first DjangoTemplates backend that's configured, or raise ImproperlyConfigured if none are configured. [b63f0c81]
- def __repr__(self): return ( "<%s:%s app_dirs=%s%s debug=%s loaders=%s string_if_invalid=%s " "file_charset=%s%s%s autoescape=%s>" ) % ( self.__class__.__qualname__, "" if not self.dirs else " dirs=%s" % repr(self.dirs), self.app_dirs, ( "" if not self.context_processors else " context_processors=%s" % repr(self.context_processors) ), self.debug, repr(self.loaders), repr(self.string_if_invalid), repr(self.file_charset), "" if not self.libraries else " libraries=%s" % repr(self.libraries), "" if not self.builtins else " builtins=%s" % repr(self.builtins), repr(self.autoescape), ) [ba27dddb]

## Beyond the budget

14 more facts did not fit in the budget: [8c09ae93] [dd698e54] [f260bcde] [4ab05bc1] [bbfea86a] [77b60332] [1881bf81] [d34dcd79] [5412547d] [0f47b3d3] [b07ff625] [34b8f831] [a7f2f4c0] [54adcbf441065810-3]
