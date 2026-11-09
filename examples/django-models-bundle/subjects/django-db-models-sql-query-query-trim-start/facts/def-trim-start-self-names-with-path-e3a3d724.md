# Fact e3a3d724

Store id: 3b79a560-ac62-452e-9732-dd5d579bb657

## Text

```text
def trim_start(self, names_with_path)
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
- posted_at: `2026-11-09T23:44:59.0535710+00:00`

## Data

```json
{
  "end_line": 2773,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2696,
  "symbol": "Query.trim_start"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2696,"selector":"L2696-L2773","symbol":"Query.trim_start"}`

## Items

```json
[
  {
    "text": "Trim joins from the start of the join path. The candidates for trim are the PathInfos in names_with_path structure that are m2m joins.",
    "locator": {
      "line": 2697
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.trim_start](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2773,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2696,
    "symbol": "Query.trim_start"
  },
  "id": "3b79a560-ac62-452e-9732-dd5d579bb657",
  "items": [
    {
      "locator": {
        "line": 2697
      },
      "text": "Trim joins from the start of the join path. The candidates for trim are the PathInfos in names_with_path structure that are m2m joins."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0535710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2696,
        "selector": "L2696-L2773",
        "symbol": "Query.trim_start"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4553c4e3-9465-4df4-874d-8d5b3c295f48",
  "subject_name": "django/db/models/sql/query::Query.trim_start",
  "tags": [
    "entity:method"
  ],
  "text": "def trim_start(self, names_with_path)"
}
```
