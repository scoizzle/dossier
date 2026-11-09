# django/contrib/sessions/migrations/0001_initial

- Subject: django/contrib/sessions/migrations/0001_initial (id `7598e529-89b2-4c5a-a9db-585d3fea69ce`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 201 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.CreateModel( name="Session", fields=[ ( "session_key", models.CharField( max_length=40, serialize=False, verbose_name="session key", primary_key=True, ), ), ("session_data", models.TextField(verbose_name="session data")), ( "expire_date", models.DateTimeField(verbose_name="expire date", db_index=True), ), ], options={ "abstract": False, "db_table": "django_session", "verbose_name": "session", "verbose_name_plural": "sessions", }, managers=[ ("objects", django.contrib.sessions.models.SessionManager()), ], ), ] [fd16937f]
- class Migration(migrations.Migration): dependencies = [] [25db17bb852de530-2]
- import django.contrib.sessions.models from django.db import migrations, models [d634ff4e]
