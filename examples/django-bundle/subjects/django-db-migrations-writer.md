# django/db/migrations/writer

- Subject: django/db/migrations/writer (id `a55d1629-fb84-4776-8696-fc45f2f6d34f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 9 of 43
- Conflicts: 0
- Gaps: 0

## Facts

- # Alright, see if it's a direct submodule of the app app_config = apps.get_app_config(self.migration.app_label) ( maybe_app_name, _, migrations_package_basename, ) = migrations_package_name.rpartition(".") if app_config.name == maybe_app_name: return os.path.join(app_config.path, migrations_package_basename) [30ebaded]
- # Deconstruct operations operations = [] for operation in self.migration.operations: operation_string, operation_imports = OperationWriter(operation).serialize() imports.update(operation_imports) operations.append(operation_string) items["operations"] = "\n".join(operations) + "\n" if operations else "" [cad07684]
- # Format dependencies and write out swappable dependencies right dependencies = [] for dependency in self.migration.dependencies: if dependency[0] == "__setting__": dependencies.append( " migrations.swappable_dependency(settings.%s)," % dependency[1] ) imports.add("from django.conf import settings") else: dependencies.append(" %s," % self.serialize(dependency)[0]) items["dependencies"] = ( "\n".join(sorted(dependencies)) + "\n" if dependencies else "" ) [ff630e5b]
- # Format imports nicely, swapping imports of functions from migration # files for comments migration_imports = set() for line in list(imports): if re.match(r"^import (.*)\.\d+[^\s]*$", line): migration_imports.add(line.split("import")[1].strip()) imports.remove(line) self.needs_manual_porting = True [d9307a96]
- # In case of using MIGRATION_MODULES setting and the custom package # doesn't exist, create one, starting from an existing package existing_dirs, missing_dirs = migrations_package_name.split("."), [] while existing_dirs: missing_dirs.insert(0, existing_dirs.pop(-1)) try: base_module = import_module(".".join(existing_dirs)) except (ImportError, ValueError): continue else: try: base_dir = module_dir(base_module) except ValueError: continue else: break else: raise ValueError( "Could not locate an appropriate location to create " "migrations package %s. Make sure the toplevel " "package exists and can be imported." % migrations_package_name ) [5991588a]
- # See if this operation is in django.db.migrations. If it is, # We can just use the fact we already have that imported, # otherwise, we need to add an import for the operation class. if getattr(migrations, name, None) == self.operation.__class__: self.feed("migrations.%s(" % name) else: imports.add("import %s" % (self.operation.__class__.__module__)) self.feed("%s.%s(" % (self.operation.__class__.__module__, name)) [56f6aa34]
- # See if we can import the migrations module directly try: migrations_module = import_module(migrations_package_name) except ImportError: pass else: try: return module_dir(migrations_module) except ValueError: pass [d893930c]
- # django.db.migrations is always used, but models import may not be. # If models import exists, merge it with migrations import. if "from django.db import models" in imports: imports.discard("from django.db import models") imports.add("from django.db import migrations, models") else: imports.add("from django.db import migrations") [146ac11a]
- final_dir = os.path.join(base_dir, *missing_dirs) os.makedirs(final_dir, exist_ok=True) for missing_dir in missing_dirs: base_dir = os.path.join(base_dir, missing_dir) with open(os.path.join(base_dir, "__init__.py"), "w"): pass [58f6dcbe]

## Beyond the budget

34 more facts did not fit in the budget: [2771191c] [ba9fa5dd] [38482298] [d050d4f3] [3e5691e8] [936ac5ae] [8c90410c] [3ca87fcb] [bfe9b4ba] [b9e35cf9] [2237818a] [c21a01fc] [a5c81933] [9d8915dd] [68e040b9] [72a6ae6f] [bb9498c6] [a8439194] [8c29361b] [19544e23] [daac68d1] [865a4a8f] [5a0c1d70] [0b84ffd4] [fc8336d4] [d346d78f8c109f45-3] [008fc6cf] [c21161ac] [55c684e1] [c8186708] [b1477b6b] [5a1e0cc1] [211d9954] [107fc362]
