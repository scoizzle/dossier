# Fact 74b283d5

Store id: 49cf347d-1512-4354-8502-3c186c2f8597

## Text

```text
def add_q(self, q_object, reuse_all=False)
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
- posted_at: `2026-11-09T22:39:51.3782250+00:00`

## Data

```json
{
  "end_line": 1683,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1662,
  "symbol": "Query.add_q"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1662,"selector":"L1662-L1683","symbol":"Query.add_q"}`

## Items

```json
[
  {
    "text": "A preprocessor for the internal _add_q(). Responsible for doing final join promotion.",
    "locator": {
      "line": 1663
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_q](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1683,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1662,
    "symbol": "Query.add_q"
  },
  "id": "49cf347d-1512-4354-8502-3c186c2f8597",
  "items": [
    {
      "locator": {
        "line": 1663
      },
      "text": "A preprocessor for the internal _add_q(). Responsible for doing final join promotion."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3782250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1662,
        "selector": "L1662-L1683",
        "symbol": "Query.add_q"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0db0f1a9-7f46-4169-97cc-7301b6c50718",
  "subject_name": "django/db/models/sql/query::Query.add_q",
  "tags": [
    "entity:method"
  ],
  "text": "def add_q(self, q_object, reuse_all=False)"
}
```
