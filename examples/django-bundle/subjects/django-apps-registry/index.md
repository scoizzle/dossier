# django/apps/registry

- Subject: django/apps/registry (id `5c24e334-3415-497a-9adc-823d48818895`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 16 of 78
- Conflicts: 0
- Gaps: 0

## Facts

- self.app_configs[app_config.label] = app_config app_config.apps = self [4a524507]
- # An RLock prevents other threads from entering this section. The # compare and set operation below is atomic. if self.loading: # Prevent reentrant calls to avoid running AppConfig.ready() # methods twice. raise RuntimeError("populate() isn't reentrant") self.loading = True [9b3539d9]
- # Check for duplicate app names. counts = Counter( app_config.name for app_config in self.app_configs.values() ) duplicates = [name for name, count in counts.most_common() if count > 1] if duplicates: raise ImproperlyConfigured( "Application names aren't unique, " "duplicates: %s" % ", ".join(duplicates) ) [06d2e1bd]
- # If "not ready" is due to unconfigured settings, accessing # INSTALLED_APPS raises a more helpful ImproperlyConfigured # exception. settings.INSTALLED_APPS raise AppRegistryNotReady("Apps aren't loaded yet.") [b1d34100]
- # If the model has already been imported and registered, partially # apply it to the function now. If not, add it to the list of # pending operations for the model, where it will be executed with # the model class as its sole argument once the model is ready. try: model_class = self.get_registered_model(*next_model) except LookupError: self._pending_operations[next_model].append(apply_next_model) else: apply_next_model(model_class) [d83067d1]
- # Phase 1: initialize app configs and import app modules. for entry in installed_apps: if isinstance(entry, AppConfig): app_config = entry else: app_config = AppConfig.create(entry) if app_config.label in self.app_configs: raise ImproperlyConfigured( "Application labels aren't unique, " "duplicates: %s" % app_config.label ) [cbdb3ad8]
- # Phase 2: import models modules. for app_config in self.app_configs.values(): app_config.import_models() [582bb04b]
- # Phase 3: run ready() methods of app configs. for app_config in self.get_app_configs(): app_config.ready() [d7f7487c]
- # This will be executed after the class corresponding to next_model # has been imported and registered. The `func` attribute provides # duck-type compatibility with partials. def apply_next_model(model): next_function = partial(apply_next_model.func, model) self.lazy_model_operation(next_function, *more_models) [70533081]
- apply_next_model.func = function [558bd6bc]
- self.apps_ready = True [0ce03695]
- self.clear_cache() [75896620]
- self.models_ready = True [ab1d964c]
- self.ready = True self.ready_event.set() [6345c96f]
- # Lock for thread-safe population. self._lock = threading.RLock() self.loading = False [f8570bbc]
- # Mapping of app labels => model names => model classes. Every time a # model is imported, ModelBase.__new__ calls apps.register_model which # creates an entry in all_models. All imported models are registered, # regardless of whether they're defined in an installed application # and whether the registry has been populated. Since it isn't possible # to reimport a module safely (it could reexecute initialization code) # all_models is never overridden or reset. self.all_models = defaultdict(dict) [6b01d484]

## Beyond the budget

62 more facts did not fit in the budget: [6d6028d7] [27dfc202] [f24951f7] [884099c6] [72c67767] [081c47dd] [d5df7040777fbcfe-2] [302ca901] [fbac367176154586-2] [2e54a177] [32a15af2] [4703c71c] [ba0e12d0] [0fb3690d] [838bb9ec] [6703211c] [ced89810] [ba451113] [86136e33] [0e63681e] [a6347c68] [511245d9] [c801d457] [1bfae6d1] [c537d71a] [33d019bb] [e62db605] [775e7e62] [654e9ce1] [bc2e5220] [619a6899] [0aba594f] [1b75512d] [4b4a0af6] [0a07df47] [dd7dd871] [161e4d89] [ae36ad68] [1cc03028] [4762cf52] [317477fc] [270b217f] [76534590] [3d8f3c31] [b1434ec0] [3535f75e] [ed9eb57d] [ca0ad36e] [db99263d] [340e2d63] [1204a0e4] [5e43ab8c] [74c76d78] [87b6b835] [54876249] [32992197] [152d949a] [c5b26a91] [2e70c95f] [ff117d74] [65c1c45b] [4302b83c]
