# Fact 26bfc784

Store id: 72502656-23c9-416c-b613-ff28a15cd889

## Text

```text
def check(self, model, connection)
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
- posted_at: `2026-11-09T22:39:40.7028260+00:00`

## Data

```json
{
  "end_line": 75,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 74,
  "symbol": "BaseConstraint.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L75","symbol":"BaseConstraint.check"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 75,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 74,
    "symbol": "BaseConstraint.check"
  },
  "id": "72502656-23c9-416c-b613-ff28a15cd889",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7028260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L75",
        "symbol": "BaseConstraint.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "78759347-ed4e-4cb6-9094-55f50ec7fd36",
  "subject_name": "django/db/models/constraints::BaseConstraint.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, model, connection)"
}
```
