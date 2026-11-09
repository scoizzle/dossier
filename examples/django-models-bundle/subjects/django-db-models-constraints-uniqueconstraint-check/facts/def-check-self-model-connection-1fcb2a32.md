# Fact 1fcb2a32

Store id: 334a8045-1e2a-462a-9e00-0c0727aee152

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
- posted_at: `2026-11-09T23:44:48.7859910+00:00`

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
  "id": "334a8045-1e2a-462a-9e00-0c0727aee152",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7859910+00:00"
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
  "subject_id": "303554a6-5baa-4421-bbc8-989e5b5c26fa",
  "subject_name": "django/db/models/constraints::UniqueConstraint.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, model, connection)"
}
```
