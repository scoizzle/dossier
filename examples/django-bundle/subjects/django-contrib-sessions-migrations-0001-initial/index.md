# django/contrib/sessions/migrations/0001_initial

- Subject: django/contrib/sessions/migrations/0001_initial (id `a25f7217-bd70-437b-91be-545d4e078000`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 201 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.CreateModel( name="Session", fields=[ ( "session_key", models.CharField( max_length=40, serialize=False, verbose_name="session key", primary_key=True, ), ), ("session_data", models.TextField(verbose_name="session data")), ( "expire_date", models.DateTimeField(verbose_name="expire date", db_index=True), ), ], options={ "abstract": False, "db_table": "django_session", "verbose_name": "session", "verbose_name_plural": "sessions", }, managers=[ ("objects", django.contrib.sessions.models.SessionManager()), ], ), ] [fd16937f]
- class Migration(migrations.Migration): dependencies = [] [25db17bb852de530-2]
- import django.contrib.sessions.models from django.db import migrations, models [d634ff4e]
