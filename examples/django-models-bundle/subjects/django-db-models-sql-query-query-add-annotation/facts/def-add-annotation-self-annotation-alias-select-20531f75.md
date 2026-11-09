# Fact 20531f75

Store id: f963bd27-2a31-47db-b9c9-6e64a43a07c8

## Text

```text
def add_annotation(self, annotation, alias, select=True)
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
- posted_at: `2026-11-09T23:32:06.8877610+00:00`

## Data

```json
{
  "end_line": 1249,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1239,
  "symbol": "Query.add_annotation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1239,"selector":"L1239-L1249","symbol":"Query.add_annotation"}`

## Items

```json
[
  {
    "text": "Add a single annotation expression to the Query.",
    "locator": {
      "line": 1240
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_annotation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1249,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1239,
    "symbol": "Query.add_annotation"
  },
  "id": "f963bd27-2a31-47db-b9c9-6e64a43a07c8",
  "items": [
    {
      "locator": {
        "line": 1240
      },
      "text": "Add a single annotation expression to the Query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8877610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1239,
        "selector": "L1239-L1249",
        "symbol": "Query.add_annotation"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5555ef76-6cfc-409b-9194-de647284e156",
  "subject_name": "django/db/models/sql/query::Query.add_annotation",
  "tags": [
    "entity:method"
  ],
  "text": "def add_annotation(self, annotation, alias, select=True)"
}
```
