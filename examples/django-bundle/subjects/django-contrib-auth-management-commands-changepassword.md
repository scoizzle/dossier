# django/contrib/auth/management/commands/changepassword

- Subject: django/contrib/auth/management/commands/changepassword (id `84fb3251-9020-4eff-be8e-b0979cc6f395`)
- Kind: subject
- Budget: 1200 tokens
- Used: 644 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- MAX_TRIES = 3 count = 0 p1, p2 = 1, 2 # To make them initially mismatch. password_validated = False while (p1 != p2 or not password_validated) and count < MAX_TRIES: p1 = self._get_pass() p2 = self._get_pass("Password (again): ") if p1 != p2: self.stdout.write("Passwords do not match. Please try again.") count += 1 # Don't validate passwords that don't match. continue try: validate_password(p2, u) except ValidationError as err: self.stderr.write("\n".join(err.messages)) count += 1 else: password_validated = True [3222d757]
- if count == MAX_TRIES: raise CommandError( "Aborting password change for user '%s' after %s attempts" % (u, count) ) [70d5181f]
- return "Password changed successfully for user '%s'" % u [c6f22e90]
- self.stdout.write("Changing password for user '%s'" % u) [de6fcd39]
- try: u = UserModel._default_manager.using(options["database"]).get( **{UserModel.USERNAME_FIELD: username} ) except UserModel.DoesNotExist: raise CommandError("user '%s' does not exist" % username) [db59e142]
- u.set_password(p1) u.save() [6acd417b]
- def _get_pass(self, prompt="Password: "): p = getpass.getpass(prompt=prompt) if not p: raise CommandError("aborted") return p [e1f1270f]
- def add_arguments(self, parser): parser.add_argument( "username", nargs="?", help=( "Username to change password for; by default, it's the current " "username." ), ) parser.add_argument( "--database", default=DEFAULT_DB_ALIAS, choices=tuple(connections), help='Specifies the database to use. Default is "default".', ) [75f71a14]
- def handle(self, *args, **options): if options["username"]: username = options["username"] else: username = getpass.getuser() [f576f115]
- UserModel = get_user_model() [890d18efd7375f44-2]
- class Command(BaseCommand): help = "Change a user's password for django.contrib.auth." requires_migrations_checks = True requires_system_checks = [] [37d0b0e0]
- from django.contrib.auth import get_user_model from django.contrib.auth.password_validation import validate_password from django.core.exceptions import ValidationError from django.core.management.base import BaseCommand, CommandError from django.db import DEFAULT_DB_ALIAS, connections [60fb49b7]
- import getpass [86c84fa3]
