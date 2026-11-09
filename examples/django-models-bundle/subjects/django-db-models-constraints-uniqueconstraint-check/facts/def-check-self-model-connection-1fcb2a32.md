# Fact 1fcb2a32

Store id: 2184954c-a9c1-4fa7-bc1b-26825a67eedb

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
- posted_at: `2026-11-09T23:31:54.2260580+00:00`

## Data

```json
{
  "end_line": 440,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 344,
  "symbol": "UniqueConstraint.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":344,"selector":"L344-L440","symbol":"UniqueConstraint.check"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 440,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 344,
    "symbol": "UniqueConstraint.check"
  },
  "id": "2184954c-a9c1-4fa7-bc1b-26825a67eedb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.2260580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 344,
        "selector": "L344-L440",
        "symbol": "UniqueConstraint.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "6112b979-abaf-4a4d-a054-6890456b7109",
  "subject_name": "django/db/models/constraints::UniqueConstraint.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, model, connection)"
}
```
