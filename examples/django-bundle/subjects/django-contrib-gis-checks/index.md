# django/contrib/gis/checks

- Subject: django/contrib/gis/checks (id `6128b191-636c-4ad8-8e08-37e5c72bdaf2`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 145 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- W001 = Warning( "The installed version of GDAL does not allow blocking file and network " "access. Upgrade to GDAL 3.9 or higher to receive protection against " "malicious spatial references.", id="gis.W001", hint=f"Your version: {GDAL_VERSION}", ) [e9152500]
- def check_gdal_39(app_configs, **kwargs): errors = [] if GDAL_VERSION < (3, 9): errors.append(W001) return errors [dd48eb40]
- from django.contrib.gis.gdal import GDAL_VERSION from django.core.checks import Warning [188d78a2]
