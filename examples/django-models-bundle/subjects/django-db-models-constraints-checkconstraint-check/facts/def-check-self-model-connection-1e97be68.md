# Fact 1e97be68

Store id: bd971199-9e5f-41a8-a0a4-cb268fe3d9da

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
- posted_at: `2026-11-09T23:44:48.7780960+00:00`

## Data

```json
{
  "end_line": 192,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 155,
  "symbol": "CheckConstraint.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":155,"selector":"L155-L192","symbol":"CheckConstraint.check"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 192,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 155,
    "symbol": "CheckConstraint.check"
  },
  "id": "bd971199-9e5f-41a8-a0a4-cb268fe3d9da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7780960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 155,
        "selector": "L155-L192",
        "symbol": "CheckConstraint.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "7f6572d1-1ea7-4501-a3a1-9e6e2b8f627a",
  "subject_name": "django/db/models/constraints::CheckConstraint.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, model, connection)"
}
```
