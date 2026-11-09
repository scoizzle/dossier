# django/contrib/auth/management/commands/createsuperuser

- Subject: django/contrib/auth/management/commands/createsuperuser (id `e8b70b2c-811a-425d-824a-805ebc380645`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 8 of 20
- Conflicts: 0
- Gaps: 0

## Facts

- if not field.many_to_many: fake_user_data[field_name] = user_data[field_name] # Wrap any foreign keys in fake model instances. if field.many_to_one: fake_user_data[field_name] = field.remote_field.model( user_data[field_name] ) [7feec63d]
- # Prompt for a password if the model has one. while PASSWORD_FIELD in user_data and user_data[PASSWORD_FIELD] is None: password = getpass.getpass() password2 = getpass.getpass("Password (again): ") if password != password2: self.stderr.write("Error: Your passwords didn't match.") # Don't validate passwords that don't match. continue if password.strip() == "": self.stderr.write("Error: Blank passwords aren't allowed.") # Don't validate blank passwords. continue try: validate_password(password2, self.UserModel(**fake_user_data)) except exceptions.ValidationError as err: self.stderr.write("\n".join(err.messages)) response = input( "Bypass password validation and create user anyway? [y/N]: " ) if response.lower() != "y": continue user_data[PASSWORD_FIELD] = password else: # Non-interactive mode. # Use password from environment variable, if provided. if ( PASSWORD_FIELD in user_data and "DJANGO_SUPERUSER_PASSWORD" in os.environ ): user_data[PASSWORD_FIELD] = os.environ["DJANGO_SUPERUSER_PASSWORD"] # Use username from environment variable, if not provided in # options. if username is None: username = os.environ.get( "DJANGO_SUPERUSER_" + self.UserModel.USERNAME_FIELD.upper() ) if username is None: raise CommandError( "You must use --%s with --noinput." % self.UserModel.USERNAME_FIELD ) else: error_msg = self._validate_username( username, verbose_field_name, database ) if error_msg: raise CommandError(error_msg) [8bba9962]
- user_data[self.UserModel.USERNAME_FIELD] = username for field_name in self.UserModel.REQUIRED_FIELDS: env_var = "DJANGO_SUPERUSER_" + field_name.upper() value = options[field_name] or os.environ.get(env_var) field = self.UserModel._meta.get_field(field_name) if not value: if field.blank and ( options[field_name] == "" or os.environ.get(env_var) == "" ): continue raise CommandError( "You must use --%s with --noinput." % field_name ) user_data[field_name] = field.clean(value, None) if field.many_to_many and isinstance(user_data[field_name], str): user_data[field_name] = [ pk.strip() for pk in user_data[field_name].split(",") ] [7da7fb94]
- self.UserModel._default_manager.db_manager(database).create_superuser( **user_data ) if options["verbosity"] >= 1: self.stdout.write("Superuser created successfully.") except KeyboardInterrupt: self.stderr.write("\nOperation cancelled.") sys.exit(1) except exceptions.ValidationError as e: raise CommandError("; ".join(e.messages)) except NotRunningInTTYException: self.stdout.write( "Superuser creation skipped due to not running in a TTY. " "You can run `manage.py createsuperuser` in your project " "to create one manually." ) [2138a1cb]
- return val [849bb75a]
- @cached_property def natural_key_defined(self): return hasattr(self.UserModel._default_manager, "get_by_natural_key") [c78c7859]
- @cached_property def username_is_unique(self): if self.username_field.unique: return True return any( len(unique_constraint.fields) == 1 and unique_constraint.fields[0] == self.username_field.name for unique_constraint in self.UserModel._meta.total_unique_constraints ) [216660e0]
- PASSWORD_FIELD = "password" [815461d5]

## Beyond the budget

12 more facts did not fit in the budget: [bb27f807] [093bfbcc] [d491653c] [d919fa0b] [c40bfb3c] [1a193870] [3c1bfd21] [f6150eed] [2ffd1500] [bf62d685] [442cb376] [10ac1b32]
