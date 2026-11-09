# django/test/utils

- Subject: django/test/utils (id `e3e92b2e-72d1-43c5-a4f8-371810b405e3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 13 of 149
- Conflicts: 0
- Gaps: 0

## Facts

- # Actually create the database for the first connection if first_alias is None: first_alias = alias with time_keeper.timed(" Creating '%s'" % alias): connection.creation.create_test_db( verbosity=verbosity, autoclobber=not interactive, keepdb=keepdb, ) if serialized_aliases is None or alias in serialized_aliases: serialize_connections.append(connection) if parallel > 1: for index in range(parallel): with time_keeper.timed(" Cloning '%s'" % alias): connection.creation.clone_test_db( suffix=str(index + 1), verbosity=verbosity, keepdb=keepdb, ) # Configure all other connections as mirrors of the first one else: connections[alias].creation.set_as_test_mirror( connections[first_alias].settings_dict ) [4263ebae]
- @wraps(func) def inner(*args, **kwargs): with self as context: if self.kwarg_name: kwargs[self.kwarg_name] = context return func(*args, **kwargs) [adbe3c3f]
- cls.setUp = setUp return cls raise TypeError("Can only decorate subclasses of unittest.TestCase") [a12b352d]
- def setUp(inner_self): context = self.enable() inner_self.addCleanup(self.disable) if self.attr_name: setattr(inner_self, self.attr_name, context) decorated_setUp(inner_self) [07950a4e]
- if "DEPENDENCIES" in test_settings: dependencies[alias] = test_settings["DEPENDENCIES"] else: if ( alias != DEFAULT_DB_ALIAS and connection.creation.test_db_signature() != default_sig ): dependencies[alias] = test_settings.get( "DEPENDENCIES", [DEFAULT_DB_ALIAS] ) [fe19ce15]
- # Try to find a DB that has all its dependencies met for signature, (db_name, aliases) in test_databases: if dependencies_map[signature].issubset(resolved_databases): resolved_databases.update(aliases) ordered_test_databases.append((signature, (db_name, aliases))) changed = True else: deferred.append((signature, (db_name, aliases))) [de50a15b]
- else: [6ad07797f4838346-14]
- if not changed: raise ImproperlyConfigured("Circular dependency in TEST[DEPENDENCIES]") test_databases = deferred return ordered_test_databases [76523bf6]
- if not issubclass(cls, SimpleTestCase): raise ValueError( "Only subclasses of Django SimpleTestCase can be decorated " "with override_settings" ) self.save_options(cls) return cls [c65425e2]
- if test_settings["MIRROR"]: # If the database is marked as a test mirror, save the alias. mirrored_aliases[alias] = test_settings["MIRROR"] elif alias in aliases: # Store a tuple with DB parameters that uniquely identify it. # If we have two aliases with the same values for that tuple, # we only need to create the test database once. item = test_databases.setdefault( connection.creation.test_db_signature(), (connection.settings_dict["NAME"], []), ) # The default database must be the first because data migrations # use the default alias by default. if alias == DEFAULT_DB_ALIAS: item[1].insert(0, alias) else: item[1].append(alias) [ac45c839]
- return inner [b9689d746b8236ce-4]
- self.registry = registry self.new_checks = new_checks self.deployment_checks = deployment_checks super().__init__() [575a3260]
- # Configure the test mirrors. for alias, mirror_alias in mirrored_aliases.items(): connections[alias].creation.set_as_test_mirror( connections[mirror_alias].settings_dict ) [210832e8]

## Beyond the budget

136 more facts did not fit in the budget: [e130dc76] [598a9158] [78ea7447] [990d8c4a] [d460bff5] [d539623a] [5249a8a2] [f6f14001] [d0a4d371] [c0ef8850] [3426e299] [a3dec1de] [a8ea4890] [a0b07f2d] [357247e3] [d78af972] [91ce023e] [cb62e7ff] [e05658d4] [45884091] [b2e5deef] [3570505b] [e92da6f4] [abc53248] [d461ef48] [88d05d6c] [7796ccf3] [b868483a] [da330370] [7ef1a45d] [2a9e9261] [0d672049] [f1a04016] [f0a7ddc935b65180-5] [286bab07] [1417e290] [c58109e1] [a3aa6fe7] [56bdd844] [5298b50d] [54f0afd9] [f14b3873] [9320e2b2] [a35667e7] [61aed685] [bc565f79] [60679974] [12284225] [85ae2dd5] [c4ea2b06] [01a7e88e] [59ef5aa7] [da82f500] [0dfba270] [a3156094] [8b2145f2] [336a8136] [6b8983a0] [f66ef300] [89a3f5ef] [5ba1b1b0] [f5cb84cc] [2acb1113] [9099a13b] [8b34adbd] [8c67fc5a] [283a8e3f] [dc922c04] [d67cc6d4] [127d9593] [4a0fa7c8] [47d6cb5b] [5806df51] [b8bb8e25] [9ccaf182] [7bfed7aa] [8a7383f9] [aac3da1d] [fa8d8331] [9d747066] [021b5df2d691cbd2-4] [06d68c23] [2766fbd4] [3c3fdd34] [f3c27240] [d3efd8aa] [f593c356] [9cf912bb] [3462c826] [7c79476f] [48c7108f] [916f8d78] [7ed45dbc] [656dcdb9] [4ded90b1] [59f4db18] [5df74386] [b48b210c] [f4e2fd96] [80204829] [af225c29] [0d542b1e] [c0266106] [214b3d74] [dfaca9f9] [0ebfd80d] [e9735252] [72ba85f4] [4a44251b] [dfaa13fd] [b065909d] [3fa9d610] [ea7c50d9] [40b79ad1] [69b9d892] [3f0b3b3d] [91f9fa0b] [3375a419] [d137f688] [6aceae21] [f4fc38fa] [a17f1432] [e9c4827c] [fe1153da] [18e4cb59] [611668da] [e75a35e6] [51258f78] [f146c29b] [e02d9bf6] [3b1a366d] [89a5b714] [08f82940] [52bd56be] [df8b2531] [d6854e4c]
