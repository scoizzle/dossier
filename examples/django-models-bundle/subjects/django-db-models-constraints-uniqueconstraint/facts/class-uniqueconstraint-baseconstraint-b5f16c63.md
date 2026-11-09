# Fact b5f16c63

Store id: 54c2a5c1-1380-4646-8f94-b13b5134c0b3

## Text

```text
class UniqueConstraint(BaseConstraint)
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
- posted_at: `2026-11-09T23:44:48.7843070+00:00`

## Data

```json
{
  "end_line": 686,
  "entity_kind": "class",
  "parent": "constraints",
  "start_line": 269,
  "symbol": "UniqueConstraint"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":269,"selector":"L269-L686","symbol":"UniqueConstraint"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 686,
    "entity_kind": "class",
    "parent": "constraints",
    "start_line": 269,
    "symbol": "UniqueConstraint"
  },
  "id": "54c2a5c1-1380-4646-8f94-b13b5134c0b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7843070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 269,
        "selector": "L269-L686",
        "symbol": "UniqueConstraint"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "a2a66c72-04f8-4283-9062-0585fcea9147",
  "subject_name": "django/db/models/constraints::UniqueConstraint",
  "tags": [
    "entity:class"
  ],
  "text": "class UniqueConstraint(BaseConstraint)"
}
```
