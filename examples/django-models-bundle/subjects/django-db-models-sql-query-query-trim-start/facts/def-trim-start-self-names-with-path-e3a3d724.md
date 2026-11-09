# Fact e3a3d724

Store id: 5b9eb622-2f47-4d24-9247-180775f1c4de

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
- posted_at: `2026-11-09T22:39:51.5521590+00:00`

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
  "id": "5b9eb622-2f47-4d24-9247-180775f1c4de",
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
    "posted_at": "2026-11-09T22:39:51.5521590+00:00"
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
  "subject_id": "23186133-b73b-4e76-a0a6-3f8740f245e3",
  "subject_name": "django/db/models/sql/query::Query.trim_start",
  "tags": [
    "entity:method"
  ],
  "text": "def trim_start(self, names_with_path)"
}
```
