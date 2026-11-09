# Fact 0d8f13f5

Store id: f46246a9-f660-42a6-bae9-afff1a8863c9

## Text

```text
def validate(self, model, instance, exclude=None, using=DEFAULT_DB_ALIAS)
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
- posted_at: `2026-11-09T23:44:48.7810220+00:00`

## Data

```json
{
  "end_line": 224,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 212,
  "symbol": "CheckConstraint.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":212,"selector":"L212-L224","symbol":"CheckConstraint.validate"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 224,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 212,
    "symbol": "CheckConstraint.validate"
  },
  "id": "f46246a9-f660-42a6-bae9-afff1a8863c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7810220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 212,
        "selector": "L212-L224",
        "symbol": "CheckConstraint.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "beb404b5-f8d5-4e59-b4d1-77b746830b12",
  "subject_name": "django/db/models/constraints::CheckConstraint.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, model, instance, exclude=None, using=DEFAULT_DB_ALIAS)"
}
```
