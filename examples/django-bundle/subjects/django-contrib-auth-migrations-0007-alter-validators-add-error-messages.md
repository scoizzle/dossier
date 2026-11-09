# django/contrib/auth/migrations/0007_alter_validators_add_error_messages

- Subject: django/contrib/auth/migrations/0007_alter_validators_add_error_messages (id `4715231b-5ae6-4bce-a07e-74afbaac03dd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 172 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="user", name="username", field=models.CharField( error_messages={"unique": "A user with that username already exists."}, help_text=( "Required. 30 characters or fewer. Letters, digits and @/./+/-/_ " "only." ), max_length=30, unique=True, validators=[validators.UnicodeUsernameValidator()], verbose_name="username", ), ), ] [cc5e6e0a]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0006_require_contenttypes_0002"), ] [03a4588b]
- from django.contrib.auth import validators from django.db import migrations, models [95f632b04cf7fe2b-2]
