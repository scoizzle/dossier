# Fact 0e2e2ae0

Store id: 48347aab-8398-490e-9bc1-72201c9f3627

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
- posted_at: `2026-11-09T22:39:40.7082730+00:00`

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
  "id": "48347aab-8398-490e-9bc1-72201c9f3627",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7082730+00:00"
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
  "subject_id": "de8b4e21-53be-43ad-b810-a1448d88ff1d",
  "subject_name": "django/db/models/constraints::CheckConstraint",
  "tags": [
    "entity:class"
  ],
  "text": "class CheckConstraint(BaseConstraint)"
}
```
