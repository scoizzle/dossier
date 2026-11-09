# Fact 0e2e2ae0

Store id: 2a1da395-5bdd-4cb9-8e78-cde8532a97fa

## Text

```text
class CheckConstraint(BaseConstraint)
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
- posted_at: `2026-11-09T23:31:54.1619150+00:00`

## Data

```json
{
  "end_line": 257,
  "entity_kind": "class",
  "parent": "constraints",
  "start_line": 135,
  "symbol": "CheckConstraint"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L257","symbol":"CheckConstraint"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 257,
    "entity_kind": "class",
    "parent": "constraints",
    "start_line": 135,
    "symbol": "CheckConstraint"
  },
  "id": "2a1da395-5bdd-4cb9-8e78-cde8532a97fa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1619150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L257",
        "symbol": "CheckConstraint"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "cdd9473b-97b6-48d4-b9b0-4493fa358521",
  "subject_name": "django/db/models/constraints::CheckConstraint",
  "tags": [
    "entity:class"
  ],
  "text": "class CheckConstraint(BaseConstraint)"
}
```
