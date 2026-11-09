# Fact df3e8451

Store id: 2faa8eb7-f900-49c0-bfd1-2c82c3328cbe

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
- posted_at: `2026-11-09T23:44:50.6533360+00:00`

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
  "id": "2faa8eb7-f900-49c0-bfd1-2c82c3328cbe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6533360+00:00"
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
  "subject_id": "eb0867fd-029f-4c31-a864-8f337c77e943",
  "subject_name": "django/db/models/fields/files::FileField._check_primary_key",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_primary_key(self)"
}
```
