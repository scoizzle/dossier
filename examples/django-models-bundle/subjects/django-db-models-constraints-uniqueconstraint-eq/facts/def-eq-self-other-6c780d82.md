# Fact 6c780d82

Store id: 760770f8-075a-4bd7-9eb0-04fb6708f826

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T22:39:40.7296990+00:00`

## Data

```json
{
  "end_line": 560,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 546,
  "symbol": "UniqueConstraint.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":546,"selector":"L546-L560","symbol":"UniqueConstraint.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 560,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 546,
    "symbol": "UniqueConstraint.__eq__"
  },
  "id": "760770f8-075a-4bd7-9eb0-04fb6708f826",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7296990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 546,
        "selector": "L546-L560",
        "symbol": "UniqueConstraint.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "06918180-ead7-4190-a5c7-db81c1307816",
  "subject_name": "django/db/models/constraints::UniqueConstraint.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
