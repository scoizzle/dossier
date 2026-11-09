# Fact 1e97be68

Store id: 6aa41b67-85fc-4734-8377-852eca5f9bef

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
- posted_at: `2026-11-09T22:39:40.7099440+00:00`

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
  "id": "6aa41b67-85fc-4734-8377-852eca5f9bef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7099440+00:00"
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
  "subject_id": "82fb6acb-7d59-46fd-8f83-e95e27f807a8",
  "subject_name": "django/db/models/constraints::CheckConstraint.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, model, connection)"
}
```
