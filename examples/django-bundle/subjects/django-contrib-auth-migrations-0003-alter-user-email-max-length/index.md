# django/contrib/auth/migrations/0003_alter_user_email_max_length

- Subject: django/contrib/auth/migrations/0003_alter_user_email_max_length (id `5ee83f97-930e-4611-91da-0c8cbf83ba18`)
- Kind: subject
- Budget: 1200 tokens
- Used: 110 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="user", name="email", field=models.EmailField( max_length=254, verbose_name="email address", blank=True ), ), ] [9c81673b]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0002_alter_permission_name_max_length"), ] [7bafa413]
- from django.db import migrations, models [b2ef032411bd05de-3]
