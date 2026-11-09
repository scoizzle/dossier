# django/contrib/auth/migrations/0009_alter_user_last_name_max_length

- Subject: django/contrib/auth/migrations/0009_alter_user_last_name_max_length (id `1c8bfcc4-4240-474f-86d2-7bc5ca0c9466`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 109 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="user", name="last_name", field=models.CharField( blank=True, max_length=150, verbose_name="last name" ), ), ] [c8e82c85]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0008_alter_user_username_max_length"), ] [41cbe85f]
- from django.db import migrations, models [b2ef032411bd05de-5]
