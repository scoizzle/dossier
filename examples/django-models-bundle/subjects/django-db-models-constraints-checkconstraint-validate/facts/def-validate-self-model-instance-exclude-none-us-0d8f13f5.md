# Fact 0d8f13f5

Store id: b89e3da7-dcf7-4ff5-a9c3-7510e47ddb3e

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
- posted_at: `2026-11-09T22:39:40.7133220+00:00`

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
  "id": "b89e3da7-dcf7-4ff5-a9c3-7510e47ddb3e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7133220+00:00"
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
  "subject_id": "73c6122c-9951-429d-9cba-f5ca4612a010",
  "subject_name": "django/db/models/constraints::CheckConstraint.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, model, instance, exclude=None, using=DEFAULT_DB_ALIAS)"
}
```
