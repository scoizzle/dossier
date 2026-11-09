# Fact df3e8451

Store id: fa9571cf-89e3-4cb2-9e55-e7c85b6e5432

## Text

```text
def _check_primary_key(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.3923680+00:00`

## Data

```json
{
  "end_line": 291,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 280,
  "symbol": "FileField._check_primary_key"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":280,"selector":"L280-L291","symbol":"FileField._check_primary_key"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField._check_primary_key](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 291,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 280,
    "symbol": "FileField._check_primary_key"
  },
  "id": "fa9571cf-89e3-4cb2-9e55-e7c85b6e5432",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3923680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 280,
        "selector": "L280-L291",
        "symbol": "FileField._check_primary_key"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "714535e2-490b-433c-aad2-d196a6c6a126",
  "subject_name": "django/db/models/fields/files::FileField._check_primary_key",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_primary_key(self)"
}
```
