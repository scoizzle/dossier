# Fact 1e97be68

Store id: bd4d2191-dd98-48a5-906f-796dd7004cbf

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
- posted_at: `2026-11-09T23:31:54.1658320+00:00`

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
  "id": "bd4d2191-dd98-48a5-906f-796dd7004cbf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1658320+00:00"
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
  "subject_id": "d1ef9396-a5b5-4bc0-8cb8-651fce281de7",
  "subject_name": "django/db/models/constraints::CheckConstraint.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, model, connection)"
}
```
