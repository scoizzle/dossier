# Fact 1e5c6ab1

Store id: 0214db4b-a2c6-4607-811e-a7cb0628c05e

## Text

```text
class SmallAutoField(AutoFieldMixin, SmallIntegerField)
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
- posted_at: `2026-11-09T23:44:50.3442960+00:00`

## Data

```json
{
  "end_line": 2984,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2979,
  "symbol": "SmallAutoField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2979,"selector":"L2979-L2984","symbol":"SmallAutoField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SmallAutoField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2984,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2979,
    "symbol": "SmallAutoField"
  },
  "id": "0214db4b-a2c6-4607-811e-a7cb0628c05e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3442960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2979,
        "selector": "L2979-L2984",
        "symbol": "SmallAutoField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "24c09999-d4d3-4ad4-822a-01a199fd3f09",
  "subject_name": "django/db/models/fields/__init__::SmallAutoField",
  "tags": [
    "entity:class"
  ],
  "text": "class SmallAutoField(AutoFieldMixin, SmallIntegerField)"
}
```
