# Fact b72f38b2

Store id: 734c4893-5847-45a3-9229-b12b9c7c3280

## Text

```text
def get_count(self, using)
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
- posted_at: `2026-11-09T23:32:06.7965590+00:00`

## Data

```json
{
  "end_line": 656,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 651,
  "symbol": "Query.get_count"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":651,"selector":"L651-L656","symbol":"Query.get_count"}`

## Items

```json
[
  {
    "text": "Perform a COUNT() query using the current filter constraints.",
    "locator": {
      "line": 652
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_count](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 656,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 651,
    "symbol": "Query.get_count"
  },
  "id": "734c4893-5847-45a3-9229-b12b9c7c3280",
  "items": [
    {
      "locator": {
        "line": 652
      },
      "text": "Perform a COUNT() query using the current filter constraints."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7965590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 651,
        "selector": "L651-L656",
        "symbol": "Query.get_count"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "079d3fa9-e978-496b-b907-dce0f349e270",
  "subject_name": "django/db/models/sql/query::Query.get_count",
  "tags": [
    "entity:method"
  ],
  "text": "def get_count(self, using)"
}
```
