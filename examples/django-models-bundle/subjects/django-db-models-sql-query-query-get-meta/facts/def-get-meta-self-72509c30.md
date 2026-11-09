# Fact 72509c30

Store id: 47e8a174-707b-422b-a87c-7934009b8885

## Text

```text
def get_meta(self)
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
- posted_at: `2026-11-09T23:32:06.7739580+00:00`

## Data

```json
{
  "end_line": 385,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 378,
  "symbol": "Query.get_meta"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":378,"selector":"L378-L385","symbol":"Query.get_meta"}`

## Items

```json
[
  {
    "text": "Return the Options instance (the model._meta) from which to start processing. Normally, this is self.model._meta, but it can be changed by subclasses.",
    "locator": {
      "line": 379
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_meta](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 385,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 378,
    "symbol": "Query.get_meta"
  },
  "id": "47e8a174-707b-422b-a87c-7934009b8885",
  "items": [
    {
      "locator": {
        "line": 379
      },
      "text": "Return the Options instance (the model._meta) from which to start processing. Normally, this is self.model._meta, but it can be changed by subclasses."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7739580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 378,
        "selector": "L378-L385",
        "symbol": "Query.get_meta"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c5293b75-cdbe-42ca-b209-a244c7103c70",
  "subject_name": "django/db/models/sql/query::Query.get_meta",
  "tags": [
    "entity:method"
  ],
  "text": "def get_meta(self)"
}
```
