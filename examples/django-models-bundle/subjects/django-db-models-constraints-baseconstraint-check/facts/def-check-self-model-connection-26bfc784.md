# Fact 26bfc784

Store id: e95a07cc-cfff-4dd1-a78f-660cc1b22153

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
- posted_at: `2026-11-09T23:31:54.1552370+00:00`

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
  "id": "e95a07cc-cfff-4dd1-a78f-660cc1b22153",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1552370+00:00"
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
  "subject_id": "57b40e2b-34d5-49e4-9191-eb7137bfecce",
  "subject_name": "django/db/models/constraints::BaseConstraint.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, model, connection)"
}
```
