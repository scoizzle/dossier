# Fact 26bac9c8

Store id: 3dbccd91-a4bc-453d-92fb-e256e7188669

## Text

```text
class SmallIntegerField(IntegerField)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.1758010+00:00`

## Data

```json
{
  "end_line": 2262,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2258,
  "symbol": "SmallIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2258,"selector":"L2258-L2262","symbol":"SmallIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SmallIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2262,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2258,
    "symbol": "SmallIntegerField"
  },
  "id": "3dbccd91-a4bc-453d-92fb-e256e7188669",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1758010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2258,
        "selector": "L2258-L2262",
        "symbol": "SmallIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4eeaf767-4c49-453f-9c4a-f2bd2be3d622",
  "subject_name": "django/db/models/fields/__init__::SmallIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class SmallIntegerField(IntegerField)"
}
```
